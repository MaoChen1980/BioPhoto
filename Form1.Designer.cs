namespace BioPhoto
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_folder = new System.Windows.Forms.ListView();
            this.label_folder_list = new System.Windows.Forms.Label();
            this.button_add_folder = new System.Windows.Forms.Button();
            this.button_remove_folder = new System.Windows.Forms.Button();
            this.label_location = new System.Windows.Forms.Label();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.textBox_camera = new System.Windows.Forms.TextBox();
            this.label_camera = new System.Windows.Forms.Label();
            this.label_extname = new System.Windows.Forms.Label();
            this.textBox_extname = new System.Windows.Forms.TextBox();
            this.label_columns = new System.Windows.Forms.Label();
            this.textBox_columns = new System.Windows.Forms.TextBox();
            this.progressBar_process = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button_process = new System.Windows.Forms.Button();
            this.groupBox_others = new System.Windows.Forms.GroupBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.dateTimePicker_starttime = new System.Windows.Forms.DateTimePicker();
            this.checkBox_rename = new System.Windows.Forms.CheckBox();
            this.checkBox_report = new System.Windows.Forms.CheckBox();
            this.checkBox_timestart = new System.Windows.Forms.CheckBox();
            this.checkBox_backup = new System.Windows.Forms.CheckBox();
            this.groupBox_others.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_folder
            // 
            this.listView_folder.HideSelection = false;
            this.listView_folder.Location = new System.Drawing.Point(41, 39);
            this.listView_folder.Name = "listView_folder";
            this.listView_folder.Size = new System.Drawing.Size(399, 86);
            this.listView_folder.TabIndex = 0;
            this.listView_folder.UseCompatibleStateImageBehavior = false;
            this.listView_folder.View = System.Windows.Forms.View.List;
            // 
            // label_folder_list
            // 
            this.label_folder_list.AutoSize = true;
            this.label_folder_list.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_folder_list.Location = new System.Drawing.Point(16, 9);
            this.label_folder_list.Name = "label_folder_list";
            this.label_folder_list.Size = new System.Drawing.Size(133, 14);
            this.label_folder_list.TabIndex = 1;
            this.label_folder_list.Text = "1. 待处理文件目录:";
            // 
            // button_add_folder
            // 
            this.button_add_folder.Location = new System.Drawing.Point(41, 134);
            this.button_add_folder.Name = "button_add_folder";
            this.button_add_folder.Size = new System.Drawing.Size(185, 37);
            this.button_add_folder.TabIndex = 2;
            this.button_add_folder.Text = "添加文件目录";
            this.button_add_folder.UseVisualStyleBackColor = true;
            this.button_add_folder.Click += new System.EventHandler(this.button_add_folder_Click);
            // 
            // button_remove_folder
            // 
            this.button_remove_folder.Location = new System.Drawing.Point(255, 134);
            this.button_remove_folder.Name = "button_remove_folder";
            this.button_remove_folder.Size = new System.Drawing.Size(185, 37);
            this.button_remove_folder.TabIndex = 3;
            this.button_remove_folder.Text = "删除选中的文件目录";
            this.button_remove_folder.UseVisualStyleBackColor = true;
            this.button_remove_folder.Click += new System.EventHandler(this.button_remove_folder_Click);
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_location.Location = new System.Drawing.Point(16, 184);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(112, 14);
            this.label_location.TabIndex = 4;
            this.label_location.Text = "2. 布设点位编号";
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(41, 205);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(399, 21);
            this.textBox_location.TabIndex = 5;
            // 
            // textBox_camera
            // 
            this.textBox_camera.Location = new System.Drawing.Point(41, 263);
            this.textBox_camera.Name = "textBox_camera";
            this.textBox_camera.Size = new System.Drawing.Size(399, 21);
            this.textBox_camera.TabIndex = 7;
            // 
            // label_camera
            // 
            this.label_camera.AutoSize = true;
            this.label_camera.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_camera.Location = new System.Drawing.Point(16, 241);
            this.label_camera.Name = "label_camera";
            this.label_camera.Size = new System.Drawing.Size(84, 14);
            this.label_camera.TabIndex = 6;
            this.label_camera.Text = "3. 相机编号";
            // 
            // label_extname
            // 
            this.label_extname.AutoSize = true;
            this.label_extname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_extname.Location = new System.Drawing.Point(16, 298);
            this.label_extname.Name = "label_extname";
            this.label_extname.Size = new System.Drawing.Size(238, 14);
            this.label_extname.TabIndex = 8;
            this.label_extname.Text = "4. 数据文件后缀名( 英文逗号分隔 )";
            // 
            // textBox_extname
            // 
            this.textBox_extname.Location = new System.Drawing.Point(41, 322);
            this.textBox_extname.Name = "textBox_extname";
            this.textBox_extname.Size = new System.Drawing.Size(399, 21);
            this.textBox_extname.TabIndex = 9;
            this.textBox_extname.Text = "png,jpg,jpeg,avi,rm,rmvb,tif,mp4,mov,raw";
            // 
            // label_columns
            // 
            this.label_columns.AutoSize = true;
            this.label_columns.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_columns.Location = new System.Drawing.Point(16, 357);
            this.label_columns.Name = "label_columns";
            this.label_columns.Size = new System.Drawing.Size(182, 14);
            this.label_columns.TabIndex = 10;
            this.label_columns.Text = "5. 新增列（英文逗号分隔）";
            // 
            // textBox_columns
            // 
            this.textBox_columns.Location = new System.Drawing.Point(41, 386);
            this.textBox_columns.Name = "textBox_columns";
            this.textBox_columns.Size = new System.Drawing.Size(399, 21);
            this.textBox_columns.TabIndex = 11;
            this.textBox_columns.Text = "对象类别,物种名称,动物数量,性别,独立探测首张,备注";
            // 
            // progressBar_process
            // 
            this.progressBar_process.Location = new System.Drawing.Point(19, 671);
            this.progressBar_process.Name = "progressBar_process";
            this.progressBar_process.Size = new System.Drawing.Size(421, 27);
            this.progressBar_process.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "处理进度";
            // 
            // button_process
            // 
            this.button_process.FlatAppearance.BorderSize = 2;
            this.button_process.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_process.Location = new System.Drawing.Point(105, 581);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(250, 64);
            this.button_process.TabIndex = 18;
            this.button_process.Text = "处理";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // groupBox_others
            // 
            this.groupBox_others.Controls.Add(this.labelHint);
            this.groupBox_others.Controls.Add(this.dateTimePicker_starttime);
            this.groupBox_others.Controls.Add(this.checkBox_rename);
            this.groupBox_others.Controls.Add(this.checkBox_report);
            this.groupBox_others.Controls.Add(this.checkBox_timestart);
            this.groupBox_others.Controls.Add(this.checkBox_backup);
            this.groupBox_others.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_others.Location = new System.Drawing.Point(18, 429);
            this.groupBox_others.Name = "groupBox_others";
            this.groupBox_others.Size = new System.Drawing.Size(432, 146);
            this.groupBox_others.TabIndex = 20;
            this.groupBox_others.TabStop = false;
            this.groupBox_others.Text = "6. 其他设置";
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint.Location = new System.Drawing.Point(252, 44);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(139, 46);
            this.labelHint.TabIndex = 20;
            this.labelHint.Text = "日期可以选择,  时间需要选中后输入";
            // 
            // dateTimePicker_starttime
            // 
            this.dateTimePicker_starttime.Checked = false;
            this.dateTimePicker_starttime.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dateTimePicker_starttime.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.dateTimePicker_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_starttime.Location = new System.Drawing.Point(237, 112);
            this.dateTimePicker_starttime.Name = "dateTimePicker_starttime";
            this.dateTimePicker_starttime.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker_starttime.TabIndex = 19;
            this.dateTimePicker_starttime.Value = new System.DateTime(2022, 11, 3, 18, 25, 20, 0);
            // 
            // checkBox_rename
            // 
            this.checkBox_rename.AutoSize = true;
            this.checkBox_rename.Checked = true;
            this.checkBox_rename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_rename.Location = new System.Drawing.Point(23, 82);
            this.checkBox_rename.Name = "checkBox_rename";
            this.checkBox_rename.Size = new System.Drawing.Size(124, 18);
            this.checkBox_rename.TabIndex = 15;
            this.checkBox_rename.Text = "重命名 /Rename";
            this.checkBox_rename.UseVisualStyleBackColor = true;
            // 
            // checkBox_report
            // 
            this.checkBox_report.AutoSize = true;
            this.checkBox_report.Checked = true;
            this.checkBox_report.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_report.Location = new System.Drawing.Point(23, 54);
            this.checkBox_report.Name = "checkBox_report";
            this.checkBox_report.Size = new System.Drawing.Size(145, 18);
            this.checkBox_report.TabIndex = 14;
            this.checkBox_report.Text = "生成报表 / Report";
            this.checkBox_report.UseVisualStyleBackColor = true;
            // 
            // checkBox_timestart
            // 
            this.checkBox_timestart.AutoSize = true;
            this.checkBox_timestart.Location = new System.Drawing.Point(23, 114);
            this.checkBox_timestart.Name = "checkBox_timestart";
            this.checkBox_timestart.Size = new System.Drawing.Size(201, 18);
            this.checkBox_timestart.TabIndex = 13;
            this.checkBox_timestart.Text = "重设开始时间 / Start Time";
            this.checkBox_timestart.UseVisualStyleBackColor = true;
            // 
            // checkBox_backup
            // 
            this.checkBox_backup.AutoSize = true;
            this.checkBox_backup.Checked = true;
            this.checkBox_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_backup.Location = new System.Drawing.Point(23, 25);
            this.checkBox_backup.Name = "checkBox_backup";
            this.checkBox_backup.Size = new System.Drawing.Size(117, 18);
            this.checkBox_backup.TabIndex = 12;
            this.checkBox_backup.Text = "备份 / Backup";
            this.checkBox_backup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(462, 711);
            this.Controls.Add(this.groupBox_others);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar_process);
            this.Controls.Add(this.textBox_columns);
            this.Controls.Add(this.label_columns);
            this.Controls.Add(this.textBox_extname);
            this.Controls.Add(this.label_extname);
            this.Controls.Add(this.textBox_camera);
            this.Controls.Add(this.label_camera);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.button_remove_folder);
            this.Controls.Add(this.button_add_folder);
            this.Controls.Add(this.label_folder_list);
            this.Controls.Add(this.listView_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "BioPhoto-2.3";
            this.groupBox_others.ResumeLayout(false);
            this.groupBox_others.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_folder;
        private System.Windows.Forms.Label label_folder_list;
        private System.Windows.Forms.Button button_add_folder;
        private System.Windows.Forms.Button button_remove_folder;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.TextBox textBox_camera;
        private System.Windows.Forms.Label label_camera;
        private System.Windows.Forms.Label label_extname;
        private System.Windows.Forms.TextBox textBox_extname;
        private System.Windows.Forms.Label label_columns;
        private System.Windows.Forms.TextBox textBox_columns;
        private System.Windows.Forms.CheckBox checkBox_backup;
        private System.Windows.Forms.CheckBox checkBox_timestart;
        private System.Windows.Forms.CheckBox checkBox_report;
        private System.Windows.Forms.CheckBox checkBox_rename;
        private System.Windows.Forms.ProgressBar progressBar_process;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.DateTimePicker dateTimePicker_starttime;
        private System.Windows.Forms.GroupBox groupBox_others;
        private System.Windows.Forms.Label labelHint;
    }
}

