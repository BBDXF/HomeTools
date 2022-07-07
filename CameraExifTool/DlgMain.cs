using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Security.Cryptography;

namespace CameraExifTool
{
    public partial class DlgMain : Form
    {
        public DlgMain()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void DlgMain_Load(object sender, EventArgs e)
        {
            // path
            text_folder_src.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            text_folder_dst.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            // page 1
            comb_roation_angle.SelectedIndex = 0;
            combo_format_new.SelectedIndex = 0;
        }
        delegate void AddLogCallback(string text);
        public void add_log(string context)
        {
            if (this.text_logs.InvokeRequired)
            {
                AddLogCallback d = new AddLogCallback(add_log);
                this.Invoke(d, new object[] { context });
            }
            else
            {
                text_logs.AppendText(context+"\r\n");
            }
        }

        private void button_folder_src_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "选择一个源照片文件夹:";
            if ( dlg.ShowDialog() == DialogResult.OK )
            {
                if ( string.IsNullOrEmpty(dlg.SelectedPath) )
                {
                    add_log("warning: 未选择一个文件夹!");
                    return;
                }
                text_folder_src.Text = dlg.SelectedPath;
            }
        }

        private void button_folder_dst_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "选择一个导出照片文件夹:";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dlg.SelectedPath))
                {
                    add_log("warning: 未选择一个文件夹!");
                    return;
                }
                text_folder_dst.Text = dlg.SelectedPath;
            }
        }

        private void button_basic_start_Click(object sender, EventArgs e)
        {
            // 角度
            int nAngle = -1;
            if ( radio_rotation_angle.Checked )
            {
                nAngle = comb_roation_angle.SelectedIndex * 90;
            }
            // 尺寸
            int nSizeMethod = 1; // 1 比例，2 固定大小，3 最大尺寸比例
            int[] nSizeArgs = { 100, 0 };
            if ( radio_size_per.Checked )
            {
                nSizeMethod = 1;
                nSizeArgs[0] = int.Parse(text_size_per.Text);
            }else if (radio_size_fixed.Checked)
            {
                nSizeMethod = 2;
                string[] split_arg = { " ", ",", "x"};
                var args = text_size_fixed.Text.Split(split_arg, StringSplitOptions.RemoveEmptyEntries);
                if (args.Length >= 2) {
                    nSizeArgs[0] = int.Parse(args[0]);
                    nSizeArgs[1] = int.Parse(args[1]);
                }
            }else if (radio_size_max_per.Checked)
            {
                nSizeMethod = 3;
                nSizeArgs[0] = int.Parse(text_size_max_per.Text);
            }
            // 格式
            int nFormat = -1;
            if ( radio_format_new.Checked )
            {
                nFormat = combo_format_new.SelectedIndex;
            }
            // precheck
            if ( string.IsNullOrEmpty(text_folder_src.Text) || string.IsNullOrEmpty(text_folder_dst.Text))
            {
                MessageBox.Show("图片路径为空，请设置后使用!");
                return;
            }
            // process
            Basic_process(text_folder_src.Text, text_folder_dst.Text, nAngle, nSizeMethod, nSizeArgs, nFormat);
        }
        public List<string> Scan_Folder(string path, bool enSub)
        {
            var imgs = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(path);
            string[] filters = { "*.jpg", "*.jpeg", "*.bmp", "*.png"  };
            foreach(string reg in filters)
            {
                FileInfo[] thefileInfo = theFolder.GetFiles(reg, enSub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                foreach (FileInfo NextFile in thefileInfo)
                {
                    imgs.Add(NextFile.FullName);
                    Debug.WriteLine(NextFile.FullName);
                }
            }
            return imgs;
        }
        public Image ImageResize(Image img, Size sz)
        {
            var bmp = new Bitmap(sz.Width, sz.Height);
            var g = Graphics.FromImage(bmp);
            //g.Clear(TransparencyKey);
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            return bmp;
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                { return codec; }
            }
            return null;
        }
        public void ImageSave(Image img, int quality, ImageFormat fmt, String path)
        {
            ImageCodecInfo CodecInfo = GetEncoder(fmt);
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            img.Save(path, CodecInfo, myEncoderParameters);
            myEncoderParameters.Dispose();
        }
        public void Basic_process(string folder_src, string folder_dst, int nAngle, int nSizeM, int[] nSizeArgs, int nFormat)
        {
            // 1. image list
            var imgList = Scan_Folder(folder_src, check_folder_sub.Checked);
            add_log($"查找到 {imgList.Count} 张图片,目标路径{folder_dst}, 开始处理...");
            // xuan zhuan
            for(int i = 0; i < imgList.Count; i++)
            {
                var imgPath = imgList[i];
                var imgSrc = Image.FromFile(imgPath);
                Image imgOut = null;
                // angle
                if ( nAngle < 0 )
                {
                    if(imgSrc.PropertyIdList.Contains(0x0112))
                    {
                        var ori = imgSrc.GetPropertyItem(0x0112);
                        switch (ori.Value[0] + ori.Value[1])
                        {
                            case 1: { nAngle = 0; } break;
                            case 3: { nAngle = 180; } break;
                            case 6: { nAngle = 270; } break;
                            case 8: { nAngle = 90; } break;
                            default: break;
                        }
                        //Debug.WriteLine($">>>> {ori.Value[0] } { ori.Value[1]} => {nAngle}");
                    }
                }
                switch (nAngle)
                {
                    case 0:
                    case -1:
                        break;
                    case 90:
                        { imgSrc.RotateFlip(RotateFlipType.Rotate90FlipNone); }
                        break;
                    case 180:
                        { imgSrc.RotateFlip(RotateFlipType.Rotate180FlipNone); }
                        break;
                    case 270:
                    case -90:
                        { imgSrc.RotateFlip(RotateFlipType.Rotate270FlipNone); }
                        break;
                    default:
                        break;
                }

                // size // 1 比例，2 固定大小，3 最大尺寸比例
                var newSz = new Size(imgSrc.Width, imgSrc.Height);
                switch ( nSizeM )
                {
                    case 1:
                    case 0:
                        newSz.Width = Convert.ToInt32(newSz.Width * 1.0 * nSizeArgs[0] / 100);
                        newSz.Height = Convert.ToInt32(newSz.Height * 1.0 * nSizeArgs[0] / 100);
                        break;
                    case 2:
                        newSz.Width = nSizeArgs[0];
                        newSz.Height = nSizeArgs[1];
                        break;
                    case 3:
                        if (newSz.Width > newSz.Height)  // width 大
                        {
                            double nMaxF = nSizeArgs[0] * 1.0 / newSz.Width;
                            newSz.Width = nSizeArgs[0];
                            newSz.Height = Convert.ToInt32(nMaxF * newSz.Height);
                        }
                        else
                        {
                            double nMaxF = nSizeArgs[0] * 1.0 / newSz.Height;
                            newSz.Height = nSizeArgs[0];
                            newSz.Width = Convert.ToInt32(nMaxF * newSz.Width);
                        }
                        break;
                    default:
                        break;
                }
                imgOut = ImageResize(imgSrc, newSz);

                // append exif
                if ( check_basic_exif.Checked )
                {
                    // 光圈，曝光，相机，固件，GPS等基础信息，不包含角度，像素，长宽等不常用信息
                    int[] ids = { 0x010F, 0x0110, 0x0131, 0x0132, 0x0001, 0x0002, 0x0003, 0x0004, 0x0005, 0x0006,
                            0x829A, 0x829D, 0x8822, 0x9003, 0x9201, 0x9202, 0x9203,0x9204, 0x9205, 0x9206,0x9207, 0x9208, 0x9209,0x920A};
                    foreach (var ex in imgSrc.PropertyItems)
                    {
                        if (ids.Contains(ex.Id))
                            imgOut.SetPropertyItem(ex);
                    }
                }                

                // format // -1 default, 0 JPG, 1 PNG, 2 BMP, 3 GIF
                var ftName = Path.GetExtension(imgPath);
                var ftFmt = ImageFormat.Png;
                switch (nFormat)
                {
                    case 0:
                        ftName = ".jpg";
                        ftFmt = ImageFormat.Jpeg;
                        break;
                    case 1:
                        ftName = ".png";
                        ftFmt = ImageFormat.Png;
                        break;
                    case 2:
                        ftName = ".bmp";
                        ftFmt = ImageFormat.Bmp;
                        break;
                    case 3:
                        ftName = ".gif";
                        ftFmt = ImageFormat.Gif;
                        break;
                    default:
                        break;
                }
                var pref = check_auto_index.Checked ? $"{i+1}_" : "";
                var fileNewPath = Path.Combine(folder_dst, $"{pref + Path.GetFileNameWithoutExtension(imgPath)+ftName}");
                
                int nQuality = int.Parse(text_basic_quality.Text);
                ImageSave(imgOut, nQuality, ftFmt, fileNewPath);

                add_log($"Save =>[{i+1}/{imgList.Count}] 处理 {imgPath} => {fileNewPath} 完成.");
                imgSrc.Dispose();
                imgOut.Dispose();
            }
            add_log("========Basic Finished=========\r\n");
        }

        // tab2
        private void btn_rename_start_Click(object sender, EventArgs e)
        {
            // precheck
            if (string.IsNullOrEmpty(text_folder_src.Text) || string.IsNullOrEmpty(text_folder_dst.Text))
            {
                MessageBox.Show("图片路径为空，请设置后使用!");
                return;
            }
            // filelist
            // 1. image list
            var imgList = Scan_Folder(text_folder_src.Text, check_folder_sub.Checked);
            add_log($"查找到 {imgList.Count} 张图片,目标路径{text_folder_dst.Text}, 开始处理...");
            // prepare base information
            
            // one by one
            for (int i = 0; i < imgList.Count; i++)
            {
                var imgPath = imgList[i];
                var name = GetNewName(imgPath, i + 1);
                var imgOutPath = Path.Combine(text_folder_dst.Text, $"{name + Path.GetExtension(imgPath)}");
                File.Copy(imgPath, imgOutPath);
                add_log($"Copy =>[{i + 1}/{imgList.Count}] 处理 {imgPath} => {imgOutPath} 完成.");
            }
            add_log("========Rename Finished=========\r\n");
        }
        public string GetNewName(string imgPath, int imgIndex)
        {
            // imgIndex // %index%
            var imgName = Path.GetFileNameWithoutExtension(imgPath); // %name%
            var imgFileTime = File.GetLastWriteTime(imgPath); // %file_time%
            var imgSrc = Image.FromFile(imgPath);
            var imgExifTime = imgFileTime;  // %exif_time%
            if (imgSrc.PropertyIdList.Contains(0x9003))
            {
                var val = imgSrc.GetPropertyItem(0x9003).Value;
                Encoding ascii = Encoding.ASCII;
                var tm = ascii.GetString(val, 0, val.Length-1);
                imgExifTime = DateTime.ParseExact(tm, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture); // "2021:08:22 17:28:00"
            }
            imgSrc.Dispose();
            // new name
            var newName = "";
            if (check_rename_prefix.Checked)
            {
                var tmp = text_rename_prefix.Text;
                if ( check_rename_append_reg.Checked )
                {
                    var m = new Regex(tmp).Match(imgName);
                    if ( m.Success )
                    {
                        newName = m.Value;
                    }
                }
                else
                {
                    tmp = tmp.Replace("%index%", imgIndex.ToString());
                    tmp = tmp.Replace("%name%", imgName);
                    tmp = tmp.Replace("%file_time%", imgFileTime.ToString("yyyyMMdd-HHmmss"));
                    tmp = tmp.Replace("%exif_time%", imgExifTime.ToString("yyyyMMdd-HHmmss"));
                    newName = tmp;
                }
            }

            if (check_rename_name.Checked)
            {
                var tmp = text_rename_name.Text;
                if (check_rename_name_reg.Checked)
                {
                    var m = new Regex(tmp).Match(imgName);
                    if (m.Success)
                    {
                        newName += m.Value;
                    }
                }
                else
                {
                    tmp = tmp.Replace("%index%", imgIndex.ToString());
                    tmp = tmp.Replace("%name%", imgName);
                    tmp = tmp.Replace("%file_time%", imgFileTime.ToString("yyyyMMdd-HHmmss"));
                    tmp = tmp.Replace("%exif_time%", imgExifTime.ToString("yyyyMMdd-HHmmss"));
                    newName += tmp;
                }
            }

            if (check_rename_append.Checked)
            {
                var tmp = text_rename_append.Text;
                if (check_rename_append_reg.Checked)
                {
                    var m = new Regex(tmp).Match(imgName);
                    if (m.Success)
                    {
                        newName += m.Value;
                    }
                }
                else
                {
                    tmp = tmp.Replace("%index%", imgIndex.ToString());
                    tmp = tmp.Replace("%name%", imgName);
                    tmp = tmp.Replace("%file_time%", imgFileTime.ToString("yyyyMMdd-HHmmss"));
                    tmp = tmp.Replace("%exif_time%", imgExifTime.ToString("yyyyMMdd-HHmmss"));
                    newName += tmp;
                }
            }

            return newName;
        }
        public bool getNewFolderName(string oldname, ref string newname)
        {
            // "100MSDCF" no, // 10000405 yes
            if (!Regex.IsMatch(oldname, @"^\d{8}$"))
            {
                return false;
            }
            var folder_number = oldname.Substring(0, 3);
            var folder_y = "XXX"+oldname.Substring(3, 1);
            var folder_mm = oldname.Substring(4, 2);
            var folder_ss = oldname.Substring(6, 2);

            var tmp = text_dir_rename.Text;
            tmp = tmp.Replace("%index%", folder_number);
            tmp = tmp.Replace("%date%", folder_y+folder_mm+folder_ss);
            newname = tmp;

            return true;
        }
        private void button_folder_rename1_Click(object sender, EventArgs e)
        {
            // precheck
            if (string.IsNullOrEmpty(text_folder_src.Text) )
            {
                MessageBox.Show("图片文件夹路径为空，请设置后使用!");
                return;
            }
            // folderlist
            var folders = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(text_folder_src.Text);
            var dirsInfo = theFolder.GetDirectories("*", SearchOption.TopDirectoryOnly);
            foreach (DirectoryInfo NextDir in dirsInfo)
            {
                folders.Add(NextDir.FullName);
                Debug.WriteLine(NextDir.FullName);
            }
            add_log($"查找到 {folders.Count} 个文件夹, 开始处理...");
            // loop process
            for (int i = 0; i < folders.Count; i++)
            {
                var dir = folders[i];
                var name = Path.GetFileName(dir);
                var name2 = "";
                if (getNewFolderName(name, ref name2) )
                {
                    var ppath = Path.GetDirectoryName(dir);
                    Directory.Move(dir, Path.Combine(ppath, name2));
                    add_log($"Move =>[{i + 1}/{folders.Count}] 处理 {dir} => {name2} 完成.");
                }
                else
                {
                    add_log($"Move =>[{i + 1}/{folders.Count}] 处理 {dir} => 名称不合规,跳过.");
                }
            }
            add_log("========Rename Dir, method 1 Finished=========\r\n");
        }
        public DateTime? getFolderInnerFileDT(string path)
        {
            DateTime? dt = null;
            DirectoryInfo theFolder = new DirectoryInfo(path);
            var fjpg = theFolder.GetFiles("*.jpg").FirstOrDefault();
            if ( fjpg!=null && fjpg.Exists )
            {
                dt = fjpg.LastWriteTime;
                // exif
                var imgSrc = Image.FromFile(fjpg.FullName);
                if (imgSrc.PropertyIdList.Contains(0x9003))
                {
                    var val = imgSrc.GetPropertyItem(0x9003).Value;
                    Encoding ascii = Encoding.ASCII;
                    var tm = ascii.GetString(val, 0, val.Length - 1);
                    dt = DateTime.ParseExact(tm, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture); // "2021:08:22 17:28:00"
                }
                imgSrc.Dispose();
            }
            return dt;
        }
        private void button_folder_rename2_Click(object sender, EventArgs e)
        {
            // 内部文件方式
            // precheck
            if (string.IsNullOrEmpty(text_folder_src.Text))
            {
                MessageBox.Show("图片文件夹路径为空，请设置后使用!");
                return;
            }
            // folderlist
            var folders = new List<string>();
            DirectoryInfo theFolder = new DirectoryInfo(text_folder_src.Text);
            var dirsInfo = theFolder.GetDirectories("*", SearchOption.TopDirectoryOnly);
            foreach (DirectoryInfo NextDir in dirsInfo)
            {
                folders.Add(NextDir.FullName);
                Debug.WriteLine(NextDir.FullName);
            }
            add_log($"查找到 {folders.Count} 个文件夹, 开始处理...");
            // loop process
            for (int i = 0; i < folders.Count; i++)
            {
                var dir = folders[i];
                var name = Path.GetFileName(dir);
                var dt = getFolderInnerFileDT(dir);
                if ( dt == null )
                {
                    add_log($"Move =>[{i + 1}/{folders.Count}] 处理 {dir} => 空文件夹 Skip.");
                    continue;
                }
                // new name
                var tmp = text_dir_rename.Text;
                tmp = tmp.Replace("%index%", i.ToString());
                tmp = tmp.Replace("%date%", dt?.ToString("yyyyMMdd"));
                var name2 = tmp;

                var ppath = Path.GetDirectoryName(dir);
                Directory.Move(dir, Path.Combine(ppath, name2));
                add_log($"Move =>[{i + 1}/{folders.Count}] 处理 {dir} => {name2} 完成.");
            }
            add_log("========Rename Dir method 2 Finished=========\r\n");
        }
        public string getFileMD5(string path)
        {
            byte[] retMd5 = null;
            var md5 = MD5.Create();
            using (var fs = File.Open(path, FileMode.Open))
            {
                retMd5 = md5.ComputeHash(fs);
            }
            return ToHexStrFromByte(retMd5);
        }
        // path md5
        public Dictionary<string, string> scan_file_md5s(string path, bool bSub) 
        {
            var filesMd5 = new Dictionary<string, string>();
            DirectoryInfo theFolder = new DirectoryInfo(path);
            var fileInfs = theFolder.GetFiles("*", bSub ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            char[] split_params = { ' ', ';', '|' };
            var fs_filter = text_sync_filter.Text.ToLower().Split(split_params, StringSplitOptions.RemoveEmptyEntries);
            // Debug.WriteLine(fs_filter.Count());

            foreach(var inf in fileInfs)
            {
                var ext = inf.Extension.ToLower();
                if ( !fs_filter.Contains(ext) ) continue;
                var md = getFileMD5(inf.FullName);
                filesMd5[inf.FullName] = md;  // path, md5 因为md5有可能重复
                Debug.WriteLine(inf.FullName);
            }
            return filesMd5;
        }
        public string ToHexStrFromByte(byte[] byteDatas)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < byteDatas.Length; i++)
            {
                builder.Append(string.Format("{0:X2}", byteDatas[i]));
            }
            return builder.ToString().Trim();
        }
        private void button_sync_start_Click(object sender, EventArgs e)
        {
            // method
            bool bBaseMd5 = radio_sync_md5.Checked;
            // precheck
            if (string.IsNullOrEmpty(text_folder_src.Text) || string.IsNullOrEmpty(text_folder_dst.Text))
            {
                MessageBox.Show("文件夹路径为空，请设置后使用!");
                return;
            }
            // scan src and dst files md5
            var src_md5s = scan_file_md5s(text_folder_src.Text, check_folder_sub.Checked);
            var dst_md5s = scan_file_md5s(text_folder_dst.Text, true);
            // src 作为要同步的文件源， dst作为参考源
            add_log($"查找到 源 {src_md5s.Count}个, 同步目标 {dst_md5s.Count}个, 开始比较处理...");
            // find unmatched files
            var lostFilesMd5 = new Dictionary<string, string>();
            foreach(var one in src_md5s)
            {
                if ( !dst_md5s.ContainsValue(one.Value) )  // check md5
                {
                    lostFilesMd5[one.Key] = one.Value;
                }
            }
            add_log($"得到{lostFilesMd5.Count}个差异 不存在于 {text_folder_dst.Text}中, 开始复制...");
            // copy form dst to src, build path
            int i = 0;
            foreach (var k_path in lostFilesMd5.Keys)
            {
                var subPath = k_path.Substring(text_folder_src.Text.Length+1);
                var targetPath = Path.Combine(text_folder_dst.Text, subPath);
                Directory.CreateDirectory(Path.GetDirectoryName(targetPath));
                if ( File.Exists(targetPath) )
                {
                    var md = getFileMD5(targetPath);
                    add_log($"warning: 目标文件 {targetPath} 已存在, MD5:{md}, 准备覆盖处理...");
                }
                File.Copy(k_path, targetPath, true);
                add_log($"Copy =>[{i + 1}/{lostFilesMd5.Count}] 处理 {subPath}, MD5:{lostFilesMd5[k_path]} 到目标目录完成.");
                i += 1;
            }
            // finish
            add_log("========Sync Finished=========\r\n");
        }

        private void button_sync_filecompare_Click(object sender, EventArgs e)
        {
            // precheck
            if (string.IsNullOrEmpty(text_folder_src.Text) )
            {
                MessageBox.Show("文件夹路径为空，请设置后使用!");
                return;
            }
            // scan src and dst files md5
            var src_md5s = scan_file_md5s(text_folder_src.Text, check_folder_sub.Checked);

            // src 作为要同步的文件源， dst作为参考源
            add_log($"查找到 {src_md5s.Count}个文件, 开始比较处理...");
            // find duplicate Files
            var tmpFiles = new Dictionary<string, string>(); // path md5
            var duplicateFiles = new Dictionary<string, string>(); // path md5
            foreach (var one in src_md5s)
            {
                if (tmpFiles.ContainsValue(one.Value)) // md5 check
                {
                    duplicateFiles[one.Key] = one.Value;
                }
                else
                {
                    tmpFiles[one.Key] = one.Value;
                }
            }
            add_log($"得到{duplicateFiles.Count}个重复文件，开始删除...");
            // copy form dst to src, build path
            int i = 0;
            foreach (var k_path in duplicateFiles.Keys)
            {
                if (File.Exists(k_path))
                {
                    File.Delete(k_path);
                }
                add_log($"Delete =>[{i + 1}/{duplicateFiles.Count}] 处理 {k_path}, MD5:{duplicateFiles[k_path]} 完成.");
                i += 1;
            }
            // finish
            add_log("========Sync delete duplicate files Finished=========\r\n");
        }
    }
}
