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
    public partial class RememberName : Form
    {
        public static string pzname="未命名";
        public RememberName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pzname = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RememberName_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
                        

        }
    }
}
