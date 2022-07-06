
namespace CameraExifTool
{
    partial class DlgMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_basic_quality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_basic_exif = new System.Windows.Forms.CheckBox();
            this.check_auto_index = new System.Windows.Forms.CheckBox();
            this.button_basic_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_format_new = new System.Windows.Forms.ComboBox();
            this.radio_format_new = new System.Windows.Forms.RadioButton();
            this.radio_format_old = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_size_max_per = new System.Windows.Forms.RadioButton();
            this.radio_size_fixed = new System.Windows.Forms.RadioButton();
            this.text_size_max_per = new System.Windows.Forms.TextBox();
            this.text_size_fixed = new System.Windows.Forms.TextBox();
            this.text_size_per = new System.Windows.Forms.TextBox();
            this.radio_size_per = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_roation_angle = new System.Windows.Forms.ComboBox();
            this.radio_rotation_angle = new System.Windows.Forms.RadioButton();
            this.radio_rotation_exif = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_rename_start = new System.Windows.Forms.Button();
            this.check_rename_append_reg = new System.Windows.Forms.CheckBox();
            this.check_rename_name_reg = new System.Windows.Forms.CheckBox();
            this.check_rename_prefix_reg = new System.Windows.Forms.CheckBox();
            this.text_rename_append = new System.Windows.Forms.TextBox();
            this.text_rename_name = new System.Windows.Forms.TextBox();
            this.check_rename_append = new System.Windows.Forms.CheckBox();
            this.text_rename_prefix = new System.Windows.Forms.TextBox();
            this.check_rename_name = new System.Windows.Forms.CheckBox();
            this.check_rename_prefix = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.text_dir_rename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_folder_rename2 = new System.Windows.Forms.Button();
            this.button_folder_rename1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.text_sync_filter = new System.Windows.Forms.TextBox();
            this.button_sync_filecompare = new System.Windows.Forms.Button();
            this.button_sync_start = new System.Windows.Forms.Button();
            this.radio_sync_md5 = new System.Windows.Forms.RadioButton();
            this.radio_sync_name = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_folder_src = new System.Windows.Forms.TextBox();
            this.text_folder_dst = new System.Windows.Forms.TextBox();
            this.button_folder_src = new System.Windows.Forms.Button();
            this.button_folder_dst = new System.Windows.Forms.Button();
            this.text_logs = new System.Windows.Forms.TextBox();
            this.check_folder_sub = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.text_basic_quality);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.check_basic_exif);
            this.tabPage1.Controls.Add(this.check_auto_index);
            this.tabPage1.Controls.Add(this.button_basic_start);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(544, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础设定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // text_basic_quality
            // 
            this.text_basic_quality.Location = new System.Drawing.Point(83, 327);
            this.text_basic_quality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_basic_quality.Name = "text_basic_quality";
            this.text_basic_quality.Size = new System.Drawing.Size(51, 22);
            this.text_basic_quality.TabIndex = 6;
            this.text_basic_quality.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "图片质量:";
            // 
            // check_basic_exif
            // 
            this.check_basic_exif.AutoSize = true;
            this.check_basic_exif.Checked = true;
            this.check_basic_exif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_basic_exif.Location = new System.Drawing.Point(16, 362);
            this.check_basic_exif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_basic_exif.Name = "check_basic_exif";
            this.check_basic_exif.Size = new System.Drawing.Size(93, 20);
            this.check_basic_exif.TabIndex = 4;
            this.check_basic_exif.Text = "附加常见EXIF";
            this.check_basic_exif.UseVisualStyleBackColor = true;
            // 
            // check_auto_index
            // 
            this.check_auto_index.AutoSize = true;
            this.check_auto_index.Location = new System.Drawing.Point(145, 361);
            this.check_auto_index.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_auto_index.Name = "check_auto_index";
            this.check_auto_index.Size = new System.Drawing.Size(71, 20);
            this.check_auto_index.TabIndex = 4;
            this.check_auto_index.Text = "自动编号";
            this.check_auto_index.UseVisualStyleBackColor = true;
            // 
            // button_basic_start
            // 
            this.button_basic_start.Location = new System.Drawing.Point(259, 327);
            this.button_basic_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_basic_start.Name = "button_basic_start";
            this.button_basic_start.Size = new System.Drawing.Size(241, 54);
            this.button_basic_start.TabIndex = 3;
            this.button_basic_start.Text = "开始";
            this.button_basic_start.UseVisualStyleBackColor = true;
            this.button_basic_start.Click += new System.EventHandler(this.button_basic_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_format_new);
            this.groupBox3.Controls.Add(this.radio_format_new);
            this.groupBox3.Controls.Add(this.radio_format_old);
            this.groupBox3.Location = new System.Drawing.Point(9, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(523, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "格式设定";
            // 
            // combo_format_new
            // 
            this.combo_format_new.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_format_new.FormattingEnabled = true;
            this.combo_format_new.Items.AddRange(new object[] {
            "JPG - 推荐",
            "PNG - 未压缩",
            "BMP - 未压缩",
            "GIF - 未压缩"});
            this.combo_format_new.Location = new System.Drawing.Point(251, 26);
            this.combo_format_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_format_new.Name = "combo_format_new";
            this.combo_format_new.Size = new System.Drawing.Size(140, 24);
            this.combo_format_new.TabIndex = 2;
            // 
            // radio_format_new
            // 
            this.radio_format_new.AutoSize = true;
            this.radio_format_new.Checked = true;
            this.radio_format_new.Location = new System.Drawing.Point(155, 28);
            this.radio_format_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_format_new.Name = "radio_format_new";
            this.radio_format_new.Size = new System.Drawing.Size(70, 20);
            this.radio_format_new.TabIndex = 1;
            this.radio_format_new.TabStop = true;
            this.radio_format_new.Text = "指定格式";
            this.radio_format_new.UseVisualStyleBackColor = true;
            // 
            // radio_format_old
            // 
            this.radio_format_old.AutoSize = true;
            this.radio_format_old.Location = new System.Drawing.Point(8, 28);
            this.radio_format_old.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_format_old.Name = "radio_format_old";
            this.radio_format_old.Size = new System.Drawing.Size(81, 20);
            this.radio_format_old.TabIndex = 0;
            this.radio_format_old.Text = "保留原格式";
            this.radio_format_old.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_size_max_per);
            this.groupBox2.Controls.Add(this.radio_size_fixed);
            this.groupBox2.Controls.Add(this.text_size_max_per);
            this.groupBox2.Controls.Add(this.text_size_fixed);
            this.groupBox2.Controls.Add(this.text_size_per);
            this.groupBox2.Controls.Add(this.radio_size_per);
            this.groupBox2.Location = new System.Drawing.Point(9, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(523, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "尺寸设定";
            // 
            // radio_size_max_per
            // 
            this.radio_size_max_per.AutoSize = true;
            this.radio_size_max_per.Location = new System.Drawing.Point(8, 100);
            this.radio_size_max_per.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_size_max_per.Name = "radio_size_max_per";
            this.radio_size_max_per.Size = new System.Drawing.Size(92, 20);
            this.radio_size_max_per.TabIndex = 3;
            this.radio_size_max_per.Text = "指定最长尺寸";
            this.radio_size_max_per.UseVisualStyleBackColor = true;
            // 
            // radio_size_fixed
            // 
            this.radio_size_fixed.AutoSize = true;
            this.radio_size_fixed.Location = new System.Drawing.Point(8, 68);
            this.radio_size_fixed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_size_fixed.Name = "radio_size_fixed";
            this.radio_size_fixed.Size = new System.Drawing.Size(70, 20);
            this.radio_size_fixed.TabIndex = 2;
            this.radio_size_fixed.Text = "指定尺寸";
            this.radio_size_fixed.UseVisualStyleBackColor = true;
            // 
            // text_size_max_per
            // 
            this.text_size_max_per.Location = new System.Drawing.Point(132, 96);
            this.text_size_max_per.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_size_max_per.Name = "text_size_max_per";
            this.text_size_max_per.Size = new System.Drawing.Size(116, 22);
            this.text_size_max_per.TabIndex = 1;
            this.text_size_max_per.Text = "1920";
            // 
            // text_size_fixed
            // 
            this.text_size_fixed.Location = new System.Drawing.Point(132, 68);
            this.text_size_fixed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_size_fixed.Name = "text_size_fixed";
            this.text_size_fixed.Size = new System.Drawing.Size(116, 22);
            this.text_size_fixed.TabIndex = 1;
            this.text_size_fixed.Text = "1920x1080";
            // 
            // text_size_per
            // 
            this.text_size_per.Location = new System.Drawing.Point(132, 38);
            this.text_size_per.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_size_per.MaxLength = 3;
            this.text_size_per.Name = "text_size_per";
            this.text_size_per.Size = new System.Drawing.Size(116, 22);
            this.text_size_per.TabIndex = 1;
            this.text_size_per.Text = "100";
            // 
            // radio_size_per
            // 
            this.radio_size_per.AutoSize = true;
            this.radio_size_per.Checked = true;
            this.radio_size_per.Location = new System.Drawing.Point(8, 38);
            this.radio_size_per.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_size_per.Name = "radio_size_per";
            this.radio_size_per.Size = new System.Drawing.Size(91, 20);
            this.radio_size_per.TabIndex = 0;
            this.radio_size_per.TabStop = true;
            this.radio_size_per.Text = "按比例缩放%";
            this.radio_size_per.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comb_roation_angle);
            this.groupBox1.Controls.Add(this.radio_rotation_angle);
            this.groupBox1.Controls.Add(this.radio_rotation_exif);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(523, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "旋转设定";
            // 
            // comb_roation_angle
            // 
            this.comb_roation_angle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_roation_angle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comb_roation_angle.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
            this.comb_roation_angle.Location = new System.Drawing.Point(247, 23);
            this.comb_roation_angle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comb_roation_angle.Name = "comb_roation_angle";
            this.comb_roation_angle.Size = new System.Drawing.Size(140, 24);
            this.comb_roation_angle.TabIndex = 1;
            // 
            // radio_rotation_angle
            // 
            this.radio_rotation_angle.AutoSize = true;
            this.radio_rotation_angle.Location = new System.Drawing.Point(154, 27);
            this.radio_rotation_angle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_rotation_angle.Name = "radio_rotation_angle";
            this.radio_rotation_angle.Size = new System.Drawing.Size(70, 20);
            this.radio_rotation_angle.TabIndex = 0;
            this.radio_rotation_angle.Text = "指定角度";
            this.radio_rotation_angle.UseVisualStyleBackColor = true;
            // 
            // radio_rotation_exif
            // 
            this.radio_rotation_exif.AutoSize = true;
            this.radio_rotation_exif.Checked = true;
            this.radio_rotation_exif.Location = new System.Drawing.Point(9, 27);
            this.radio_rotation_exif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_rotation_exif.Name = "radio_rotation_exif";
            this.radio_rotation_exif.Size = new System.Drawing.Size(67, 20);
            this.radio_rotation_exif.TabIndex = 0;
            this.radio_rotation_exif.TabStop = true;
            this.radio_rotation_exif.Text = "跟随Exif";
            this.radio_rotation_exif.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_rename_start);
            this.tabPage2.Controls.Add(this.check_rename_append_reg);
            this.tabPage2.Controls.Add(this.check_rename_name_reg);
            this.tabPage2.Controls.Add(this.check_rename_prefix_reg);
            this.tabPage2.Controls.Add(this.text_rename_append);
            this.tabPage2.Controls.Add(this.text_rename_name);
            this.tabPage2.Controls.Add(this.check_rename_append);
            this.tabPage2.Controls.Add(this.text_rename_prefix);
            this.tabPage2.Controls.Add(this.check_rename_name);
            this.tabPage2.Controls.Add(this.check_rename_prefix);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(544, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量重命名";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_rename_start
            // 
            this.btn_rename_start.Location = new System.Drawing.Point(120, 291);
            this.btn_rename_start.Name = "btn_rename_start";
            this.btn_rename_start.Size = new System.Drawing.Size(267, 65);
            this.btn_rename_start.TabIndex = 4;
            this.btn_rename_start.Text = "开始处理";
            this.btn_rename_start.UseVisualStyleBackColor = true;
            this.btn_rename_start.Click += new System.EventHandler(this.btn_rename_start_Click);
            // 
            // check_rename_append_reg
            // 
            this.check_rename_append_reg.AutoSize = true;
            this.check_rename_append_reg.Location = new System.Drawing.Point(435, 107);
            this.check_rename_append_reg.Name = "check_rename_append_reg";
            this.check_rename_append_reg.Size = new System.Drawing.Size(71, 20);
            this.check_rename_append_reg.TabIndex = 3;
            this.check_rename_append_reg.Text = "正则模式";
            this.check_rename_append_reg.UseVisualStyleBackColor = true;
            // 
            // check_rename_name_reg
            // 
            this.check_rename_name_reg.AutoSize = true;
            this.check_rename_name_reg.Location = new System.Drawing.Point(435, 62);
            this.check_rename_name_reg.Name = "check_rename_name_reg";
            this.check_rename_name_reg.Size = new System.Drawing.Size(71, 20);
            this.check_rename_name_reg.TabIndex = 3;
            this.check_rename_name_reg.Text = "正则模式";
            this.check_rename_name_reg.UseVisualStyleBackColor = true;
            // 
            // check_rename_prefix_reg
            // 
            this.check_rename_prefix_reg.AutoSize = true;
            this.check_rename_prefix_reg.Location = new System.Drawing.Point(435, 23);
            this.check_rename_prefix_reg.Name = "check_rename_prefix_reg";
            this.check_rename_prefix_reg.Size = new System.Drawing.Size(71, 20);
            this.check_rename_prefix_reg.TabIndex = 3;
            this.check_rename_prefix_reg.Text = "正则模式";
            this.check_rename_prefix_reg.UseVisualStyleBackColor = true;
            // 
            // text_rename_append
            // 
            this.text_rename_append.Location = new System.Drawing.Point(120, 107);
            this.text_rename_append.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_rename_append.Name = "text_rename_append";
            this.text_rename_append.Size = new System.Drawing.Size(299, 22);
            this.text_rename_append.TabIndex = 2;
            this.text_rename_append.Text = "_end";
            // 
            // text_rename_name
            // 
            this.text_rename_name.Location = new System.Drawing.Point(120, 62);
            this.text_rename_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_rename_name.Name = "text_rename_name";
            this.text_rename_name.Size = new System.Drawing.Size(299, 22);
            this.text_rename_name.TabIndex = 2;
            this.text_rename_name.Text = "%name%_%file_time%_%exif_time%";
            // 
            // check_rename_append
            // 
            this.check_rename_append.AutoSize = true;
            this.check_rename_append.Checked = true;
            this.check_rename_append.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rename_append.Location = new System.Drawing.Point(26, 110);
            this.check_rename_append.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_rename_append.Name = "check_rename_append";
            this.check_rename_append.Size = new System.Drawing.Size(71, 20);
            this.check_rename_append.TabIndex = 1;
            this.check_rename_append.Text = "添加后缀";
            this.check_rename_append.UseVisualStyleBackColor = true;
            // 
            // text_rename_prefix
            // 
            this.text_rename_prefix.Location = new System.Drawing.Point(120, 21);
            this.text_rename_prefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_rename_prefix.Name = "text_rename_prefix";
            this.text_rename_prefix.Size = new System.Drawing.Size(299, 22);
            this.text_rename_prefix.TabIndex = 2;
            this.text_rename_prefix.Text = "rename_%index%_";
            // 
            // check_rename_name
            // 
            this.check_rename_name.AutoSize = true;
            this.check_rename_name.Checked = true;
            this.check_rename_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rename_name.Enabled = false;
            this.check_rename_name.Location = new System.Drawing.Point(26, 64);
            this.check_rename_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_rename_name.Name = "check_rename_name";
            this.check_rename_name.Size = new System.Drawing.Size(71, 20);
            this.check_rename_name.TabIndex = 1;
            this.check_rename_name.Text = "修改名字";
            this.check_rename_name.UseVisualStyleBackColor = true;
            // 
            // check_rename_prefix
            // 
            this.check_rename_prefix.AutoSize = true;
            this.check_rename_prefix.Location = new System.Drawing.Point(26, 21);
            this.check_rename_prefix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_rename_prefix.Name = "check_rename_prefix";
            this.check_rename_prefix.Size = new System.Drawing.Size(71, 20);
            this.check_rename_prefix.TabIndex = 1;
            this.check_rename_prefix.Text = "添加前缀";
            this.check_rename_prefix.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 80);
            this.label4.TabIndex = 0;
            this.label4.Text = "自定义规则：\r\n- %index% 自增序号，如1，2，3....\r\n- %name% 原始文件名，如 PHOTO012801\r\n- %exif_time% EX" +
    "IF中时间\r\n- %file_time% 文件修改时间\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.text_dir_rename);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button_folder_rename2);
            this.tabPage3.Controls.Add(this.button_folder_rename1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件夹改名";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "命名规范";
            // 
            // text_dir_rename
            // 
            this.text_dir_rename.Location = new System.Drawing.Point(89, 19);
            this.text_dir_rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_dir_rename.Name = "text_dir_rename";
            this.text_dir_rename.Size = new System.Drawing.Size(299, 22);
            this.text_dir_rename.TabIndex = 3;
            this.text_dir_rename.Text = "SONY_%index%_%date%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 144);
            this.label5.TabIndex = 1;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // button_folder_rename2
            // 
            this.button_folder_rename2.Location = new System.Drawing.Point(25, 67);
            this.button_folder_rename2.Name = "button_folder_rename2";
            this.button_folder_rename2.Size = new System.Drawing.Size(179, 57);
            this.button_folder_rename2.TabIndex = 0;
            this.button_folder_rename2.Text = "使用内部文件属性(推荐)";
            this.button_folder_rename2.UseVisualStyleBackColor = true;
            this.button_folder_rename2.Click += new System.EventHandler(this.button_folder_rename2_Click);
            // 
            // button_folder_rename1
            // 
            this.button_folder_rename1.Location = new System.Drawing.Point(234, 67);
            this.button_folder_rename1.Name = "button_folder_rename1";
            this.button_folder_rename1.Size = new System.Drawing.Size(164, 57);
            this.button_folder_rename1.TabIndex = 0;
            this.button_folder_rename1.Text = "使用文件夹名规则";
            this.button_folder_rename1.UseVisualStyleBackColor = true;
            this.button_folder_rename1.Click += new System.EventHandler(this.button_folder_rename1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.text_sync_filter);
            this.tabPage4.Controls.Add(this.button_sync_filecompare);
            this.tabPage4.Controls.Add(this.button_sync_start);
            this.tabPage4.Controls.Add(this.radio_sync_md5);
            this.tabPage4.Controls.Add(this.radio_sync_name);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "文件同步";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "处理文件类型:";
            // 
            // text_sync_filter
            // 
            this.text_sync_filter.Location = new System.Drawing.Point(125, 129);
            this.text_sync_filter.Name = "text_sync_filter";
            this.text_sync_filter.Size = new System.Drawing.Size(336, 22);
            this.text_sync_filter.TabIndex = 2;
            this.text_sync_filter.Text = ".png .jpg .jpeg .gif .bmp .raw";
            // 
            // button_sync_filecompare
            // 
            this.button_sync_filecompare.Location = new System.Drawing.Point(43, 274);
            this.button_sync_filecompare.Name = "button_sync_filecompare";
            this.button_sync_filecompare.Size = new System.Drawing.Size(182, 60);
            this.button_sync_filecompare.TabIndex = 1;
            this.button_sync_filecompare.Text = "基于MD5文件去重";
            this.button_sync_filecompare.UseVisualStyleBackColor = true;
            this.button_sync_filecompare.Click += new System.EventHandler(this.button_sync_filecompare_Click);
            // 
            // button_sync_start
            // 
            this.button_sync_start.Location = new System.Drawing.Point(43, 172);
            this.button_sync_start.Name = "button_sync_start";
            this.button_sync_start.Size = new System.Drawing.Size(179, 50);
            this.button_sync_start.TabIndex = 1;
            this.button_sync_start.Text = "开始";
            this.button_sync_start.UseVisualStyleBackColor = true;
            this.button_sync_start.Click += new System.EventHandler(this.button_sync_start_Click);
            // 
            // radio_sync_md5
            // 
            this.radio_sync_md5.AutoSize = true;
            this.radio_sync_md5.Checked = true;
            this.radio_sync_md5.Location = new System.Drawing.Point(43, 93);
            this.radio_sync_md5.Name = "radio_sync_md5";
            this.radio_sync_md5.Size = new System.Drawing.Size(95, 20);
            this.radio_sync_md5.TabIndex = 0;
            this.radio_sync_md5.TabStop = true;
            this.radio_sync_md5.Text = "基于文件MD5";
            this.radio_sync_md5.UseVisualStyleBackColor = true;
            // 
            // radio_sync_name
            // 
            this.radio_sync_name.AutoSize = true;
            this.radio_sync_name.Enabled = false;
            this.radio_sync_name.Location = new System.Drawing.Point(199, 93);
            this.radio_sync_name.Name = "radio_sync_name";
            this.radio_sync_name.Size = new System.Drawing.Size(133, 20);
            this.radio_sync_name.TabIndex = 0;
            this.radio_sync_name.Text = "基于文件名+修改时间";
            this.radio_sync_name.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "源路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标路径：";
            // 
            // text_folder_src
            // 
            this.text_folder_src.Location = new System.Drawing.Point(91, 10);
            this.text_folder_src.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_folder_src.Name = "text_folder_src";
            this.text_folder_src.Size = new System.Drawing.Size(318, 22);
            this.text_folder_src.TabIndex = 3;
            // 
            // text_folder_dst
            // 
            this.text_folder_dst.Location = new System.Drawing.Point(91, 42);
            this.text_folder_dst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_folder_dst.Name = "text_folder_dst";
            this.text_folder_dst.Size = new System.Drawing.Size(318, 22);
            this.text_folder_dst.TabIndex = 3;
            // 
            // button_folder_src
            // 
            this.button_folder_src.Location = new System.Drawing.Point(418, 7);
            this.button_folder_src.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_folder_src.Name = "button_folder_src";
            this.button_folder_src.Size = new System.Drawing.Size(33, 28);
            this.button_folder_src.TabIndex = 4;
            this.button_folder_src.Text = "...";
            this.button_folder_src.UseVisualStyleBackColor = true;
            this.button_folder_src.Click += new System.EventHandler(this.button_folder_src_Click);
            // 
            // button_folder_dst
            // 
            this.button_folder_dst.Location = new System.Drawing.Point(418, 38);
            this.button_folder_dst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_folder_dst.Name = "button_folder_dst";
            this.button_folder_dst.Size = new System.Drawing.Size(33, 28);
            this.button_folder_dst.TabIndex = 4;
            this.button_folder_dst.Text = "...";
            this.button_folder_dst.UseVisualStyleBackColor = true;
            this.button_folder_dst.Click += new System.EventHandler(this.button_folder_dst_Click);
            // 
            // text_logs
            // 
            this.text_logs.Location = new System.Drawing.Point(7, 501);
            this.text_logs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_logs.Multiline = true;
            this.text_logs.Name = "text_logs";
            this.text_logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_logs.Size = new System.Drawing.Size(546, 183);
            this.text_logs.TabIndex = 5;
            // 
            // check_folder_sub
            // 
            this.check_folder_sub.AutoSize = true;
            this.check_folder_sub.Location = new System.Drawing.Point(458, 14);
            this.check_folder_sub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_folder_sub.Name = "check_folder_sub";
            this.check_folder_sub.Size = new System.Drawing.Size(82, 20);
            this.check_folder_sub.TabIndex = 6;
            this.check_folder_sub.Text = "包含子目录";
            this.check_folder_sub.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(547, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "注意：\r\n- 源路径存放被同步文件夹，方向是 源 => 目标路径，程序在目标路径中查找源路径中不存在的文件进行同步。";
            // 
            // DlgMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 688);
            this.Controls.Add(this.check_folder_sub);
            this.Controls.Add(this.text_logs);
            this.Controls.Add(this.button_folder_dst);
            this.Controls.Add(this.button_folder_src);
            this.Controls.Add(this.text_folder_dst);
            this.Controls.Add(this.text_folder_src);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DlgMain";
            this.Text = "CameraExifTool";
            this.Load += new System.EventHandler(this.DlgMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_format_new;
        private System.Windows.Forms.RadioButton radio_format_new;
        private System.Windows.Forms.RadioButton radio_format_old;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_size_max_per;
        private System.Windows.Forms.RadioButton radio_size_fixed;
        private System.Windows.Forms.TextBox text_size_max_per;
        private System.Windows.Forms.TextBox text_size_fixed;
        private System.Windows.Forms.TextBox text_size_per;
        private System.Windows.Forms.RadioButton radio_size_per;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_rotation_angle;
        private System.Windows.Forms.RadioButton radio_rotation_exif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_folder_src;
        private System.Windows.Forms.TextBox text_folder_dst;
        private System.Windows.Forms.Button button_folder_src;
        private System.Windows.Forms.Button button_folder_dst;
        private System.Windows.Forms.TextBox text_logs;
        private System.Windows.Forms.Button button_basic_start;
        private System.Windows.Forms.ComboBox comb_roation_angle;
        private System.Windows.Forms.CheckBox check_folder_sub;
        private System.Windows.Forms.CheckBox check_auto_index;
        private System.Windows.Forms.TextBox text_basic_quality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_basic_exif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_rename_append;
        private System.Windows.Forms.TextBox text_rename_name;
        private System.Windows.Forms.CheckBox check_rename_append;
        private System.Windows.Forms.TextBox text_rename_prefix;
        private System.Windows.Forms.CheckBox check_rename_name;
        private System.Windows.Forms.CheckBox check_rename_prefix;
        private System.Windows.Forms.Button btn_rename_start;
        private System.Windows.Forms.CheckBox check_rename_append_reg;
        private System.Windows.Forms.CheckBox check_rename_prefix_reg;
        private System.Windows.Forms.CheckBox check_rename_name_reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_dir_rename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_folder_rename2;
        private System.Windows.Forms.Button button_folder_rename1;
        private System.Windows.Forms.RadioButton radio_sync_md5;
        private System.Windows.Forms.RadioButton radio_sync_name;
        private System.Windows.Forms.Button button_sync_start;
        private System.Windows.Forms.Button button_sync_filecompare;
        private System.Windows.Forms.TextBox text_sync_filter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

