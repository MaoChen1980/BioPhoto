using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BioPhoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_folder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "选择需要处理的图片视频目录";

                // Do not allow the user to create new files via the FolderBrowserDialog.
                folderBrowserDialog1.ShowNewFolderButton = false;

                // Default to the My Documents folder.
                //folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (folderBrowserDialog1.SelectedPath != null && folderBrowserDialog1.SelectedPath.Length >0)
                    {
                        String selectedPath = folderBrowserDialog1.SelectedPath;
                        ListViewItem item = null;

                        if (listView_folder.Items.Count >0)
                            item = listView_folder.FindItemWithText(selectedPath,false,0 , false);

                        if (item == null || item.Text.CompareTo(selectedPath) != 0)
                        {
                            listView_folder.Items.Add(selectedPath);
                        }
                        else
                        {
                            MessageBox.Show("列表中已添加过该目录");
                        }

                    }
                }
            }
        }

        private void button_remove_folder_Click(object sender, EventArgs e)
        {
            if (listView_folder.SelectedItems == null)
            {
                MessageBox.Show("请先选择需要删除的文件夹"); 
            }
            else
            {
                foreach (ListViewItem item in listView_folder.Items)
                    if (item.Selected)
                        listView_folder.Items.Remove(item);
            }
        }

        private void button_process_Click(object sender, EventArgs e)
        {
            List<String> folderlist = new List<String>();
            String location = textBox_location.Text;
            String camera = textBox_camera.Text;
            List<String> fileext = new List<String>();
            List<String> columns= new List<String>();
            bool backup = checkBox_backup.Checked;
            bool report = checkBox_report.Checked;
            bool rename = checkBox_rename.Checked;
            bool timeChange = checkBox_timestart.Checked;
            DateTime starttime = dateTimePicker_starttime.Value;


            ///pre handle
            foreach (ListViewItem item in listView_folder.Items)
                folderlist.Add(item.Text);

            ////
            String text_ext = textBox_extname.Text;
            String[] all_ext = text_ext.Split(',');
            if (all_ext != null && all_ext.Length > 0)
            {
                fileext.AddRange(all_ext);
            }

            ////
            String text_columns = textBox_columns.Text;
            String[] all_columms = text_columns.Split(',');
            if (all_columms != null && all_columms.Length > 0)
            {
                columns.AddRange(all_columms);
            }

            if (folderlist.Count==0)
            {
                MessageBox.Show("请先添加需要处理的文件夹");
                return;
            }

            if (location.Length == 0)
            {
                MessageBox.Show("请先添加位置编号");
                return;
            }

            if (camera.Length == 0)
            {
                MessageBox.Show("请先添加相机编号");
                return;
            }

            if (fileext.Count == 0)
            {
                MessageBox.Show("请先添加需要处理的文件后缀名");
                return;
            }

            List<String> filesearchpattern = new List<String>();
            foreach (String ext in fileext)
            {
                filesearchpattern.Add("." + ext.ToLower());
            }

            foreach (String folder in folderlist)
            {
                List<FileInfo> files = new List<FileInfo>();
                System.IO.DirectoryInfo rootInfo = new System.IO.DirectoryInfo(folder);


                // First, process all the files directly under this folder
                try
                {
                    files = rootInfo.GetFiles().Where(f => filesearchpattern.Any(f.Name.ToLower().EndsWith)).ToList();
                }
                catch (UnauthorizedAccessException exp)
                {
                    MessageBox.Show("无法处理该目录下的文件，没有读写权限");
                    return;
                }
                catch (System.IO.DirectoryNotFoundException exp)
                {
                    MessageBox.Show("无法访问该目录");
                    return;
                }

                if (files == null || files.Count == 0)
                {
                    MessageBox.Show("该目录下没有找到需要处理的文件: " + folder);
                    continue;
                }

                ///按创建时间排序
                IEnumerable<FileInfo> sorted_files = from original_file in files
                                                                 orderby original_file.CreationTime.Ticks //"ascending" is default
                                                                 select original_file; //sorting_by_creating_time
                List<FileInfo> sorted_list = sorted_files.ToList();

                if (sorted_list == null || sorted_list.Count == 0)
                {
                    MessageBox.Show("该目录下没有找到需要处理的文件");
                    return;
                }


                //备份
                if (backup)
                {
                    Backup(sorted_files, folder);
                }

                List<String> original_file_name_list = null;

                //重命名
                if (rename)
                {
                    original_file_name_list = Rename(sorted_files);
                }

                //写报告
                if (report)
                {
                    Report(sorted_list, original_file_name_list, folder, text_columns, camera,location, timeChange, starttime);
                }
            }

            MessageBox.Show("处理完毕");


        }

        private void Report(List<FileInfo> sorted_files, List<String> original_file_name, String folder, String header_ext, String camera, String location, bool timeChange, DateTime starttime )
        {
            if (sorted_files == null || sorted_files.Count<FileInfo>() ==0)
            {
                return;
            }

            System.IO.DirectoryInfo rootInfo = new System.IO.DirectoryInfo(folder);
            String report_file_name = System.IO.Path.Combine(folder, rootInfo.Name + ".csv");

            //删除重复报告
            if (System.IO.File.Exists(report_file_name))
            {
                System.IO.File.Delete(report_file_name);
            }

            StreamWriter report_file = new StreamWriter(report_file_name);

            String header_txt = "文件编号,原始文件编号,文件格式,文件夹编号,相机编号,布设点位编号,拍摄日期,拍摄时间,工作天数" + ((header_ext == null || header_ext.Length == 0) ? "" : "," + header_ext);
            report_file.WriteLine(header_txt);

            //计算时间重置的位移
            DateTime first_time = sorted_files[0].CreationTime;
            TimeSpan timeAdjust = first_time - first_time;
            if (timeChange)
                timeAdjust = first_time - starttime;


            for (int i = 0; i < sorted_files.Count<FileInfo>(); i++)
            {
                String file_name = sorted_files[i].Name;
                String file_name_old = original_file_name[i];
                String file_format = sorted_files[i].Extension.ToUpper().Substring(1);
                DateTime adjusted_time = sorted_files[i].CreationTime - timeAdjust;

                String date_create = adjusted_time.ToString("d");
                String time_create = adjusted_time.ToString("T");

                String working_days = "" + (sorted_files[i].CreationTime - first_time).Days +1;

                String report_line = file_name + "," + file_name_old + "," + file_format + "," + "1" + "," + camera + "," + location + "," + date_create + "," + time_create + "," + working_days;

                report_file.WriteLine(report_line);

                progressBar_process.Value = 100 * (i+1) / sorted_files.Count<FileInfo>();
            }

            report_file.Flush();
            report_file.Close();

        }

        void Backup(IEnumerable<FileInfo> filelist, String folder)
        {
            String backup_path = System.IO.Path.Combine(folder, "Backup");

            if (System.IO.Directory.Exists(backup_path))
            {
                System.IO.Directory.Delete(backup_path, true);
            }

            System.IO.Directory.CreateDirectory(backup_path);

            foreach (FileInfo file in filelist)
            {
                String new_filename = System.IO.Path.Combine(backup_path, file.Name);
                file.CopyTo(new_filename, true);
            }

        }

        List<String> Rename(IEnumerable<FileInfo> filelist)
        {
            int filenumber = 0;

            List<String> old_filename_list= new List<String>();

            foreach (FileInfo file in filelist)
            {
                filenumber++;

                old_filename_list.Add(file.Name);

                String dirName = file.Directory.Name;
                String formated_file_name = dirName + String.Format("{0:0000}", filenumber) + file.Extension;

                String new_filename = System.IO.Path.Combine(file.DirectoryName, formated_file_name);

                file.MoveTo(new_filename);

            }

            return old_filename_list;
        }
    }

}
