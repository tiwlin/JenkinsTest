using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BranchLib
{
    public class BranchHelper
    {
        public bool InvokeBuild()
        {
            bool isInvoke = false;

            string strUrl = string.Format("http://localhost:8080/job/JenkinsTest/build?token={0}", "tiwlintesttoken");

            string strResult = GetRequest(strUrl);

            return isInvoke;
        }

        public static string GetRequest(string url)
        {
            string strBuff = "";
            Uri httpURL = new Uri(url);
            ///HttpWebRequest类继承于WebRequest，并没有自己的构造函数，需通过WebRequest的Creat方法 建立，并进行强制的类型转换   
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(httpURL);
            ///通过HttpWebRequest的GetResponse()方法建立HttpWebResponse,强制类型转换   
            HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();
            ///GetResponseStream()方法获取HTTP响应的数据流,并尝试取得URL中所指定的网页内容   
            ///若成功取得网页的内容，则以System.IO.Stream形式返回，若失败则产生ProtoclViolationException错 误。在此正确的做法应将以下的代码放到一个try块中处理。这里简单处理   
            Stream respStream = httpResp.GetResponseStream();
            ///返回的内容是Stream形式的，所以可以利用StreamReader类获取GetResponseStream的内容，并以   
            //StreamReader类的Read方法依次读取网页源程序代码每一行的内容，直至行尾（读取的编码格式：UTF8）   
            StreamReader respStreamReader = new StreamReader(respStream, Encoding.UTF8);
            strBuff = respStreamReader.ReadToEnd();
            return strBuff;
        }
    }
}
