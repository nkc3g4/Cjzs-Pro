using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
namespace 攒机助手专业版
{
    static class OnlineOperation
    {
        public static void WebReport()
        {
            string pageHtml;
            try
            {

                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                Byte[] pageData = MyWebClient.DownloadData("http://bbs.luobotou.org/app/cjzs_pro.txt"); //从指定网站下载数据

                pageHtml = Encoding.Default.GetString(pageData);
                //MessageBox.Show(pageHtml);
                int index = pageHtml.IndexOf("webreport=");

                if (pageHtml.Substring(index + 10, 1) == "1")
                {
                    string strURL = "http://myapp.luobotou.org/statistics.aspx?name=cjzspro&ver=" + Application.ProductVersion + "&an=" + AuthKeyManager.GetAuthName();
                    System.Net.HttpWebRequest request;
                    // 创建一个HTTP请求
                    request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
                    //request.Method="get";
                    System.Net.HttpWebResponse response;
                    response = (System.Net.HttpWebResponse)request.GetResponse();
                    System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    string responseText = myreader.ReadToEnd();
                    myreader.Close();

                }


            }
            catch (WebException webEx)
            {

                Console.WriteLine(webEx.Message.ToString());

            }

        }
        public static void ProgramUpdate()
        {
            //if (IsRegeditExit(Application.ProductName)) { if ((GetRegistData("nevercheckupdate")) == "1") { return; } }

            string pageHtml;
            try
            {

                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                Byte[] pageData = MyWebClient.DownloadData("http://bbs.luobotou.org/app/cjzs_pro.txt"); //从指定网站下载数据

                pageHtml = Encoding.UTF8.GetString(pageData);
                //MessageBox.Show(pageHtml);
                int index = pageHtml.IndexOf("~");
                String ver;
                //MessageBox.Show(index.ToString());
                ver = pageHtml.Substring(index + 1, 7);
                if (ver != Application.ProductVersion)
                {
                    Update frmf = new Update(ver);
                    frmf.ShowDialog();
                    //frmf.Show();
                }

            }
            catch (WebException webEx)
            {

                Console.WriteLine(webEx.Message.ToString());

            }
        }
    }
}
