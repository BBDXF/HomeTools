using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Web;

namespace MidiBookSearcher
{
    public partial class FormMain : Form
    {
        public AppSource _appSrc;
        public WorkTool _appTool;


        public FormMain()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // add when using net core
            _appTool = new WorkTool();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // config
            _appSrc = _appTool.LoadConfigSources();
            Debug.WriteLine(_appSrc);
            foreach(var sr in _appSrc.Sources)
            {
                comboBox_search_source.Items.Add(sr.Name);
            }
            comboBox_search_source.SelectedIndex = 0;

            textBox_search_input.Text = "童话";

            // datagrid
            dataGridView.Columns.Clear();
            var col = new DataGridViewTextBoxColumn();
            col.HeaderText = "序号";
            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.Width = 40;
            dataGridView.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "标题";
            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.Width = 140;
            dataGridView.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "详情";
            //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col.Width = 400;
            dataGridView.Columns.Add(col);
            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "链接";
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.Add(col);
            var col2 = new DataGridViewButtonColumn();
            col2.HeaderText = "操作";
            col2.Width = 80;
            col2.Text = "下载";
            col2.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(col2);

            label_log.Text = "Initial finished.";
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var kw = textBox_search_input.Text.Trim();
            if ( kw.Length < 1 )
            {
                MessageBox.Show("Input is empty!", "Warning");
                return;
            }
            dataGridView.Rows.Clear();
            // source
            var src = _appSrc.Sources[comboBox_search_source.SelectedIndex];

            var url_s = src.Search.Url.Replace("{kw}",_appTool.UrlEncode(kw, src.Encoding));

            Debug.WriteLine($"Source: {src.Name}, {src.Url} {kw} => {url_s}");

            var html = "";
            if (_appTool.FetchGet(url_s, ref html, src.Encoding) > 0)
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var xmlNodes = doc.DocumentNode.SelectNodes(src.Search.ResultUrl);
                for(var i=0; i<xmlNodes.Count();i++)
                {
                    var nd = xmlNodes[i];
                    int nrow = dataGridView.Rows.Add();
                    dataGridView.Rows[nrow].Cells[0].Value = i+1;
                    dataGridView.Rows[nrow].Cells[1].Value = nd.InnerText;
                    var url2 = nd.Attributes["href"].Value;
                    if ( !url2.StartsWith("http") )
                    {
                        url2 = src.Url + url2;
                    }
                    dataGridView.Rows[nrow].Cells[3].Value = url2;
                    //dataGridView.Rows[nrow].Cells[4]. = "下载";
                }
                // detail
                xmlNodes = doc.DocumentNode.SelectNodes(src.Search.ResultName);
                for (var i = 0; i < xmlNodes.Count(); i++)
                {
                    var nd = xmlNodes[i];
                    var txt = nd.InnerText.Replace("&nbsp;", "").Replace("\t", " ");
                    txt = txt.Replace("\r", "").Replace("\n", "");
                    dataGridView.Rows[i].Cells[2].Value = txt;
                }

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine($"{e.RowIndex} {e.ColumnIndex} {dataGridView[e.ColumnIndex, e.RowIndex].Value}");
            if ( e.ColumnIndex == 4 )  // button
            {
                var url = dataGridView[3, e.RowIndex].Value.ToString();
                var src = _appSrc.Sources[comboBox_search_source.SelectedIndex];

                var html = "";
                if (_appTool.FetchGet(url, ref html, src.Encoding) > 0)
                {
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    // title
                    var title = doc.DocumentNode.SelectNodes(src.Download.ImageName).FirstOrDefault().InnerText;
                    var folder = $"./Data/{src.Name}-{System.IO.Path.GetFileNameWithoutExtension(url)}-{title}";
                    System.IO.Directory.CreateDirectory(folder);
                    // images
                    var xmlNodes = doc.DocumentNode.SelectNodes(src.Download.ImageUrl);
                    var nc = xmlNodes.Count();
                    for (var i = 0; i < nc; i++)
                    {
                        var reflink = xmlNodes[i].Attributes["src"].Value.ToString();
                        var imgurl = $"{src.Url}{reflink}";
                        var targetPath = $"{folder}/{i + 1}{System.IO.Path.GetExtension(reflink)}";
                        label_log.Text = $"{i + 1}/{nc} {reflink} => {folder} download start...";
                        if( _appTool.FetchGetFile(imgurl, targetPath) < 0)
                        {
                            label_log.Text = $"{i + 1}/{nc} {reflink} => {folder} download Failed.";
                        }
                        else
                        {
                            label_log.Text = $"{i + 1}/{nc} {reflink} => {folder} download Done.";
                        }
                        
                    }
                }
            }
        }
    }
}
