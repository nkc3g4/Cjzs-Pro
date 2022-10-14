using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;
using System.Net;
namespace 攒机助手专业版
{
    public partial class Activate : Form
    {
        public Activate()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            #region OldCode
            //string authkey;
            //MD5 md5 = new MD5CryptoServiceProvider();

            //byte[] result = Encoding.Default.GetBytes("cjzs_pro_" + textBoxname.Text );
            //byte[] output = md5.ComputeHash(result);//tbPass为输入密码的文本框
            //authkey = BitConverter.ToString(output).Replace("-", "");
            //if (authkey != textBoxkey.Text) {MessageBox .Show ("注册码错误！请重新输入！");return; }

            //string upstr = AESEncryption.Encrypt(textBoxmacode.Text + "|" + textBoxname.Text + "|" + textBoxkey.Text);

            //string[] strSplit = upstr.Split('-');
            //byte[] bytTemp2 = new byte[strSplit.Length];
            //for (int i = 0; i < strSplit.Length; i++)
            //    bytTemp2[i] = byte.Parse(strSplit[i], System.Globalization.NumberStyles.AllowHexSpecifier);
            //string upstr2 = BitConverter.ToString(bytTemp2);
            //Clipboard.SetText(upstr);
            //MessageBox.Show(upstr);
            //string pageHtml;
            //try
            //{

            //    WebClient MyWebClient = new WebClient();

            //    MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

            //    Byte[] pageData = MyWebClient.DownloadData("http://bbs.luobotou.org/app/cjzs_pro.txt"); //从指定网站下载数据

            //    pageHtml = Encoding.Default.GetString(pageData);
            //    //MessageBox.Show(pageHtml);
            //    int index = pageHtml.IndexOf("webreport=");

            //    if (pageHtml.Substring(index + 10, 1) == "1")
            //    {
            //string strURL = "http://myapp.luobotou.org/cjzsreg.aspx?string=cjzspro&ver=" + Application.ProductVersion + "&an=" + AuthKeyManager.AuthName();
            //System.Net.HttpWebRequest request;
            //// 创建一个HTTP请求
            //request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            ////request.Method="get";
            //System.Net.HttpWebResponse response;
            //response = (System.Net.HttpWebResponse)request.GetResponse();
            //System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            //string responseText = myreader.ReadToEnd();
            //myreader.Close();

            //    }


            //}
            //catch (WebException webEx)
            //{

            //    Console.WriteLine(webEx.Message.ToString());

            //}
            #endregion
            if (textBoxname.Text.Length == 0 || textBoxkey.Text.Length == 0)
            {
                MessageBox.Show("请输入名和码");
                return;
            }

            using (FileStream fs = new FileStream(Form1.userpath + "\\auth.key", FileMode.Open, FileAccess.Write))
            {
                fs.SetLength(0);
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    string writeString = string.Empty;
                    writeString = "[EMAIL]" + textBoxname.Text.Trim();
                    sw.WriteLine(writeString);
                    writeString = "[KEY]" + textBoxkey.Text.Trim();
                    sw.WriteLine(writeString);
                }
            }
            MessageBox.Show("注册信息已录入！感谢您购买此软件！\n程序将重新启动！");
            Application.Restart();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-7252-1-1.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-4296-1-1.html");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-7252-1-1.html");
        }

        private void Activate_Load(object sender, EventArgs e)
        {
            textBoxmacode.Text = MachineCode.GetMachineCode();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-7252-1-1.html");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-4296-1-1.html");

        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-7252-1-1.html");

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.OrangeRed;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Blue;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.OrangeRed;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Red;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.OrangeRed;

        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Blue;

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxmacode.Text);
            MessageBox.Show("已复制");
        }
    }
}
