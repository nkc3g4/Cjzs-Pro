using System;
using System.Windows.Forms;
using Microsoft.Win32;
namespace 攒机助手专业版
{
    public partial class Update : Form
    {
        string args = null;
        public Update(string args)
        {
            InitializeComponent();
            this.args = args;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { button1.Enabled = false; }
            if (checkBox1.Checked == false) { button1.Enabled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                IniFile.WriteVal("Main", "AutoUpdate", "0", Form1.settingsIni);

                //WTRegedit("nevercheckupdate", "1");
            }
            this.Close();
        }
        //private void WTRegedit(string name, string tovalue)
        //{
        //    RegistryKey hklm = Registry.CurrentUser ;
        //    RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
        //    RegistryKey aimdir = software.CreateSubKey(Application.ProductName);
        //    aimdir.SetValue(name, tovalue);
        //}

        private void update_Load(object sender, EventArgs e)
        {
            label1.Text += args;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057");
            this.Close();
        }
    }
}
