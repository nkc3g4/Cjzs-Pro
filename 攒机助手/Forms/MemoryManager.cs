using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public partial class MemoryManager : Form
    {
        int[] pzint = new int[11];
        //Dictionary<int, string> listDict = new Dictionary<int, string>();
        public MemoryManager()
        {
            InitializeComponent();
        }
        private void LoadMemory()
        {
            listBox1.Items.Clear();
            int c = 0;
            for (int i = 1; i <= 10; i++)
            {
                string memstring = IniFile.ReadVal("M3", "PZ" + i.ToString(), Form1.settingsIni);
                if (!string.IsNullOrEmpty(memstring))
                {

                    listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~")));

                    pzint[c++] = i;
                }

            }
            #region OldCode
            //string memstring;
            //int i = 0;
            //memstring = IniFile.ReadVal("M2", "PZ1", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 1; }

            //memstring = IniFile.ReadVal("M2", "PZ2", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 2; }
            //memstring = IniFile.ReadVal("M2", "PZ3", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 3; }
            //memstring = IniFile.ReadVal("M2", "PZ4", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 4; }
            //memstring = IniFile.ReadVal("M2", "PZ5", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 5; }
            //memstring = IniFile.ReadVal("M2", "PZ6", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 6; }
            //memstring = IniFile.ReadVal("M2", "PZ7", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 7; }
            //memstring = IniFile.ReadVal("M2", "PZ8", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 8; }
            //memstring = IniFile.ReadVal("M2", "PZ9", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 9; }

            //memstring = IniFile.ReadVal("M2", "PZ10", Form1.settingsini);
            //if (memstring != "") { listBox1.Items.Add(memstring.Substring(0, memstring.IndexOf("~"))); pzint[i++] = 10; }
            #endregion
        }
        private void MemoryManager_Load(object sender, EventArgs e)
        {

            LoadMemory();
            #region OldCode
            //memstring = IniFile.ReadVal("M1", "PZ2", Form1.settingsini);
            //if (memstring != "") { this.存入2ToolStripMenuItem.Text = "存入2：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ2ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ2ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ3", Form1.settingsini);
            //if (memstring != "") { this.存入3ToolStripMenuItem.Text = "存入3：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ3ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ3ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ4", Form1.settingsini);
            //if (memstring != "") { this.存入4ToolStripMenuItem.Text = "存入4：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ4ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ4ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ5", Form1.settingsini);
            //if (memstring != "") { this.存入5ToolStripMenuItem.Text = "存入5：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ5ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ5ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ6", Form1.settingsini);
            //if (memstring != "") { this.存入6ToolStripMenuItem.Text = "存入6：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ6ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ6ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ7", Form1.settingsini);
            //if (memstring != "") { this.存入7ToolStripMenuItem.Text = "存入7：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ7ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ7ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ8", Form1.settingsini);
            //if (memstring != "") { this.存入8ToolStripMenuItem.Text = "存入8：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ8ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ8ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ9", Form1.settingsini);
            //if (memstring != "") { this.存入9ToolStripMenuItem.Text = "存入9：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ9ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ9ToolStripMenuItem.Visible = true; }
            //memstring = IniFile.ReadVal("M1", "PZ10", Form1.settingsini);
            //if (memstring != "") { this.存入10ToolStripMenuItem.Text = "存入10：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ10ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ10ToolStripMenuItem.Visible = true; }
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region OldCode
            //string memstring = IniFile.ReadVal("M2", "PZ"+(listBox1 .SelectedIndex+1).ToString (), Form1.settingsini);
            ////MessageBox.Show(listBox1.SelectedIndex.ToString());

            //if (memstring != "")
            //{
            //    string cpu;
            //    //int cpu1;
            //    string mb;
            //    //int mb1;
            //    string ram;
            //    int ram1;
            //    string hdd;
            //    int hdd1;
            //    string ssd;
            //    int ssd1;
            //    string gpu;
            //    int gpu1;
            //    string lcd;
            //    int lcd1;
            //    string box;
            //    int box1;
            //    string fan;
            //    int fan1;
            //    string power;
            //    int power1;
            //    string cdrom;
            //    int cdrom1;
            //    string kb;
            //    int kb1;
            //    string hs;
            //    int hs1;
            //    string cam;
            //    int cam1;
            //    string sp;
            //    int sp1;
            //    string o;
            //    int o1;
            //    memstring.Substring(0, memstring.IndexOf("~"));
            //    string shorter = memstring.Substring(memstring.IndexOf("~") + 1);

            //    //string shorter = pzstring.Substring(pzstring.IndexOf("~") + 1);

            //    cpu = Form1.cpu[Int32.Parse(memstring.Substring(0, memstring.IndexOf("#")))];
            //    shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    mb = Form1.mb[Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")))];
            //    shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //ram = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //hdd = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //ssd = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //gpu = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //lcd_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //box_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //fan_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //power_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //cdrom_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //kb_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //hs_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //cam_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //sp_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);
            //    //o_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    ////////////////////
            //    //cpu = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //cpu1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //mb = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //mb1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //ram = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //ram1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //hdd = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //hdd1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //ssd = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //ssd1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //gpu = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //gpu1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //lcd = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //lcd1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //box = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //box1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //fan = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //fan1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //power = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //power1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    //////////////////////
            //    //cdrom = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //cdrom1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //kb = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //kb1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //hs = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //hs1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //cam = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //cam1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //sp = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //sp1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);
            //    /////////////////////
            //    //o = shorter.Substring(0, shorter.IndexOf("#"));

            //    //shorter = shorter.Substring(shorter.IndexOf("#") + 1);

            //    //o1 = Int32.Parse(shorter.Substring(0, shorter.IndexOf("|")));

            //    //shorter = shorter.Substring(shorter.IndexOf("|") + 1);

            //    //textBox1.Text = "名称：" + memstring.Substring(0, memstring.IndexOf("~")) + "\r\nCPU:" + cpu + "￥" + cpu1 + "\r\n主板:" + mb + "￥" + mb1 + "\r\n内存:" + ram + "￥" + ram1 + "\r\n硬盘:" + hdd + "￥" + hdd1 + "\r\n固态硬盘:" + ssd + "￥" + ssd1 + "\r\n显卡:" + gpu + "￥" + gpu1 + "\r\n显示器:" + lcd + "￥" + lcd1 + "\r\n机箱:" + box + "￥" + box1 + "\r\n散热器:" + fan + "￥" + fan1 + "\r\n电源:" + power + "￥" + power1 + "\r\n光驱:" + cdrom + "￥" + cdrom1 + "\r\n键鼠:" + kb + "￥" + kb1 + "\r\n耳机:" + hs + "￥" + hs1 + "\r\n摄像头:" + cam + "￥" + cam1 + "\r\n音响:" + sp + "￥" + sp1 + "\r\n其他:" + o + "￥" + o1 + "\r\n";
            //    //listBox1 .SelectedIndex 
            //}
            //else { textBox1.Text = ""; }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //foreach (var item in listBox1.SelectedItems)
            //{

            //}
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (( listBox1 .Items[i])
            //}






            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {

                IniFile.WriteVal("M3", "PZ" + pzint[listBox1.SelectedIndices[i]].ToString(), string.Empty, Form1.settingsIni);

                //MessageBox.Show((Int32.Parse ( listBox1.GetItemText(listBox1.SelectedItems[i]))).ToString ());
            }
            MessageBox.Show("删除完成！");
            LoadMemory();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=9469");
        }
    }
}
