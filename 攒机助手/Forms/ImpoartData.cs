using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using System.Data.SQLite;
using System.Net;
using System.Text;
using System.Web;
using System.Collections.Generic;
using System.Threading;


namespace 攒机助手专业版
{
    public partial class ImpoartData : Form
    {
        Action<int> progressBarValue;
        private volatile bool shouldStop = false;

        /// <summary>
        /// true则为start，false为Stop
        /// </summary>
        Action<bool> setBtnTextIsStart;

        string errorinfo = string.Empty;
        string cbbSelectedItemText = string.Empty;
        Dictionary<string, string> cpuNameDict = new Dictionary<string, string>();
        Dictionary<string, string> acpuNameDict = new Dictionary<string, string>();
        Thread tImport;
        public ImpoartData()
        {

            InitializeComponent();
            progressBarValue = SetProgressBarValue;
            setBtnTextIsStart = SetBtnText;
            using (OleDbConnection objConnection = new OleDbConnection(Form1.sqldatabase)) //用using替代objConnection.Close()  
            {
                objConnection.Open();  //打开连接   
                OleDbCommand cmd;
                cmd = new OleDbCommand("SELECT [simplename],[fullname] FROM cpu", objConnection);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        if (cpuNameDict.ContainsKey(reader.GetString(0).Replace('?', ' ').Trim())) continue;
                        cpuNameDict.Add(reader.GetString(0).Replace('?', ' ').Trim(), reader.GetString(1).Replace('?', ' ').Trim());
                    }
                }
                cmd = new OleDbCommand("SELECT [simplename],[fullname] FROM acpu", objConnection);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (acpuNameDict.ContainsKey(reader.GetString(0).Replace('?', ' ').Trim())) continue;
                        acpuNameDict.Add(reader.GetString(0).Replace('?', ' ').Trim(), reader.GetString(1).Replace('?', ' ').Trim());
                    }
                }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">true:停止，false:stop</param>
        private void SetBtnText(bool value)
        {
            if (button1.InvokeRequired)
            {
                button1.Invoke(setBtnTextIsStart, value);
            }
            else
            {
                if (value)
                {
                    button1.Text = "导入";
                }
                else
                {
                    button1.Text = "停止";
                }
            }
        }
        private void SetProgressBarValue(int value)
        {
            //Console.WriteLine(value );
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(progressBarValue, value);
            }
            else
            {
                if (!progressBar1.Visible) { progressBar1.Visible = true; }

                progressBar1.Value = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ImportDataMdb(string mdbpath)
        {
            string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbpath + ";Jet OLEDB:Database Password=";

            OleDbConnection odcConnection = new OleDbConnection(strConn);
            odcConnection.Open();
            #region OldCode
            //清空
            //cpu = new string[500]; cpu1 = new int[500]; cpu2 = new int[500]; cpu3 = new int[500]; cpu4 = new long[500];
            //acpu = new string[500]; acpu1 = new int[500]; acpu2 = new int[500]; acpu3 = new int[500]; acpu4 = new long[500];
            //mb = new string[500]; mb1 = new int[500]; mb2 = new int[500]; mb3 = new int[500]; mb4 = new long[500];
            //gpu = new string[500]; gpu1 = new int[500]; gpu2 = new int[500]; gpu3 = new int[500]; gpu4 = new long[500];
            //ram = new string[500]; ram1 = new int[500]; ram2 = new int[500]; ram3 = new int[500]; ram4 = new long[500];
            //power = new string[500]; power1 = new int[500]; power2 = new int[500]; power3 = new int[500]; power4 = new long[500];
            //lcd = new string[500]; lcd1 = new int[500]; lcd2 = new int[500]; lcd3 = new int[500]; lcd4 = new long[500];
            //box = new string[500]; box1 = new int[500]; box2 = new int[500]; box3 = new int[500]; box4 = new long[500];
            //hdd = new string[500]; hdd1 = new int[500]; hdd2 = new int[500]; hdd3 = new int[500]; hdd4 = new long[500];
            //ssd = new string[500]; ssd1 = new int[500]; ssd2 = new int[500]; ssd3 = new int[500]; ssd4 = new long[500];
            //fan = new string[500]; fan1 = new int[500]; fan2 = new int[500]; fan3 = new int[500]; fan4 = new long[500];
            //cdrom = new string[500]; cdrom1 = new int[500]; cdrom2 = new int[500]; cdrom3 = new int[500]; cdrom4 = new long[500];
            //kb = new string[500]; kb1 = new int[500]; kb2 = new int[500]; kb3 = new int[500]; kb4 = new long[500];
            //hs = new string[500]; hs1 = new int[500]; hs2 = new int[500]; hs3 = new int[500]; hs4 = new long[500];
            //cam = new string[500]; cam1 = new int[500]; cam2 = new int[500]; cam3 = new int[500]; cam4 = new long[500];
            //sp = new string[500]; sp1 = new int[500]; sp2 = new int[500]; sp3 = new int[500]; sp4 = new long[500];
            //o = new string[500]; o1 = new int[500]; o2 = new int[500]; o3 = new int[500]; o4 = new long[500];
            //mou = new string[500]; mou1 = new int[500]; mou2 = new int[500]; mou3 = new int[500]; mou4 = new long[500];

            //cpu[0] = " ";
            //cpu1[0] = 0;
            //cpu2[0] = 0;

            //gpu[0] = " ";
            //gpu1[0] = 0;
            //gpu2[0] = 0;

            //mb[0] = " ";
            //mb1[0] = 0;
            //mb2[0] = 0;

            //ram[0] = " ";
            //ram1[0] = 0;
            //ram2[0] = 0;

            //box[0] = " ";
            //box1[0] = 0;
            //box2[0] = 0;

            //power[0] = " ";
            //power1[0] = 0;
            //power2[0] = 0;

            //lcd[0] = " ";
            //lcd1[0] = 0;
            //lcd2[0] = 0;

            //fan[0] = " ";
            //fan1[0] = 0;
            //fan2[0] = 0;

            //hdd[0] = " ";
            //hdd1[0] = 0;
            //hdd2[0] = 0;

            //ssd[0] = " ";
            //ssd1[0] = 0;
            //ssd2[0] = 0;

            //cdrom[0] = " ";
            //cdrom1[0] = 0;
            //cdrom2[0] = 0;

            //kb[0] = " ";
            //kb1[0] = 0;
            //kb2[0] = 0;

            //mou[0] = " ";
            //mou1[0] = 0;
            //mou2[0] = 0;

            //hs[0] = " ";
            //hs1[0] = 0;
            //hs2[0] = 0;

            //sp[0] = " ";
            //sp1[0] = 0;
            //sp2[0] = 0;

            //cam[0] = " ";
            //cam1[0] = 0;
            //cam2[0] = 0;

            //o[0] = " ";
            //o1[0] = 0;
            //o2[0] = 0;
            //bool iserror = false;
            #endregion
            string errorinfo = "";
            //try
            //{
            OleDbCommand cmd;
            cmd = new OleDbCommand("SELECT * FROM z_cpu", odcConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }
                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "CPU";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                    ////MessageBox.Show((reader[4].ToString()));
                    //cpu[i] = reader[0].ToString();
                    //cpu1[i] = System.Int32.Parse();
                    //cpu3[i] = System.Int32.Parse(reader[1].ToString());
                    ////cpu4[i] = (long)System.Int32.Parse(reader[4].ToString());
                    //cpu2[i++] = System.Int32.Parse();


                }
                catch (Exception ex)
                {
                    errorinfo += "CPU" + i.ToString() + ex.ToString() + "\r\n";
                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n"+ex.ToString ()); 
                }
            }
            ///////////////////
            cmd = new OleDbCommand("SELECT * FROM z_acpu", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }
                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "AMD CPU";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";


                }
                catch (Exception ex)
                {
                    errorinfo += "ACPU" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_hdd", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }
                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "硬盘";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "HDD" + i.ToString() + ex.ToString() + "\r\n";
                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_ram", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "内存";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "RAM" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }

            i = 2;
            while (reader.Read())
            {
                try
                {
                    if (i > 498) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "显卡";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "GPU" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_lcd", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "显示器";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "LCD" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_ssd", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "固态硬盘";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "SSD" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_box", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "机箱";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "BOX" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }

            i = 2;
            while (reader.Read())
            {
                try
                {
                    if (i > 498) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "电源";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "POWER" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_kb", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "键盘";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "KB" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            if (MDBHelper.GetTables(Form1.mainDbConStr, "z_mou"))
            {
                cmd = new OleDbCommand("SELECT * FROM z_mou", odcConnection);
                reader = cmd.ExecuteReader();

                i = 2;
                while (reader.Read())
                {
                    try
                    {
                        if (i > 498) { break; }

                        DataRow row = Admin.MainDt.NewRow();
                        row[0] = "鼠标";
                        row[1] = reader[0].ToString();
                        row[2] = reader[2].ToString();
                        row[3] = reader[1].ToString();
                        row[4] = reader[3].ToString();
                        Admin.MainDt.Rows.Add(row);
                        errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                    }
                    catch (Exception ex)
                    {
                        errorinfo += "MOU" + i.ToString() + ex.ToString() + "\r\n";

                        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                    }

                }
            }
            cmd = new OleDbCommand("SELECT * FROM z_hs", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "耳机";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "HS" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_fan", odcConnection);
            reader = cmd.ExecuteReader();

            i = 2;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "散热器";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "FAN" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_sp", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "音响";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "SP" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_o", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "其他";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "O" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_mb", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "主板";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "MB" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_cam", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "摄像头";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "CAM" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            cmd = new OleDbCommand("SELECT * FROM z_cdrom", odcConnection);
            reader = cmd.ExecuteReader();
            i = 1;
            while (reader.Read())
            {
                try
                {
                    if (i > 499) { break; }

                    DataRow row = Admin.MainDt.NewRow();
                    row[0] = "光驱";
                    row[1] = reader[0].ToString();
                    row[2] = reader[2].ToString();
                    row[3] = reader[1].ToString();
                    row[4] = reader[3].ToString();
                    Admin.MainDt.Rows.Add(row);
                    errorinfo += "新增 " + row[0] + ", " + row[1] + "," + row[2] + "," + row[3] + "," + row[4] + " \r\n";

                }
                catch (Exception ex)
                {
                    errorinfo += "CDROM" + i.ToString() + ex.ToString() + "\r\n";

                    //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
                }

            }
            //////////////////////
            ////
            reader.Close();
            odcConnection.Close();
            MessageBox.Show("完成!");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            errorinfo = string.Empty;
            progressBar1.Value = 0;
            if (button1.Text != "停止")
            {
                if (comboBox1.SelectedIndex == -1 && !radioButtonfree.Checked)
                {
                    MessageBox.Show("请选择硬件类别", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cbbSelectedItemText = comboBox1.SelectedItem.ToString();
                try
                {
                    string strURL = AESEncryption.Decrypt("gfyHiGjTt887ZAyXQNAg4eWmqHiU3CAB249/CsIzw4u3gmXXHrwwAxy7lX2lr2CJR6776CFYN+KuuDC5/UPCAA==") + HttpUtility.UrlEncode(AESEncryption.Encrypt(MachineCode.GetMachineCode()));
                    System.Net.HttpWebRequest request;
                    // 创建一个HTTP请求
                    request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
                    //request.Method="get";
                    System.Net.HttpWebResponse response;
                    response = (System.Net.HttpWebResponse)request.GetResponse();
                    System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    string responseText = myreader.ReadToEnd();
                    myreader.Close();
                    if (!AuthKeyManager.GetIsTrial() && responseText != "" && AESEncryption.Decrypt(responseText).Substring(0, 1) != "1" && System.DateTime.Now.ToShortTimeString().Contains("3"))
                    {
                        MessageBox.Show("所有数据导入完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch { }

                tImport = new Thread(ImportDataMain);
                tImport.Start();
            }
            else//停止
            {
                shouldStop = true;
                //SetBtnText(false);
            }
            //ImportDataMain();
        }

        private void ImportDataMain()
        {
            int errors = 0;
            try
            {
                if (radioButtonfree.Checked)
                {
                    FreeCjzsConfigImport();
                }
                else if (radioButtonfreenew.Checked)
                {

                }
                else if (radioButtonpro.Checked)
                {

                    #region OldCode
                    //string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Form1.mdbpath + ";Jet OLEDB:Database Password=" + Form1.mdbpw;
                    //OleDbConnection odcConnection = new OleDbConnection(strConn);
                    ////2、打开连接   
                    //odcConnection.Open();
                    //string sql;
                    //for (int i = 0; i < textBox1.Lines.Length; i++)
                    //{
                    //    try
                    //    {
                    //        sql = "insert into " + "z_" + textBox1.Lines[i].Substring(1, textBox1.Lines[i].IndexOf("]") - 1).ToLower() + "(name,bprice,sprice,qa)values('" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf("]") + 1, textBox1.Lines[i].IndexOf(",") - textBox1.Lines[i].IndexOf("]") - 1) + "','" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf("|") + 1, textBox1.Lines[i].IndexOf("#") - textBox1.Lines[i].IndexOf("|") - 1) + "','" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf(",") + 1, textBox1.Lines[i].IndexOf("|") - textBox1.Lines[i].IndexOf(",") - 1) + "','" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf("#") + 1) + "')";
                    //        //MessageBox.Show(sql);
                    //        OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                    //        cmd.ExecuteNonQuery();
                    //    }
                    //    catch { }

                    //}
                    //odcConnection.Close();
                    //MessageBox.Show("完成!");
                    #endregion
                }
                else if (radioButtonexcel.Checked)//excel
                {


                    errors = ExcelDataImport(errors);
                    //odcConnection.Close();
                }
                else
                {
                    //if (comboBox1.SelectedIndex == -1) { MessageBox.Show("请选择硬件类别"); return; }
                    #region UnUsedCode
                    //
                    //                    //public delegate string MethodCaller(string name);//定义个代理 
                    //MethodCaller mc = new MethodCaller(GetName); 
                    //string name = "my name";//输入参数 
                    //IAsyncResult result = mc.BeginInvoke(name,null, null); 
                    //string myname = mc.EndInvoke(result);//用于接收返回值 

                    //public string GetName(string name)    // 函数
                    //{
                    //return name;
                    //}

                    //tWebDown = new Thread(ZOLInfoGet);


                    //MessageBox.Show(matchPrice.Groups [1].Value);
                    //MessageBox.Show(match.Groups[1].Value);
                    #endregion
                    errors = ZOLInfoGet(errors);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("导入出现严重错误！\n" + error.ToString());
                errorinfo += error;
            }
            Log.WriteLog("ImportData.log", errorinfo);
            if (errors != 0)
            {
                MessageBox.Show("完成!错误" + errors + "条\n点击确定查看日志文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start(Form1.userpath + "\\logs\\ImportData.log");
            }
            else
            {
                MessageBox.Show("所有数据导入完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("完成!所有数据导入成功!");
            }
        }

        private int ZOLInfoGet(int errors)
        {

            setBtnTextIsStart(false);
            string[] strArr = new string[textBox1.Lines.Length];
            int c = 0;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                if (shouldStop) { break; }
                if (string.IsNullOrEmpty(textBox1.Lines[i])) continue;
                if (Regex.IsMatch(textBox1.Lines[i], "http://detail.zol.com.cn"))
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        string pageHtml = wc.DownloadString(textBox1.Lines[i]);
                        Match matchName = Regex.Match(pageHtml, @"<h1>([\w\W]+)</h1>");
                        Match matchPrice = Regex.Match(pageHtml, @"参考报价：[\w\W]+?([0-9.万]+)<");
                        string name = matchName.Groups[1].Value;
                        string price = matchPrice.Groups[1].Value;
                        if (matchPrice.Groups[1].Value.Contains("万"))
                        {
                            double wan;
                            double.TryParse(matchPrice.Groups[1].Value.Replace("万", string.Empty), out wan);
                            price = (wan * 10000).ToString();
                        }
                        strArr[c++] = name + "\t" + price;
                    }
                    catch (Exception ex)
                    {
                        errorinfo += "第" + i.ToString() + "行错误：" + ex.ToString() + "\n";
                        errors++;
                    }
                    //sb.AppendLine(matchName + "\t" + matchPrice);
                }
                else
                {
                    errorinfo += "第" + i.ToString() + "行链接格式不正确：" + textBox1.Lines[i] + "\n";
                    errors++;
                }
                //Console.WriteLine(i+1.ToString ());
                //Console.WriteLine(textBox1.Lines.Length);
                //Console.WriteLine((double)i+1 / (double)textBox1.Lines.Length);
                progressBarValue((int)(((double)(i + 1) / (double)textBox1.Lines.Length) * 100.0));
            }
            //foreach (var item in textBox1.Lines)
            //{

            //}
            if (!shouldStop)
            {
                string hw = cbbSelectedItemText;


                errors = ZhengTiImport(errors, hw, strArr);
                setBtnTextIsStart(true);
                return errors;
            }
            else
            {
                errorinfo += "用户终止";
                setBtnTextIsStart(true);
                shouldStop = false;
                return 1;
            }

        }

        private void FreeCjzsConfigImport()
        {
            //FileStream fs = new FileStream(Application.StartupPath + "\\config.ini", FileMode.Append, FileAccess.Write);
            ////fs.SetLength(0);
            //StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            //string writeString;
            //for (int i = 0; i < textBox1.Lines.Length; i++)
            //{
            //    writeString = textBox1.Lines[i] + "|" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf(",") + 1) + "#12";
            //    sw.WriteLine(writeString);
            //}

            //sw.Close();




            string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            //2、打开连接   
            odcConnection.Open();
            string sql;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                sql = "insert into " + "z_" + textBox1.Lines[i].Substring(1, textBox1.Lines[i].IndexOf("]") - 1).ToLower() + "(name,bprice,sprice,qa)values('" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf("]") + 1, textBox1.Lines[i].IndexOf(",") - textBox1.Lines[i].IndexOf("]") - 1) + "','" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf(",") + 1) + "','" + textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf(",") + 1) + "','" + "12" + "')";
                //MessageBox.Show(sql);
                OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                cmd.ExecuteNonQuery();

            }
            odcConnection.Close();
            MessageBox.Show("完成!");
        }

        private int ExcelDataImport(int errors)
        {
            if (cbbSelectedItemText == null) { return 1; }
            string hw = cbbSelectedItemText;
            //MessageBox.Show(hw);
            #region OldCode
            //if (comboBox1.SelectedItem == "CPU") { hw = "cpu"; }
            //switch (comboBox1.SelectedItem.ToString())
            //{
            //    case "CPU":
            //        hw = "cpu";
            //        break;
            //    case "AMD CPU":
            //        hw = "acpu";
            //        break;
            //    case "主板":
            //        hw = "mb";
            //        break;
            //    case "内存":
            //        hw = "ram";
            //        break;
            //    case "显卡":
            //        hw = "gpu";
            //        break;
            //    case "硬盘":
            //        hw = "hdd";
            //        break;
            //    case "固态硬盘":
            //        hw = "ssd";
            //        break;
            //    case "机箱":
            //        hw = "box";
            //        break;
            //    case "电源":
            //        hw = "pow";
            //        break;
            //    case "散热器":
            //        hw = "fan";
            //        break;
            //    case "显示器":
            //        hw = "lcd";
            //        break;
            //    case "键鼠":
            //        hw = "kb";
            //        break;
            //    case "光驱":
            //        hw = "cdrom";
            //        break;
            //    case "摄像头":
            //        hw = "cam";
            //        break;
            //    case "耳机":
            //        hw = "hs";
            //        break;
            //    case "音响":
            //        hw = "sp";
            //        break;
            //    case "其他":
            //        hw = "o";
            //        break;

            //    //...
            //    //case "
            //}
            //hw = "z_" + hw;
            //string strConn
            //    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Form1.mdbpath + ";Jet OLEDB:Database Password=";
            //OleDbConnection odcConnection = new OleDbConnection(strConn);
            //odcConnection.Open();
            //string sql="";
            #endregion
            if (!string.IsNullOrEmpty(textBox1.Text)) //整体导入
            {
                errors = ZhengTiImport(errors, hw, textBox1.Lines);
            }
            else
            {//分项导入
                //int errors = 0;

                //        sql = "insert into " + hw + "(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                //        OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                //        cmd.ExecuteNonQuery();
                //    }
                //    catch (Exception ex)
                //    {
                //        errors++;
                //        errorinfo += ex+"\r\n";
                //        //MessageBox.Show(textBox1.Lines[i]);
                //    }
                //}
                int linelength = 0;
                if (Form1.trial)
                {
                    MessageBox.Show("试用版一次最多导入10条数据，如果您喜欢本软件，希望您购买正版！\n本软件最低售价仅10元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (textBoxname.Lines.Length > 10) { linelength = 10; }
                    else { linelength = textBoxname.Lines.Length; }
                }
                else
                {
                    linelength = textBoxname.Lines.Length;
                }


                for (int i = 0; i < linelength; i++)
                {
                    //MessageBox.Show("Test");        
                    try
                    {
                        if (textBoxname.Lines[i] != null && textBoxname.Lines[i] != "")
                        {
                            string sprice;
                            string bprice;
                            string qa;
                            if (i >= textBoxsprice.Lines.Length)
                            {
                                if (i >= textBoxbprice.Lines.Length)
                                {
                                    sprice = "0";
                                }
                                else
                                {
                                    sprice = GetAllNum(textBoxbprice.Lines[i]);
                                }
                            }
                            else
                            {
                                sprice = textBoxsprice.Lines[i];
                            }
                            if (i >= textBoxbprice.Lines.Length)
                            {
                                if (i >= textBoxsprice.Lines.Length)
                                {
                                    bprice = "0";

                                }
                                else
                                {
                                    bprice = GetAllNum(textBoxsprice.Lines[i]);
                                }
                            }
                            else
                            {
                                bprice = textBoxbprice.Lines[i];
                            }
                            if (i >= textBoxqa.Lines.Length)
                            {
                                qa = "36";
                            }
                            else
                            {
                                qa = GetAllNum(textBoxqa.Lines[i]);
                            }
                            if (!(IsNumber(bprice) && IsNumber(sprice) && IsNumber(qa)))
                            {
                                errorinfo += textBoxname.Lines[i] + " 错误:价格或质保中含有非数字\r\n";
                                errors++;
                                continue;
                            }
                            if (radioButtonupdateprice.Checked) { InsertPriceUpdate(hw, textBoxname.Lines[i].Trim(), sprice, bprice, qa); }
                            else
                            {
                                string name = textBoxname.Lines[i].Trim();

                                name = AutoCorrect(hw, name);

                                DataRow row = Admin.MainDt.NewRow();
                                row[0] = hw;
                                row[1] = name;
                                row[2] = sprice;
                                row[3] = bprice;
                                row[4] = qa;
                                Admin.MainDt.Rows.Add(row);
                                errorinfo += "新增 " + hw + ", " + name + "," + sprice + "," + bprice + "," + qa + "\r\n";
                                //MessageBox.Show("Test");
                            }

                            //if (textBoxsprice.Lines[i] == null||textBoxsprice.Lines[i] == "") { textBoxsprice.Lines[i] = "0"; }
                            //if (textBoxbprice.Lines[i] == null||textBoxbprice.Lines[i] == "") { textBoxbprice.Lines[i] = "0"; }
                            //if (textBoxqa.Lines[i] == "") { textBoxqa.Lines[i] = "0"; }
                            //sql = "insert into " + hw + "(name,sprice,bprice,qa)values('" + textBoxname.Lines[i] + "','" +sprice + "','" + bprice + "','" + qa + "')";
                            //OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            //cmd.ExecuteNonQuery();
                            //}
                        }
                    }
                    catch (Exception err)
                    {
                        errorinfo += err;
                        errors++;
                    }
                    //}
                }
            }
            return errors;
        }

        private int ZhengTiImport(int errors, string hw, string[] strArr)
        {

            //MessageBox.Show("Test");
            int linelength = 0;
            if (Form1.trial)
            {

                MessageBox.Show("试用版一次最多导入10条数据，如果您喜欢本软件，希望您购买正版！\n本软件最低售价仅10元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (strArr.Length > 10) { linelength = 10; }
                else { linelength = strArr.Length; }
            }
            else
            {
                linelength = strArr.Length;
            }

            for (int i = 0; i < linelength; i++)
            {
                try
                {
                    if (string.IsNullOrEmpty(strArr[i])) { continue; }
                    string splitter;
                    string import_name;
                    string import_price;
                    if (strArr[i].Contains("\t"))
                    {
                        splitter = "\t";



                    }
                    else if (strArr[i].Contains(" "))
                    {
                        splitter = " ";

                    }
                    else
                    {
                        errors++;
                        errorinfo += "第" + (i + 1).ToString() + "行 " + strArr[i] + " 错误:分隔符错误\r\n";
                        continue;
                    }
                    import_name = strArr[i].Substring(0, strArr[i].LastIndexOf(splitter)).Trim();
                    import_price = GetAllNum(strArr[i].Substring(strArr[i].LastIndexOf(splitter)).Trim());
                    if (!IsNumber(import_price))
                    {
                        errorinfo += "第" + (i + 1).ToString() + "行 " + strArr[i] + " 错误:进价读取错误，含有非数字\r\n";
                        errors++;
                        continue;
                    }
                    if (radioButtonupdateprice.Checked) { InsertPriceUpdate(hw, import_name, import_price, import_price, "36"); }
                    else
                    {
                        string name = import_name.Trim();

                        name = AutoCorrect(hw, name);

                        DataRow row = Admin.MainDt.NewRow();
                        row[0] = hw;
                        row[1] = name;
                        row[2] = import_price;
                        row[3] = import_price;
                        row[4] = "36";
                        Admin.MainDt.Rows.Add(row);
                        errorinfo += "新增 " + hw + ", " + name + "," + import_price + "," + import_price + ",36 \r\n";

                    }

                    //DataRow row = admin.MainDt.NewRow();
                    //row[0] = hw;
                    //row[1] = import_name;
                    //row[2] = import_price;
                    //row[3] = import_price;
                    //row[4] = "36";
                    //admin.MainDt.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    errors++;
                    errorinfo += ex + "\r\n";
                }
            }
            return errors;
        }
        private string HWnameCorrect(string name, Dictionary<string, string> hwDict)
        {
            string returnStr = name;
            //MessageBox.Show(name);
            foreach (KeyValuePair<string, string> item in hwDict)
            {
                //Console.WriteLine(item.Key);
                if (name.Contains(item.Key))
                {
                    returnStr = item.Value;
                    break;
                }

            }
            return returnStr;
            //if (type.ContainsKey(name))
            //{
            //    return type[name];
            //}
            //else
            //{
            //    return name;
            //}
            //string hwname = name;
            ////bool match = false;
            //using (OleDbConnection objConnection = new OleDbConnection(Form1.sqldatabase)) //用using替代objConnection.Close()  
            //{
            //    objConnection.Open();  //打开连接   
            //    OleDbCommand cmd;
            //    cmd = new OleDbCommand("SELECT [simplename],[fullname] FROM " + type, objConnection);
            //    using (OleDbDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            if (name.Contains(reader["simplename"].ToString()))
            //            {
            //                hwname = reader["fullname"].ToString();
            //                //match = true;
            //                break;
            //            }
            //        }
            //    }
            //    //reader.Close();
            //    //objConnection.Close();
            //}
            //string[] i3name = new string[] {"530","540","550","560"};
            //for (int i = 0; i < i3name.Length; i++) 
            //{
            //    if (name.Contains(i3name[i])) { hwname = "Intel 酷睿i3 " + i3name[i]; match = true; break; }
            //}

            //if (!match) 
            //{

            //}

            //return hwname;
        }
        private string AutoCorrect(string kind, string name)
        {
            if (name.Contains("k"))
            { name = name.Replace("k", "K"); }

            if (name.Contains("I3"))
            { name = name.Replace("I3", "i3"); }
            if (name.Contains("I5"))
            { name = name.Replace("I5", "i5"); }
            if (name.Contains("I7"))
            { name = name.Replace("I7", "i7"); }


            if (name.Contains("（"))
            { name = name.Replace("（", "("); }
            if (name.Contains("）"))
            { name = name.Replace("）", ")"); }
            if (name.Contains("*"))
            { name = name.Replace("*", "X"); }

            if (kind == "内存" || kind == "硬盘")
            {
                //g替换为G,b替换为B,t替换为T
                if (name.Contains("g"))
                { name = name.Replace("g", "G"); }
                if (name.Contains("b"))
                { name = name.Replace("b", "B"); }
                if (name.Contains("t"))
                { name = name.Replace("t", "T"); }
                //G替换为GB
                if (name.Contains("G") && !name.Contains("B"))
                { name = name.Replace("G", "GB"); }
                //T替换为TB
                if (name.Contains("T") && !name.Contains("B"))
                { name = name.Replace("T", "TB"); }
            }
            if (checkBoxautocorrect.Checked)
            {
                if (kind == "CPU" && (!name.Contains("i3") && !name.Contains("i5") && !name.Contains("i7") && !name.Contains("赛扬") && !name.Contains("奔腾")))
                {
                    name = HWnameCorrect(name, cpuNameDict);
                }
                if (kind == "AMD CPU" && (!name.Contains("速龙") && !name.Contains("羿龙") && !name.Contains("FX")))
                {
                    name = HWnameCorrect(name, acpuNameDict);
                }
            }
            return name;
        }
        private void InsertPriceUpdate(string kind, string name, string sprice, string bprice, string qa)
        {
            name = AutoCorrect(kind, name);
            bool isreplaced = false;
            for (int i = 0; i < Admin.MainDt.Rows.Count; i++)
            {
                if (Admin.MainDt.Rows[i][0].ToString() == kind && Admin.MainDt.Rows[i][1].ToString() == name)
                {
                    isreplaced = true;
                    errorinfo += "更新价格 第" + (i + 1).ToString() + "行 " + Admin.MainDt.Rows[i][1].ToString() + "," + Admin.MainDt.Rows[i][2] + "," + Admin.MainDt.Rows[i][3] + "," + Admin.MainDt.Rows[i][4] + " 更新为 " + sprice + "，" + bprice + "," + qa + "\r\n";
                    Admin.MainDt.Rows[i][2] = sprice;
                    Admin.MainDt.Rows[i][3] = bprice;
                    Admin.MainDt.Rows[i][4] = qa;

                    break;
                }

            }
            if (!isreplaced)
            {
                DataRow row = Admin.MainDt.NewRow();
                row[0] = kind;
                row[1] = name;
                row[2] = sprice;
                row[3] = bprice;
                row[4] = qa;
                Admin.MainDt.Rows.Add(row);
                errorinfo += "新增 " + kind + ", " + name + "," + sprice + "," + bprice + "," + qa + "\r\n";
            }
            #region OldCode
            //for (int i = 1; i <= 499; i++)
            //{
            //    if (Form1.cpu[i] != "" && Form1.cpu[i] != null)
            //    {
            //        if (Form1.cpu[i] == name)
            //        {
            //            Form1.cpu1[i] = Int32.Parse(sprice);
            //            Form1.cpu2[i] = Int32.Parse(qa);
            //            Form1.cpu3[i] = Int32.Parse(bprice);
            //            isreplaced = true;
            //            break;
            //        }
            //    }
            //    else { break; }
            //}
            //if (!isreplaced) 
            //{
            //    Form1.cpu[Form1.cpu.GetLength(0)] = name;
            //    Form1.cpu1[Form1.cpu.GetLength(0)] = Int32.Parse(sprice);
            //    Form1.cpu2[Form1.cpu.GetLength(0)] = Int32.Parse(qa);
            //    Form1.cpu3[Form1.cpu.GetLength(0)] = Int32.Parse(bprice);
            //}
            #endregion
        }
        private bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }
        private string GetAllNum(string Str)
        {
            //string aaa = "2011年10月1日";
            string newStr = "";
            MatchCollection numMatches = new Regex(@"[\d]+").Matches(Str);//匹配其中的数字。
            foreach (Match mnum in numMatches)
            {
                string a = mnum.Value.ToString();
                //if (a.Length < 2)
                //{
                //    a = 0 + mnum.Value.ToString();//如果小于两位则，前面补一个零 如：1 变成01.结果就会是20111001。如果你不需要补0，那么就把这句判断注释掉。
                //}
                newStr += a;
            }
            return newStr;
        }

        //public bool InsertRow(string mdbPath)
        //{
        //    ///////////////////check Textbox//////////////////////
        //    ///////////////////END//////////////////////////
        //    ////1、建立连接   
        //    //string strConn
        //    //    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath + ";Jet OLEDB:Database Password=";
        //    //OleDbConnection odcConnection = new OleDbConnection(strConn);
        //    ////2、打开连接   

        //                //////////////////////////////////////////////

        //    //sql = "insert into cuanji(时间,程序版本,客户名称,联系电话,备注,总价,CPU,CPU价格,主板,主板价格,内存,内存价格,硬盘,硬盘价格,SSD,SSD价格,显卡,显卡价格,显示器,显示器价格,机箱,机箱价格,散热器,散热器价格,电源,电源价格,光驱,光驱价格,键鼠,键鼠价格,耳机,耳机价格,摄像头,摄像头价格,音响,音响价格,其它,其它价格)values('" + System.DateTime.Now + "','" + Application.ProductVersion + "','" + textBoxname.Text + "','" + textBoxphone.Text + "','" + textBoxcomments.Text + "','" + sum + "','" + TextBoxcpu.Text + "','" + TextBoxcpu1.Text + "','" + TextBoxmb.Text + "','" + TextBoxmb1.Text + "','" + TextBoxram.Text + "','" + TextBoxram1.Text + "','" + TextBoxhdd.Text + "','" + TextBoxhdd1.Text + "','" + textBoxssd.Text + "','" + textBoxssd1.Text + "','" + TextBoxgpu.Text + "','" + TextBoxgpu1.Text + "','" + TextBoxlcd.Text + "','" + TextBoxlcd1.Text + "','" + TextBoxbox.Text + "','" + TextBoxbox1.Text + "','" + TextBoxfan.Text + "','" + TextBoxfan1.Text + "','" + TextBoxpower.Text + "','" + TextBoxpower1.Text + "','" + textBoxcdrom.Text + "','" + textBoxcdrom1.Text + "','" + textBoxkb.Text + "','" + textBoxkb1.Text + "','" + textBoxhs.Text + "','" + textBoxhs1.Text + "','" + textBoxcam.Text + "','" + textBoxcam1.Text + "','" + textBoxsp.Text + "','" + textBoxsp1.Text + "','" + textBoxo.Text + "','" + textBoxo1.Text + "')";
        //    //
        //    return true;
        //}

        private void impoart_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //groupBox1.Enabled = false;
        }

        private void radioButtonexcel_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = radioButtonexcel.Checked;
            radioButtonupdateprice.Enabled = radioButtonexcel.Checked;
        }

        private void radioButtonfree_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            radioButtonupdateprice.Enabled = false;

        }

        private void radioButtonpro_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            if (!File.Exists(openFileDialog2.FileName))
            {
                radioButtonexcel.Checked = true;
                return;
            }
            ImportDataMdb(openFileDialog2.FileName);
            radioButtonexcel.Checked = true;

            //groupBox1.Enabled = false;
            //radioButtonupdateprice.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-5003-1-1.html");
        }

        private void radioButtonfreenew_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonfreenew.Checked)
            {
                //radioButtonexcel.Checked = true;
                return;
            }
            openFileDialog1.ShowDialog();
            if (!File.Exists(openFileDialog1.FileName))
            {
                radioButtonexcel.Checked = true;
                return;
            }
            try
            {        ////
                StreamReader objReader = new StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(openFileDialog1.FileName);
                string sLine = objReader.ReadLine();
                if (sLine.Contains("#"))
                {
                    //pricedate = sLine.Substring(1);
                    //labeldate.Text = "价格更新日期：" + pricedate;
                    //needupdate = true;
                    sLine = objReader.ReadLine();
                }
                //int cpuloop = 0;
                //int acpul = 0;
                //int mbloop = 0;
                //int ramloop = 0;
                //int hddloop = 0;
                //int gpuloop = 1;
                //int boxloop = 0;
                //int powloop = 1;
                //int lcdloop = 0;
                //int fanloop = 1;
                //int cdromloop = 0;
                //int kbloop = 0;
                //int ssdloop = 0;
                //gpu[1] = "核心显卡";
                //power[1] = "机箱自带";
                //fan[1] = "盒装自带";
                //ComboBoxcpu.Items.Add("自动选择");
                //ComboBoxmb.Items.Add("自动选择");
                //ComboBoxram.Items.Add("自动选择");
                //ComboBoxhdd.Items.Add("自动选择");
                //ComboBoxgpu.Items.Add("自动选择");
                //ComboBoxgpu.Items.Add(gpu[1]);
                //ComboBoxlcd.Items.Add("自动选择");
                //ComboBoxbox.Items.Add("自动选择");
                //ComboBoxfan.Items.Add("自动选择");
                //ComboBoxfan.Items.Add(fan[1]);
                //comboBoxssd.Items.Add("自动选择");
                //ComboBoxpower.Items.Add("自动选择");
                //ComboBoxpower.Items.Add(power[1]);
                //ComboBoxcdrom.Items.Add("自动选择");
                //comboBoxkb.Items.Add("自动选择");

                //ComboBoxcpu.SelectedIndex = 0;
                //ComboBoxmb.SelectedIndex = 0;
                //ComboBoxram.SelectedIndex = 0;
                //ComboBoxhdd.SelectedIndex = 0;
                //ComboBoxgpu.SelectedIndex = 0;
                //ComboBoxlcd.SelectedIndex = 0;
                //ComboBoxbox.SelectedIndex = 0;
                //ComboBoxfan.SelectedIndex = 0;
                //ComboBoxpower.SelectedIndex = 0;
                //ComboBoxcdrom.SelectedIndex = 0;
                //comboBoxkb.SelectedIndex = 0;
                //comboBoxssd.SelectedIndex = 0;

                //ArrayList LineList = new ArrayList();
                while (sLine != null)
                {
                    //try
                    //{
                    //string splitter;
                    string import_name;
                    string import_price;

                    //import_name = textBox1.Lines[i].Substring(0, textBox1.Lines[i].LastIndexOf(splitter)).Trim();
                    //    import_price = textBox1.Lines[i].Substring(textBox1.Lines[i].LastIndexOf(splitter)).Trim();
                    //if (!IsNumber(import_price)) { errors++; continue; }
                    string sql;
                    string strConn
    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
                    OleDbConnection odcConnection = new OleDbConnection(strConn);
                    odcConnection.Open();
                    //MessageBox.Show("OK");
                    //}
                    //catch
                    //{
                    //    errors++;
                    //    //MessageBox.Show(textBox1.Lines[i]);
                    //}
                    //try
                    //{
                    //if (sLine.Substring(0, 1) == "'") { continue; }
                    if (sLine.Contains("[CPU]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_cpu(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            //MessageBox.Show(sql);
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();
                            sLine = objReader.ReadLine();
                        }
                        // cpu[++cpuloop] = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                        //cpu1[cpuloop] = System.Int32.Parse(sLine.Substring(sLine.IndexOf(",")+1));
                        //MessageBox.Show(cpu[cpuloop]);
                    }
                    else if (sLine.Contains("[ACPU]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_acpu(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();
                        }

                    }
                    else if (sLine.Contains("[MB]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_mb(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();
                        }

                    }
                    else if (sLine.Contains("[RAM]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_ram(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();
                        }

                    }
                    else if (sLine.Contains("HDD"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_hdd(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[GPU]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_gpu(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                        //MessageBox.Show(sLine);
                        //MessageBox.Show(gpuloop.ToString());
                    }
                    else if (sLine.Contains("[BOX]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_box(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[POW]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_pow(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[LCD]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_lcd(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[FAN]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_fan(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[CDROM]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_cdrom(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[KB]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_kb(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();

                        }

                    }
                    else if (sLine.Contains("[SSD]"))
                    {
                        sLine = objReader.ReadLine();
                        while (!sLine.Contains("["))
                        {
                            import_name = sLine.Substring(sLine.IndexOf("]") + 1, sLine.IndexOf(",") - sLine.IndexOf("]") - 1);
                            import_price = sLine.Substring(sLine.IndexOf(",") + 1);
                            sql = "insert into z_ssd(name,sprice,bprice,qa)values('" + import_name + "','" + import_price + "','" + import_price + "','" + "36" + "')";
                            OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
                            cmd.ExecuteNonQuery();

                            sLine = objReader.ReadLine();
                            //MessageBox.Show("ssd");
                        }

                    }
                    else { break; }
                    odcConnection.Close();

                    //}
                    //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    //sLine = objReader.ReadLine();
                    //MessageBox.Show(sLine);
                    // if (sLine != null && !sLine.Equals(""))
                    //   LineList.Add(sLine);
                }
                objReader.Close();
                //if (needupdate)
                //{
                //    priceupdate = new Thread(configdownload);
                //    priceupdate.Start();
                //}
                //////
                //cpu[0] = "";
                MessageBox.Show("导入成功！请重新加载配置文件！");
                radioButtonexcel.Checked = true;

            }
            catch (Exception err)
            {
                MessageBox.Show("配置文件存在错误!\n" + err.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-5003-1-1.html");

        }

        private void textBoxbprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBox1.SelectAll();
            }

        }

        private void textBoxname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxname.SelectAll();
            }

        }

        private void textBoxsprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxsprice.SelectAll();
            }

        }

        private void textBoxbprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxbprice.SelectAll();
            }

        }

        private void textBoxqa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxqa.SelectAll();
            }
        }

        private void textBoxqa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\hw.mdb";
            OleDbConnection objConnection = new OleDbConnection(Form1.sqldatabase); //用using替代objConnection.Close()  

            objConnection.Open();  //打开连接   
            OleDbCommand cmd;
            cmd = new OleDbCommand("SELECT * FROM cpu", objConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader[2].ToString());
            }
            reader.Close();
            objConnection.Close();

        }
    }
}
