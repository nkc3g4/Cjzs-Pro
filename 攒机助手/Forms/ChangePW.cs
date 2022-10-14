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
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
        }
      
        private string MD5_PRO(string md5string) 
        {
            byte[] result = Encoding.Default.GetBytes(md5string.Trim());   
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return  BitConverter.ToString(output).Replace("-", "");  

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxnew.Text != textBoxrenew.Text) 
            {
                MessageBox.Show("两次输入的新密码不一致！"); return;
            }
            string hwadd
    = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw ;
            OleDbConnection hwaddConnection = new OleDbConnection(hwadd);
            //2、打开连接   
            hwaddConnection.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT password FROM settings", hwaddConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            string password = "";
            while (reader.Read())
            {
                password = reader[0].ToString();
                //dataGridView1.Rows.Add("CPU", reader[0].ToString(), System.Int32.Parse(reader[1].ToString()), System.Int32.Parse(reader[2].ToString()), System.Int32.Parse(reader[3].ToString()));
            }
            if (password == MD5_PRO(textBoxold .Text ))
            {

                string sql = "UPDATE [settings] SET [password] = '" + MD5_PRO(textBoxnew.Text) + "' WHERE [password] = '" + MD5_PRO(textBoxold.Text) + "'";
                OleDbCommand changepasswd = new OleDbCommand(sql, hwaddConnection);
                changepasswd.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误！");
            }
            hwaddConnection.Close();



        }

        private void changepw_Load(object sender, EventArgs e)
        {

        }
    }
}
