
namespace MidiBookSearcher
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel_search_top = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search_input = new System.Windows.Forms.TextBox();
            this.comboBox_search_source = new System.Windows.Forms.ComboBox();
            this.tabPage_Down = new System.Windows.Forms.TabPage();
            this.tabPage_Config = new System.Windows.Forms.TabPage();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel_search_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage_Search);
            this.tabControl.Controls.Add(this.tabPage_Down);
            this.tabControl.Controls.Add(this.tabPage_Config);
            this.tabControl.Controls.Add(this.tabPage_About);
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPage_Search
            // 
            resources.ApplyResources(this.tabPage_Search, "tabPage_Search");
            this.tabPage_Search.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Search.Controls.Add(this.dataGridView);
            this.tabPage_Search.Controls.Add(this.panel_search_top);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.UseWaitCursor = true;
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.UseWaitCursor = true;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // panel_search_top
            // 
            resources.ApplyResources(this.panel_search_top, "panel_search_top");
            this.panel_search_top.Controls.Add(this.button_search);
            this.panel_search_top.Controls.Add(this.textBox_search_input);
            this.panel_search_top.Controls.Add(this.comboBox_search_source);
            this.panel_search_top.Name = "panel_search_top";
            this.panel_search_top.UseWaitCursor = true;
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_search.Name = "button_search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.UseWaitCursor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search_input
            // 
            resources.ApplyResources(this.textBox_search_input, "textBox_search_input");
            this.textBox_search_input.Name = "textBox_search_input";
            this.textBox_search_input.UseWaitCursor = true;
            // 
            // comboBox_search_source
            // 
            resources.ApplyResources(this.comboBox_search_source, "comboBox_search_source");
            this.comboBox_search_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_search_source.FormattingEnabled = true;
            this.comboBox_search_source.Name = "comboBox_search_source";
            this.comboBox_search_source.UseWaitCursor = true;
            // 
            // tabPage_Down
            // 
            resources.ApplyResources(this.tabPage_Down, "tabPage_Down");
            this.tabPage_Down.Name = "tabPage_Down";
            this.tabPage_Down.UseVisualStyleBackColor = true;
            // 
            // tabPage_Config
            // 
            resources.ApplyResources(this.tabPage_Config, "tabPage_Config");
            this.tabPage_Config.Name = "tabPage_Config";
            this.tabPage_Config.UseVisualStyleBackColor = true;
            // 
            // tabPage_About
            // 
            resources.ApplyResources(this.tabPage_About, "tabPage_About");
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "config.png");
            this.imageList1.Images.SetKeyName(2, "down.png");
            this.imageList1.Images.SetKeyName(3, "search.png");
            this.imageList1.Images.SetKeyName(4, "midi.ico");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel_search_top.ResumeLayout(false);
            this.panel_search_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_Down;
        private System.Windows.Forms.TabPage tabPage_Config;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel_search_top;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search_input;
        private System.Windows.Forms.ComboBox comboBox_search_source;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

