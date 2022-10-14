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
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }

        private void Profit_Load(object sender, EventArgs e)
        {
            textBoxsum.Text = Form1.sum.ToString ();
            textBoxcost.Text = Form1.costsum.ToString();
            textBoxprofit.Text = (Form1.sum - Form1.costsum).ToString();
            Single costmargins = ((float)(Form1.sum - Form1.costsum) / (float)Form1.costsum)*100;
            textBoxcostmargins.Text = costmargins.ToString()+"%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
