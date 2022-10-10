using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using HtmlAgilityPack;

namespace BgImageTool
{
    public partial class FormMain : Form
    {
        public string root_folder = "./Data";
        private IDesktopWallpaper Wallpaper = (IDesktopWallpaper)new DesktopWallpaper();

        public FormMain()
        {
            InitializeComponent();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        //[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        //public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public void SetBGForScreens(List<string> paths)
        {
            var monitorCount = Wallpaper.GetMonitorDevicePathCount();
            var uLastIndex = 0;
            for (var i = 0; i < monitorCount; i++)
            {
                if (i < paths.Count)
                {
                    uLastIndex = i;
                }
                var screen_id = Wallpaper.GetMonitorDevicePathAt((uint)i);
                // 不显示的屏幕，screen_id 为空
                if (screen_id.Length > 2)
                {
                    Wallpaper.SetWallpaper(screen_id, paths[uLastIndex]);
                    Debug.WriteLine($"{i} {screen_id} => {uLastIndex}");
                    label_log.Text = $"Set monitor background for {i + 1}/{monitorCount} using {paths[uLastIndex]}";
                }
            }
        }
        public void SetBGForScreens(string path)
        {
            // https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setwallpaper
            // SystemParametersInfo(20, 0, path, 2);
            Wallpaper.SetWallpaper(null, path);
            label_log.Text = $"Set all monitor background with {path}";
        }

        // http get
        public async Task<string> FetchGet(string url, string encoding="UTF-8")
        {
            try
            {
                var enc = Encoding.GetEncoding(encoding);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.5060.114 Safari/537.36 Edg/103.0.1264.49");
                var dt = await client.GetByteArrayAsync(url);
                return enc.GetString(dt);
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
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.5060.114 Safari/537.36 Edg/103.0.1264.49");
                using (var webst = await client.GetStreamAsync(url))
                {
                    using (var fs = new FileStream(imgPath, FileMode.OpenOrCreate))
                    {
                        await webst.CopyToAsync(fs);
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

        public void SetBGfromImages(List<string> imgList)
        {
            // 随机壁纸
            if (checkBox_random.Checked)
            {
                var imgList2 = new List<string>();
                var seed = Guid.NewGuid().GetHashCode();
                var r = new Random(seed);
                while (imgList.Count > 0)
                {
                    var idx = r.Next(0, imgList.Count);
                    imgList2.Add(imgList[idx]);
                    imgList.RemoveAt(idx);
                }
                // update 
                imgList = imgList2;
            }
            // 多屏幕不同壁纸
            if (checkBox_multiscreen.Checked)
            {
                SetBGForScreens(imgList);
            }
            else
            {
                SetBGForScreens(imgList.First());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(root_folder);
        }

        private async void button_bing_Click(object sender, EventArgs e)
        {
            var url = $"https://cn.bing.com/HPImageArchive.aspx?format=js&idx={num_bing_idx.Value}&n={num_bing_count.Value}&mkt=zh-CN";
            var html = await FetchGet(url);
            try
            {
                if (html.Length > 0)
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
                        label_log.Text = $"Bing {i + 1}/{cn} => {path} start ...";
                        if (System.IO.File.Exists(path))
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
            }
            catch (Exception ex)
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
                if (html.Length > 0)
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
            if (tabControl1.SelectedTab == tabPage_360)
            {
                // update 
                comboBox_360_categary.Items.Clear();

                var url = "http://wallpaper.apc.360.cn/index.php?c=WallPaperAndroid&a=getAllCategories";
                var html = await FetchGet(url);
                if (html.Length > 0)
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
            if (tabControl1.SelectedTab == tabPage_bian)
            {
                comboBox_bian_categary.Items.Clear();
                // 分类信息
                var url = "http://www.netbian.com/";
                var html = await FetchGet(url, "GBK");
                var cateXpath = "//div[@class='nav cate']/a";
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var nds = doc.DocumentNode.SelectNodes(cateXpath);
                foreach(var nd in nds)
                {
                    var href = nd.Attributes["href"].Value;
                    if ( href.StartsWith("/"))
                    {
                        var itm = new BGBianCategary
                        {
                            Name = nd.InnerText,
                            Url = "http://www.netbian.com" + href,
                        };
                        comboBox_bian_categary.Items.Add(itm);
                    }
                }
                comboBox_bian_categary.SelectedIndex = 0;
            }
        }
        private void button_bg_set_Click(object sender, EventArgs e)
        {
            var imgList = new List<String>();
            DirectoryInfo d = new DirectoryInfo(root_folder);
            var imgs = d.GetFiles("*.jpg");
            imgs = imgs.OrderBy(g => g.CreationTime).Reverse().ToArray();
            foreach (var f in imgs)
            {
                imgList.Add(f.FullName);
            }
            SetBGfromImages(imgList);
        }

        private void button_bg_select_Click(object sender, EventArgs e)
        {
            var fsDlg = new OpenFileDialog();
            fsDlg.InitialDirectory = root_folder;
            fsDlg.Filter = "JPG Image|*.jpg|PNG Image|*.png";
            fsDlg.Multiselect = true;
            fsDlg.Title = "Select the images you want set as background:";
            fsDlg.CheckFileExists = true;
            fsDlg.CheckPathExists = true;
            //fsDlg.RestoreDirectory = true;
            if (fsDlg.ShowDialog() == DialogResult.OK)
            {
                var imgList = fsDlg.FileNames.ToList();
                SetBGfromImages(imgList);
            }
        }

        private void radioButton_tm_change_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1000 * 60 * ((int)num_tm_delay.Value);
            timer1.Start();
        }

        private void radioButton_tm_none_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button_bg_set.PerformClick();
        }

        private async void button_bian_Click(object sender, EventArgs e)
        {
            var item = (BGBianCategary)comboBox_bian_categary.SelectedItem;
            var url = item.Url;
            var page = (int)(num_bian_page.Value);
            if (page>1)
            {
                url = $"http://www.netbian.com/{item.Url}/index_{page}.htm";
            }
            var html = await FetchGet(url, "GBK");
            try
            {
                if (html.Length > 0)
                {
                    var cateXpath = "//div[@class='list']/ul/li//img";
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var nds = doc.DocumentNode.SelectNodes(cateXpath);
                    for (var i=0; i<nds.Count;i++)
                    {
                        var nd = nds[i];
                        var smurl = nd.Attributes["src"].Value;

                        var ext = System.IO.Path.GetExtension(smurl);
                        var smname = System.IO.Path.GetFileNameWithoutExtension(smurl);
                        var lgname = smname + ext;
                        if (smname.StartsWith("small") && smname.Length>15) { 
                            lgname = smname.Substring(5, smname.Length - 5 - 10) + ext;
                        }
                        var lgpath = smurl.Substring(0, smurl.Length-smname.Length-ext.Length) + lgname;

                        string path = $"{root_folder}/BiAn_{lgname}";
                        label_log.Text = $"BiAn {i + 1}/{nds.Count} => {path} start ...";
                        if (System.IO.File.Exists(path))
                        {
                            label_log.Text = $"BiAn {i + 1}/{nds.Count} => {path} exist, skip it.";
                        }
                        else
                        {
                            await FetchGetFile(lgpath, path);
                            label_log.Text = $"BiAn {i + 1}/{nds.Count} => {path} Done.";
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
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
    public class BGBianCategary
    {
        public string Name { get; set; }
        public string Url { get; set; }
        override public string ToString() { return Name; }
    }
}