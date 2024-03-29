﻿namespace BgImageTool
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_foot = new System.Windows.Forms.Panel();
            this.num_tm_delay = new System.Windows.Forms.NumericUpDown();
            this.radioButton_tm_change = new System.Windows.Forms.RadioButton();
            this.radioButton_tm_none = new System.Windows.Forms.RadioButton();
            this.checkBox_random = new System.Windows.Forms.CheckBox();
            this.checkBox_multiscreen = new System.Windows.Forms.CheckBox();
            this.button_bg_select = new System.Windows.Forms.Button();
            this.button_bg_set = new System.Windows.Forms.Button();
            this.label_log = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Bing = new System.Windows.Forms.TabPage();
            this.num_bing_idx = new System.Windows.Forms.NumericUpDown();
            this.num_bing_count = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_bing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_360 = new System.Windows.Forms.TabPage();
            this.comboBox_360_categary = new System.Windows.Forms.ComboBox();
            this.num_360_idx = new System.Windows.Forms.NumericUpDown();
            this.num_360_count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_360 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_bian = new System.Windows.Forms.TabPage();
            this.comboBox_bian_categary = new System.Windows.Forms.ComboBox();
            this.num_bian_page = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_bian = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_foot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tm_delay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Bing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bing_idx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bing_count)).BeginInit();
            this.tabPage_360.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_360_idx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_360_count)).BeginInit();
            this.tabPage_bian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bian_page)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_foot
            // 
            this.panel_foot.Controls.Add(this.num_tm_delay);
            this.panel_foot.Controls.Add(this.radioButton_tm_change);
            this.panel_foot.Controls.Add(this.radioButton_tm_none);
            this.panel_foot.Controls.Add(this.checkBox_random);
            this.panel_foot.Controls.Add(this.checkBox_multiscreen);
            this.panel_foot.Controls.Add(this.button_bg_select);
            this.panel_foot.Controls.Add(this.button_bg_set);
            this.panel_foot.Controls.Add(this.label_log);
            this.panel_foot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_foot.Location = new System.Drawing.Point(0, 261);
            this.panel_foot.Name = "panel_foot";
            this.panel_foot.Size = new System.Drawing.Size(584, 100);
            this.panel_foot.TabIndex = 1;
            // 
            // num_tm_delay
            // 
            this.num_tm_delay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_tm_delay.Location = new System.Drawing.Point(506, 30);
            this.num_tm_delay.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.num_tm_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_tm_delay.Name = "num_tm_delay";
            this.num_tm_delay.Size = new System.Drawing.Size(66, 23);
            this.num_tm_delay.TabIndex = 1;
            this.toolTip1.SetToolTip(this.num_tm_delay, "单位: 分钟(m), 壁纸更换周期。");
            this.num_tm_delay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radioButton_tm_change
            // 
            this.radioButton_tm_change.AutoSize = true;
            this.radioButton_tm_change.Location = new System.Drawing.Point(391, 31);
            this.radioButton_tm_change.Name = "radioButton_tm_change";
            this.radioButton_tm_change.Size = new System.Drawing.Size(122, 21);
            this.radioButton_tm_change.TabIndex = 3;
            this.radioButton_tm_change.Text = "定时换壁纸（分）";
            this.radioButton_tm_change.UseVisualStyleBackColor = true;
            this.radioButton_tm_change.CheckedChanged += new System.EventHandler(this.radioButton_tm_change_CheckedChanged);
            // 
            // radioButton_tm_none
            // 
            this.radioButton_tm_none.AutoSize = true;
            this.radioButton_tm_none.Checked = true;
            this.radioButton_tm_none.Location = new System.Drawing.Point(391, 6);
            this.radioButton_tm_none.Name = "radioButton_tm_none";
            this.radioButton_tm_none.Size = new System.Drawing.Size(74, 21);
            this.radioButton_tm_none.TabIndex = 3;
            this.radioButton_tm_none.TabStop = true;
            this.radioButton_tm_none.Text = "定时关闭";
            this.radioButton_tm_none.UseVisualStyleBackColor = true;
            this.radioButton_tm_none.CheckedChanged += new System.EventHandler(this.radioButton_tm_none_CheckedChanged);
            // 
            // checkBox_random
            // 
            this.checkBox_random.AutoSize = true;
            this.checkBox_random.Location = new System.Drawing.Point(26, 10);
            this.checkBox_random.Name = "checkBox_random";
            this.checkBox_random.Size = new System.Drawing.Size(75, 21);
            this.checkBox_random.TabIndex = 2;
            this.checkBox_random.Text = "随机壁纸";
            this.toolTip1.SetToolTip(this.checkBox_random, "默认设置最新壁纸，选中后随机");
            this.checkBox_random.UseVisualStyleBackColor = true;
            // 
            // checkBox_multiscreen
            // 
            this.checkBox_multiscreen.AutoSize = true;
            this.checkBox_multiscreen.Location = new System.Drawing.Point(26, 37);
            this.checkBox_multiscreen.Name = "checkBox_multiscreen";
            this.checkBox_multiscreen.Size = new System.Drawing.Size(111, 21);
            this.checkBox_multiscreen.TabIndex = 2;
            this.checkBox_multiscreen.Text = "多屏幕不同壁纸";
            this.toolTip1.SetToolTip(this.checkBox_multiscreen, "每个屏幕设置不同壁纸\r\n注意：请选择大于屏幕数量的壁纸，否则后续屏幕与最后一个屏幕相同");
            this.checkBox_multiscreen.UseVisualStyleBackColor = true;
            // 
            // button_bg_select
            // 
            this.button_bg_select.Location = new System.Drawing.Point(261, 15);
            this.button_bg_select.Name = "button_bg_select";
            this.button_bg_select.Size = new System.Drawing.Size(89, 43);
            this.button_bg_select.TabIndex = 1;
            this.button_bg_select.Text = "手动选择壁纸";
            this.button_bg_select.UseVisualStyleBackColor = true;
            this.button_bg_select.Click += new System.EventHandler(this.button_bg_select_Click);
            // 
            // button_bg_set
            // 
            this.button_bg_set.Location = new System.Drawing.Point(166, 15);
            this.button_bg_set.Name = "button_bg_set";
            this.button_bg_set.Size = new System.Drawing.Size(89, 43);
            this.button_bg_set.TabIndex = 1;
            this.button_bg_set.Text = "设置壁纸";
            this.button_bg_set.UseVisualStyleBackColor = true;
            this.button_bg_set.Click += new System.EventHandler(this.button_bg_set_Click);
            // 
            // label_log
            // 
            this.label_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_log.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_log.Location = new System.Drawing.Point(0, 61);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(584, 39);
            this.label_log.TabIndex = 0;
            this.label_log.Text = "log section ";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Bing);
            this.tabControl1.Controls.Add(this.tabPage_360);
            this.tabControl1.Controls.Add(this.tabPage_bian);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 64);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 261);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage_Bing
            // 
            this.tabPage_Bing.Controls.Add(this.num_bing_idx);
            this.tabPage_Bing.Controls.Add(this.num_bing_count);
            this.tabPage_Bing.Controls.Add(this.label3);
            this.tabPage_Bing.Controls.Add(this.button_bing);
            this.tabPage_Bing.Controls.Add(this.label2);
            this.tabPage_Bing.ImageKey = "bing.png";
            this.tabPage_Bing.Location = new System.Drawing.Point(4, 68);
            this.tabPage_Bing.Name = "tabPage_Bing";
            this.tabPage_Bing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Bing.Size = new System.Drawing.Size(576, 189);
            this.tabPage_Bing.TabIndex = 0;
            this.tabPage_Bing.Text = "Bing";
            this.tabPage_Bing.ToolTipText = "Bing 壁纸下载";
            this.tabPage_Bing.UseVisualStyleBackColor = true;
            // 
            // num_bing_idx
            // 
            this.num_bing_idx.Location = new System.Drawing.Point(106, 22);
            this.num_bing_idx.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.num_bing_idx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.num_bing_idx.Name = "num_bing_idx";
            this.num_bing_idx.Size = new System.Drawing.Size(120, 23);
            this.num_bing_idx.TabIndex = 1;
            this.toolTip1.SetToolTip(this.num_bing_idx, "1 代表明天\r\n0 今天\r\n[-1,-16] 之前N天");
            // 
            // num_bing_count
            // 
            this.num_bing_count.Location = new System.Drawing.Point(106, 53);
            this.num_bing_count.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.num_bing_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_bing_count.Name = "num_bing_count";
            this.num_bing_count.Size = new System.Drawing.Size(120, 23);
            this.num_bing_count.TabIndex = 1;
            this.num_bing_count.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "起始时间:";
            // 
            // button_bing
            // 
            this.button_bing.Location = new System.Drawing.Point(38, 106);
            this.button_bing.Name = "button_bing";
            this.button_bing.Size = new System.Drawing.Size(188, 35);
            this.button_bing.TabIndex = 1;
            this.button_bing.Text = "下载";
            this.button_bing.UseVisualStyleBackColor = true;
            this.button_bing.Click += new System.EventHandler(this.button_bing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "下载数量:";
            // 
            // tabPage_360
            // 
            this.tabPage_360.Controls.Add(this.comboBox_360_categary);
            this.tabPage_360.Controls.Add(this.num_360_idx);
            this.tabPage_360.Controls.Add(this.num_360_count);
            this.tabPage_360.Controls.Add(this.label5);
            this.tabPage_360.Controls.Add(this.label1);
            this.tabPage_360.Controls.Add(this.button_360);
            this.tabPage_360.Controls.Add(this.label4);
            this.tabPage_360.ImageKey = "360.png";
            this.tabPage_360.Location = new System.Drawing.Point(4, 68);
            this.tabPage_360.Name = "tabPage_360";
            this.tabPage_360.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_360.Size = new System.Drawing.Size(576, 189);
            this.tabPage_360.TabIndex = 1;
            this.tabPage_360.Text = "360";
            this.tabPage_360.ToolTipText = "360壁纸下载";
            this.tabPage_360.UseVisualStyleBackColor = true;
            // 
            // comboBox_360_categary
            // 
            this.comboBox_360_categary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_360_categary.FormattingEnabled = true;
            this.comboBox_360_categary.Location = new System.Drawing.Point(106, 24);
            this.comboBox_360_categary.Name = "comboBox_360_categary";
            this.comboBox_360_categary.Size = new System.Drawing.Size(153, 25);
            this.comboBox_360_categary.TabIndex = 7;
            // 
            // num_360_idx
            // 
            this.num_360_idx.Location = new System.Drawing.Point(106, 64);
            this.num_360_idx.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_360_idx.Name = "num_360_idx";
            this.num_360_idx.Size = new System.Drawing.Size(120, 23);
            this.num_360_idx.TabIndex = 4;
            // 
            // num_360_count
            // 
            this.num_360_count.Location = new System.Drawing.Point(106, 101);
            this.num_360_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_360_count.Name = "num_360_count";
            this.num_360_count.Size = new System.Drawing.Size(120, 23);
            this.num_360_count.TabIndex = 5;
            this.num_360_count.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "图片分类:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始偏移:";
            // 
            // button_360
            // 
            this.button_360.Location = new System.Drawing.Point(48, 141);
            this.button_360.Name = "button_360";
            this.button_360.Size = new System.Drawing.Size(211, 35);
            this.button_360.TabIndex = 6;
            this.button_360.Text = "下载";
            this.button_360.UseVisualStyleBackColor = true;
            this.button_360.Click += new System.EventHandler(this.button_360_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "下载数量:";
            // 
            // tabPage_bian
            // 
            this.tabPage_bian.Controls.Add(this.comboBox_bian_categary);
            this.tabPage_bian.Controls.Add(this.num_bian_page);
            this.tabPage_bian.Controls.Add(this.label6);
            this.tabPage_bian.Controls.Add(this.label7);
            this.tabPage_bian.Controls.Add(this.button_bian);
            this.tabPage_bian.ImageKey = "4k.png";
            this.tabPage_bian.Location = new System.Drawing.Point(4, 68);
            this.tabPage_bian.Name = "tabPage_bian";
            this.tabPage_bian.Size = new System.Drawing.Size(576, 189);
            this.tabPage_bian.TabIndex = 2;
            this.tabPage_bian.Text = "netbian";
            this.tabPage_bian.UseVisualStyleBackColor = true;
            // 
            // comboBox_bian_categary
            // 
            this.comboBox_bian_categary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bian_categary.FormattingEnabled = true;
            this.comboBox_bian_categary.Location = new System.Drawing.Point(246, 18);
            this.comboBox_bian_categary.Name = "comboBox_bian_categary";
            this.comboBox_bian_categary.Size = new System.Drawing.Size(153, 25);
            this.comboBox_bian_categary.TabIndex = 14;
            // 
            // num_bian_page
            // 
            this.num_bian_page.Location = new System.Drawing.Point(246, 58);
            this.num_bian_page.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_bian_page.Name = "num_bian_page";
            this.num_bian_page.Size = new System.Drawing.Size(120, 23);
            this.num_bian_page.TabIndex = 11;
            this.num_bian_page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "图片分类:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "页码:";
            // 
            // button_bian
            // 
            this.button_bian.Location = new System.Drawing.Point(188, 111);
            this.button_bian.Name = "button_bian";
            this.button_bian.Size = new System.Drawing.Size(211, 35);
            this.button_bian.TabIndex = 13;
            this.button_bian.Text = "下载";
            this.button_bian.UseVisualStyleBackColor = true;
            this.button_bian.Click += new System.EventHandler(this.button_bian_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "360.png");
            this.imageList1.Images.SetKeyName(1, "app.ico");
            this.imageList1.Images.SetKeyName(2, "bing.png");
            this.imageList1.Images.SetKeyName(3, "4k.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_foot);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "BgImageTool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_foot.ResumeLayout(false);
            this.panel_foot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tm_delay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Bing.ResumeLayout(false);
            this.tabPage_Bing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bing_idx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bing_count)).EndInit();
            this.tabPage_360.ResumeLayout(false);
            this.tabPage_360.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_360_idx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_360_count)).EndInit();
            this.tabPage_bian.ResumeLayout(false);
            this.tabPage_bian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bian_page)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_foot;
        private TabControl tabControl1;
        private TabPage tabPage_Bing;
        private TabPage tabPage_360;
        private CheckBox checkBox_random;
        private ToolTip toolTip1;
        private CheckBox checkBox_multiscreen;
        private Button button_bg_select;
        private Button button_bg_set;
        private Label label_log;
        private Label label2;
        private NumericUpDown num_bing_idx;
        private NumericUpDown num_bing_count;
        private Label label3;
        private Button button_bing;
        private ImageList imageList1;
        private NumericUpDown num_360_idx;
        private NumericUpDown num_360_count;
        private Label label1;
        private Button button_360;
        private Label label4;
        private ComboBox comboBox_360_categary;
        private Label label5;
        private RadioButton radioButton_tm_change;
        private RadioButton radioButton_tm_none;
        private NumericUpDown num_tm_delay;
        private System.Windows.Forms.Timer timer1;
        private TabPage tabPage_bian;
        private ComboBox comboBox_bian_categary;
        private NumericUpDown num_bian_page;
        private Label label6;
        private Label label7;
        private Button button_bian;
    }
}