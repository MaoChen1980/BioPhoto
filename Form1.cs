using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                        if (listView_folder.FindItemWithText(selectedPath) == null)
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
    }
}
