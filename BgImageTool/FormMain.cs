using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

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
                Wallpaper.SetWallpaper(screen_id, paths[uLastIndex]);
                label_log.Text = $"Set monitor background for {i + 1}/{monitorCount} using {paths[uLastIndex]}";
            }
        }
        public void SetBGForScreens(string path)
        {
            // https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-idesktopwallpaper-setwallpaper
            // SystemParametersInfo(20, 0, path, 2);
            Wallpaper.SetWallpaper(null, path);
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
                // SystemParametersInfo(20, 0, imgList.First(), 2);
                Wallpaper.SetWallpaper(null, imgList.First());
                label_log.Text = $"Set all monitor background with {imgList.First()}";
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
    }
    public class BG360Categary
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        override public string ToString() { return Name + " - " + Count; }
    }

}