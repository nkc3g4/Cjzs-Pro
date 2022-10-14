using System;
using System.Collections;//在C#中使用ArrayList必须引用Collections类
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace 攒机助手专业版
{

    public partial class Form1 : Form
    {
        //1:售价  2：质保 3.进价 4.ID


        //cpu[1]="";
        public Form1()
        {
            InitializeComponent();

            SData.hwCpu = new HardWareKind("CPU", "CPU", ComboBoxcpu, TextBoxcpu, TextBoxcpu1, textBoxCpuSr);
            SData.hwACpu = new HardWareKind("AMD CPU", "ACPU", ComboBoxcpu, TextBoxcpu, TextBoxcpu1, textBoxCpuSr);
            SData.hwMb = new HardWareKind("主板", "MB", ComboBoxmb, TextBoxmb, TextBoxmb1, textBoxMbSr);
            SData.hwRam = new HardWareKind("内存", "RAM", ComboBoxram, TextBoxram, TextBoxram1, textBoxRamSr);
            SData.hwHdd = new HardWareKind("硬盘", "HDD", ComboBoxhdd, TextBoxhdd, TextBoxhdd1, textBoxHddSr);
            SData.hwSsd = new HardWareKind("固态硬盘", "SSD", ComboBoxssd, TextBoxssd, TextBoxssd1, textBoxSsdSr);
            SData.hwGpu = new HardWareKind("显卡", "GPU", ComboBoxgpu, TextBoxgpu, TextBoxgpu1, textBoxGpusr);
            SData.hwLcd = new HardWareKind("显示器", "LCD", ComboBoxlcd, TextBoxlcd, TextBoxlcd1, textBoxLcdSr);
            SData.hwBox = new HardWareKind("机箱", "BOX", ComboBoxbox, TextBoxbox, TextBoxbox1, textBoxBoxsr);
            SData.hwFan = new HardWareKind("散热器", "FAN", ComboBoxfan, TextBoxfan, TextBoxfan1, textBoxFanSr);
            SData.hwPower = new HardWareKind("电源", "POW", ComboBoxpower, TextBoxpower, TextBoxpower1, textBoxPowerSr);
            SData.hwCdrom = new HardWareKind("光驱", "CDROM", ComboBoxcdrom, TextBoxcdrom, TextBoxcdrom1, textBoxCdromSr);
            SData.hwKb = new HardWareKind("键盘", "KB", ComboBoxkb, TextBoxkb, TextBoxkb1, textBoxKbSr);
            SData.hwHs = new HardWareKind("耳机", "HS", ComboBoxhs, TextBoxhs, TextBoxhs1, textBoxHsSr);
            SData.hwMou = new HardWareKind("鼠标", "MOU", ComboBoxmou, TextBoxmou, TextBoxmou1, textBoxMouSr);
            SData.hwCam = new HardWareKind("摄像头", "CAM", ComboBoxcam, TextBoxcam, TextBoxcam1, textBoxCamSr);
            SData.hwSp = new HardWareKind("音响", "SP", ComboBoxsp, TextBoxsp, TextBoxsp1, textBoxSpSr);
            SData.hwO = new HardWareKind("其他", "O", ComboBoxo, TextBoxo, TextBoxo1, textBoxOSr);

            SData.allHwKind.Add(SData.hwCpu);
            SData.allHwKind.Add(SData.hwACpu);
            SData.allHwKind.Add(SData.hwMb);
            SData.allHwKind.Add(SData.hwRam);
            SData.allHwKind.Add(SData.hwHdd);
            SData.allHwKind.Add(SData.hwSsd);
            SData.allHwKind.Add(SData.hwGpu);
            SData.allHwKind.Add(SData.hwLcd);
            SData.allHwKind.Add(SData.hwBox);
            SData.allHwKind.Add(SData.hwFan);
            SData.allHwKind.Add(SData.hwPower);
            SData.allHwKind.Add(SData.hwCdrom);
            SData.allHwKind.Add(SData.hwKb);
            SData.allHwKind.Add(SData.hwHs);
            SData.allHwKind.Add(SData.hwMou);
            SData.allHwKind.Add(SData.hwCam);
            SData.allHwKind.Add(SData.hwSp);
            SData.allHwKind.Add(SData.hwO);

            SData.hwCpu.AutoCuanJiInForm1 = c_cpu;
            SData.hwACpu.AutoCuanJiInForm1 = c_cpu;
            SData.hwMb.AutoCuanJiInForm1 = c_mb;
            SData.hwRam.AutoCuanJiInForm1 = c_ram;
            SData.hwHdd.AutoCuanJiInForm1 = c_hdd;
            SData.hwSsd.AutoCuanJiInForm1 = c_ssd;
            SData.hwGpu.AutoCuanJiInForm1 = c_gpu;
            SData.hwLcd.AutoCuanJiInForm1 = c_lcd;
            SData.hwBox.AutoCuanJiInForm1 = c_box;
            SData.hwFan.AutoCuanJiInForm1 = c_fan;
            SData.hwPower.AutoCuanJiInForm1 = c_power;
            SData.hwCdrom.AutoCuanJiInForm1 = c_cdrom;
            SData.hwKb.AutoCuanJiInForm1 = c_kb;
            SData.hwHs.AutoCuanJiInForm1 = c_hs;
            SData.hwMou.AutoCuanJiInForm1 = c_mou;
            SData.hwCam.AutoCuanJiInForm1 = c_cam;
            SData.hwSp.AutoCuanJiInForm1 = c_sp;
            SData.hwO.AutoCuanJiInForm1 = c_o;

            SData.hwCpu.CheckGift = cpuz;
            SData.hwACpu.CheckGift = cpuz;
            SData.hwMb.CheckGift = mbz;
            SData.hwRam.CheckGift = ramz;
            SData.hwHdd.CheckGift = hddz;
            SData.hwSsd.CheckGift = ssdz;
            SData.hwGpu.CheckGift = gpuz;
            SData.hwLcd.CheckGift = lcdz;
            SData.hwBox.CheckGift = boxz;
            SData.hwFan.CheckGift = fanz;
            SData.hwPower.CheckGift = powerz;
            SData.hwCdrom.CheckGift = cdromz;
            SData.hwKb.CheckGift = kbz;
            SData.hwHs.CheckGift = hsz;
            SData.hwMou.CheckGift = mouz;
            SData.hwCam.CheckGift = camz;
            SData.hwSp.CheckGift = spz;
            SData.hwO.CheckGift = oz;

            SData.hwCpu.CheckLeft = checkcpu;
            SData.hwACpu.CheckLeft = checkcpu;
            SData.hwMb.CheckLeft = checkmb;
            SData.hwRam.CheckLeft = checkram;
            SData.hwHdd.CheckLeft = checkhdd;
            SData.hwSsd.CheckLeft = checkssd;
            SData.hwGpu.CheckLeft = checkgpu;
            SData.hwLcd.CheckLeft = checklcd;
            SData.hwBox.CheckLeft = checkbox;
            SData.hwFan.CheckLeft = checkfan;
            SData.hwPower.CheckLeft = checkpower;
            SData.hwCdrom.CheckLeft = checkcdrom;
            SData.hwKb.CheckLeft = checkkb;
            SData.hwHs.CheckLeft = checkhs;
            SData.hwMou.CheckLeft = checkmou;
            SData.hwCam.CheckLeft = checkcam;
            SData.hwSp.CheckLeft = checksp;
            SData.hwO.CheckLeft = checko;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            if (!File.Exists(userpath + "\\settings.ini"))
            {
                CreateSettingsIni();
            }
            if (!File.Exists(userpath + "\\data.mdb"))
            {
                File.Copy(Application.StartupPath + "\\data.mdb", userpath + "\\data.mdb");
            }
            if (!File.Exists(userpath + "\\data.mdb.zip"))
            {
                File.Copy(Application.StartupPath + "\\data.mdb.zip", userpath + "\\data.mdb.zip");
            }
            if (!File.Exists(userpath + "\\sell.mdb"))
            {
                File.Copy(Application.StartupPath + "\\sell.mdb", userpath + "\\sell.mdb");
            }
            if (!File.Exists(userpath + "\\cjzs_.doc"))
            {
                File.Copy(Application.StartupPath + "\\cjzs_.doc", userpath + "\\cjzs_.doc");
            }


            sellMdbPath = userpath + "\\sell.mdb";
            settingsIni = userpath + "\\settings.ini";
            SettingItems.MdbPath = userpath + "\\data.mdb";

            //}


            trial = AuthKeyManager.GetIsTrial();
            ReadConfig();


            if (!File.Exists(SettingItems.MdbPath))
            {
                MessageBox.Show("配置文件错误！data.mdb不存在！");
                Application.Exit();
                return;
            }

            this.Text += Application.ProductVersion;
            if (trial)
            {
                this.Text += " 试用版";
                输入注册码ToolStripMenuItem.Visible = true;
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，希望您支持正版！\n本软件最低售价仅10元！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pdDocument.PrintPage += new PrintPageEventHandler(OnPrintPage);
            Set_Text = new set_Text(set_textboxText);

            Loading();

            //////////////////////////////////
            if (Application.ProductVersion.Substring(Application.ProductVersion.Length - 1, 1) == "0" && SettingItems.AutoUpdate)
            {
                threadupdate = new Thread(OnlineOperation.ProgramUpdate);
                threadupdate.Start();
            }
            if (Application.ProductVersion.Substring(Application.ProductVersion.Length - 1, 1) == "9")
                this.Text = "攒机助手专业版 测试版 Build:" + System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location);

            if (SettingItems.ShowAd)
            {
                threadad = new Thread(ad);
                threadad.Start();
            }
            dataupdate = new Thread(MdbDataUpdate);
            dataupdate.Start();
            threadreport = new Thread(OnlineOperation.WebReport);
            threadreport.Start();
            /*if (!trial)
            {
                active = new Thread(AuthKeyManager.Ac);
                active.Start();
            }*/


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gpu[Closest.cauto(gpu, gpu1, 1200, "^(?!.*R9)(?=.*HD).*$")]);
            if (textBoxMoney.Text == "") { MessageBox.Show("请输入预算金额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            int inputMoney = 0;
            if (!Int32.TryParse(textBoxMoney.Text, out inputMoney)) { MessageBox.Show("金额输入错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            if (inputMoney > 500000) { MessageBox.Show("您输入的金额过大，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            if (inputMoney <= 0) { MessageBox.Show("金额需大于0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            fixmode = true;
            try
            {
                Initialization();
                c_cpu();
                c_mb();
                c_gpu();
                c_ram();
                c_hdd();
                c_ssd();
                c_box();
                c_fan();
                c_power();
                c_cdrom();
                c_kb();
                c_mou();
                c_hs();
                c_cam();
                c_sp();
                c_o();
                //c_khcso();
                c_lcd();
                //gift();
                totalprice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("自动攒机出现严重错误\n" + ex.ToString());
                Log.WriteLog("Button1_Click.log", ex.ToString());
            }
        }


        private void ComboboxMouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip((ComboBox)sender, ((ComboBox)sender).SelectedItem.ToString());
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.textBoxMoney.Focus();
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            /*
             * 得到TextBox中每行的字符串數組
             * \n換行
             * \r回車
             */
            char[] param = { '\n' };
            string[] lines = clipdata.Split(param);

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in lines)
            {
                //刪除每行中的\r
                lines[i++] = s.TrimEnd(trimParam);
            }

            int x = 20;
            int y = 20;
            foreach (string line in lines)
            {
                /*
                 * 4、把文本行發送給打印機，其中e是PrintPageEventArgs類型的一個變量，其屬性連接到打印機關聯文本中。
                 * 打印機關聯文本可以寫到打印機設備上。
                 * 輸出結果的位置用變更X和Y定義。
                 */
                e.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, x, y);
                y += 15;
            }
        }
        private void labelcopy_Click(object sender, EventArgs e)
        {
            if (trial == true)
            {
                System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CopyToClipboard();
            Clipboard.SetText(clipdata);
            MessageBox.Show("复制成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CopyToClipboard()
        {
            if (checkcpu.Checked)
            {
                clipdata = "";
                clipdata += "CPU";
                clipdata += " ";
                clipdata += TextBoxcpu.Text;
                clipdata += " ";
                clipdata += TextBoxcpu1.Text;
                clipdata += "\r\n";
            }
            if (checkmb.Checked)
            {
                clipdata += "主板";
                clipdata += " ";
                clipdata += TextBoxmb.Text;
                clipdata += " ";
                clipdata += TextBoxmb1.Text;
                clipdata += "\r\n";
            }
            if (checkram.Checked)
            {
                clipdata += "内存";
                clipdata += " ";
                clipdata += TextBoxram.Text;
                clipdata += " ";
                clipdata += TextBoxram1.Text;
                clipdata += "\r\n";
            }
            if (checkhdd.Checked)
            {
                clipdata += "硬盘";
                clipdata += " ";
                clipdata += TextBoxhdd.Text;
                clipdata += " ";
                clipdata += TextBoxhdd1.Text;
                clipdata += "\r\n";
            }
            if (checkssd.Checked)
            {
                clipdata += "固态硬盘";
                clipdata += " ";
                clipdata += TextBoxssd.Text;
                clipdata += " ";
                clipdata += TextBoxssd1.Text;
                clipdata += "\r\n";
            }
            if (checkgpu.Checked)
            {
                clipdata += "显卡";
                clipdata += " ";
                clipdata += TextBoxgpu.Text;
                clipdata += " ";
                clipdata += TextBoxgpu1.Text;
                clipdata += "\r\n";
            }
            if (checklcd.Checked)
            {
                clipdata += "显示器";
                clipdata += " ";
                clipdata += TextBoxlcd.Text;
                clipdata += " ";
                clipdata += TextBoxlcd1.Text;
                clipdata += "\r\n";
            }
            if (checkbox.Checked)
            {
                clipdata += "机箱";
                clipdata += " ";
                clipdata += TextBoxbox.Text;
                clipdata += " ";
                clipdata += TextBoxbox1.Text;
                clipdata += "\r\n";
            }
            if (TextBoxfan.Text != "")
            {
                clipdata += "散热器";
                clipdata += " ";
                clipdata += TextBoxfan.Text;
                clipdata += " ";
                clipdata += TextBoxfan1.Text;
                clipdata += "\r\n";
            }

            if (TextBoxpower.Text != "")
            {
                clipdata += "电源";
                clipdata += " ";
                clipdata += TextBoxpower.Text;
                clipdata += " ";
                clipdata += TextBoxpower1.Text;
                clipdata += "\r\n";
            }
            if (checkcdrom.Checked)
            {
                clipdata += "光驱";
                clipdata += " ";
                clipdata += TextBoxcdrom.Text;
                clipdata += " ";
                clipdata += TextBoxcdrom1.Text;
                clipdata += "\r\n";
            }
            if (checkkb.Checked)
            {
                clipdata += "键盘";
                clipdata += " ";
                clipdata += TextBoxkb.Text;
                clipdata += " ";
                clipdata += TextBoxkb1.Text;
                clipdata += "\r\n";
            }
            if (checkmou.Checked)
            {
                clipdata += "鼠标";
                clipdata += " ";
                clipdata += TextBoxmou.Text;
                clipdata += " ";
                clipdata += TextBoxmou1.Text;
                clipdata += "\r\n";

            }
            if (checkhs.Checked)
            {
                clipdata += "耳机";
                clipdata += " ";
                clipdata += TextBoxhs.Text;
                clipdata += " ";
                clipdata += TextBoxhs1.Text;
                clipdata += "\r\n";
            }
            if (checkcam.Checked)
            {
                clipdata += "摄像头";
                clipdata += " ";
                clipdata += TextBoxcam.Text;
                clipdata += " ";
                clipdata += TextBoxcam1.Text;
                clipdata += "\r\n";
            }
            if (checksp.Checked)
            {
                clipdata += "音响";
                clipdata += " ";
                clipdata += TextBoxsp.Text;
                clipdata += " ";
                clipdata += TextBoxsp1.Text;
                clipdata += "\r\n";
            }
            if (checko.Checked)
            {
                clipdata += "其他";
                clipdata += " ";
                clipdata += TextBoxo.Text;
                clipdata += " ";
                clipdata += TextBoxo1.Text;
                clipdata += "\r\n";
            }
            clipdata += labelall.Text;
            if (trial)
            {
                clipdata += "\r\n";
                clipdata += "————来自" + " 攒机助手专业版 " + Application.ProductVersion;
            }
        }


        private void CheckBoxamd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustAmd.Checked)
            {
                SData.hwACpu.AddToComboBox();

            }
            else
            {
                SData.hwCpu.AddToComboBox();

            }
        }
        private void ad()
        {
            //MessageBox.Show("OK");
            string pageHtml1;
            try
            {

                WebClient MyWebClient = new WebClient();

                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                Byte[] pageData = MyWebClient.DownloadData("http://bbs.luobotou.org/app/cjzs_pro.txt"); //从指定网站下载数据

                pageHtml1 = Encoding.UTF8.GetString(pageData);
                //MessageBox.Show(pageHtml);
                int index = pageHtml1.IndexOf("announcement=");
                //MessageBox.Show(pageHtml1.Substring(index + 3, 1));
                if (pageHtml1.Substring(index + 13, 1) != "0")
                {
                    string pageHtml;
                    try
                    {

                        WebClient MyWebClient1 = new WebClient();

                        MyWebClient1.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

                        Byte[] pageData1 = MyWebClient1.DownloadData("http://bbs.luobotou.org/app/announcement.txt"); //从指定网站下载数据

                        pageHtml = Encoding.UTF8.GetString(pageData1);
                        // MessageBox.Show(pageHtml);

                        int index1 = pageHtml.IndexOf("攒机助手商业版");//特别修改
                        //pageHtml = pageHtml.Substring(index1);
                        int startindex = pageHtml.IndexOf("~", index1);
                        int endindex = pageHtml.IndexOf("结束", index1);
                        int adprogram = index1 + Application.ProductName.Length + 1;
                        //MessageBox.Show("FFF");

                        String adtitle;
                        //MessageBox.Show(adprogram + " " + startindex );
                        adtitle = pageHtml.Substring(adprogram, startindex - adprogram);
                        //MessageBox.Show("OK");
                        adlink = pageHtml.Substring(startindex + 1, endindex - startindex - 1);
                        if (SettingItems.ShowAd)
                        {
                            labelad.Invoke(Set_Text, new object[] { adtitle });
                        }
                        //MessageBox.Show(adtitle + "     " + adlink);
                    }
                    catch (WebException webEx)
                    {
                        //
                        Console.WriteLine(webEx.Message.ToString());
                        //
                    }
                }
            }
            catch
            { }

        }
        private void MdbDataUpdate()
        {
            try
            {
                string strConn
                    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
                OleDbConnection odcConnection = new OleDbConnection(strConn);
                odcConnection.Open();
                //object[] oa = { null, null, "z_cpu", "ID" };

                //DataTable schemaTable = odcConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, oa);

                #region OldCode
                //if (!MDBHelper.GetTables(odcConnection, "tuijian"))
                //{
                //    ArrayList pj = new ArrayList();

                //    pj.Add("ID");
                //    pj.Add("item");
                //    pj.Add("data");


                //    MDBHelper.CreateMDBTable(SettingItems.MdbPath, "config", pj);

                //    ArrayList al = new ArrayList();
                //    al.Add("ID");
                //    al.Add("data");


                //    //MessageBox.Show("SSS");
                //    MDBHelper.CreateMDBTable(SettingItems.MdbPath, "tuijian", al);
                //    odcConnection.Close();
                //    string strConn1
                //    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
                //    OleDbConnection odcConnection1 = new OleDbConnection(strConn);
                //    odcConnection1.Open();
                //    string sql;

                //    sql = "insert into config(ID,item,data)values('1','copyright','1')";
                //    OleDbCommand cmd = new OleDbCommand(sql, odcConnection1);
                //    cmd.ExecuteNonQuery();
                //    sql = "insert into config(ID,item,data)values('2','hidead','0')";
                //    OleDbCommand cmd0 = new OleDbCommand(sql, odcConnection1);
                //    cmd0.ExecuteNonQuery();


                //    odcConnection1.Close();
                //    odcConnection.Open();
                //}
                #endregion
                if (!MDBHelper.GetTables(Form1.mainDbConStr, "z_mou"))
                {
                    ArrayList al = new ArrayList();
                    al.Add("name");
                    al.Add("bprice");
                    al.Add("sprice");
                    al.Add("qa");
                    MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_mou", al);
                }

                //if (!MDBHelper.GetTables(odcConnection, "settings"))
                //{
                //    ArrayList pj = new ArrayList();

                //    pj.Add("耳机");
                //    pj.Add("耳机价格");
                //    pj.Add("摄像头");
                //    pj.Add("摄像头价格");
                //    pj.Add("音响");
                //    pj.Add("音响价格");


                //    MDBHelper.CreateField(SettingItems.MdbPath, pj);

                //    ArrayList al = new ArrayList();
                //    al.Add("user");
                //    al.Add("password");
                //    al.Add("gift");
                //    al.Add("checkedstate");
                //    al.Add("copyright");
                //    al.Add("search");

                //    //MessageBox.Show("SSS");
                //    MDBHelper.CreateMDBTable(SettingItems.MdbPath, "settings", al);
                //    odcConnection.Close();
                //}
                #region OldCode
                //if (!MDBHelper.GetTables(odcConnection, "z_cpu"))
                //{
                //    //ArrayList al = new ArrayList();
                //    //al.Add("name");
                //    //al.Add("bprice");
                //    //al.Add("sprice");
                //    //al.Add("qa");
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_cpu", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_acpu", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_mb", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_ram", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_hdd", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_gpu", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_box", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_pow", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_lcd", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_fan", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_cdrom", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_kb", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_ssd", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_hs", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_cam", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_sp", al);
                //    //MDBHelper.CreateMDBTable(SettingItems.MdbPath, "z_o", al);

                //    ////1、建立连接   
                //    //string hwadd
                //    //    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
                //    //OleDbConnection hwaddConnection = new OleDbConnection(hwadd);
                //    ////2、打开连接   
                //    //hwaddConnection.Open();
                //    ////////////////////////////////////////////////
                //    //string sql;
                //    //for (int i = 1; i < 100; i++)
                //    //{
                //    //    if (cpu[i] != null && cpu[i] != "")
                //    //    {
                //    //        sql = "insert into [z_cpu](name,bprice,sprice,qa)values('" + cpu[i] + "','" + cpu3[i] + "','" + cpu1[i] + "','" + cpu2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (acpu1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_acpu(name,bprice,sprice,qa)values('" + acpu[i] + "','" + acpu3[i] + "','" + acpu1[i] + "','" + acpu2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (mb1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_mb(name,bprice,sprice,qa)values('" + mb[i] + "','" + mb3[i] + "','" + mb1[i] + "','" + mb2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (ram1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_ram(name,bprice,sprice,qa)values('" + ram[i] + "','" + ram3[i] + "','" + ram1[i] + "','" + ram2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (hdd1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_hdd(name,bprice,sprice,qa)values('" + hdd[i] + "','" + hdd3[i] + "','" + hdd1[i] + "','" + hdd2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (box1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_box(name,bprice,sprice,qa)values('" + box[i] + "','" + box3[i] + "','" + box1[i] + "','" + box2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (lcd1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_lcd(name,bprice,sprice,qa)values('" + lcd[i] + "','" + lcd3[i] + "','" + lcd1[i] + "','" + lcd2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (fan1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_fan(name,bprice,sprice,qa)values('" + fan[i] + "','" + fan3[i] + "','" + fan1[i] + "','" + fan2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (cdrom1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_cdrom(name,bprice,sprice,qa)values('" + cdrom[i] + "','" + cdrom3[i] + "','" + cdrom1[i] + "','" + cdrom2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (kb1[i] != 0)
                //    //    {
                //    //        sql = "insert into z_kb(name,bprice,sprice,qa)values('" + kb[i] + "','" + kb3[i] + "','" + kb1[i] + "','" + kb2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (gpu[i] != null && gpu[i] != "")
                //    //    {
                //    //        sql = "insert into z_gpu(name,bprice,sprice,qa)values('" + gpu[i] + "','" + gpu3[i] + "','" + gpu1[i] + "','" + gpu2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (hs[i] != null && hs[i] != "")
                //    //    {
                //    //        sql = "insert into z_hs(name,bprice,sprice,qa)values('" + hs[i] + "','" + hs3[i] + "','" + hs1[i] + "','" + hs2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (cam[i] != null && cam[i] != "")
                //    //    {
                //    //        sql = "insert into z_cam(name,bprice,sprice,qa)values('" + cam[i] + "','" + cam3[i] + "','" + cam1[i] + "','" + cam2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (sp[i] != null && sp[i] != "")
                //    //    {
                //    //        sql = "insert into z_sp(name,bprice,sprice,qa)values('" + sp[i] + "','" + sp3[i] + "','" + sp1[i] + "','" + sp2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (o[i] != null && o[i] != "")
                //    //    {
                //    //        sql = "insert into z_o(name,bprice,sprice,qa)values('" + o[i] + "','" + o3[i] + "','" + o1[i] + "','" + o2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (ssd[i] != null && ssd[i] != "")
                //    //    {
                //    //        sql = "insert into z_ssd(name,bprice,sprice,qa)values('" + ssd[i] + "','" + ssd3[i] + "','" + ssd1[i] + "','" + ssd2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();
                //    //    }
                //    //    if (power[i] != null && power[i] != "")
                //    //    {
                //    //        sql = "insert into z_pow(name,bprice,sprice,qa)values('" + power[i] + "','" + power3[i] + "','" + power1[i] + "','" + power2[i] + "')";
                //    //        OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //    //        cmd.ExecuteNonQuery();

                //    //    }
                //    //}
                //    ////关闭连接
                //    //hwaddConnection.Close();
                //    //MessageBox.Show("升级成功！\n配置文件改为access数据库");
                //}
                #endregion
                using (OleDbCommand cmd1 = new OleDbCommand("SELECT password FROM settings", odcConnection))
                {
                    using (OleDbDataReader readere = cmd1.ExecuteReader())
                    {
                        string password = "";
                        while (readere.Read())
                        {
                            password = readere[0].ToString();
                            //dataGridView1.Rows.Add("CPU", reader[0].ToString(), System.Int32.Parse(reader[1].ToString()), System.Int32.Parse(reader[2].ToString()), System.Int32.Parse(reader[3].ToString()));
                        }
                        if (string.IsNullOrEmpty(password))
                        {
                            string sql = "insert into [settings]([password])values('D41D8CD98F00B204E9800998ECF8427E')";
                            using (OleDbCommand cmd = new OleDbCommand(sql, odcConnection))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        }
                    }
                }
                foreach (var item in SData.allHwKind)
                {
                    if (!MDBHelper.GetTables(mainDbConStr, "z_" + item.KindNameShort.ToLower())) continue;

                    //IF  EXISTS (SELECT   O.NAME AS 表名,C.NAME AS 列名 FROM SYSOBJECTS O INNER JOIN SYSCOLUMNS C ON O.ID=C.ID  WHERE O.NAME= '表名' AND C.NAME   = '列名')   SELECT 'EXISTS' ELSE  SELECT 'NOT EXISTS'

                    bool createCl = true;

                    object[] oa = { null, null, "z_" + item.KindNameShort.ToLower(), "DBID" };

                    DataTable schemaTable = odcConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, oa);
                    if (schemaTable.Rows.Count != 0)
                    {
                        createCl = false;
                    }
                    //MessageBox.Show((schemaTable.Rows.Count == 0 ? "不存在" : "存在"));  


                    //using (OleDbCommand cmd = new OleDbCommand("IF  EXISTS (SELECT   O.NAME AS z_" + item.KindNameShort.ToLower()+",C.NAME AS DBID FROM SYSOBJECTS O INNER JOIN SYSCOLUMNS C ON O.ID=C.ID  WHERE O.NAME= 'z_" + item.KindNameShort.ToLower()+"' AND C.NAME   = 'DBID')   SELECT 'EXISTS' ELSE  SELECT 'NOT EXISTS'", odcConnection))
                    //{

                    //    OleDbDataReader reader = cmd.ExecuteReader();
                    //    while (reader.Read())
                    //    {
                    //        if (reader[0].ToString().Contains("EXISTS")) { createCl = false; break; }
                    //    } 
                    //}
                    if (createCl)
                    {
                        using (OleDbCommand cmd1 = new OleDbCommand("alter table z_" + item.KindNameShort.ToLower() + " add DBID int", odcConnection))
                        {
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }

                odcConnection.Close();
                odcConnection.Dispose();
                AddDBID();

                if (!MDBHelper.GetTables(Form1.sellDbConStr, "AssInfo"))
                {
                    string sql_createtable = "create table AssInfo([ID] counter(1, 1),[SellDateTime] datetime,[AssemblyInfo] Memo)";
                    try
                    {
                        MDBHelper.ExecuteNonQuery(Form1.sellDbConStr, sql_createtable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("销售数据库更新失败\n" + ex.ToString());
                        Log.WriteLog("UpdateSellMdb.log", ex.ToString());
                        //throw;
                    }
                }


                ///////////////////check Textbox//////////////////////
                //if (textBoxname.Text == "") { textBoxname.Text = " "; }
                //if (textBoxphone.Text == "") { textBoxphone.Text = " "; }
                ///////////////////END//////////////////////////
                //M
            }
            catch (Exception err)
            {
                MessageBox.Show("升级失败！\n错误：" + err.ToString());
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AboutBox1 aboutshow = new AboutBox1();
            aboutshow.Show();
        }



        private void ComboBoxcpu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (trial == true)
            //{
            //    //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
            //    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请联系作者购买！\nQQ:1409231794 官方网站 cuanji.luobotou.pw", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //if (TextBoxcpu.Text == " ") { return; }

            if (ComboBoxcpu.SelectedIndex != 0)
            {
                if (checkCustAmd.Checked)
                {
                    SData.hwACpu.HWChoice = ComboBoxcpu.SelectedItem as HardWare;
                    //acpu_choice = ComboBoxcpu.SelectedIndex;
                    //cpu1[0] = acpu1[ComboBoxcpu.SelectedIndex];

                }
                else
                {
                    SData.hwCpu.HWChoice = ComboBoxcpu.SelectedItem as HardWare;
                    //cpu_choice = ComboBoxcpu.SelectedIndex;
                    //cpu[0] = cpu[ComboBoxcpu.SelectedIndex];
                    //cpu1[0] = cpu1[ComboBoxcpu.SelectedIndex];
                }
            }
            else
            {
                if (fixmode) { c_cpu(); }
                else
                {
                    //#warning 有问题
                    //cpu_choice=0
                    SData.hwCpu.HWChoice = null;
                    SData.hwACpu.HWChoice = null;
                }
                //c_cpu();
                //if (CheckBoxamd.Checked)
                //{

                //    //if (cpu_choice == 0) { cpu[0] = " "; cpu1[0] = 0; }
                //    //else
                //    //{
                //    //    cpu[0] = aSData.hwCpu.HWChoice.Name;
                //    //    cpu1[0] = aSData.hwCpu.HWChoice.Price;
                //    //}
                //}
                //else
                //{
                //    if (cpu_choice == 0) { cpu[0] = " "; cpu1[0] = 0; }
                //    else
                //    {
                //        cpu[0] = SData.hwCpu.HWChoice.Name;
                //        cpu1[0] = SData.hwCpu.HWChoice.Price;
                //    }
                //}
            }
            //if (cpuz.Checked) { cpu1[0] = 0; }
            //if (mb[0] != " ")
            //{
            //    choice = ComboBoxcpu.SelectedIndex;
            //    if (ComboBoxmb.SelectedIndex == 0) { c_mb(); }
            //}
            totalprice();
            //c_cpu();
        }


        private void label23_Click(object sender, EventArgs e)
        {

            ComboBoxcpu.SelectedIndex = 0;
            ComboBoxmb.SelectedIndex = 0;
            ComboBoxram.SelectedIndex = 0;
            ComboBoxhdd.SelectedIndex = 0;
            ComboBoxgpu.SelectedIndex = 0;
            ComboBoxlcd.SelectedIndex = 0;
            ComboBoxbox.SelectedIndex = 0;
            ComboBoxfan.SelectedIndex = 0;
            ComboBoxpower.SelectedIndex = 0;
            ComboBoxssd.SelectedIndex = 0;
            ComboBoxcdrom.SelectedIndex = 0;
            ComboBoxkb.SelectedIndex = 0;
            ComboBoxmou.SelectedIndex = 0;

            ComboBoxhs.SelectedIndex = 0;
            ComboBoxcam.SelectedIndex = 0;
            ComboBoxsp.SelectedIndex = 0;
            ComboBoxo.SelectedIndex = 0;


            textBoxCpuSr.Text = "";
            textBoxGpusr.Text = "";
            textBoxMbSr.Text = "";
            textBoxRamSr.Text = "";
            textBoxHddSr.Text = "";
            textBoxSsdSr.Text = "";
            textBoxLcdSr.Text = "";
            textBoxBoxsr.Text = "";
            textBoxFanSr.Text = "";
            textBoxPowerSr.Text = "";
            textBoxCdromSr.Text = "";
            textBoxKbSr.Text = "";
            textBoxMouSr.Text = "";
            textBoxHsSr.Text = "";
            textBoxCamSr.Text = "";

            textBoxSpSr.Text = "";
            textBoxOSr.Text = "";
            checkCustHighxcpu.Checked = false;
            checkCuste3.Checked = false;
            checkCustk.Checked = false;
            checkCustBoxedCpu.Checked = false;
            checkCustHighGpu.Checked = false;
            checkCustNvGpu.Checked = false;
            checkCustAmdGpu.Checked = false;
            checkCustDoubleMemory.Checked = false;
            checkCustCoreGpu.Checked = false;

        }

        private void label25_Click(object sender, EventArgs e)
        {
            AboutBox1 frmAbout = new AboutBox1();
            frmAbout.Show();
        }

        #region LinkLabels
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/thread-6309-1-1.html");

        }

        private void 反馈建议ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-116-1.html");

            //Feedback frmf = new Feedback();
            //frmf.Show();//http://bbs.luobotou.org/forum-116-1.html
        }

        private void 购买软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-116-1.html");

        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.kuaipan.cn/file/id_6067465939320914.html");
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-6400-1-1.html");


        }
        private void label45_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-116-1.html");

        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum-116-1.html");

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=9890");
        }

        #endregion

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            threadupdate = new Thread(OnlineOperation.ProgramUpdate);
            threadupdate.Start();
            MessageBox.Show("没弹出任何提示框就是没更新，O(∩_∩)O感谢支持！");
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutshow = new AboutBox1();
            aboutshow.Show();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //settings
            Settings sts = new Settings();
            sts.ShowDialog();
            ReadConfig();
            Loading();


        }

        private void label24_Click(object sender, EventArgs e)
        {
            Process.Start(adlink);
        }

        private void checkBoxgpu_CheckedChanged(object sender, EventArgs e)
        {
            if (trial == true)
            {
                //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label24_Click_1(object sender, EventArgs e)
        {
            if (SettingItems.PrintMode == SettingItems.ModeEnum.Doc)
            {
                try
                {
                    if (DialogResult.Cancel == printDialog1.ShowDialog()) { return; }
                    //if (printDialog1 .)
                    object Nothing;
                    Word._Application WordApp;
                    Word._Document WordDoc;
                    WordGen(out Nothing, out WordApp, out WordDoc);
                    //文件保存
                    PrintDocument prtdoc = new PrintDocument();
                    string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;//获取默认的打印机名

                    WordApp.ActivePrinter = printDialog1.PrinterSettings.PrinterName;
                    object newfilename = userpath + "\\cjzs_new.doc";


                    //object Background = true;
                    //object Range = Word.WdPrintOutRange.wdPrintAllDocument;
                    object Copies = printDialog1.PrinterSettings.Copies;




                    WordDoc.PrintOut(ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Copies, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                    WordDoc.SaveAs(ref newfilename, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                    WordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
                    WordApp.ActivePrinter = strDefaultPrinter;
                    WordApp.Quit(ref Nothing, ref Nothing, ref Nothing);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("打印文档失败！有可能未安装完整版MS OFFICE\n" + ex.ToString());
                }
            }
            else
            {
                pdDocument.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                pdDocument.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
                CopyToClipboard();
                pdDocument.Print();

            }
        }

        private void WordGen(out Object Nothing, out Word._Application WordApp, out Word._Document WordDoc)
        {
            Nothing = System.Reflection.Missing.Value;
            //Directory.CreateDirectory("d:/CNSI");  //创建文件所在目录
            string name = "\\cjzs_.doc";
            //MessageBox.Show(userpath);
            object filename = userpath + name;  //文件保存路径
            WordApp = new Word.ApplicationClass();
            //WordDoc = WordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            WordDoc = WordApp.Documents.Open(ref filename, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            //添加页眉
            WordApp.Selection.ParagraphFormat.LineSpacing = 15f;//设置文档的行间距
            // WordApp.ActiveDocument.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape ;
            //   WordApp.ActiveDocument.PageSetup.TopMargin = WordApp.CentimetersToPoints(float.Parse("1"));
            //   WordApp.ActiveDocument.PageSetup.BottomMargin = WordApp.CentimetersToPoints(float.Parse("1"));//下页边距
            //   WordApp.ActiveDocument.PageSetup.LeftMargin = WordApp.CentimetersToPoints(float.Parse("1.69"));//左页边距
            //   WordApp.ActiveDocument.PageSetup.RightMargin = WordApp.CentimetersToPoints(float.Parse("1.47"));//右页边距 
            //移动焦点并换行
            // object count = 14;
            //  object WdLine = Word.WdUnits.wdLine;//换一行;
            //   WordApp.Selection.MoveDown(ref WdLine, ref count, ref Nothing);//移动焦点
            //    WordApp.Selection.TypeParagraph();//插入段落

            object unit = Word.WdUnits.wdStory;
            object move = Word.WdMovementType.wdMove;
            WordApp.Selection.EndKey(ref unit, ref move);
            //文档中创建表格

            Word.Table newTable = WordDoc.Tables.Add(WordApp.Selection.Range, SData.allHwKind.Count, 5, ref Nothing, ref Nothing);
            //设置表格样式
            newTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleThickThinLargeGap;
            newTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            newTable.Columns[1].Width = 70f;
            newTable.Columns[2].Width = 220f;
            newTable.Columns[3].Width = 55f;
            newTable.Columns[4].Width = 40f;
            newTable.Columns[5].Width = 40f;

            //newTable.Rows[1].Height = float.Parse("1.69");
            //填充表格内容
            newTable.Cell(1, 1).Range.Text = string.IsNullOrEmpty(SettingItems.PrintCol1Txt) ? "配置" : SettingItems.PrintCol1Txt;
            newTable.Cell(1, 2).Range.Text = string.IsNullOrEmpty(SettingItems.PrintCol2Txt) ? "品牌、型号、数量" : SettingItems.PrintCol2Txt;
            newTable.Cell(1, 3).Range.Text = string.IsNullOrEmpty(SettingItems.PrintCol3Txt) ? "金额/元" : SettingItems.PrintCol3Txt;
            newTable.Cell(1, 4).Range.Text = string.IsNullOrEmpty(SettingItems.PrintCol4Txt) ? "质保/月" : SettingItems.PrintCol4Txt;
            newTable.Cell(1, 5).Range.Text = string.IsNullOrEmpty(SettingItems.PrintCol5Txt) ? "备注" : SettingItems.PrintCol5Txt;
            //for (int i = 1; i <= 5; i++)
            //{
            //    //newTable.Cell(1, i).Range.Font.
            //}
            //newTable.Cell(1, 1).Range.Bold = 2;//设置单元格中字体为粗体
            //合并单元格
            //  newTable.Cell(1, 1).Merge(newTable.Cell(1, 3));
            WordApp.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;//垂直居中
            WordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;//水平居中

            //填充表格内容
            //newTable.Cell(2, 1).Range.Text = "CPU";
            //newTable.Cell(2, 1).Range.Font.Color = Word.WdColor.wdColorDarkBlue;//设置单元格内字体颜色
            //合并单元格

            WordApp.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            //填充表格内容
            int row = 2;
            foreach (var item in SData.allHwKind)
            {
                if (checkCustAmd.Checked)
                {
                    if (item == SData.hwCpu) continue;
                }
                else
                {
                    if (item == SData.hwACpu) continue;
                }
                //MessageBox.Show(row.ToString());
                newTable.Cell(row, 1).Range.Text = item.KindNameCh;
                newTable.Cell(row, 2).Range.Text = item.HWChoice == null ? string.Empty : item.HWChoice.Name.ToString();
                newTable.Cell(row, 3).Range.Text = item.HWChoice == null ? string.Empty : item.HWChoice.Price.ToString();
                newTable.Cell(row++, 4).Range.Text = item.HWChoice == null ? string.Empty : item.HWChoice.Warranty.ToString();
            }
            #region PrintOldCode
            //newTable.Cell(3, 1).Range.Text = "主板";
            //newTable.Cell(4, 1).Range.Text = "内存";
            //newTable.Cell(5, 1).Range.Text = "显卡";
            //newTable.Cell(6, 1).Range.Text = "硬盘";
            //newTable.Cell(7, 1).Range.Text = "固态硬盘";

            //newTable.Cell(8, 1).Range.Text = "光驱";
            //newTable.Cell(9, 1).Range.Text = "机箱";
            //newTable.Cell(10, 1).Range.Text = "电源";
            //newTable.Cell(11, 1).Range.Text = "散热器";
            //newTable.Cell(12, 1).Range.Text = "显示器";
            //newTable.Cell(13, 1).Range.Text = "键盘";
            //newTable.Cell(14, 1).Range.Text = "鼠标";

            //newTable.Cell(15, 1).Range.Text = "耳机";
            //newTable.Cell(16, 1).Range.Text = "摄像头";
            //newTable.Cell(17, 1).Range.Text = "音响";
            //newTable.Cell(18, 1).Range.Text = "其他";

            //newTable.Cell(19, 1).Range.Text = "合计金额";

            //newTable.Cell(2, 2).Range.Text = SData.hwCpu.HWChoice.Name;
            //newTable.Cell(2, 3).Range.Text = SData.hwCpu.HWChoice.Price.ToString();
            //newTable.Cell(2, 4).Range.Text = SData.hwCpu.HWChoice.Warranty.ToString();

            //newTable.Cell(3, 2).Range.Text = mb[mb_choice];
            //newTable.Cell(3, 3).Range.Text = mb1[mb_choice].ToString();
            //newTable.Cell(3, 4).Range.Text = mb2[mb_choice].ToString();

            //newTable.Cell(4, 2).Range.Text = ram[ram_choice];
            //newTable.Cell(4, 3).Range.Text = ram1[ram_choice].ToString();
            //newTable.Cell(4, 4).Range.Text = ram2[ram_choice].ToString();

            //newTable.Cell(5, 2).Range.Text = gpu[gpu_choice];
            //newTable.Cell(5, 3).Range.Text = gpu1[gpu_choice].ToString();
            //newTable.Cell(5, 4).Range.Text = gpu2[gpu_choice].ToString();


            //newTable.Cell(6, 2).Range.Text = hdd[hdd_choice];
            //newTable.Cell(6, 3).Range.Text = hdd1[hdd_choice].ToString();
            //newTable.Cell(6, 4).Range.Text = hdd2[hdd_choice].ToString();


            //newTable.Cell(7, 2).Range.Text = ssd[ssd_choice];
            //newTable.Cell(7, 3).Range.Text = ssd1[ssd_choice].ToString();
            //newTable.Cell(7, 4).Range.Text = ssd2[ssd_choice].ToString();

            //newTable.Cell(8, 2).Range.Text = cdrom[cdrom_choice];
            //newTable.Cell(8, 3).Range.Text = cdrom1[cdrom_choice].ToString();
            //newTable.Cell(8, 4).Range.Text = cdrom2[cdrom_choice].ToString();

            //newTable.Cell(9, 2).Range.Text = box[box_choice];
            //newTable.Cell(9, 3).Range.Text = box1[box_choice].ToString();
            //newTable.Cell(9, 4).Range.Text = box2[box_choice].ToString();

            //newTable.Cell(10, 2).Range.Text = power[power_choice];
            //newTable.Cell(10, 3).Range.Text = power1[power_choice].ToString();
            //newTable.Cell(10, 4).Range.Text = power2[power_choice].ToString();

            //newTable.Cell(11, 2).Range.Text = fan[fan_choice];
            //newTable.Cell(11, 3).Range.Text = fan1[fan_choice].ToString();
            //newTable.Cell(11, 4).Range.Text = fan2[fan_choice].ToString();

            //newTable.Cell(12, 2).Range.Text = lcd[lcd_choice];
            //newTable.Cell(12, 3).Range.Text = lcd1[lcd_choice].ToString();
            //newTable.Cell(12, 4).Range.Text = lcd2[lcd_choice].ToString();

            //newTable.Cell(13, 2).Range.Text = kb[kb_choice];
            //newTable.Cell(13, 3).Range.Text = kb1[kb_choice].ToString();
            //newTable.Cell(13, 4).Range.Text = kb2[kb_choice].ToString();

            //newTable.Cell(14, 2).Range.Text = mou[mou_choice];
            //newTable.Cell(14, 3).Range.Text = mou1[mou_choice].ToString();
            //newTable.Cell(14, 4).Range.Text = mou2[mou_choice].ToString();


            //newTable.Cell(15, 2).Range.Text = hs[hs_choice];
            //newTable.Cell(15, 3).Range.Text = hs1[hs_choice].ToString();
            //newTable.Cell(15, 4).Range.Text = hs2[hs_choice].ToString();
            //newTable.Cell(16, 2).Range.Text = cam[cam_choice];
            //newTable.Cell(16, 3).Range.Text = cam1[cam_choice].ToString();
            //newTable.Cell(16, 4).Range.Text = cam2[cam_choice].ToString();

            //newTable.Cell(17, 2).Range.Text = sp[sp_choice];
            //newTable.Cell(17, 3).Range.Text = sp1[sp_choice].ToString();
            //newTable.Cell(17, 4).Range.Text = sp2[sp_choice].ToString();

            //newTable.Cell(18, 2).Range.Text = o[o_choice];
            //newTable.Cell(18, 3).Range.Text = o1[o_choice].ToString();
            //newTable.Cell(18, 4).Range.Text = o2[o_choice].ToString();
            #endregion
            //newTable.Cell(row, 2).Range.Text = sum.ToString() + " 元";
            //WordDoc.Paragraphs.Last .lef

            if (trial)
            {
                WordDoc.Paragraphs.Last.Range.Text = "合计金额:" + sum.ToString() + " 元" + "    客户名称：" + textBoxCusName.Text + "  联系电话：" + textBoxCusPhone.Text + "   备注：" + textBoxCusComments.Text + "\n" + "本配置单由攒机助手专业版" + Application.ProductVersion + "生成   " + "官方论坛：http://bbs.luobotou.org/forum-116-1.html  \n" + "生成时间：" + DateTime.Now.ToString();//“落款”
            }
            else
            {
                WordDoc.Paragraphs.Last.Range.Text = "合计金额:" + sum.ToString() + " 元" + (string.IsNullOrEmpty(textBoxCusName.Text) ? string.Empty : "    客户名称：") + textBoxCusName.Text + (string.IsNullOrEmpty(textBoxCusPhone.Text) ? string.Empty : "  联系电话：") + textBoxCusPhone.Text + (string.IsNullOrEmpty(textBoxCusComments.Text) ? string.Empty : "   备注：") + textBoxCusComments.Text;
            }
            WordDoc.Paragraphs.Last.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        }
        private void ExportDoc()
        {
            if (SettingItems.SaveMode == SettingItems.ModeEnum.Doc)
            {
                try
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName == "") { return; }
                    Object Nothing;
                    Word._Application WordApp;
                    Word._Document WordDoc;
                    WordGen(out Nothing, out WordApp, out WordDoc);
                    #region ExportOldCode
                    //Object Nothing = System.Reflection.Missing.Value;
                    ////Directory.CreateDirectory("d:/CNSI");  //创建文件所在目录
                    //string name = "\\cjzs_" + ".doc";
                    //object filename = Application.StartupPath + name;  //文件保存路径
                    //Word._Application WordApp = new Word.ApplicationClass();
                    //// Word.Document WordDoc = WordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                    //Word._Document WordDoc = WordApp.Documents.Open(ref filename, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                    ////添加页眉
                    //WordApp.Selection.ParagraphFormat.LineSpacing = 15f;//设置文档的行间距
                    //// WordApp.ActiveDocument.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape ;
                    ////   WordApp.ActiveDocument.PageSetup.TopMargin = WordApp.CentimetersToPoints(float.Parse("1"));
                    ////   WordApp.ActiveDocument.PageSetup.BottomMargin = WordApp.CentimetersToPoints(float.Parse("1"));//下页边距
                    ////   WordApp.ActiveDocument.PageSetup.LeftMargin = WordApp.CentimetersToPoints(float.Parse("1.69"));//左页边距
                    ////   WordApp.ActiveDocument.PageSetup.RightMargin = WordApp.CentimetersToPoints(float.Parse("1.47"));//右页边距 
                    ////移动焦点并换行
                    //// object count = 14;
                    ////  object WdLine = Word.WdUnits.wdLine;//换一行;
                    ////   WordApp.Selection.MoveDown(ref WdLine, ref count, ref Nothing);//移动焦点
                    ////    WordApp.Selection.TypeParagraph();//插入段落

                    //object unit = Word.WdUnits.wdStory;
                    //object move = Word.WdMovementType.wdMove;
                    //WordApp.Selection.EndKey(ref   unit, ref   move);
                    ////文档中创建表格

                    //Word.Table newTable = WordDoc.Tables.Add(WordApp.Selection.Range, 18, 5, ref Nothing, ref Nothing);
                    ////设置表格样式
                    //newTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleThickThinLargeGap;
                    //newTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    //newTable.Columns[1].Width = 70f;
                    //newTable.Columns[2].Width = 220f;
                    //newTable.Columns[3].Width = 55f;
                    //newTable.Columns[4].Width = 40f;
                    //newTable.Columns[5].Width = 40f;

                    ////newTable.Rows[1].Height = float.Parse("1.69");
                    ////填充表格内容
                    //newTable.Cell(1, 1).Range.Text = "配置";
                    //newTable.Cell(1, 2).Range.Text = "品牌、型号、数量";
                    //newTable.Cell(1, 3).Range.Text = "金额";
                    //newTable.Cell(1, 4).Range.Text = "质保/月";
                    //newTable.Cell(1, 5).Range.Text = "备注";

                    ////newTable.Cell(1, 1).Range.Bold = 2;//设置单元格中字体为粗体
                    ////合并单元格
                    ////  newTable.Cell(1, 1).Merge(newTable.Cell(1, 3));
                    //WordApp.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;//垂直居中
                    //WordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;//水平居中

                    ////填充表格内容
                    //newTable.Cell(2, 1).Range.Text = "CPU";
                    ////newTable.Cell(2, 1).Range.Font.Color = Word.WdColor.wdColorDarkBlue;//设置单元格内字体颜色
                    ////合并单元格

                    //WordApp.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    ////填充表格内容
                    //newTable.Cell(3, 1).Range.Text = "主板";
                    //newTable.Cell(4, 1).Range.Text = "内存";
                    //newTable.Cell(5, 1).Range.Text = "显卡";
                    //newTable.Cell(6, 1).Range.Text = "硬盘";
                    //newTable.Cell(7, 1).Range.Text = "固态硬盘";

                    //newTable.Cell(8, 1).Range.Text = "光驱";
                    //newTable.Cell(9, 1).Range.Text = "机箱";
                    //newTable.Cell(10, 1).Range.Text = "电源";
                    //newTable.Cell(11, 1).Range.Text = "散热器";
                    //newTable.Cell(12, 1).Range.Text = "显示器";
                    //newTable.Cell(13, 1).Range.Text = "键盘";
                    //newTable.Cell(14, 1).Range.Text = "鼠标";

                    //newTable.Cell(15, 1).Range.Text = "耳机";
                    //newTable.Cell(16, 1).Range.Text = "摄像头";
                    //newTable.Cell(17, 1).Range.Text = "音响";
                    //newTable.Cell(18, 1).Range.Text = "其他";

                    //newTable.Cell(19, 1).Range.Text = "合计金额";

                    //newTable.Cell(2, 2).Range.Text = SData.hwCpu.HWChoice.Name;
                    //newTable.Cell(2, 3).Range.Text = SData.hwCpu.HWChoice.Price.ToString();
                    //newTable.Cell(2, 4).Range.Text = SData.hwCpu.HWChoice.Warranty.ToString();

                    //newTable.Cell(3, 2).Range.Text = mb[mb_choice];
                    //newTable.Cell(3, 3).Range.Text = mb1[mb_choice].ToString();
                    //newTable.Cell(3, 4).Range.Text = mb2[mb_choice].ToString();

                    //newTable.Cell(4, 2).Range.Text = ram[ram_choice];
                    //newTable.Cell(4, 3).Range.Text = ram1[ram_choice].ToString();
                    //newTable.Cell(4, 4).Range.Text = ram2[ram_choice].ToString();

                    //newTable.Cell(5, 2).Range.Text = gpu[gpu_choice];
                    //newTable.Cell(5, 3).Range.Text = gpu1[gpu_choice].ToString();
                    //newTable.Cell(5, 4).Range.Text = gpu2[gpu_choice].ToString();


                    //newTable.Cell(6, 2).Range.Text = hdd[hdd_choice];
                    //newTable.Cell(6, 3).Range.Text = hdd1[hdd_choice].ToString();
                    //newTable.Cell(6, 4).Range.Text = hdd2[hdd_choice].ToString();


                    //newTable.Cell(7, 2).Range.Text = ssd[ssd_choice];
                    //newTable.Cell(7, 3).Range.Text = ssd1[ssd_choice].ToString();
                    //newTable.Cell(7, 4).Range.Text = ssd2[ssd_choice].ToString();

                    //newTable.Cell(8, 2).Range.Text = cdrom[cdrom_choice];
                    //newTable.Cell(8, 3).Range.Text = cdrom1[cdrom_choice].ToString();
                    //newTable.Cell(8, 4).Range.Text = cdrom2[cdrom_choice].ToString();

                    //newTable.Cell(9, 2).Range.Text = box[box_choice];
                    //newTable.Cell(9, 3).Range.Text = box1[box_choice].ToString();
                    //newTable.Cell(9, 4).Range.Text = box2[box_choice].ToString();

                    //newTable.Cell(10, 2).Range.Text = power[power_choice];
                    //newTable.Cell(10, 3).Range.Text = power1[power_choice].ToString();
                    //newTable.Cell(10, 4).Range.Text = power2[power_choice].ToString();

                    //newTable.Cell(11, 2).Range.Text = fan[fan_choice];
                    //newTable.Cell(11, 3).Range.Text = fan1[fan_choice].ToString();
                    //newTable.Cell(11, 4).Range.Text = fan2[fan_choice].ToString();

                    //newTable.Cell(12, 2).Range.Text = lcd[lcd_choice];
                    //newTable.Cell(12, 3).Range.Text = lcd1[lcd_choice].ToString();
                    //newTable.Cell(12, 4).Range.Text = lcd2[lcd_choice].ToString();

                    //newTable.Cell(13, 2).Range.Text = kb[kb_choice];
                    //newTable.Cell(13, 3).Range.Text = kb1[kb_choice].ToString();
                    //newTable.Cell(13, 4).Range.Text = kb2[kb_choice].ToString();

                    //newTable.Cell(14, 2).Range.Text = mou[mou_choice];
                    //newTable.Cell(14, 3).Range.Text = mou1[mou_choice].ToString();
                    //newTable.Cell(14, 4).Range.Text = mou2[mou_choice].ToString();

                    //newTable.Cell(15, 2).Range.Text = hs[hs_choice];
                    //newTable.Cell(15, 3).Range.Text = hs1[hs_choice].ToString();
                    //newTable.Cell(15, 4).Range.Text = hs2[hs_choice].ToString();
                    //newTable.Cell(16, 2).Range.Text = cam[cam_choice];
                    //newTable.Cell(16, 3).Range.Text = cam1[cam_choice].ToString();
                    //newTable.Cell(16, 4).Range.Text = cam2[cam_choice].ToString();

                    //newTable.Cell(17, 2).Range.Text = sp[sp_choice];
                    //newTable.Cell(17, 3).Range.Text = sp1[sp_choice].ToString();
                    //newTable.Cell(17, 4).Range.Text = sp2[sp_choice].ToString();

                    //newTable.Cell(18, 2).Range.Text = o[o_choice];
                    //newTable.Cell(18, 3).Range.Text = o1[o_choice].ToString();
                    //newTable.Cell(18, 4).Range.Text = o2[o_choice].ToString();

                    //newTable.Cell(19, 2).Range.Text = sum.ToString() + " 元";
                    //if (trial)
                    //{
                    //    WordDoc.Paragraphs.Last.Range.Text = "客户名称：" + textBoxname.Text + "  联系电话：" + textBoxphone.Text + "\n" + textBoxcomments.Text + "\n" + "本配置单由攒机助手专业版" + Application.ProductVersion + "生成   " + "官方论坛：http://bbs.luobotou.org/forum-116-1.html  \n" + "生成时间：" + DateTime.Now.ToString();//“落款”
                    //}
                    //else
                    //{
                    //    WordDoc.Paragraphs.Last.Range.Text = "客户名称：" + textBoxname.Text + "  联系电话：" + textBoxphone.Text + "\n" + textBoxcomments.Text;
                    //}
                    //WordDoc.Paragraphs.Last.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    //文件保存
                    #endregion
                    object savefilename = saveFileDialog1.FileName;

                    WordDoc.SaveAs(ref savefilename, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                    WordDoc.Close(ref Nothing, ref Nothing, ref Nothing);

                    WordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
                    //System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                    MessageBox.Show("保存完成!");
                }
                catch (Exception e)
                {
                    MessageBox.Show(
                        "保存文档失败！有可能未安装完整版MS OFFICE！\n" + e.ToString());
                }
            }
            else
            {
                System.Windows.Forms.SaveFileDialog kk = new System.Windows.Forms.SaveFileDialog();
                kk.Title = "保存文本文件";
                kk.Filter = "文本文件(*.txt) |*.txt |所有文件(*.*) |*.*";
                kk.FilterIndex = 1;
                if (kk.ShowDialog() == DialogResult.OK)
                {
                    CopyToClipboard();
                    string FileName = kk.FileName;
                    if (File.Exists(FileName))
                        File.Delete(FileName);
                    FileStream objFileStream;
                    StreamWriter objStreamWriter;
                    string strLine = clipdata;
                    objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
                    //for (int i = 0; i < m_DataTable.Columns.Count; i++)
                    //{
                    //    strLine = strLine + m_DataTable.Columns[i].Caption.ToString() + Convert.ToChar(9);
                    //}
                    //objStreamWriter.WriteLine(strLine);
                    //strLine = "";

                    //for (int i = 0; i < m_DataTable.Rows.Count; i++)
                    //{
                    //    for (int j = 0; j < m_DataTable.Columns.Count; j++)
                    //    {
                    //        if (m_DataTable.Rows[i].ItemArray[j] == null)
                    //            strLine = strLine + " " + Convert.ToChar(9);
                    //        else
                    //        {
                    //            string rowstr = "";
                    //            rowstr = m_DataTable.Rows[i].ItemArray[j].ToString();
                    //            if (rowstr.IndexOf("\r\n") > 0)
                    //                rowstr = rowstr.Replace("\r\n", " ");
                    //            if (rowstr.IndexOf("\t") > 0)
                    //                rowstr = rowstr.Replace("\t", " ");
                    //strLine = strLine + rowstr + Convert.ToChar(9);
                    //        }
                    //    }
                    objStreamWriter.Write(strLine);
                    //    strLine = "";
                    //}
                    objStreamWriter.Close();
                    objFileStream.Close();
                    MessageBox.Show(this, "保存文本文档成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // WordDoc.Paragraphs.Last.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
        }


        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        /// <summary>
        /// 价格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriceClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                Process.Start("http://www.baidu.com/s?wd=" + Encoding.GetEncoding("gbk").GetString(Encoding.Default.GetBytes(((TextBox)sender).Text)));
            }
        }


        private void 管理面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (trial == true)
            //{
            //    System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
            //    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请联系作者购买！\nQQ:1409231794 官方网站 cuanji.luobotou.pw", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            try
            {
                if (threadupdate.IsAlive)
                {
                    MessageBox.Show("数据正在升级，请稍后再打开管理面板！");
                }
            }
            catch { }

            Login lg = new Login();
            lg.ShowDialog();
            bool isright = false;
            isright = lg.pw;
            if (isright)
            {
                Admin adcp = new Admin();
                adcp.ShowDialog();
                Loading();
            }

            //admin adcp = new admin();
            //adcp.Show();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (trial == true)
            {
                System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ExportDoc();
        }



        private void labeldb_Click(object sender, EventArgs e)
        {
            if (trial == true)
            {
                System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            InsertRow(SettingItems.MdbPath);

        }




        private void 输入注册码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activate act = new Activate();
            act.ShowDialog();
        }

        /// <summary>
        /// 左侧CheckBox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HwCheckChanged(object sender, EventArgs e)
        {
            totalprice();
        }

        private void CbbSelIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in SData.allHwKind)
            {
                if (item.CBB == sender as ComboBox)
                {
                    if (item.CBB.SelectedIndex != 0)
                    {
                        item.HWChoice = item.CBB.SelectedItem as HardWare;
                    }
                    else
                    {
                        if (fixmode && item.CheckLeft.Checked)
                        {
                            item.AutoCuanJiInForm1();
                        }
                        else
                        {
                            item.HWChoice = null;
                        }
                    }
                    break;
                }
            }
            totalprice();
        }

        private void labelRCMD_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确认清空当前配置？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)) { return; }
            foreach (var item in SData.allHwKind)
            {
                item.HWChoice = null;
            }
            //cpu_choice = 0;
            //acpu_choice = 0;
            //mb_choice = 0;
            //ram_choice = 0;
            //hdd_choice = 0;
            //box_choice = 0;
            //lcd_choice = 0;
            //power_choice = 0;
            //ssd_choice = 0;
            //cdrom_choice = 0;
            //kb_choice = 0;
            //mou_choice = 0;
            //cam_choice = 0;
            //hs_choice = 0;
            //sp_choice = 0;
            //o_choice = 0;
            //gpu_choice = 0;
            //fan_choice = 0;

            totalprice();
            labelcopy.Visible = false;
            labelprint.Visible = false;
            labeldb.Visible = false;
            labeldoc.Visible = false;
            labelRCMD.Visible = false;
            labelremember.Visible = false;
            fixmode = false;

        }

        private void checkBoxk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCuste3.Checked && checkCustk.Checked) { MessageBox.Show("E3处理器不可超频！"); checkCustk.Checked = false; }
            if (checkCustk.Checked) { textBoxCpuSr.Text = "K"; }
            else { textBoxCpuSr.Text = ""; }
        }

        private void checkBoxdouble_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustDoubleMemory.Checked) { textBoxRamSr.Text = "x2"; }
            else { textBoxRamSr.Text = ""; }

        }

        private void checkBoxe3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustk.Checked && checkCuste3.Checked) { MessageBox.Show("E3处理器不可超频！"); checkCuste3.Checked = false; }
            if (checkCustAmd.Checked && checkCuste3.Checked) { MessageBox.Show("E3为英特尔处理器型号！"); checkCuste3.Checked = false; }
            if (checkCuste3.Checked) { textBoxCpuSr.Text = "E3"; }
            else { textBoxCpuSr.Text = ""; }

        }

        private void toolStripMenuItempath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }





        private void hideadMenuItem8_Click(object sender, EventArgs e)
        {
            if (trial == true)
            {
                try
                {
                    Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                }
                catch { }
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //hidead = !hidead;
            //labelad.Visible = !labelad.Visible;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string strConn
    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            odcConnection.Open();
            string sql = "insert into tuijian(ID,data)values('1','hidead')";

            OleDbCommand cmd0 = new OleDbCommand(sql, odcConnection);

            cmd0.ExecuteNonQuery();


            odcConnection.Close();

        }



        private void Form1_Activated(object sender, EventArgs e)
        {
            textBoxMoney.Focus();
        }


        #region checkBox_CheckedChanged
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            cpuz.Enabled = checkcpu.Checked;
        }
        private void checkmb_CheckedChanged(object sender, EventArgs e)
        {
            mbz.Enabled = checkmb.Checked;
        }

        private void checkram_CheckedChanged(object sender, EventArgs e)
        {
            ramz.Enabled = checkram.Checked;

        }

        private void checkBoxhdd_CheckedChanged(object sender, EventArgs e)
        {
            hddz.Enabled = checkhdd.Checked;

        }

        private void checkBoxssd_CheckedChanged(object sender, EventArgs e)
        {
            ssdz.Enabled = checkssd.Checked;

        }

        private void checkgpu_CheckedChanged(object sender, EventArgs e)
        {
            gpuz.Enabled = checkgpu.Checked;

        }

        private void CheckBoxlcd_CheckedChanged(object sender, EventArgs e)
        {
            lcdz.Enabled = checklcd.Checked;

        }

        private void checkBoxbox_CheckedChanged(object sender, EventArgs e)
        {
            boxz.Enabled = checkbox.Checked;

        }

        private void checkBoxfan_CheckedChanged(object sender, EventArgs e)
        {
            fanz.Enabled = checkfan.Checked;

        }

        private void checkpower_CheckedChanged(object sender, EventArgs e)
        {
            powerz.Enabled = checkpower.Checked;

        }

        private void checkBoxcdrom_CheckedChanged(object sender, EventArgs e)
        {
            cdromz.Enabled = checkcdrom.Checked;

        }

        private void checkBoxkb_CheckedChanged(object sender, EventArgs e)
        {
            kbz.Enabled = checkkb.Checked;

        }

        private void checkBoxhs_CheckedChanged(object sender, EventArgs e)
        {
            hsz.Enabled = checkhs.Checked;
        }

        private void checkBoxcam_CheckedChanged(object sender, EventArgs e)
        {
            camz.Enabled = checkcam.Checked;

        }

        private void checkBoxsp_CheckedChanged(object sender, EventArgs e)
        {
            spz.Enabled = checksp.Checked;


        }

        private void checkBoxo_CheckedChanged(object sender, EventArgs e)
        {
            oz.Enabled = checko.Checked;

        }



        private void checknvgpu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustAmdGpu.Checked && checkCustNvGpu.Checked) { checkCustAmdGpu.Checked = false; }
            if (checkCustNvGpu.Checked) { textBoxGpusr.Text = "GT"; }
            else { textBoxGpusr.Text = ""; }

        }

        private void checkamdgpu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustNvGpu.Checked && checkCustAmdGpu.Checked) { checkCustNvGpu.Checked = false; }
            if (checkCustAmdGpu.Checked) { textBoxGpusr.Text = "HD|R5|R7|R9"; } else { textBoxGpusr.Text = ""; }

        }


        #endregion



        #region Memory
        private void labelremember_Click(object sender, EventArgs e)
        {
            MenuRemember.Show(Control.MousePosition);
        }

        private void 存入记忆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("1");
        }

        private void label46_Click(object sender, EventArgs e)
        {
            MenuMemory.Show(Control.MousePosition);
        }

        private void pZ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("1");
        }

        private void 存入2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("2");
            //Form RN = new RememberName();
            //RN.ShowDialog();
            //IniFile.WriteVal("M2", "PZ2", RememberName.pzname + "~" + cpu_choice + "#" + mb_choice + "#" + ram_choice + "#" + hdd_choice + "#" + ssd_choice + "#" + gpu_choice + "#" + lcd_choice + "#" + box_choice + "#" + fan_choice + "#" + power_choice + "#" + cdrom_choice + "#" + kb_choice + "#" + hs_choice + "#" + cam_choice + "#" + sp_choice + "#" + o_choice + "#", settingsini);
            //readconfig();

        }

        private void 存入3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("3");



        }

        private void 存入4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("4");



        }

        private void 存入5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("5");



        }

        private void 存入6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("6");



        }

        private void 存入7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("7");



        }

        private void 存入8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("8");



        }

        private void 存入9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("9");


        }

        private void 存入10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMemory("10");


        }

        private void pZ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("2");

        }

        private void pZ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("3");

        }

        private void pZ4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("4");

        }

        private void pZ5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("5");

        }

        private void pZ6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("6");

        }

        private void pZ7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("7");

        }

        private void pZ8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("8");

        }

        private void pZ9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("9");

        }

        private void pZ10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadMemory("10");

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MemoryManager MM = new MemoryManager();
            MM.ShowDialog();
            ReadConfig();
        }


        #endregion


        private void labelall_Click(object sender, EventArgs e)
        {
            Profit pf = new Profit();
            pf.Show();
        }



        private void comboBoxmou_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.ComboBoxmou, ComboBoxmou.SelectedItem.ToString());

        }




        private void checkBoxmou_CheckedChanged(object sender, EventArgs e)
        {
            mouz.Enabled = checkmou.Checked;

        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start(userpath);
        }

        private void checkBoxall_CheckStateChanged(object sender, EventArgs e)
        {
            if (trial == true)
            {
                //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (checkBoxall.CheckState == CheckState.Checked)
            {
                checkcpu.Checked = true;
                checkmb.Checked = true;
                checkram.Checked = true;
                checkhdd.Checked = true;
                checkssd.Checked = true;
                checkgpu.Checked = true;
                checklcd.Checked = true;
                checkbox.Checked = true;
                checkfan.Checked = true;
                checkpower.Checked = true;
                checkcdrom.Checked = true;
                checkkb.Checked = true;
                checkmou.Checked = true;
                checkhs.Checked = true;
                checkcam.Checked = true;
                checksp.Checked = true;
                checko.Checked = true;
            }
            else if (checkBoxall.CheckState == CheckState.Indeterminate)
            {
                checkcpu.Checked = true;
                checkmb.Checked = true;
                checkram.Checked = true;
                checkhdd.Checked = true;
                checkgpu.Checked = true;
                checklcd.Checked = true;
                checkbox.Checked = true;
                checkfan.Checked = true;
                checkpower.Checked = true;

                checkssd.Checked = false;
                checkcdrom.Checked = false;
                checkkb.Checked = false;
                checkmou.Checked = false;
                checkhs.Checked = false;
                checkcam.Checked = false;
                checksp.Checked = false;
                checko.Checked = false;
            }
            else
            {
                checkcpu.Checked = false;
                checkmb.Checked = false;
                checkram.Checked = false;
                checkhdd.Checked = false;
                checkssd.Checked = false;
                checkgpu.Checked = false;
                checklcd.Checked = false;
                checkbox.Checked = false;
                checkfan.Checked = false;
                checkpower.Checked = false;
                checkcdrom.Checked = false;
                checkkb.Checked = false;
                checkmou.Checked = false;
                checkhs.Checked = false;
                checkcam.Checked = false;
                checksp.Checked = false;
                checko.Checked = false;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Activate act = new Activate();
            act.ShowDialog();
        }

        private void checkBoxall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ssdz_EnabledChanged(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
    }
}
