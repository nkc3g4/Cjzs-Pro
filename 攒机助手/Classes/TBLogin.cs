using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using MS.Utility;
namespace 攒机助手专业版
{
    class TBLogin
    {
        CookieContainer cookieContainer = new CookieContainer();
        /// <summary>
        /// 通过POST方式发送数据
        /// </summary>
        /// <param name="Url">url</param>
        /// <param name="postDataStr">Post数据</param>
        /// <param name="cookie">Cookie容器</param>
        /// <returns></returns>
        public static string SendDataByPost(string Url, Encoding encoding, string postDataStr, ref CookieContainer cookie, ref string AbsoluteUri)
        {
            string retString = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Timeout = 40000;
                if (cookie.Count == 0)
                {
                    request.CookieContainer = new CookieContainer();
                    cookie = request.CookieContainer;
                }
                else
                {
                    request.CookieContainer = cookie;
                }

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                //request.ContentLength = postDataStr.Length;
                Stream myRequestStream = request.GetRequestStream();
                StreamWriter myStreamWriter = new StreamWriter(myRequestStream, encoding);
                myStreamWriter.Write(postDataStr);
                myStreamWriter.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, encoding);
                retString = myStreamReader.ReadToEnd();
                AbsoluteUri = response.ResponseUri.AbsoluteUri;
                myStreamReader.Close();
                myResponseStream.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return retString;
        }
        private string aq_0 = "您需要安装安全控件，才可使用安全登录。";
        private string aq_1 = "您还未安装密码安全控件，安装后即可输入密码。";
        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.Default.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }

        /// <summary>
        /// 淘宝登陆
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool LoginTaobao(string Account, string Password)
        {
            string AbsoluteUri = string.Empty;
            string result = SendDataByPost("http://login.taobao.com/member/login.jhtml", Encoding.GetEncoding("gb2312"), "TPL_username=" + UrlEncode(Account) +
                "&TPL_password=" + UrlEncode(Password) + "&actionForStable=enable_post_user_action&action=Authenticator&event_submit_do_login=anything", ref cookieContainer, ref AbsoluteUri);
            //System.Windows.Forms.MessageBox.Show(result );
            Console.WriteLine(result);
            if (Regex.IsMatch(result, "safe/check_ip.do"))
            {
                System.Windows.Forms.MessageBox.Show("Test1");
                //Platform.Common.StatusOutputEvent(new object(), new Platform.Common.StatusArgs() { Message = "请在淘宝页面 [账号管理] 页面关闭 [登录保护] 功能或设置不进行二次验证地域." });
                return false;
            }

            if (result.IndexOf(aq_0) == -1 && result.IndexOf(aq_1) == -1)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Test2");
                //Platform.Common.StatusOutputEvent(new object(), new Platform.Common.StatusArgs() { Message = "[" + this.Name + "] 登录失败." });
                return false;
            }
        }

    }
}
