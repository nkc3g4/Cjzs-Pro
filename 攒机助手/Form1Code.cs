using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public partial class Form1
    {


        PrintDocument pdDocument = new PrintDocument();
        string clipdata = "";

        public static string sellMdbPath = Application.StartupPath + "\\sell.mdb";
        public static string settingsIni = Application.StartupPath + "\\settings.ini";
        public static string mainDbConStr = string.Empty;
        public static string hwDataDbConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\hw.mdb;Jet OLEDB:Database Password=zTg3l#7zJOgjw%ap";
        public static string sellDbConStr = string.Empty;
        public static string sqldatabase = hwDataDbConStr;
        //int choice = 0;
        //int mbchoice = 0;
        int money;
        int realmoney = 0;
        bool fixmode = false;
        public static bool trial = false;
        public static int sum = 0;
        public static int costsum = 0;

        Thread threadupdate;
        Thread threadreport;
        Thread threadad;
        String adlink;
        Thread dataupdate;
        Thread active;
        //bool issetup = false;
        public static string userpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Cjzs Files";

        delegate void set_Text(string s); //定义委托
        set_Text Set_Text;


      


        private void set_textboxText(string s)
        {
            labelad.Text = s;
            labelad.Visible = true;

        }




        public void SaveToDatabase()
        {

            InsertRow(SettingItems.MdbPath);
        }


        public bool InsertRow(string mdbPath)
        {

            ///////////////////check Textbox//////////////////////
            //if (textBoxCusName.Text.Length == 0) { textBoxCusName.Text = " "; }
            //if (textBoxCusPhone.Text.Length == 0) { textBoxCusPhone.Text = " "; }
            ///////////////////END//////////////////////////
            //1、建立连接   
            //string strConn
            //    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sellMdbPath + ";Jet OLEDB:Database Password=";
            //OleDbConnection odcConnection = new OleDbConnection(strConn);
            ////2、打开连接   
            //odcConnection.Open();
            ///////纠错///////////////////////////////////////
            if (textBoxCusComments.Text.Length == 0)
            {
                textBoxCusComments.Text = "无";

            }
            if (textBoxCusName.Text.Length == 0)
            {
                textBoxCusName.Text = "无";
            }
            if (textBoxCusPhone.Text.Length == 0)
            {
                textBoxCusPhone.Text = "无";
            }
            //////////////////////////////////////////////
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("程序版本", Application.ProductVersion);
            dict.Add("客户名称", textBoxCusName.Text.Trim());
            dict.Add("联系电话", textBoxCusPhone.Text.Trim());
            dict.Add("备注", textBoxCusComments.Text.Trim());
            dict.Add("总价", sum.ToString());
            dict.Add("CPU", TextBoxcpu.Text.Trim());
            dict.Add("CPU价格", TextBoxcpu1.Text.Trim());
            dict.Add("主板", TextBoxmb.Text.Trim());
            dict.Add("主板价格", TextBoxmb1.Text.Trim());
            dict.Add("内存", TextBoxram.Text.Trim());
            dict.Add("内存价格", TextBoxram1.Text.Trim());
            dict.Add("硬盘", TextBoxhdd.Text.Trim());
            dict.Add("硬盘价格", TextBoxhdd1.Text.Trim());
            dict.Add("固态硬盘", TextBoxssd.Text.Trim());
            dict.Add("固态硬盘价格", TextBoxssd1.Text.Trim());
            dict.Add("显卡", TextBoxgpu.Text.Trim());
            dict.Add("显卡价格", TextBoxgpu1.Text.Trim());
            dict.Add("显示器", TextBoxlcd.Text.Trim());
            dict.Add("显示器价格", TextBoxlcd1.Text.Trim());
            dict.Add("机箱", TextBoxbox.Text.Trim());
            dict.Add("机箱价格", TextBoxbox1.Text.Trim());
            dict.Add("散热器", TextBoxfan.Text.Trim());
            dict.Add("散热器价格", TextBoxfan1.Text.Trim());
            dict.Add("电源", TextBoxpower.Text.Trim());
            dict.Add("电源价格", TextBoxpower1.Text.Trim());
            dict.Add("光驱", TextBoxcdrom.Text.Trim());
            dict.Add("光驱价格", TextBoxcdrom1.Text.Trim());
            dict.Add("键盘", TextBoxkb.Text.Trim());
            dict.Add("键盘价格", TextBoxkb1.Text.Trim());
            dict.Add("鼠标", TextBoxmou.Text.Trim());
            dict.Add("鼠标价格", TextBoxmou1.Text.Trim());
            dict.Add("耳机", TextBoxhs.Text.Trim());
            dict.Add("耳机价格", TextBoxhs1.Text.Trim());
            dict.Add("摄像头", TextBoxcam.Text.Trim());
            dict.Add("摄像头价格", TextBoxcam1.Text.Trim());
            dict.Add("音响", TextBoxsp.Text.Trim());
            dict.Add("音响价格", TextBoxsp1.Text.Trim());
            dict.Add("其他", TextBoxo.Text.Trim());
            dict.Add("其他价格", TextBoxo1.Text.Trim());
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string serStr = jss.Serialize(dict);
            OleDbParameter[] pms = new OleDbParameter[]
            {
                new OleDbParameter ("@sdt",OleDbType.Variant),
                new OleDbParameter("@assinfo",OleDbType.BSTR ,0)
            };
            pms[0].Value = DateTime.Now;
            pms[1].Value = serStr;
            Log.WriteLog("Serialize.log", serStr);
            string sql = "insert into AssInfo(SellDateTime,AssemblyInfo)values(@sdt,@assinfo)";
            try
            {
                MDBHelper.ExecuteNonQuery(Form1.sellDbConStr, sql, pms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存到数据库出错！\n" + ex.ToString());
                Log.WriteLog("SaveToSellMdb.log", ex.ToString());
                return false;
            }


            MessageBox.Show("完成！");
      
            return true;
        }

        private static void CreateSettingsIni()
        {
            if (!Directory.Exists(userpath)) { Directory.CreateDirectory(userpath); }
            FileStream fs = new FileStream(userpath + "\\settings.ini", FileMode.Create, FileAccess.Write);
            fs.SetLength(0);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            string writeString = "";
            writeString = "[Main]";
            sw.WriteLine(writeString);
            writeString = "Hidead=0";
            sw.WriteLine(writeString);
            writeString = "AutoUpdate=1";
            sw.WriteLine(writeString);
            writeString = "MdbPath=";
            sw.WriteLine(writeString);
            writeString = "Align=True";
            sw.WriteLine(writeString);
            writeString = "Print=0";
            sw.WriteLine(writeString);
            writeString = "Save=0";
            sw.WriteLine(writeString);
            writeString = "ShowBBS=1";
            sw.WriteLine(writeString);
            writeString = "CostPrice=1";
            sw.WriteLine(writeString);
            sw.Close();
        }
        private void ReadConfig()
        {
            SettingItems.ReadIni();

            if (SettingItems.ShowBbs) { 问题咨询ToolStripMenuItem.Visible = true; }
            else 问题咨询ToolStripMenuItem.Visible = false;
            if (!File.Exists(SettingItems.MdbPath)) { SettingItems.MdbPath = userpath + "\\data.mdb"; }

            mainDbConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            sellDbConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sellMdbPath + ";";

            label46.Visible = false;
            MenuMemory.Items.Clear();
            //for (int i = 1; i < 11; i++)
            //{
            //    MenuRemember
            //}
            for (int i = 1; i < 11; i++)
            {
                string memstring = IniFile.ReadVal("M3", "PZ" + i.ToString(), settingsIni);
                if (!string.IsNullOrEmpty(memstring))
                {
                    label46.Visible = true;
                    MenuRemember.Items[i - 1].Text = "存入" + i.ToString() + "：" + memstring.Substring(0, memstring.IndexOf("~"));
                    //this.存入记忆ToolStripMenuItem.Text = "存入1：" + memstring.Substring(0, memstring.IndexOf("~")); 

                    ToolStripItem tsi = MenuMemory.Items.Add(memstring.Substring(0, memstring.IndexOf("~")));
                    tsi.Tag = i;
                    tsi.Click += tsi_Click;

                    //this.pZ1ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); 
                    this.pZ1ToolStripMenuItem.Visible = true;
                }
                else
                {
                    MenuRemember.Items[i - 1].Text = "存入" + i.ToString() + "：";
                }
            }


            CuanJiPofileStruct cjbox = new CuanJiPofileStruct();
            cjbox.P1 = 2000;
            cjbox.P2 = 5000;
            cjbox.P3 = 12000;
            cjbox.K1 = 150;
            cjbox.K2 = 200;
            cjbox.K3 = 300;
            cjbox.K4 = 400;
            SData.hwBox.CuanJiPofile = cjbox;

            //////
            CuanJiPofileStruct cjmou = new CuanJiPofileStruct();
            cjmou.P1 = 2000;
            cjmou.P2 = 5000;
            cjmou.P3 = 12000;
            cjmou.K1 = 150;
            cjmou.K2 = 200;
            cjmou.K3 = 300;
            cjmou.K4 = 400;
            SData.hwMou.CuanJiPofile = cjmou;
            //////
            CuanJiPofileStruct cjpow = new CuanJiPofileStruct();
            cjpow.P1 = 3000;
            cjpow.P2 = 7000;
            cjpow.P3 = 10000;
            cjpow.K1 = 200;
            cjpow.K2 = 400;
            cjpow.K3 = 600;
            cjpow.K4 = 800;
            SData.hwPower.CuanJiPofile = cjpow;
            /////
            CuanJiPofileStruct cjkb = new CuanJiPofileStruct();
            cjkb.P1 = 2000;
            cjkb.P2 = 5000;
            cjkb.P3 = 12000;
            cjkb.K1 = 0.03F;
            cjkb.K2 = 0.03F;
            cjkb.K3 = 0.03F;
            cjkb.K4 = 0.03F;
            SData.hwKb.CuanJiPofile = cjkb;
            /////
            CuanJiPofileStruct cjhs = new CuanJiPofileStruct();
            cjhs.P1 = 2000;
            cjhs.P2 = 5000;
            cjhs.P3 = 12000;
            cjhs.K1 = 0.03F;
            cjhs.K2 = 0.03F;
            cjhs.K3 = 0.03F;
            cjhs.K4 = 0.03F;
            SData.hwHs.CuanJiPofile = cjhs;
            /////
            CuanJiPofileStruct cjcam = new CuanJiPofileStruct();
            cjcam.P1 = 2000;
            cjcam.P2 = 5000;
            cjcam.P3 = 12000;
            cjcam.K1 = 0.03F;
            cjcam.K2 = 0.03F;
            cjcam.K3 = 0.03F;
            cjcam.K4 = 0.03F;
            SData.hwCam.CuanJiPofile = cjcam;
            /////
            CuanJiPofileStruct cjsp = new CuanJiPofileStruct();
            cjsp.P1 = 2000;
            cjsp.P2 = 5000;
            cjsp.P3 = 12000;
            cjsp.K1 = 0.03F;
            cjsp.K2 = 0.03F;
            cjsp.K3 = 0.03F;
            cjsp.K4 = 0.03F;
            SData.hwSp.CuanJiPofile = cjsp;
            /////
            CuanJiPofileStruct cjcdrom = new CuanJiPofileStruct();
            cjcdrom.P1 = 2000;
            cjcdrom.P2 = 5000;
            cjcdrom.P3 = 12000;
            cjcdrom.K1 = 0.03F;
            cjcdrom.K2 = 0.03F;
            cjcdrom.K3 = 0.03F;
            cjcdrom.K4 = 0.03F;
            SData.hwCdrom.CuanJiPofile = cjcdrom;
            /////
            CuanJiPofileStruct cjram = new CuanJiPofileStruct();
            cjram.P1 = 2000;
            cjram.P2 = 5500;
            cjram.P3 = 12000;
            cjram.K1 = 250;
            cjram.K2 = 300;
            cjram.K3 = 400;
            cjram.K4 = 800;
            SData.hwRam.CuanJiPofile = cjram;
            /////
            CuanJiPofileStruct cjhdd = new CuanJiPofileStruct();
            cjhdd.P1 = 3000;
            cjhdd.P2 = 6000;
            cjhdd.P3 = 10000;
            cjhdd.K1 = 200;
            cjhdd.K2 = 300;
            cjhdd.K3 = 400;
            cjhdd.K4 = 500;
            SData.hwHdd.CuanJiPofile = cjhdd;
            /////
            CuanJiPofileStruct cjssd = new CuanJiPofileStruct();
            cjssd.P1 = 5000;
            cjssd.P2 = 10000;
            cjssd.P3 = 12000;
            cjssd.K1 = 0.14F;
            cjssd.K2 = 0.1F;
            cjssd.K3 = 0.1F;
            cjssd.K4 = 0.1F;
            SData.hwSsd.CuanJiPofile = cjssd;
            ///
            //
            ReadCuanJiPofile(SData.hwPower, "Power");
            ReadCuanJiPofile(SData.hwBox, "Box");
            ReadCuanJiPofile(SData.hwCdrom, "Cdrom");
            ReadCuanJiPofile(SData.hwKb, "Kb");
            ReadCuanJiPofile(SData.hwMou, "Mou");
            ReadCuanJiPofile(SData.hwRam, "Ram");
            ReadCuanJiPofile(SData.hwSp, "Sp");
            ReadCuanJiPofile(SData.hwHs, "Hs");
            ReadCuanJiPofile(SData.hwHdd, "Hdd");
            ReadCuanJiPofile(SData.hwSsd, "Ssd");
            //ReadCuanJiPofile(ref cj, "Ssd");


        }

        void tsi_Click(object sender, EventArgs e)
        {
            ReadMemory(((ToolStripItem)sender).Tag.ToString());
            //throw new NotImplementedException();
        }
        private void ReadCuanJiPofile(HardWareKind hwk, string HwName)
        {
            string temp;
            int outstring;
            float outnum;
            //string HwIdName=cjp.;
            CuanJiPofileStruct cjp = new CuanJiPofileStruct();
            temp = IniFile.ReadVal(HwName, "P1", Form1.settingsIni);
            if (temp != "")
            {
                Int32.TryParse(temp, out outstring);
                cjp.P1 = outstring;
            }

            temp = IniFile.ReadVal(HwName, "P2", Form1.settingsIni);
            if (temp != "")
            {
                Int32.TryParse(temp, out outstring);
                cjp.P2 = outstring;
            }
            temp = IniFile.ReadVal(HwName, "P3", Form1.settingsIni);
            if (temp != "")
            {
                Int32.TryParse(temp, out outstring);
                cjp.P3 = outstring;

            }
            temp = IniFile.ReadVal(HwName, "K1", Form1.settingsIni);
            if (temp != "")
            {
                float.TryParse(temp, out outnum);
                cjp.K1 = outnum;
            }
            temp = IniFile.ReadVal(HwName, "K2", Form1.settingsIni);
            if (temp != "")
            {
                float.TryParse(temp, out outnum);
                cjp.K2 = outnum;
            }
            temp = IniFile.ReadVal(HwName, "K3", Form1.settingsIni);
            if (temp != "")
            {
                float.TryParse(temp, out outnum);
                cjp.K3 = outnum;
            }
            temp = IniFile.ReadVal(HwName, "K4", Form1.settingsIni);
            if (temp != "")
            {
                float.TryParse(temp, out outnum);
                cjp.K4 = outnum;
            }
            cjp.RG1 = IniFile.ReadVal(HwName, "R1", Form1.settingsIni);
            cjp.RG2 = IniFile.ReadVal(HwName, "R2", Form1.settingsIni);
            cjp.RG3 = IniFile.ReadVal(HwName, "R3", Form1.settingsIni);
            cjp.RG4 = IniFile.ReadVal(HwName, "R4", Form1.settingsIni);
            hwk.CuanJiPofile = cjp;
        }

        private void Loading()
        {
            ReadAccessData();

        }
        private void AddDBID()
        {


            using (OleDbConnection objConnection = new OleDbConnection(Form1.sqldatabase)) //用using替代objConnection.Close()  
            {
                objConnection.Open();  //打开连接   
                OleDbCommand cmd;
                foreach (var hwKindItem in SData.allHwKind)
                {

                    if (hwKindItem != SData.hwCpu && hwKindItem != SData.hwACpu) continue;
                    cmd = new OleDbCommand("SELECT [simplename],[ID] FROM " + hwKindItem.KindNameShort.ToLower(), objConnection);
                    string specialCharRegex = string.Empty;
                    if (hwKindItem == SData.hwCpu) { specialCharRegex = "K|T|R|S"; }
                    else if (hwKindItem == SData.hwACpu) { specialCharRegex = "K|U|E|T|B"; }
                    Dictionary<string, int> dict = new Dictionary<string, int>();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string newStr = reader.GetValue(0).ToString().Replace('?', ' ').Trim();
                            if (dict.ContainsKey(newStr)) continue;
                            dict.Add(newStr, reader.GetInt32(1));

                        }
                    }
                    foreach (var item in hwKindItem.HW)
                    {

                        if (item.DBID != 0)
                        {
                            continue;
                        }
                        //else
                        //{
                        //    //Console.WriteLine(item.Name);
                        //}
                        foreach (KeyValuePair<string, int> dictItem in dict)
                        {

                            if (item.Name.ToUpper().Contains(dictItem.Key.ToUpper()))
                            {

                                if (Regex.IsMatch(Regex.Replace(item.Name.ToUpper().Trim(), @"\([^\(]*\)", string.Empty).Replace("INTEL", "").Replace("AMD", ""), specialCharRegex))
                                {
                                    //MessageBox.Show(Regex.Replace(item.Name.ToUpper().Trim(), @"\([^\(]*\)", string.Empty));
                                    //MessageBox.Show(item.Name);
                                    if (Regex.IsMatch(dictItem.Key.ToUpper(), specialCharRegex))
                                    {
                                        item.DBID = dictItem.Value;
                                        break;
                                    }
                                }
                                else
                                {

                                    item.DBID = dictItem.Value;

                                    break;
                                }

                            }


                        }
                    }
                }
          

            }



        }
        public static void ReadAccessData()
        {
            foreach (var item in SData.allHwKind)
            {
                item.HW = new List<HardWare>();
            }
    
            string errorinfo = "";
            //try
            //{
            foreach (var item in SData.allHwKind)
            {
                item.HW.Add(new HardWare("自动选择", 0, 0, 0));
            }
            SData.hwGpu.HW.Add(new HardWare("集成显卡/核心显卡", 0, 0, 0));
            SData.hwMou.HW.Add(new HardWare("套装自带", 0, 0, 0));
            SData.hwPower.HW.Add(new HardWare("机箱自带", 0, 0, 0));
            SData.hwFan.HW.Add(new HardWare("盒装自带", 0, 0, 0));
            foreach (var item in SData.allHwKind)
            {
                if (!MDBHelper.GetTables(mainDbConStr, "z_" + item.KindNameShort.ToLower())) continue;
                string sql_read = "SELECT * FROM z_" + item.KindNameShort.ToLower();
                using (OleDbDataReader reader = MDBHelper.ExecuteReader(Form1.mainDbConStr, sql_read))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string name = reader.GetString(0);
                                //string name = reader[0].ToString();
                                int sellPrice;
                                int.TryParse(reader[2].ToString(), out sellPrice);
                                int buyPrice;
                                int.TryParse(reader[1].ToString(), out buyPrice);
                                int warr;
                                int.TryParse(reader[3].ToString(), out warr);

                                int DBID = 0;
                                try
                                {
                                    int.TryParse(reader[4].ToString(), out DBID);
                                }
                                catch { }
                                item.HW.Add(new HardWare(name, sellPrice, buyPrice, warr, DBID));
                            }
                            catch (Exception ex)
                            {
                                errorinfo += item.KindNameShort + ex.ToString() + "\r\n";
                            }
                        }
                    }
                }



                //OleDbCommand ocmd = new OleDbCommand("SELECT * FROM z_" + item.KindNameShort.ToLower(), odcConnection);
                //OleDbDataReader oReader = ocmd.ExecuteReader();
                //while (oReader.Read())
                //{

                //}


                if (item != SData.hwACpu)
                {


                    item.AddToComboBox();


                }

                //oReader.Close();
                //oReader.Dispose();
                //ocmd.Dispose();

            }

            //odcConnection.Close();
            //odcConnection.Dispose();
            if (errorinfo != "")
            {
                Log.WriteLog("ReadData.log", errorinfo);
                MessageBox.Show("配置文件错在部分错误，程序已自动忽略！\n详情请看日志文件ReadData.log");
            }
        }
        private void Initialization()
        {
            foreach (var item in SData.allHwKind)
            {
                //item.TxtFilter.Text = string.Empty;
                item.TxtName.Text = " ";
                item.TxtPrice.Text = string.Empty;
                item.HWChoice = null;
            }

            Int32.TryParse(textBoxMoney.Text.Trim(), out realmoney);
            //            if (realmoney == 0) { MessageBox.Show(""); return; }
            //#warning 未实现
            if (!checklcd.Checked) { money = realmoney + realmoney / 3; }
            else { money = realmoney; }
            if (!checkhdd.Checked) { money = money + 300; }
            if (checkssd.Checked) { money = money - (int)(((float)money) * 0.1); }
            if (checkhs.Checked) { money = money - 100; }
            if (checkcam.Checked) { money = money - 100; }
            if (checksp.Checked) { money = money - 150; }
            if (checkkb.Checked) { money = money - 100; }

            ////////////////////////
        }
        private void c_cpu()
        {
            if (checkcpu.Checked)
            {
                if (!checkCustAmd.Checked)
                {
                    SData.hwCpu.AutoChooseHardWare(() =>
                    {
                        HardWare choice = null;
                        List<string> incpart = new List<string>();
                        if (checkCustBoxedCpu.Checked) { incpart.Add("盒"); }
                        //incpart.Add(cpusr2);
                        List<string> notincpart = new List<string>();
                        if (checkCustCoreGpu.Checked) { notincpart.Add("E3"); }

                        AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();

                        if (money <= 2500)
                        {
                            if (checkCustHighxcpu.Checked)
                            {
                                paras.paidMoney = money / 5;
                            }
                            else
                            {
                                paras.paidMoney = money / 6;
                            }
                        }
                        else if (money > 2500 && money <= 5500)
                        {
                            if (checkCustHighxcpu.Checked || textBoxCpuSr.Text == "K")
                            {
                                paras.paidMoney = money / 4;
                            }
                            else
                            {
                                notincpart.Add("K");
                                paras.paidMoney = money / 5;
                            }
                        }
                        //else if 
                        else if (money > 5500 && money <= 9000)
                        {
                            if (checkCustHighxcpu.Checked || textBoxCpuSr.Text == "K")
                            {
                                paras.paidMoney = money / 3;
                            }
                            else
                            {
                                notincpart.Add("K");
                                paras.paidMoney = money / 4;
                            }

                        }
                        else
                        {
                            if (checkCustHighxcpu.Checked)
                            {
                                paras.paidMoney = money / 3;
                            }
                            else
                            {
                                paras.paidMoney = (int)(((float)money) / 3.5);
                            }

                        }



                        //}

                        paras.hwk = SData.hwCpu;
                        paras.includedPart = incpart;
                        paras.notIncludedPart = notincpart;
                        choice = AutoHW.AutoChooseHW(paras);
                        return choice;
                    });


                }
                else //AMD CPU
                {
                    SData.hwACpu.AutoChooseHardWare(() =>
                    {
                        HardWare choice = null;
                        List<string> incpart = new List<string>();
                        if (checkCustBoxedCpu.Checked) { incpart.Add("盒"); }
                        //incpart.Add(cpusr2);
                        List<string> notincpart = new List<string>();
                        AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                        if (checkCustCoreGpu.Checked)
                        {
                            notincpart.Add("速龙"); notincpart.Add("羿龙");
                        }

                        if (checkCustHighxcpu.Checked)
                        {
                            paras.paidMoney = money / 5;
                        }
                        else
                        {
                            paras.paidMoney = money / 6;
                        }
                        paras.hwk = SData.hwACpu;
                        paras.includedPart = incpart;
                        paras.notIncludedPart = notincpart;
                        choice = AutoHW.AutoChooseHW(paras);
                        return choice;



                    });

               
                }
            }

        }
        private void c_mb()
        {
            if (checkmb.Checked)
            {


                int ivb = 0;
                HardWare cpu_model = null;
                if (fixmode)
                {
                    if (SData.hwCpu.HWChoice != null) { cpu_model = SData.hwCpu.HWChoice; }
                    else if (SData.hwACpu.HWChoice != null) { cpu_model = SData.hwACpu.HWChoice; }
                }
                Dictionary<string, int> mbChoice = new Dictionary<string, int>();
             
                if (!checkCustAmd.Checked)
                {
                
                    if (cpu_model.Name.Contains("赛扬") || cpu_model.Name.Contains("奔腾"))
                    {
                        if (cpu_model.Name.Contains("1820") || cpu_model.Name.Contains("1830") || cpu_model.Name.Contains("1810") || cpu_model.Name.Contains("1840") || cpu_model.Name.Contains("1850"))
                        {
                            mbChoice.Add("H81", 300);
                            mbChoice.Add("B85", 350);

                        }
                        else if (cpu_model.Name.Contains("1610") || cpu_model.Name.Contains("1620") || cpu_model.Name.Contains("1630"))
                        {
                            mbChoice.Add("B75", 300);
                            mbChoice.Add("H61", 300);

                            //mbchoice = Closest.cauto(mb, mb1, 300, "B75", mbsr);
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 300, "H61", mbsr); }
                        }

                        //////下面奔腾
                        else if (cpu_model.Name.Contains("4440") || cpu_model.Name.Contains("4500") || cpu_model.Name.Contains("4520"))
                        {
                            mbChoice.Add("H110", 300);
                            mbChoice.Add("B150", 350);
                            mbChoice.Add("H170", 400);

                        }
                        else if (cpu_model.Name.Contains("3220") || cpu_model.Name.Contains("3240") || cpu_model.Name.Contains("3420") || cpu_model.Name.Contains("3430") || cpu_model.Name.Contains("3440") || cpu_model.Name.Contains("3450") || cpu_model.Name.Contains("3460") || cpu_model.Name.Contains("3470"))
                        {
                            mbChoice.Add("H81", 300);
                            mbChoice.Add("B85", 350);
                            mbChoice.Add("H87", 400);
                            //mbchoice = Closest.cauto(mb, mb1, 300, "H81", mbsr);
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 350, "B85", mbsr); }
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 400, "H87", mbsr); }

                        }
                        else if (cpu_model.Name.Contains("2010") || cpu_model.Name.Contains("2020") || cpu_model.Name.Contains("2100") || cpu_model.Name.Contains("2120") || cpu_model.Name.Contains("2130") || cpu_model.Name.Contains("2140"))
                        {
                            mbChoice.Add("B75", 350);
                            mbChoice.Add("H61", 300);
                            //mbchoice = Closest.cauto(mb, mb1, 350, "B75", mbsr);
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 300, "H61", mbsr); }
                        }
                        else if (cpu_model.Name.Contains("3258"))
                        {
                            mbChoice.Add("Z87", 600);
                            mbChoice.Add("Z97", 800);
                            mbChoice.Add("B85", 400);
                            mbChoice.Add("H87", 400);
                         

                        }
                        else
                        {
                            mbChoice.Add("H61", 300);
                          
                        }

                      
                    }
                    else if (cpu_model.Name.Contains("i3"))
                    {
                        ivb = cpu_model.Name.IndexOf("3");
                        if (cpu_model.Name.Substring(ivb + 1).Contains("32"))
                        {
                            mbChoice.Add("B75", 500);
                            mbChoice.Add("H77", 500);
                            mbChoice.Add("H61", 500);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("41") || cpu_model.Name.Substring(ivb + 1).Contains("43"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("H81", 450);
                            }
                            else
                            {
                                mbChoice.Add("B85", 500);
                                mbChoice.Add("H81", 500);
                            }
                            mbChoice.Add("H87", 500);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("61") || cpu_model.Name.Substring(ivb + 1).Contains("63"))
                        {
                            mbChoice.Add("H170", 450);
                            mbChoice.Add("B150", 450);
                            mbChoice.Add("Z170", 500);
                            mbChoice.Add("H110", 450);

                        }
                        else
                        {
                            mbChoice.Add("H61", 400);
                            //mbchoice = Closest.cauto(mb, mb1, 400, "H61", mbsr); 
                        }
                    }
                    else if (cpu_model.Name.Contains("i5") && !cpu_model.Name.Contains("K") && !cpu_model.Name.Contains("X"))  //I5 !K !X
                    {
                        ivb = cpu_model.Name.IndexOf("5");

                        if (cpu_model.Name.Substring(ivb + 1).Contains("34") || cpu_model.Name.Substring(ivb + 1).Contains("35") || cpu_model.Name.Substring(ivb + 1).Contains("33"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("B75", 500);
                                //mbchoice = Closest.cauto(mb, mb1, 500, "B75", mbsr); 
                            }
                            else
                            {
                                mbChoice.Add("B75", 600);
                                //mbchoice = Closest.cauto(mb, mb1, 600, "B75", mbsr); 
                            }
                            mbChoice.Add("H77", 600);
                            mbChoice.Add("Z77", 600);
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 600, "H77", mbsr); }
                            //if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 600, "Z77", mbsr); }
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("44") || cpu_model.Name.Substring(ivb + 1).Contains("45") || cpu_model.Name.Substring(ivb + 1).Contains("46"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("B85", 500);
                                //mbchoice = Closest.cauto(mb, mb1, 500, "B85", mbsr); 
                            }
                            else
                            {
                                mbChoice.Add("B85", 600);
                                //mbchoice = Closest.cauto(mb, mb1, 600, "B85", mbsr); 
                            }
                            mbChoice.Add("H87", 600);
                            mbChoice.Add("H81", 600);
                            mbChoice.Add("Z87", 600);
                            mbChoice.Add("Z97", 800);

                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("64") || cpu_model.Name.Substring(ivb + 1).Contains("65") || cpu_model.Name.Substring(ivb + 1).Contains("66"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("B150", 500);
                            }
                            else
                            {
                                mbChoice.Add("B150", 600);
                            }
                            mbChoice.Add("H170", 600);
                            mbChoice.Add("H110", 600);
                            mbChoice.Add("Z170", 600);

                        }
                        else
                        {
                            if (checkCustHighxcpu.Checked)
                            {
                                mbChoice.Add("H61", 500);

                            }
                            else
                            {
                                mbChoice.Add("H67", 700);
                                mbChoice.Add("H61", 500);
                            }

                        }
                    }
                    else if (cpu_model.Name.Contains("i7") && !cpu_model.Name.Contains("K") && !cpu_model.Name.Contains("X"))
                    {
                        //i7 !X !K
                        // int ivb = 0;
                        ivb = cpu_model.Name.IndexOf("7");
                        if (cpu_model.Name.Substring(ivb + 1).Contains("38"))
                        {
                            mbChoice.Add("X79", 2000);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("37"))
                        {
                            mbChoice.Add("B75", 800);
                            mbChoice.Add("H77", 800);
                            mbChoice.Add("Z77", 600);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("47"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("B85", 650);
                            }

                            else
                            {
                                mbChoice.Add("B85", 750);
                            }
                            mbChoice.Add("H87", 800);
                            mbChoice.Add("H81", 600);
                            mbChoice.Add("Z87", 600);
                            mbChoice.Add("Z97", 800);

                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("67"))
                        {
                            if (checkCustHighxcpu.Checked || checkCustHighGpu.Checked)
                            {
                                mbChoice.Add("B150", 650);
                            }

                            else
                            {
                                mbChoice.Add("B150", 750);
                            }
                            mbChoice.Add("H170", 800);
                            mbChoice.Add("H110", 600);
                            mbChoice.Add("Z170", 600);
                        }
                        else if (checkCustHighxcpu.Checked)
                        {
                            mbChoice.Add("H67", 700);
                        }
                        else
                        {
                            mbChoice.Add("H67", 1000);
                        }
                    }
                    else if (cpu_model.Name.Contains("i7") && cpu_model.Name.Contains("K"))//i7 K
                    {
                        //  int ivb = 0;
                        ivb = cpu_model.Name.IndexOf("7");
                        if (cpu_model.Name.Substring(ivb + 1).Contains("48") || cpu_model.Name.Substring(ivb + 1).Contains("49") || cpu_model.Name.Substring(ivb + 1).Contains("39"))
                        {
                            mbChoice.Add("X79", 3000);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("37"))
                        {
                            mbChoice.Add("Z77", 1000);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("47"))
                        {
                            if (money < 10000)
                            {
                                mbChoice.Add("Z97", 1000);
                                mbChoice.Add("Z87", 800);
                            }
                            else
                            {
                                mbChoice.Add("Z87", 1500);
                            }
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("67"))
                        {
                            if (money < 10000)
                            {
                                mbChoice.Add("Z170", 1000);
                            }
                            else
                            {
                                mbChoice.Add("Z170", 1500);
                            }
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("59") || cpu_model.Name.Substring(ivb + 1).Contains("58"))
                        {
                            mbChoice.Add("X99", 2000);
                        }
                        else if (checkCustHighxcpu.Checked)
                        {
                            mbChoice.Add("Z68", 1000);
                        }
                        else
                        {
                            mbChoice.Add("Z68", 1500);
                        }
                    }
                    else if (cpu_model.Name.Contains("980X") || cpu_model.Name.Contains("990X") || cpu_model.Name.Contains("995X"))
                    {
                        mbChoice.Add("X58", 2000);
                    }
                    else if (cpu_model.Name.Contains("3960X") || cpu_model.Name.Contains("3970X") || cpu_model.Name.Contains("4960X"))
                    {
                        mbChoice.Add("X79", 3000);
                    }
                    else if (cpu_model.Name.Contains("5960X"))
                    {
                        mbChoice.Add("X99", 3500);
                    }
                    else if (cpu_model.Name.Contains("i5") && cpu_model.Name.Contains("K")) //I5 K
                    {
                        //  int ivb = 0;
                        ivb = cpu_model.Name.IndexOf("5");
                        if (cpu_model.Name.Substring(ivb + 1).Contains("35"))
                        {
                            mbChoice.Add("Z77", 800);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("46") || cpu_model.Name.Substring(ivb + 1).Contains("45"))
                        {
                            mbChoice.Add("Z87", 800);
                        }
                        else if (cpu_model.Name.Substring(ivb + 1).Contains("66") || cpu_model.Name.Substring(ivb + 1).Contains("65"))
                        {
                            mbChoice.Add("Z170", 800);

                        }
                        else
                        {
                            mbChoice.Add("Z68", 800);
                        }

                    }
                    else if (cpu_model.Name.Contains("E3") && (cpu_model.Name.Contains("V2") || cpu_model.Name.Contains("v2")))
                    {
                        mbChoice.Add("B75", 600);
                    }
                    else if (cpu_model.Name.Contains("E3") && (cpu_model.Name.Contains("V3") || cpu_model.Name.Contains("v3")))
                    {
                        mbChoice.Add("B85", 700);
                    }
                }
                else
                {

                    if (cpu_model.Name.Contains("羿龙"))
                    {
                        mbChoice.Add("AM3", 500);
                        //mbchoice = Closest.cauto(mb, mb1, 500, "AM3", mbsr);
                    }
                    else if (cpu_model.Name.Contains("FX"))
                    {
                        if (cpu_model.Name.Contains("4"))
                        {
                            mbChoice.Add("AM3+", 400);
                            //mbchoice = Closest.cauto(mb, mb1, 400, "AM3+", mbsr); 
                        }
                        if (cpu_model.Name.Contains("6"))
                        {
                            mbChoice.Add("AM3+", 600);
                            //mbchoice = Closest.cauto(mb, mb1, 600, "AM3+", mbsr); 
                        }
                        else
                        {
                            mbChoice.Add("AM3+", 800);
                            //mbchoice = Closest.cauto(mb, mb1, 800, "AM3+", mbsr);
                        }
                    }
                    else if (Regex.IsMatch(cpu_model.Name, "4020|6320|6420K|6790K|6500T|6700T|4000|5600K|5500|6400K|6500|6700|6600K|6800K|5700|5800K|760K|6400K|740|750K|5400K|5300"))
                    {
                        mbChoice.Add("FM2", 400);
                    }
                    //else if (cpu_model.Name.Contains("4020") || cpu_model.Name.Contains("6320") || cpu_model.Name.Contains("6420K") || cpu_model.Contains("6790K") || cpu_model.Contains("6500T") || cpu_model.Contains("6700T") || cpu_model.Contains("4000") || cpu_model.Contains("5600K") || cpu_model.Contains("5500") || cpu_model.Contains("6400K") || cpu_model.Contains("6500") || cpu_model.Contains("6700") || cpu_model.Contains("6600K") || cpu_model.Contains("6800K") || cpu_model.Contains("5700") || cpu_model.Contains("5800K") || cpu_model.Contains("760K") || cpu_model.Contains("6400K") || cpu_model.Contains("740") || cpu_model.Contains("750K") || cpu_model.Contains("5400K") || cpu_model.Contains("5300") || cpu_model.Contains("4000"))
                    //{
                    //    mbchoice = Closest.cauto(mb, mb1, 400, "FM2", mbsr);
                    //}
                    else if (cpu_model.Name.Contains("3850") || cpu_model.Name.Contains("3870K") || cpu_model.Name.Contains("3800") || cpu_model.Name.Contains("3620") || cpu_model.Name.Contains("3820") || cpu_model.Name.Contains("638") || cpu_model.Name.Contains("641") || cpu_model.Name.Contains("631") || cpu_model.Name.Contains("651") || cpu_model.Name.Contains("3650") || cpu_model.Name.Contains("3500") || cpu_model.Name.Contains("3670K") || cpu_model.Name.Contains("3600") || cpu_model.Name.Contains("3400") || cpu_model.Name.Contains("3300"))
                    {
                        mbChoice.Add("FM1", 400);
                        //mbchoice = Closest.cauto(mb, mb1, 400, "FM1", mbsr);
                    }
                    else if (cpu_model.Name.Contains("7850K") || cpu_model.Name.Contains("7700K") || cpu_model.Name.Contains("7600") || cpu_model.Name.Contains("7400K") || cpu_model.Name.Contains("7800"))
                    {
                        mbChoice.Add("FM2+", 500);
                        //mbchoice = Closest.cauto(mb, mb1, 500, "FM2+", mbsr);

                    }
                    else if (cpu_model.Name.Contains("速龙"))
                    {
                        mbChoice.Add("AM3", 200);
                        //mbchoice = Closest.cauto(mb, mb1, 200, "AM3", mbsr);

                    }
                    //else { mbchoice = 0; }
                    //}

                }
                HardWare choice = null;
                AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                foreach (var item in mbChoice)
                {
                    paras.paidMoney = item.Value;
                    paras.includedPart = new List<string>() { item.Key };
                    paras.hwk = SData.hwMb;
                    choice = AutoHW.AutoChooseHW(paras);
                    if (choice != null) break;
                }
                SData.hwMb.AutoChooseHardWare(choice);

                //if (mbchoice == 0 || mbchoice == -1)
                //{
                //    mb_choice = 0;
                //    //mb[0] = "没有找到合适的主板，请检查配置文件！"; mb1[0] = 0; mb2[0] = 0; 
                //}
                //else
                //{
                //    mb_choice = mbchoice;
                //}
            }
        }
        private void c_gpu()
        {
            if (checkgpu.Checked && checklcd.Checked)
            {

                //if (ComboBoxgpu.SelectedIndex != 0)
                //{
                //    choice = ComboBoxgpu.SelectedIndex;
                //}
                //else
                //{
                HardWare choice = null;
                AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                if (checkCustCoreGpu.Checked || (money < 4000 && !checkCustHighGpu.Checked && ((!checkCustAmd.Checked &&
                    !SData.hwCpu.HWChoice.Name.Contains("3820") &&
                    !SData.hwCpu.HWChoice.Name.Contains("3930K") &&
                    !SData.hwCpu.HWChoice.Name.Contains("4820K") &&
                    !SData.hwCpu.HWChoice.Name.Contains("4930K") &&
                    !SData.hwCpu.HWChoice.Name.Contains("3550P") &&
                    !SData.hwCpu.HWChoice.Name.Contains("2450P") &&
                    !SData.hwCpu.HWChoice.Name.Contains("2380P") &&
                    !SData.hwCpu.HWChoice.Name.Contains("2550K") &&
                    !SData.hwCpu.HWChoice.Name.Contains("E3") &&
                    !SData.hwCpu.HWChoice.Name.Contains("X"))
                    || (checkCustAmd.Checked &&
                    !SData.hwACpu.HWChoice.Name.Contains("速龙") &&
                    !SData.hwACpu.HWChoice.Name.Contains("羿龙")))))
                {
                    choice = SData.hwGpu.HW[1];
                }
                else if (money < 4000)
                {
                    paras.paidMoney = money / 5;
                    //choice = Closest.cauto(gpu, gpu1, money / 5, "", gpusr);
                    //choice = closest(gpu1, money / 5);
                }
                else if (money >= 4000 && money <= 5500 && !checkCustHighGpu.Checked)
                {
                    paras.paidMoney = money / 5;
                    //choice = Closest.cauto(gpu, gpu1, money / 5, "", gpusr);
                    //choice = closest(gpu1, money / 5); 
                }
                else if (money >= 4000 && money <= 5500 && checkCustHighGpu.Checked)
                {
                    paras.paidMoney = money / 4;
                    //choice = Closest.cauto(gpu, gpu1, money / 4, "", gpusr);
                    //   choice = closest(gpu1, money / 4); 
                }
                else if (money > 5500 && money <= 7500 && !checkCustHighGpu.Checked)
                {
                    paras.paidMoney = money / 4;
                    //choice = Closest.cauto(gpu, gpu1, money / 4, "", gpusr);
                }
                else if (money > 5500 && money <= 7500 && checkCustHighGpu.Checked)
                {
                    paras.paidMoney = (int)(((float)money) / 3.5);
                    //choice = Closest.cauto(gpu, gpu1, (int)(((float)money) / 3.5), "", gpusr);

                }
                else if (money > 7500 && !checkCustHighGpu.Checked)
                {
                    paras.paidMoney = (int)(((float)money) / 3.5);
                    //choice = Closest.cauto(gpu, gpu1, (int)(((float)money) / 3.5), "", gpusr);
                }
                else if (money > 7500 && checkCustHighGpu.Checked)
                {
                    paras.paidMoney = money / 3;
                    //choice = Closest.cauto(gpu, gpu1, money / 3, "", gpusr);
                }
                if (choice == null)
                {
                    paras.hwk = SData.hwGpu;
                    choice = AutoHW.AutoChooseHW(paras);
                }
                SData.hwGpu.AutoChooseHardWare(choice);

            }
            //gpu_choice = choice;
        }
        private void c_ram()
        {
            if (!checkram.Checked) { return; }
            if (SData.hwMb.HWChoice != null)
            {
                if (Regex.IsMatch(SData.hwMb.HWChoice.Name, @"X99|H110|B150|H170|Z170"))
                {
                    SData.hwRam.CJViaPofile(realmoney, new Regex(@"DDR4"));
                }
                else
                {
                    SData.hwRam.CJViaPofile(realmoney, new Regex(@"DDR3"));
                }
            }
            else
            {
                SData.hwRam.CJViaPofile(realmoney);
            }        
        }
        private void c_hdd()
        {
            if (!checkhdd.Checked) { return; }
            SData.hwHdd.CJViaPofile(realmoney);
        }
        private void c_ssd()
        {
            if (!checkssd.Checked) { return; }
            SData.hwSsd.CJViaPofile(realmoney);
        }


        private void c_box()
        {
            if (!checkbox.Checked) { return; }
            SData.hwBox.CJViaPofile(realmoney);
        }
        private void c_fan()
        {
            //散热器

            if (checkfan.Checked)
            {
                HardWare choice = null;
                HardWare cpuChoice = null;
                if (checkCustAmd.Checked)
                {
                    cpuChoice = SData.hwACpu.HWChoice;

                }
                else
                {
                    cpuChoice = SData.hwCpu.HWChoice;
                }
                if (cpuChoice != null)
                {
                    AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                    //if (ComboBoxfan.SelectedIndex != 0)
                    //{
                    //    choice = ComboBoxfan.SelectedIndex;
                    //}
                    if (cpuChoice.Name.Contains("散") || cpuChoice.Name.Contains("E3"))
                    {
                        if (cpuChoice.SellPrice <= 500)
                        {
                            paras.paidMoney = 20;
                            //choice = Closest.cauto(fan, fan1, 20, "", fansr); 
                        }
                        else if (cpuChoice.SellPrice > 500 && cpuChoice.SellPrice <= 1000)
                        {
                            paras.paidMoney = 50;
                            //choice = Closest.cauto(fan, fan1, 50, "", fansr); 
                        }
                        else if (cpuChoice.SellPrice > 1000 && cpuChoice.SellPrice <= 2000)
                        {
                            paras.paidMoney = 100;
                            //choice = Closest.cauto(fan, fan1, 100, "", fansr); 
                        }
                        else
                        {
                            paras.paidMoney = 200;
                            //choice = Closest.cauto(fan, fan1, 200, "", fansr);
                        }

                    }
                    else if (SData.hwMb.HWChoice != null && (SData.hwMb.HWChoice.Name.Contains("X79") || SData.hwMb.HWChoice.Name.Contains("X99")))
                    {
                        paras.paidMoney = 400;
                        paras.includedPart = new List<string>() { "LGA2011" };
                        //choice = Closest.cauto(fan, fan1, 400, "LGA2011", fansr);
                        // fan[0] = fan[7];
                        // fan1[0] = fan1[7];
                    }
                    else choice = SData.hwFan.HW[1];
                    if (choice == null)
                    {
                        paras.hwk = SData.hwFan;
                        choice = AutoHW.AutoChooseHW(paras);
                    }
                }
                SData.hwFan.AutoChooseHardWare(choice);


            }
        }
        private void c_power()
        {
            if (checkpower.Checked)
            {
                //if (ComboBoxpower.SelectedIndex != 0)
                //{
                //    choice = ComboBoxpower.SelectedIndex;

                //}
                if (!SData.hwBox.HWChoice.Name.Contains("带电源"))
                {
                    SData.hwPower.CJViaPofile(realmoney);

                }
                //else { choice = 1; }
                //if (choice == 0 || choice == -1)
                //{
                //    power_choice = 0;

                //    //power[0] = "没有找到符合要求的配件。"; power1[0] = 0; 
                //}
                //else
                //{
                //    power_choice = choice;

                //    //power[0] = power[choice];
                //    //power1[0] = power1[choice];
                //    //power2[0] = power2[choice];

                //}
            }
        }
        private void c_cdrom()
        {

            //CDROM,100

            if (!checkcdrom.Checked) return;


            SData.hwCdrom.CJViaPofile(realmoney);


        }
        private void c_kb()
        {
            if (checkkb.Checked)
            {
                SData.hwKb.CJViaPofile(realmoney);
                //CJViaPofile(cjkb, kb, kb1, ref kb_choice, kbsr, ComboBoxkb);
            }



        }
        private void c_mou()
        {
            if (!checkmou.Checked) { return; }
            HardWare choice = null;
            if (SData.hwKb.HWChoice.Name.Contains("键鼠套装"))
            {
                choice = SData.hwMou.HW[1];
            }
            else
            {
                SData.hwMou.CJViaPofile(realmoney);

            }


        }
        private void c_hs()
        {
            if (checkhs.Checked)
            {
                SData.hwHs.CJViaPofile(realmoney);
                //CJViaPofile(cjhs, hs, hs1, ref hs_choice, hssr, ComboBoxhs);
            }



        }
        private void c_cam()
        {

            if (checkcam.Checked)
            {
                SData.hwCam.CJViaPofile(realmoney);
                //CJViaPofile(cjcam, cam, cam1, ref cam_choice, camsr, ComboBoxcam);
            }


        }
        private void c_sp()
        {
            if (checksp.Checked)
            {
                SData.hwSp.CJViaPofile(realmoney);
                //CJViaPofile(cjsp, sp, sp1, ref sp_choice, spsr, ComboBoxsp);
            }

        }
        private void c_o()
        {

            if (!checko.Checked) return;

            SData.hwO.AutoChooseHardWare(() => { return null; });

        }
        private void c_lcd()
        {
            int rest;
            int cpu_price = 0;
            if (fixmode)
            {
                if (!SData.hwCpu.IsNullOrNoResult())
                {
                    cpu_price = SData.hwCpu.HWChoice.SellPrice;
                }
                else if (!SData.hwACpu.IsNullOrNoResult())
                {
                    cpu_price = SData.hwACpu.HWChoice.SellPrice;
                }
            }
            int sum = 0;
            foreach (var item in SData.allHwKind)
            {
                if (item == SData.hwCpu || item == SData.hwACpu) continue;
                if (item.HWChoice != null)
                {
                    sum += item.HWChoice.SellPrice;
                }
            }
            rest = realmoney - (cpu_price + sum);
            ////////////////////////
            if (checklcd.Checked)
            {
                //if (ComboBoxlcd.SelectedIndex != 0) { choice = ComboBoxlcd.SelectedIndex; }
                //else
                //{
                HardWare choice = null;
                AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                paras.paidMoney = rest;
                paras.hwk = SData.hwLcd;

                choice = AutoHW.AutoChooseHW(paras);
                SData.hwLcd.AutoChooseHardWare(choice);

            }
            else
            {
                if (checkgpu.Checked)
                {
                    //if (ComboBoxgpu.SelectedIndex != 0)
                    //{
                    //    choice = ComboBoxgpu.SelectedIndex;
                    //}
                    HardWare choice = null;
                    if (realmoney <= 3000 && !checkCustHighGpu.Checked && !SData.hwCpu.HWChoice.Name.Contains("E3") && !SData.hwCpu.HWChoice.Name.Contains("羿龙") && !SData.hwCpu.HWChoice.Name.Contains("X") && !SData.hwCpu.HWChoice.Name.Contains("速龙"))
                    {
                        choice = SData.hwGpu.HW[1];
                    }
                    else
                    {

                        AutoHW.AutoChooseParameters paras = new AutoHW.AutoChooseParameters();
                        paras.paidMoney = rest;
                        paras.hwk = SData.hwGpu;
                        choice = AutoHW.AutoChooseHW(paras);

                        //choice = Closest.cauto(gpu, gpu1, rest, gpusr);

                    }
                    SData.hwGpu.AutoChooseHardWare(choice);

                }
            }
        }
        private void totalprice()
        {
            labelall.Visible = true;
            labelcopy.Visible = true;
            labelprint.Visible = true;
            labeldb.Visible = true;
            labeldoc.Visible = true;
            labelRCMD.Visible = true;
            labelremember.Visible = true;
            if (SettingItems.CostPrice != SettingItems.CostPriceEnum.不显示)
            {
                labelcostprice.Visible = true;
            }
            labelremember.Visible = true;
            sum = 0;
            costsum = 0;
            this.TextBoxmou1.ForeColor = System.Drawing.Color.Red;

            //int costsum = 0;
            //sum = cpu1[cpu_choice] + mb1[mb_choice] + gpu1[gpu_choice] + ram1[ram_choice] + hdd1[hdd_choice] + box1[box_choice ] + lcd1[lcd_choice ] + power1[power_choice ] + fan1[fan_choice ] + cdrom1[cdrom_choice ] + kb1[kb_choice ] + ssd1[ssd_choice ] + hs1[hs_choice ] + cam1[cam_choice ] + sp1[sp_choice ] + o1[o_choice ];  //总价
            //string costsum=
            ///////////////////////////
            //
            foreach (var item in SData.allHwKind)
            {
                if (checkCustAmd.Checked) { if (item == SData.hwCpu) continue; }
                else
                {
                    if (item == SData.hwACpu) continue;
                }
                item.ShowHardWareToTextBox();
                if (item.HWChoice != null)
                {
                    if (!item.CheckGift.Checked)
                    {
                        sum += item.HWChoice.SellPrice;
                    }
                    costsum += item.HWChoice.BuyPrice;
                }

            }


            if (trial)
            {
                TextBoxfan.Text = "试用版";
                TextBoxfan1.Text = "试用版";

                TextBoxpower.Text = "试用版";
                TextBoxpower1.Text = "试用版";
            }
            //////
            labelall.Text = "合计:" + sum + "元";
            if (SettingItems.CostPrice == SettingItems.CostPriceEnum.成本)
            {
                labelcostprice.Text = "成本:" + costsum + "元";
            }
            else if (SettingItems.CostPrice == SettingItems.CostPriceEnum.利润)
            {
                labelcostprice.Text = "利润:" + (Form1.sum - Form1.costsum) + "元";

            }
            else
            {
                labelcostprice.Text = "利润率:" + String.Format("{0:N2} ", (((float)(Form1.sum - Form1.costsum) / (float)Form1.costsum) * 100)) + "%";

            }
            this.TextBoxmou1.ForeColor = System.Drawing.Color.Red;

        }


        private void SaveMemory(string memNum)
        {
            //#warning 最近实现
            Form RN = new RememberName();
            DialogResult dr = RN.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            StringBuilder sb = new StringBuilder();
            sb.Append(RememberName.pzname);
            sb.Append("~");
            List<HardWare> list = new List<HardWare>();
            foreach (var item in SData.allHwKind)
            {
                list.Add(item.HWChoice);

            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            sb.Append(jss.Serialize(list));
            #region SaveMemoryOldCode
            //sb.Append("|");
            //HardWare cpuchoice;
            ////
            ////jss.Serialize ()

            //if (checkCustAmd.Checked) { cpuchoice = SData.hwACpu.HWChoice; } else { cpuchoice = SData.hwCpu.HWChoice; }
            //foreach (var item in SData.allHwKind)
            //{

            //}
            ////IniFile.WriteVal("M1", "PZ1", RememberName.pzname + "~" + cpu[0] + "#" + cpu1[0] + "|" + mb[0] + "#" + mb1[0] + "|" + ram[0] + "#" + ram1[0] + "|" + hdd[0] + "#" + hdd1[0] + "|" + ssd[0] + "#" + ssd1[0] + "|" + gpu[0] + "#" + gpu1[0] + "|" + lcd[0] + "#" + lcd1[0] + "|" + box[0] + "#" + box1[0] + "|" + fan[0] + "#" + fan1[0] + "|" + power[0] + "#" + power1[0] + "|" + cdrom[0] + "#" + cdrom1[0] + "|" + kb[0] + "#" + kb1[0] + "|" + hs[0] + "#" + hs1[0] + "|" + cam[0] + "#" + cam1[0] + "|" + sp[0] + "#" + sp1[0] + "|" + o[0] + "#" + o1[0] + "|", settingsini);
            //IniFile.WriteVal("M2", "PZ" + number, RememberName.pzname + "~" + checkCustAmd.Checked.ToString() + "|" + cpuchoice + "#" + mb_choice + "#" + ram_choice + "#" + hdd_choice + "#" + ssd_choice + "#" + gpu_choice + "#" + lcd_choice + "#" + box_choice + "#" + fan_choice + "#" + power_choice + "#" + cdrom_choice + "#" + kb_choice + "#" + mou_choice + "#" + hs_choice + "#" + cam_choice + "#" + sp_choice + "#" + o_choice + "#", settingsini);
            #endregion
            IniFile.WriteVal("M3", "PZ" + memNum, sb.ToString(), settingsIni);
            ReadConfig();

        }
        private void ReadMemory(string memNum)
        {
            //#warning 最近实现
            string pzstring = IniFile.ReadVal("M3", "PZ" + memNum, settingsIni);
            //pzstring = ;
            string[] parts = pzstring.Split('~');
            JavaScriptSerializer jss = new JavaScriptSerializer();
            List<HardWare> list = jss.Deserialize<List<HardWare>>(parts[1]);
            for (int i = 0; i < list.Count; i++)
            {
                SData.allHwKind[i].HWChoice = list[i];
            }
            totalprice();
            #region ReadMemoryOldCode
            //string pzstring = IniFile.ReadVal("M2", "PZ" + num, settingsini);
            ////pzstring = ;
            //string[] parts = pzstring.Split('~', '|', '#');
            //for (int i = 0; i < 18; i++)
            //{
            //    if (string.IsNullOrEmpty(parts[i]))
            //    {
            //        return;
            //    }
            //}
            //string isamd = parts[1];


            //MessageBox.Show("Test");
            //MessageBox.Show(list.Count.ToString ());
            //MessageBox.Show("Test");
            //for (int i = 0; i < 18; i++)
            //{
            //    if (string.IsNullOrEmpty(parts[i]))
            //    {
            //        return;
            //    }
            //}
            //if (parts[1] != "null") //INTEL处理器？
            //{
            //    checkCustAmd.Checked = false;
            //    JavaScriptSerializer jss = new JavaScriptSerializer();
            //    SData.hwCpu.HWChoice = jss.Deserialize<HardWare>(parts[1]);
            //}
            //else
            //{
            //    checkCustAmd.Checked = true;
            //    JavaScriptSerializer jss = new JavaScriptSerializer();
            //    SData.hwACpu.HWChoice = jss.Deserialize<HardWare>(parts[1]);
            //}
            //for (int i = 3; i <= 18; i++)
            //{

            //}
            //string isamd = parts[1];


            ////pzstring=pzstring.Substring(pzstring.IndexOf("~"));
            ////string shorter = pzstring.Substring(pzstring.IndexOf("~") + 1);
            ////MessageBox.Show(shorter);
            ////string isamd = shorter.Substring(0, shorter.IndexOf("|"));
            //if (isamd == "True")
            //{
            //    checkCustAmd.Checked = true;
            //    Int32.TryParse(parts[2], out acpu_choice);
            //    //acpu_choice = Int32.Parse(shorter.Substring(shorter.IndexOf("|") + 1, shorter.IndexOf("#") - shorter.IndexOf("|") - 1));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //}
            //else
            //{
            //    Int32.TryParse(parts[2], out cpu_choice);

            //    //MessageBox.Show(shorter.Substring(shorter.IndexOf("|") + 1, shorter.IndexOf("#") - shorter.IndexOf("|")));
            //    //cpu_choice = Int32.Parse(shorter.Substring(shorter.IndexOf("|") + 1, shorter.IndexOf("#") - shorter.IndexOf("|") - 1));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //}
            //Int32.TryParse(parts[3], out mb_choice);
            //Int32.TryParse(parts[4], out ram_choice);
            //Int32.TryParse(parts[5], out hdd_choice);
            //Int32.TryParse(parts[6], out ssd_choice);
            //Int32.TryParse(parts[7], out gpu_choice);
            //Int32.TryParse(parts[8], out lcd_choice);
            //Int32.TryParse(parts[9], out box_choice);
            //Int32.TryParse(parts[10], out fan_choice);
            //Int32.TryParse(parts[11], out power_choice);
            //Int32.TryParse(parts[12], out cdrom_choice);
            //Int32.TryParse(parts[13], out kb_choice);
            //Int32.TryParse(parts[14], out mou_choice);
            //Int32.TryParse(parts[15], out hs_choice);
            //Int32.TryParse(parts[16], out cam_choice);
            //Int32.TryParse(parts[17], out sp_choice);
            //Int32.TryParse(parts[18], out o_choice);
            //totalprice();
            #endregion
        }
    }
}
