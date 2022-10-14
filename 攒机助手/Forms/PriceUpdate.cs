using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
namespace 攒机助手专业版
{
    public partial class PriceUpdate : Form
    {
        public PriceUpdate()
        {
            InitializeComponent();
        }

        int allhw = 0;
        int errorhw = 0;
        bool shouldcontinue = true;
        delegate void set_Text(string s); //定义委托
        set_Text Set_Text;
        Thread pupdate;
        //string s = "ejkf()55(  )44(..)hgdhg(ertret)ertrt(rtret  12323.--4))";
        //string ss = Regex.Replace(s, @"\([^\(]*\)", "");

        private void set_textboxText(string s)
        {
            txtLog.AppendText(DateTime.Now.ToString() + " " + s + "\r\n");
            txtLog.Focus();
        }
        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = Encoding.Default.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
        private void log(string logs)
        {
            txtLog.AppendText(DateTime.Now.ToString() + " " + logs + "\r\n");
            txtLog.Focus();
        }


        /// <summary>
        /// 判断输入字符串是否为数字
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public bool IsNumber(string strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            string strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            string strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }

        private int GetTaobaoPrice(string hw, int originalprice)
        {
            allhw++;
            try
            {
                if (checkBoxNoParentheses.Checked)
                {
                    hw = Regex.Replace(hw.Trim(), @"\([^\(]*\)", "");
                }
                string pageHtml;
                WebClient MyWebClient1 = new WebClient();

                MyWebClient1.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                byte[] pageData1 = MyWebClient1.DownloadData("http://s.taobao.com/search?q=" + UrlEncode(hw) + "&style=list"); //从指定网站下载数据

                pageHtml = Encoding.GetEncoding("gb2312").GetString(pageData1);
                // MessageBox.Show(pageHtml);
                //选择5前5个平均
                int endpriceindex = 1;
                int startpartindex;
                int startpriceindex;
                long finalresult = 0;
                int i;
                int average_count = 0;
                int sum = 0;

                int[] tbprices = new int[(int)numericUpDown1.Value];
                if (!pageHtml.Contains("view_price"))
                {

                    endpriceindex = pageHtml.IndexOf("sell-info");
                }
                for (i = 0; i < numericUpDown1.Value; i++)
                {
                    //view_price
                    if (!pageHtml.Contains("view_price"))
                    {
                        startpartindex = pageHtml.IndexOf("price-num", endpriceindex);
                        startpriceindex = startpartindex + 11;
                        endpriceindex = pageHtml.IndexOf(".", startpriceindex);
                        string tbprice = pageHtml.Substring(startpriceindex, endpriceindex - startpriceindex);
                        if (!IsNumber(tbprice) && i != 0)
                        {
                            continue;
                        }
                        tbprices[i] = int.Parse(tbprice);
                        sum += tbprices[i];
                        //finalresult += System.Int32.Parse(tbprice);
                        average_count++;


                    }
                    else
                    {
                        startpartindex = pageHtml.IndexOf("view_price", endpriceindex);

                        //Console.WriteLine("http://s.taobao.com/search?q=" + UrlEncode(hw));
                        startpriceindex = startpartindex + 13;
                        endpriceindex = pageHtml.IndexOf(".", startpriceindex);
                        string tbprice = pageHtml.Substring(startpriceindex, endpriceindex - startpriceindex);
                        if (!IsNumber(tbprice) && i != 0)
                        {
                            continue;
                        }
                        tbprices[i] = int.Parse(tbprice);
                        sum += tbprices[i];

                        average_count++;
                    }

                }
                //////////////////删除偏差过大数据，计算平均值
                int average = sum / average_count;
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    if ((Math.Abs(tbprices[j] - average) / average) > 0.5 && average_count > 1)
                    {
                        sum = sum - tbprices[j];
                        average_count--;
                    }
                }
                finalresult = sum / average_count;
                //////////////////


                if (hw.Contains("x2"))
                {
                    txtLog.Invoke(Set_Text, new object[] { hw + " " + ((finalresult) * 2).ToString() });

                    return (int)(finalresult) * 2;
                }
                else if (hw.Contains("x3"))
                {
                    txtLog.Invoke(Set_Text, new object[] { hw + " " + ((finalresult) * 3).ToString() });

                    return (int)(finalresult) * 3;
                }
                else if (hw.Contains("x4"))
                {
                    txtLog.Invoke(Set_Text, new object[] { hw + " " + ((finalresult) * 4).ToString() });

                    return (int)(finalresult) * 4;
                }
                else
                {
                    txtLog.Invoke(Set_Text, new object[] { hw + " " + ((int)(finalresult)).ToString() });

                    return (int)(finalresult);
                }
            }
            catch (Exception e)
            {
                txtLog.Invoke(Set_Text, new object[] { hw + "http://s.taobao.com/search?q=" + UrlEncode(hw) + "&style=list" + e.ToString() });
                errorhw++;
                return originalprice;
            }
        }


        private int GetZolPrice(string pname, int originalprice)
        {
            string pageHtml;
            allhw++;
            try
            {
                if (checkBoxNoParentheses.Checked)
                {
                    pname = Regex.Replace(pname.Trim(), @"\([^\(]*\)", "");
                }

                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                byte[] pageData;
                pageData = MyWebClient.DownloadData("http://detail.zol.com.cn/index.php?c=SearchList&keyword=" + UrlEncode(pname)); //从指定网站下载数据

                pageHtml = Encoding.Default.GetString(pageData);

                int pricestart = pageHtml.IndexOf("price-type") + 12;
                int priceend = pageHtml.IndexOf("</b>", pricestart);
                string newprice = pageHtml.Substring(pricestart, priceend - pricestart);
                txtLog.Invoke(Set_Text, new object[] { pname + " " + newprice });
                //log(pname + " " + newprice);

                if (pname.Contains("x2")) { return int.Parse(newprice) * 2; }
                else if (pname.Contains("x3")) { return int.Parse(newprice) * 3; }
                else if (pname.Contains("x4")) { return int.Parse(newprice) * 4; }
                else { return int.Parse(newprice); }
            }
            catch (Exception e)
            {
                errorhw++;
                PriceUpdate pu = new PriceUpdate();
                //if (!pu.IsDisposed)
                //{
                txtLog.Invoke(Set_Text, new object[] { pname + e.ToString() });
                //}
                return originalprice;

            }

        }
        private void updating()
        {
            txtLog.Invoke(Set_Text, new object[] { "进程已启动" });
            bool isf = false;//是否盗版
            //progressBar1 .Invoke 
            try
            {
                string strURL = AESEncryption.Decrypt("gfyHiGjTt887ZAyXQNAg4eWmqHiU3CAB249/CsIzw4u3gmXXHrwwAxy7lX2lr2CJR6776CFYN+KuuDC5/UPCAA==") + HttpUtility.UrlEncode(AESEncryption.Encrypt(MachineCode.GetMachineCode()));
                HttpWebRequest request;
                // 创建一个HTTP请求
                request = (HttpWebRequest)WebRequest.Create(strURL);
                //request.Method="get";
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                StreamReader myreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string responseText = myreader.ReadToEnd();
                myreader.Close();
                if (!AuthKeyManager.GetIsTrial() && responseText != "" && AESEncryption.Decrypt(responseText).Substring(0, 1) != "1" && System.DateTime.Now.ToShortTimeString().Contains("3"))
                {
                    isf = true;
                }
            }
            catch { }

            //int z = 1;
            if (isf)
            {
                foreach (HardWareKind item in checkedListBox1.SelectedItems)
                {
                    foreach (var hwItem in item.HW)
                    {
                        //hwItem.SellPrice = GetZolPrice(hwItem.Name, hwItem.SellPrice);
                    }
                }
              
            }
            else
            {
                Func<string, int, int> updateFunc;
                List<string> notUpdateItem = new List<string>();
                notUpdateItem.Add("自动选择");
                notUpdateItem.Add("集成显卡/核心显卡");
                notUpdateItem.Add("套装自带");
                notUpdateItem.Add("机箱自带");
                notUpdateItem.Add("盒装自带");
                if (radioButtonzol.Checked)
                {
                    updateFunc = GetZolPrice;                   
                }
                else
                {
                    updateFunc = GetTaobaoPrice;
                
                }
                //for (int i = 0; i < checkedListBox1.Items.Count ; i++)
                //{
                //    if (checkedListBox1.Items[i]
                //}
                foreach (HardWareKind item in checkedListBox1.CheckedItems)
                {
                    foreach (var hwItem in item.HW)
                    {
                        if (!shouldcontinue) { return; }
                        bool shouldUpdate = true;
                        if ((!checkBoxIncludeZero.Checked) && hwItem.SellPrice == 0)
                        {
                            continue;
                        }
                        foreach (var doNotUpdateItem in notUpdateItem)
                        {
                            if (hwItem.Name == doNotUpdateItem)
                            {
                                shouldUpdate = false;
                            }
                        }
                        if (!shouldUpdate) continue;
                        hwItem.SellPrice = updateFunc(hwItem.Name, hwItem.SellPrice);
                    }
                }
            }

            Invoke(new MethodInvoker(Btntext));


            MessageBox.Show("更新完成!总共更新" + allhw.ToString() + "个硬件，错误" + errorhw.ToString() + "个。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //buttonstart.Text = "点击开始更新";


        }
        private void Btntext()
        {
            btnStart.Text = "点击开始更新";
        }
        private void priceupdate_Load(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = SData.allHwKind;
          
            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            //攒机助手配件价格更新模块1.1  build20140712
            Set_Text = new set_Text(set_textboxText);


            log("配置文件加载完毕");

        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "点击开始更新")
            {
                pupdate = new Thread(updating);
                pupdate.IsBackground = true;

                pupdate.Start();
                shouldcontinue = true;
                btnStart.Text = "停止";
            }
            else
            {
                btnStart.Text = "点击开始更新";
                shouldcontinue = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtLog.ScrollToCaret();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-6212-1-1.html");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-6212-1-1.html");

        }

        private void priceupdate_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void priceupdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try { if (pupdate.IsAlive) { pupdate.Abort(); } }
            //catch { }
            Log.WriteLog("PriceUpdate.log", txtLog.Text);


        }

        private void label5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, false);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));

            }

        }

        private void radioButtonzol_CheckedChanged(object sender, EventArgs e)
        {
            if (Form1.trial && radioButtonzol.Checked)
            {
                MessageBox.Show("试用版不提供此功能！如果您喜欢本软件，希望您支持正版！\n本软件最低售价仅10元！");
                radioButtonzol.Checked = false;
                radioButtontb.Checked = true;
            }
        }
    }
}
