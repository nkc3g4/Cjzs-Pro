using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace 攒机助手专业版
{
    public partial class Settings : Form
    {
      
        List<HardWareKind> comboBoxHw;
        public Settings()
        {
            /* 
             机箱
电源
光驱
键盘
鼠标
耳机
摄像头
音响
内存
硬盘
固态硬盘
             */
            InitializeComponent();
            comboBoxHw = new List<HardWareKind>();
            comboBoxHw.Add(SData.hwBox);
            comboBoxHw.Add(SData.hwPower);

            comboBoxHw.Add(SData.hwCdrom);
            comboBoxHw.Add(SData.hwKb);
            comboBoxHw.Add(SData.hwMou);
            comboBoxHw.Add(SData.hwHs);
            comboBoxHw.Add(SData.hwCam);
            comboBoxHw.Add(SData.hwSp);
            comboBoxHw.Add(SData.hwRam);
            comboBoxHw.Add(SData.hwHdd);
            comboBoxHw.Add(SData.hwSsd);
          

            comboBox1.DataSource = comboBoxHw;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //SettingItems si = new SettingItems();
            //si.PrintMode = SettingItems.ModeEnum.Doc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingItems.MdbPath = textBox1.Text;
            SettingItems.MdbPw = textBoxmdbpw.Text;
            SettingItems.WriteIni();
        
            this.Close();

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(SettingItems.PrintCol1Txt))
            {
                txtCol1.Text = SettingItems.PrintCol1Txt;
            }
            if (!string.IsNullOrEmpty(SettingItems.PrintCol2Txt))
            {
                txtCol1.Text = SettingItems.PrintCol2Txt;
            }
            if (!string.IsNullOrEmpty(SettingItems.PrintCol3Txt))
            {
                txtCol1.Text = SettingItems.PrintCol3Txt;
            }
            if (!string.IsNullOrEmpty(SettingItems.PrintCol4Txt))
            {
                txtCol1.Text = SettingItems.PrintCol4Txt;
            }
            if (!string.IsNullOrEmpty(SettingItems.PrintCol5Txt))
            {
                txtCol1.Text = SettingItems.PrintCol5Txt;
            }
            

            checkBoxhidead.Checked = !SettingItems.ShowAd;
            checkBoxautoupdate.Checked = SettingItems.AutoUpdate;
        
            radioButtonprintrich.Checked = (SettingItems.PrintMode == SettingItems.ModeEnum.Doc);
            radioButtonprinttext.Checked = (SettingItems.PrintMode == SettingItems.ModeEnum.Txt);
            radioButtonsaverich.Checked = (SettingItems.SaveMode == SettingItems.ModeEnum.Doc);
            radioButtonsavetext.Checked = (SettingItems.SaveMode == SettingItems.ModeEnum.Txt);
            if (SettingItems.ShowBbs) { checkBoxbbs.Checked = true; }
            else checkBoxbbs.Checked = false;
            if (SettingItems.CostPrice == SettingItems.CostPriceEnum.成本)
            {
                checkBoxcostprice.Checked = true;
                radioButtonchengben.Checked = true;
            }
            else if (SettingItems.CostPrice == SettingItems.CostPriceEnum.利润)
            {

                checkBoxcostprice.Checked = true;
                radioButtonlirun.Checked = true;

            }
            else if (SettingItems.CostPrice == SettingItems.CostPriceEnum.利润率)
            {
                checkBoxcostprice.Checked = true;
                radioButtonlirunlv.Checked = true;
            }
            else
            {
                checkBoxcostprice.Checked = false;
                radioButtonchengben.Enabled = false;
                radioButtonlirun.Enabled = false;
                radioButtonlirunlv.Enabled = false;

            }
            comboBox1.SelectedIndex = 0;
         
            textBox1.Text = SettingItems.MdbPath;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName)) { textBox1.Text = openFileDialog1.FileName; }
        }

        private void checkBoxhidead_CheckedChanged(object sender, EventArgs e)
        {
            if (Form1.trial && checkBoxhidead.Checked)
            {
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请联系作者购买！\nQQ:1409231794", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxhidead.Checked = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-9466-1-1.html");

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcostprice.Checked)
            {
                radioButtonchengben.Enabled = true;
                radioButtonlirun.Enabled = true;
                radioButtonlirunlv.Enabled = true;

            }
            else
            {
                radioButtonchengben.Enabled = false;
                radioButtonlirun.Enabled = false;
                radioButtonlirunlv.Enabled = false;
                SettingItems.CostPrice = SettingItems.CostPriceEnum.不显示;
            }
        }

        private void textBoxp12_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxp21.Text = textBoxp12.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString ());
            /*
             * 机箱
电源
光驱
键盘
鼠标
耳机
摄像头
音响*/
            ReadCustomRatio(((HardWareKind)comboBox1.SelectedItem).CuanJiPofile);
         

        }
        private void ReadCustomRatio(CuanJiPofileStruct cjp)
        {
            textBoxp11.Text = "0";

            textBoxp12.Text = cjp.P1.ToString();
            textBoxp21.Text = textBoxp12.Text;
            textBoxp22.Text = cjp.P2.ToString();
            textBoxp31.Text = textBoxp22.Text;
            textBoxp32.Text = cjp.P3.ToString();
            textBoxp41.Text = textBoxp32.Text;
            textBoxp42.Text = "999999";
            textBoxk1.Text = cjp.K1.ToString();
            textBoxk2.Text = cjp.K2.ToString();
            textBoxk3.Text = cjp.K3.ToString();
            textBoxk4.Text = cjp.K4.ToString();
            textBoxr1.Text = cjp.RG1;
            textBoxr2.Text = cjp.RG2;
            textBoxr3.Text = cjp.RG3;
            textBoxr4.Text = cjp.RG4;


        }
        private void WriteCustomRatio(string kind)
        {
            IniFile.WriteVal(kind, "P1", textBoxp12.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "P2", textBoxp22.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "P3", textBoxp32.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "K1", textBoxk1.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "K2", textBoxk2.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "K3", textBoxk3.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "K4", textBoxk4.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "R1", textBoxr1.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "R2", textBoxr2.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "R3", textBoxr3.Text, Form1.settingsIni);
            IniFile.WriteVal(kind, "R4", textBoxr4.Text, Form1.settingsIni);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*
             * 机箱
                电源
                光驱
                键盘
                鼠标
                耳机
                摄像头
                音响*/
            if (comboBox1.SelectedIndex == 0)
            {
                WriteCustomRatio("Box");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                WriteCustomRatio("Power");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                WriteCustomRatio("Cdrom");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                WriteCustomRatio("Kb");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                WriteCustomRatio("Mou");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                WriteCustomRatio("Hs");
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                WriteCustomRatio("Cam");
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                WriteCustomRatio("Sp");
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                WriteCustomRatio("Ram");
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                WriteCustomRatio("Hdd");
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                WriteCustomRatio("Ssd");
            }

            MessageBox.Show("保存完成！");

        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Restore("Box");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Restore("Power");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Restore("Cdrom");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Restore("Kb");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Restore("Mou");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Restore("Hs");
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Restore("Cam");
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Restore("Sp");
            }
            MessageBox.Show("还原完成，请重新启动程序！");
        }
        private void Restore(string kind)
        {

            IniFile.WriteVal(kind, "P1", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "P2", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "P3", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "K1", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "K2", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "K3", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "K4", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "R1", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "R2", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "R3", "", Form1.settingsIni);
            IniFile.WriteVal(kind, "R4", "", Form1.settingsIni);


        }

        private void radioButtonprintrich_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonprintrich.Checked) { SettingItems.PrintMode = SettingItems.ModeEnum.Doc; }
        }

        private void radioButtonprinttext_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonprinttext.Checked) { SettingItems.PrintMode = SettingItems.ModeEnum.Txt; }

        }

        private void radioButtonsaverich_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonsaverich.Checked) { SettingItems.SaveMode = SettingItems.ModeEnum.Doc; }

        }

        private void radioButtonsavetext_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonsavetext.Checked) { SettingItems.SaveMode = SettingItems.ModeEnum.Txt; }

        }

        private void checkBoxautoupdate_CheckedChanged(object sender, EventArgs e)
        {
            SettingItems.AutoUpdate = checkBoxautoupdate.Checked;
        }

        private void checkBoxhidead_CheckedChanged_1(object sender, EventArgs e)
        {
            SettingItems.ShowAd = !checkBoxhidead.Checked;
        }

        private void checkBoxbbs_CheckedChanged(object sender, EventArgs e)
        {
            SettingItems.ShowBbs = checkBoxbbs.Checked;
        }

        private void radioButtonchengben_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonchengben.Checked) { SettingItems.CostPrice = SettingItems.CostPriceEnum.成本; }
        }

        private void radioButtonlirun_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonlirun.Checked) { SettingItems.CostPrice = SettingItems.CostPriceEnum.利润; }

        }

        private void radioButtonlirunlv_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonlirunlv.Checked) { SettingItems.CostPrice = SettingItems.CostPriceEnum.利润率; }

        }
    }


}
