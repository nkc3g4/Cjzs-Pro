using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace 攒机助手专业版
{
    public partial class Login : Form
    {
        string password = "";
        bool passwordisright=false;
        public Login()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (password == MD5_PRO ( textBox1.Text))
            {
                //admin adcp = new admin(true);
                //adcp.Show();
                passwordisright = true;
                this.Close();

            }
            else 
            {
                MessageBox.Show("密码错误！");
            }
        }
        private string MD5_PRO(string md5string)
        {
            byte[] result = Encoding.Default.GetBytes(md5string.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");

        }
        public bool pw
        {
            get { return passwordisright; }
        }

        private void login_Load(object sender, EventArgs e)
        {
            string strConn
    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems .MdbPath  + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw ;
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            //2、打开连接   
            odcConnection.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT password FROM settings", odcConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                password = reader[0].ToString();
                //dataGridView1.Rows.Add("CPU", reader[0].ToString(), System.Int32.Parse(reader[1].ToString()), System.Int32.Parse(reader[2].ToString()), System.Int32.Parse(reader[3].ToString()));
            }
            odcConnection.Close();
            if (password == "D41D8CD98F00B204E9800998ECF8427E")
            {
                passwordisright = true;
                this.Close();
                //admin adcp = new admin(true);
                //adcp.Show();
                //this.Close();
            }
        }
    }
}
