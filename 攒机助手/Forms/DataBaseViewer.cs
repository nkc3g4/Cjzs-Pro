using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Collections.Generic;
namespace 攒机助手专业版
{
    public partial class DataBaseViewer : Form
    {
        DataTable dt;
        //bool isedited = false;
        public DataBaseViewer()
        {
            InitializeComponent();
        }
        private void databaseview_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataDataSet.cuanji”中。您可以根据需要移动或删除它。
            //this.cuanjiTableAdapter.Fill(this.dataDataSet.cuanji);
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Form1.sellMdbPath);
            //con.Open();
            //string sql = "select * from 销售记录";
            //OleDbDataAdapter ad = new OleDbDataAdapter(sql, con);
            //dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;]

            dt = new DataTable();

            Dictionary<string, string> dict = null;
            int i = 0;
            string sql = "select * from AssInfo";
            using (OleDbDataReader reader = MDBHelper.ExecuteReader(Form1.sellDbConStr, sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        JavaScriptSerializer jss = new JavaScriptSerializer();
                        dict = jss.Deserialize<Dictionary<string, string>>(reader[2].ToString());

                        if (i == 0)
                        {
                            dt.Columns.Add("ID");
                            dt.Columns.Add("时间");
                            foreach (KeyValuePair<string, string> item in dict)
                            {
                                dt.Columns.Add(item.Key);
                            }
                            i++;
                        }
                        string[] strArr = new string[dict.Values.Count + 2];
                        strArr[0] = reader[0].ToString();
                        strArr[1] = reader[1].ToString();
                        dict.Values.CopyTo(strArr, 2);
                        dt.Rows.Add(strArr);
                        //foreach (KeyValuePair <string,string> item in dict)
                        //{

                        //}

                    }
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void databaseview_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                DialogResult RSS = MessageBox.Show(this, "确定要删除选中行数据码？\n此操作不可撤销！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (RSS)
                {
                    case DialogResult.Yes:
                        for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                        {
                            //isedited = true;

                            try
                            {
                                //dt.Rows[dataGridView1.SelectedRows[i - 1].Index].Delete ();;
                                
                                string sql_delete = "delete from AssInfo where [ID]=" + dataGridView1.Rows[dataGridView1.SelectedRows[i - 1].Index].Cells[0].Value;

                                MDBHelper.ExecuteNonQuery(Form1.sellDbConStr, sql_delete);
                                dt.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        MessageBox.Show("成功删除选中行数据！");
                        break;
                    case DialogResult.No:
                        break;
                }
                //dt.
                //this.dataDataSet.cuanji.DefaultView[dataGridView1.CurrentCell.RowIndex].Delete();
            }
        }
        //private void save()
        //{
        //    try
        //    {
        //        //SqlCommandBuilder builder = new SqlCommandBuilder(ad);
        //        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw);
        //        con.Open();
        //        string sql;
        //        OleDbCommand cmd;
        //        sql = "DELETE FROM [cuanji]";
        //        cmd = new OleDbCommand(sql, con);
        //        cmd.ExecuteNonQuery();

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            sql = "insert into cuanji(时间,程序版本,客户名称,联系电话,备注,总价,CPU,CPU价格,主板,主板价格,内存,内存价格,硬盘,硬盘价格,SSD,SSD价格,显卡,显卡价格,显示器,显示器价格,机箱,机箱价格,散热器,散热器价格,电源,电源价格,光驱,光驱价格,键鼠,键鼠价格,其它,其它价格,耳机,耳机价格,摄像头,摄像头价格,音响,音响价格)values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "','" + dt.Rows[i][6].ToString() + "','" + dt.Rows[i][7].ToString() + "','" + dt.Rows[i][8].ToString() + "','" + dt.Rows[i][9].ToString() + "','" + dt.Rows[i][10].ToString() + "','" + dt.Rows[i][11].ToString() + "','" + dt.Rows[i][12].ToString() + "','" + dt.Rows[i][13].ToString() + "','" + dt.Rows[i][14].ToString() + "','" + dt.Rows[i][15].ToString() + "','" + dt.Rows[i][16].ToString() + "','" + dt.Rows[i][17].ToString() + "','" + dt.Rows[i][18].ToString() + "','" + dt.Rows[i][19].ToString() + "','" + dt.Rows[i][20].ToString() + "','" + dt.Rows[i][21].ToString() + "','" + dt.Rows[i][22].ToString() + "','" + dt.Rows[i][23].ToString() + "','" + dt.Rows[i][24].ToString() + "','" + dt.Rows[i][25].ToString() + "','" + dt.Rows[i][26].ToString() + "','" + dt.Rows[i][27].ToString() + "','" + dt.Rows[i][28].ToString() + "','" + dt.Rows[i][29].ToString() + "','" + dt.Rows[i][30].ToString() + "','" + dt.Rows[i][31].ToString() + "','" + dt.Rows[i][32].ToString() + "','" + dt.Rows[i][33].ToString() + "','" + dt.Rows[i][34].ToString() + "','" + dt.Rows[i][35].ToString() + "','" + dt.Rows[i][36].ToString() + "','" + dt.Rows[i][37].ToString() + "')";
        //            cmd = new OleDbCommand(sql, con);
        //            cmd.ExecuteNonQuery();
        //        }
        //        //this.cuanjiTableAdapter.Update(this.dataDataSet.cuanji);
        //        MessageBox.Show("保存完成！");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void buttonsave_Click(object sender, EventArgs e)
        {
            //save();
        }
        public void DataToExcel(DataTable m_DataTable)
        {
            SaveFileDialog kk = new SaveFileDialog();
            kk.Title = "保存EXECL文件";
            kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";
            kk.FilterIndex = 1;
            if (kk.ShowDialog() == DialogResult.OK)
            {
                string FileName = kk.FileName;
                if (File.Exists(FileName))
                    File.Delete(FileName);
                FileStream objFileStream;
                StreamWriter objStreamWriter;
                string strLine = "";
                objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
                for (int i = 0; i < m_DataTable.Columns.Count; i++)
                {
                    strLine = strLine + m_DataTable.Columns[i].Caption.ToString() + Convert.ToChar(9);
                }
                objStreamWriter.WriteLine(strLine);
                strLine = "";

                for (int i = 0; i < m_DataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < m_DataTable.Columns.Count; j++)
                    {
                        if (m_DataTable.Rows[i].ItemArray[j] == null)
                            strLine = strLine + " " + Convert.ToChar(9);
                        else
                        {
                            string rowstr = "";
                            rowstr = m_DataTable.Rows[i].ItemArray[j].ToString();
                            if (rowstr.IndexOf("\r\n") > 0)
                                rowstr = rowstr.Replace("\r\n", " ");
                            if (rowstr.IndexOf("\t") > 0)
                                rowstr = rowstr.Replace("\t", " ");
                            strLine = strLine + rowstr + Convert.ToChar(9);
                        }
                    }
                    objStreamWriter.WriteLine(strLine);
                    strLine = "";
                }
                objStreamWriter.Close();
                objFileStream.Close();
                MessageBox.Show(this, "保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataToExcel(dt);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
            cm.SuspendBinding(); //挂起数据绑定
            int visable_row_count = 0;
            string searchstring = textBoxsearch.Text.ToUpper();
            int rowcount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowcount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    dataGridView1.Rows[i].Visible = false;

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToUpper().Contains(searchstring))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            visable_row_count++;
                        }
                    }
                }

            }
            cm.ResumeBinding();
            //labelstatus.Text = "当前显示数据: " + visable_row_count.ToString() + " 条";

        }
    }
}
