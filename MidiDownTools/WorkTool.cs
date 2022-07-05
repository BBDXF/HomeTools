using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MidiBookSearcher
{
    public struct SiteSearch
    {
        public string Url;
        public string ResultUrl;
        public string ResultName;
    }

    public struct SiteDown
    {
        public string Meta;
        public string ImageUrl;
        public string ImageName;
    }

    public struct SiteSource{
        public string Name;
        public string Url;
        public string Tips;
        public string Encoding;
        public SiteSearch Search;
        public SiteDown Download;
    }

    public struct AppSource
    {
        public string Version;
        public string App;
        public string Tips;        
        public SiteSource[] Sources;
    }
    public class WorkTool
    {
        public AppSource LoadConfigSources()
        {
            var txt = "";
            using(var fs = new System.IO.StreamReader("./Source.json",Encoding.UTF8))
            {
                txt = fs.ReadToEnd();
            }
            var appSrc = JsonConvert.DeserializeObject<AppSource>(txt);
            return appSrc;
        }

        // http get
        public int FetchGet(string url, ref string result, string encoding="UTF-8")
        {
            result = "";
            try
            {
                HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
                wbRequest.Proxy = null;
                wbRequest.Method = "GET";
                HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
                using (Stream responseStream = wbResponse.GetResponseStream())
                {
                    using (StreamReader sReader = new StreamReader(responseStream, Encoding.GetEncoding(encoding)))
                    {
                        result = sReader.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;     //输出捕获到的异常，用OUT关键字输出
                return -1;              //出现异常，函数的返回值为-1
            }

            return result.Length;
        }

        // http post
        public int FetchPost(string url, string reqBody, ref string result, string encoding="UTF-8")
        {
            result = "";
            try
            {
                var enc = Encoding.GetEncoding(encoding);
                byte[] data = enc.GetBytes(reqBody);
                HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
                wbRequest.Proxy = null;    
                wbRequest.Method = "POST";
                wbRequest.ContentType = "application/json";
                wbRequest.ContentLength = data.Length;

                using (Stream wStream = wbRequest.GetRequestStream())
                {
                    wStream.Write(data, 0, data.Length);
                }

                //获取响应
                HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
                using (Stream responseStream = wbResponse.GetResponseStream())
                {
                    using (StreamReader sReader = new StreamReader(responseStream, enc))  
                    {
                        result = sReader.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;     //输出捕获到的异常，用OUT关键字输出
                return -1;              //出现异常，函数的返回值为-1
            }

            return result.Length;
        }

        public string UrlEncode(string str, string encoding="UTF-8")
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = Encoding.GetEncoding(encoding).GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }

        public int FetchGetFile(string url, string path)
        {
            Debug.WriteLine($"Download {url} to {path}");
            try
            {
                HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
                wbRequest.Proxy = null;
                wbRequest.Method = "GET";
                HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
                using (var responseStream = wbResponse.GetResponseStream())
                {
                    var buff = new byte[4096];
                    using (var sReader = new BinaryReader(responseStream))
                    {
                        using(var sWriter = new FileStream(path, FileMode.OpenOrCreate))
                        {
                            var nLen = 0;
                            do
                            {
                                nLen = sReader.Read(buff, 0, 1024);
                                if ( nLen > 0 )
                                {
                                    sWriter.Write(buff, 0, nLen);
                                }
                            } while (nLen>0);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return -1;
            }

            return 1;
        }
    }
}
