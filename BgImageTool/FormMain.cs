using System.Net;
using System.Text;
using System.Text.Json;

namespace BgImageTool
{
    public partial class FormMain : Form
    {
        public string root_folder = "./Data";

        public FormMain()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        // http get
        public async Task<string> FetchGet(string url)
        {
            try
            {
                var client = new HttpClient();
                return await client.GetStringAsync(url);
            }
            catch (Exception)
            {
            }

            return "";
        }
        public async Task<int> FetchGetFile(string url, string imgPath)
        {
            try
            {
                var client = new HttpClient();
                using (var webst = await client.GetStreamAsync(url))
                {
                    using (var fs = new FileStream(imgPath, FileMode.OpenOrCreate))
                    {
                        webst.CopyTo(fs);
                    }
                }                
            }
            catch (Exception)
            {
                return -1;
            }

            return 1;
        }

        // http post
        public async Task<string> FetchPost(string url, Dictionary<string, string> reqBody)
        {
            try
            {
                var client = new HttpClient();
                var reqParm = new FormUrlEncodedContent(reqBody);
                var req = await client.PostAsync(url, reqParm);
                var rsp = req.Content.ReadAsStringAsync();
                return await rsp;
            }
            catch (Exception)
            {
            }

            return "";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(root_folder);
        }

        private async void button_bing_Click(object sender, EventArgs e)
        {
            var url = $"https://cn.bing.com/HPImageArchive.aspx?format=js&idx={num_bing_idx.Value}&n={num_bing_count.Value}&mkt=zh-CN";
            var html = await FetchGet(url);
            try { 
                if( html.Length > 0)
                {
                    var doc = JsonDocument.Parse(html);
                    var imgs = doc.RootElement.GetProperty("images").EnumerateArray().ToArray();
                    var cn = imgs.Count();
                    label_log.Text = $"Bing images count {cn}.";
                    for (var i = 0; i < cn; i++)
                    {
                        var ele = imgs[i];
                        var img_url = $"https://www.bing.com{ele.GetProperty("url")}";
                        string path = $"{root_folder}/Bing_{ele.GetProperty("fullstartdate")}.jpg";
                        label_log.Text = $"Bing {i+1}/{cn} => {path} start ...";
                        if ( System.IO.File.Exists(path) )
                        {
                            label_log.Text = $"Bing {i + 1}/{cn} => {path} exist, skip it.";
                        }
                        else
                        {
                            await FetchGetFile(img_url, path);
                            label_log.Text = $"Bing {i + 1}/{cn} => {path} Done.";
                        }                        
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private async void button_360_Click(object sender, EventArgs e)
        {
            var item = (BG360Categary)comboBox_360_categary.SelectedItem;
            var url = $"http://wallpaper.apc.360.cn/index.php?c=WallPaperAndroid&a=getAppsByCategory&cid={item.Id}&start={num_360_idx.Value}&count={num_360_count.Value}";
            var html = await FetchGet(url);
            try
            {
                if ( html.Length > 0)
                {
                    var doc = JsonDocument.Parse(html);
                    var imgs = doc.RootElement.GetProperty("data").EnumerateArray().ToArray();
                    var cn = imgs.Count();
                    label_log.Text = $"360 images count {cn}.";
                    for (var i = 0; i < cn; i++)
                    {
                        var ele = imgs[i];
                        var img_url = ele.GetProperty("url").GetString();
                        String pid = "";
                        JsonElement ele_val;
                        if (ele.TryGetProperty("pid", out ele_val))
                        {
                            pid = ele_val.GetString();
                        }
                        else
                        {
                            pid = ele.GetProperty("id").GetString();
                        }
                        string path = $"{root_folder}/360_{pid}.jpg";
                        label_log.Text = $"360 {i + 1}/{cn} => {path} start ...";
                        if (System.IO.File.Exists(path))
                        {
                            label_log.Text = $"360 {i + 1}/{cn} => {path} exist, skip it.";
                        }
                        else
                        {
                            await FetchGetFile(img_url, path);
                            label_log.Text = $"360 {i + 1}/{cn} => {path} Done.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( tabControl1.SelectedTab == tabPage_360 )
            {
                // update 
                comboBox_360_categary.Items.Clear();
                
                var url = "http://wallpaper.apc.360.cn/index.php?c=WallPaperAndroid&a=getAllCategories";
                var html = await FetchGet(url);
                if ( html.Length > 0 )
                {
                    var doc = JsonDocument.Parse(html);
                    var imgs = doc.RootElement.GetProperty("data");
                    foreach (var img in imgs.EnumerateArray())
                    {
                        var tmp = new BG360Categary
                        {
                            Name = img.GetProperty("name").GetString(),
                            Id = img.GetProperty("id").GetString(),
                            Count = img.GetProperty("totalcnt").GetString()
                        };
                        comboBox_360_categary.Items.Add(tmp);
                    }
                    comboBox_360_categary.SelectedIndex = 0;
                }
            }
        }
    }
    public class BG360Categary
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        override public string ToString() { return Name + " - " + Count; }
    }
}