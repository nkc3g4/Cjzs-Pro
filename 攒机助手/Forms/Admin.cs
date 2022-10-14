using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace 攒机助手专业版
{
    public partial class Admin : Form
    {
        //bool frestart=false ;
        bool isedited = false;
        Canvas canvas;
        UndoRedo un;
        /// <summary>
        /// MainDt存储数据
        /// </summary>
        public static DataTable MainDt;
        /// <summary>
        /// ShowDt仅用于DataGridView展示
        /// </summary>
        private DataTable ShowDt;
        public static int[] showmain = new int[10000];
        public Admin()
        {
            InitializeComponent();
            foreach (var item in SData.allHwKind)
            {
                ToolStripItem tsi = MenuAdd.Items.Add(item.KindNameCh);
                tsi.Tag = item;
                tsi.Click += tsi_Click;
            }
        }
        #region ControlCode
        private void buttonUndoRedo_Click(object sender, EventArgs e)
        {
            un.Undo(1);
            dataGridView1.DataSource = canvas.Children;
            if (!un.IsUndoPossible())
                buttonUndo.Enabled = false;
            if (un.IsRedoPossible())
                buttonRedo.Enabled = true;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                return;
            }
            try
            {
                un.SetStateForUndoRedo();
                if (un.IsRedoPossible())
                    buttonRedo.Enabled = true;
                if (un.IsUndoPossible())
                    buttonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            un.Redo(1);
            dataGridView1.DataSource = canvas.Children;
            if (!un.IsRedoPossible())
                buttonRedo.Enabled = false;
            if (un.IsUndoPossible())
                buttonUndo.Enabled = true;

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var brush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), dataGridView1.DefaultCellStyle.Font, brush, e.RowBounds.Location.X + 12, e.RowBounds.Y + 5);
            }

        }



        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteRow();
            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            AutoBackup();
            if (DialogResult.No == MessageBox.Show("此操作将会清空数据库内所有硬件！\n确认继续？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) { return; }
            //if (File.Exists(Application.StartupPath + "\\tempsave.mdb")) { File.Delete(Application.StartupPath + "\\tempsave.mdb"); }
            //File.Copy(Application.StartupPath + "\\data.mdb", Application.StartupPath + "\\tempsave.mdb");
            //
            string hwadd = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            OleDbConnection hwaddConnection = new OleDbConnection(hwadd);
            //2、打开连接   
            hwaddConnection.Open();
            //////////////////////////////////////////////
            string sql;
            sql = "DELETE FROM [z_cpu]";
            OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_acpu]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_mb]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_ram]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_hdd]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_ssd]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_box]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_pow]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_lcd]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_hs]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_kb]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_mou]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();


            sql = "DELETE FROM [z_cam]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_sp]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_o]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_fan]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_cdrom]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM [z_gpu]";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            sql = "insert into z_o(name,bprice,sprice,qa)values('0','0','0','0')";
            cmd = new OleDbCommand(sql, hwaddConnection);
            cmd.ExecuteNonQuery();
            hwaddConnection.Close();
            textBoxsearch.Text = "";
            Form1.ReadAccessData();
            ReadCongFile();
            reloadcheckedListBox_and_search();

            MessageBox.Show("所有硬件数据已删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            reloadcheckedListBox_and_search();

        }

        private void buttonrenm_Click(object sender, EventArgs e)
        {
            MemoryManager MM = new MemoryManager();
            MM.ShowDialog();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DataGridviewShowToExcel(dataGridView1, true);

        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) return;
            StringBuilder selectItemsText = new StringBuilder();
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            foreach (DataGridViewCell item in dataGridView1.SelectedCells)
            {
                if (dict.ContainsKey(item.RowIndex))
                {
                    dict[item.RowIndex] += item.Value.ToString() + " ";
                }
                else { dict.Add(item.RowIndex, item.Value.ToString() + " "); }


            }

            foreach (KeyValuePair<int, string> item in dict)
            {
                selectItemsText.AppendLine(item.Value);
            }
            Clipboard.SetText(selectItemsText.ToString());
            //MessageBox.Show("已复制");
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //MessageBox.Show("Test");
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

            MenuAdd.Show(Control.MousePosition);

        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lirun.PerformClick();
            }

        }

        private void textBoxzhibao_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button2.PerformClick();

            }

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-7502-1-1.html");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Search();

            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
            reloadcheckedListBox_and_search();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Search();

            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, false);

            }
            reloadcheckedListBox_and_search();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Search();

            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));

            }
            reloadcheckedListBox_and_search();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-6309-1-1.html");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Search();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DeleteRow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\cjzs_.doc");

        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult restore = MessageBox.Show(this, "确认要还原吗？您对配置文件的更改将全部抹去！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (restore == DialogResult.No)
            {
                return;
            }

            DialogResult restore1 = MessageBox.Show(this, "此操作将不可恢复！您确认继续吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restore == DialogResult.No || restore1 == DialogResult.No)
            {
                return;

            }
            //CompressFile(Application.StartupPath + "\\config.ini", Application.StartupPath + "\\config.ini.zip");
            Compress.DeCompressFile(Form1.userpath + "\\data.mdb.zip", SettingItems.MdbPath);
            Form1.ReadAccessData();
            ReadCongFile();
            //frestart = true;
            //Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataBaseViewer da = new DataBaseViewer();
            da.Show();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!frestart)
            //{

            if (isedited)
            {
                DialogResult save = MessageBox.Show("是否保存您所做的更改？", "询问保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (save == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (save == DialogResult.Yes)
                {

                    SaveMDBFile(e);
                    //frestart = true;
                    //Application.Restart();
                }
            }
            //}

        }

        private void CPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            //contextMenuStripadd.Show(Control.MousePosition);
            PriceUpdate pu = new PriceUpdate();
            pu.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.textBox1.Focus();
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void textBoxzhibao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.textBoxzhibao.Focus();
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isedited = true;

            try
            {
                int RowNumber = dataGridView1.CurrentCell.RowIndex;
                DataRow row = ShowDt.NewRow();
                row[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                row[1] = " ";
                row[2] = "0";
                row[3] = "0";
                row[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                ShowDt.Rows.InsertAt(row, RowNumber + 1);

                DataRow row2 = MainDt.NewRow();
                row2[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                row2[1] = " ";
                row2[2] = "0";
                row2[3] = "0";
                row2[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                MainDt.Rows.InsertAt(row2, showmain[RowNumber] + 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("插入错误！" + ex.ToString());
            }

        }

        private void checkallhw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
            reloadcheckedListBox_and_search();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                checkedListBox1.SetItemChecked(i, false);

            }
            reloadcheckedListBox_and_search();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));

            }
            reloadcheckedListBox_and_search();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.luobotou.org/thread-6309-1-1.html");
        }

        private void buttonbak_Click(object sender, EventArgs e)
        {
            if (isedited)
            {
                DialogResult restore = MessageBox.Show(this, "您是否需要先保存当前编辑中的配置？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (restore == DialogResult.Yes)
                {
                    SaveMDBFile();
                }
            }
            //MessageBox.Show("请在备份之前保存配置！");
            Compress.CompressFile(SettingItems.MdbPath, Form1.userpath + "\\data.mdb.zip");
            MessageBox.Show("备份完成！");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isedited)
            {
                DialogResult save = MessageBox.Show("需要保存您的更改，是否继续？", "询问", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (save == DialogResult.Cancel)
                {
                    return;
                    //e.Cancel = true;
                }
                else if (save == DialogResult.Yes)
                {
                    SaveMDBFile();
                }
            }
            ImpoartData im = new ImpoartData();
            im.ShowDialog();
            //readcongfile();
            reloadcheckedListBox_and_search();
            //Search();
            isedited = true;

        }

        private void btnpw_Click(object sender, EventArgs e)
        {
            ChangePW cp = new ChangePW();
            cp.Show();
        }

        private void autoupdate_Click(object sender, EventArgs e)
        {
            if (isedited)
            {
                SaveMDBFile(true);
            }

            PriceUpdate pu = new PriceUpdate();
            pu.ShowDialog();
            ReadCongFile();
            //Search();

            reloadcheckedListBox_and_search();
            isedited = true;
            //frestart = true;
            //Application.Restart();

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isedited = true;
            //MessageBox .Show (dataGridView1.Rows[dataGridView1 .CurrentRow.Index  ].Cells[dataGridView1.CurrentCell.ColumnIndex ].Value.ToString());
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() == "内存" || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() == "硬盘")
                {
                    //g替换为G,b替换为B,t替换为T
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("g"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("g", "G"); }
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("b"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("b", "B"); }
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("t"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("t", "T"); }
                    //G替换为GB
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("G") && !dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("B"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("G", "GB"); }
                    //T替换为TB
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("T") && !dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("B"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("T", "TB"); }
                }
                else if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString() == "CPU")
                {
                    //I替换为i
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("I3"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("I3", "i3"); }
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("I5"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("I5", "i5"); }
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("I7"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("I7", "i7"); }

                    //E3
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("e3"))
                    { dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Replace("e3", "E3"); }

                    //判断型号是否正确
                    if (!(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("i3") || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("i5") || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("i7") || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("奔腾") || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("赛扬") || dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Contains("E3")))
                    {
                        MessageBox.Show("请将型号输入完整\n例如：Intel Core i3 530(盒)"); return;
                    }


                }

                if (!(IsNumber(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString()) && IsNumber(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString()) && IsNumber(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString())))
                {
                    MessageBox.Show("进价、售价、质保必须为数字！");
                }
            }
            catch { }
            try
            {
                MainDt.Rows[showmain[dataGridView1.CurrentRow.Index]][0] = ShowDt.Rows[dataGridView1.CurrentRow.Index][0];
                MainDt.Rows[showmain[dataGridView1.CurrentRow.Index]][1] = ShowDt.Rows[dataGridView1.CurrentRow.Index][1];
                MainDt.Rows[showmain[dataGridView1.CurrentRow.Index]][2] = ShowDt.Rows[dataGridView1.CurrentRow.Index][2];
                MainDt.Rows[showmain[dataGridView1.CurrentRow.Index]][3] = ShowDt.Rows[dataGridView1.CurrentRow.Index][3];
                MainDt.Rows[showmain[dataGridView1.CurrentRow.Index]][4] = ShowDt.Rows[dataGridView1.CurrentRow.Index][4];
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误！\n" + ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isedited)
            {
                DialogResult save = MessageBox.Show("确认放弃您所做的更改？", "询问", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (save == DialogResult.Cancel)
                {
                    return;
                    //e.Cancel = true;
                }
                else if (save == DialogResult.Yes)
                {
                    textBoxsearch.Text = "";
                    Form1.ReadAccessData();
                    ReadCongFile();
                    reloadcheckedListBox_and_search();
                }
            }
            else
            {
                textBoxsearch.Text = "";
                Form1.ReadAccessData();
                ReadCongFile();
                reloadcheckedListBox_and_search();
            }



        }
        private void save_Click(object sender, EventArgs e)
        {
            SaveMDBFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(2);
        }

        private void lirun_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("此操作将对所有显示项目进行设置，且不可恢复，确认继续？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) { return; }
            isedited = true;
            //previous.Rows.AddRange(dataGridView1.Rows); ;
            //buttonUndo.Text = "撤销";
            //buttonUndo.Enabled = true;
            //MessageBox .Show (((System.Int32.Parse(textBox1.Text) / 100)).ToString());
            dataGridView1.DataSource = null;
            for (int i = 0; i < ShowDt.Rows.Count; i++)
            {
                try
                {
                    if (textBox1.Text == "0")
                    {
                        if (ShowDt.Rows[i][0].ToString() != "")
                        {
                            ShowDt.Rows[i][2] = ShowDt.Rows[i][3].ToString();
                            MainDt.Rows[showmain[i]][2] = ShowDt.Rows[i][2];

                        }
                    }
                    else
                    {
                        if (ShowDt.Rows[i][0].ToString() != "")
                        {
                            ShowDt.Rows[i][2] = (System.Int32.Parse(ShowDt.Rows[i][3].ToString()) + (System.Int32.Parse(ShowDt.Rows[i][3].ToString()) / (100 / (System.Int32.Parse(textBox1.Text))))).ToString();
                            MainDt.Rows[showmain[i]][2] = ShowDt.Rows[i][2];

                            //dataGridView1.Rows[i].Cells[2].Value = (System.Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + (System.Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) / (100 / (System.Int32.Parse(textBox1.Text))))).ToString();
                        }
                    }
                }
                catch { }
            }
            dataGridView1.DataSource = ShowDt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;

        }

        private void hide_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //dataGridView1.Rows[i].Cells[0].Value.to
            }
        }


        private void admin_Load(object sender, EventArgs e)
        {
            MainDt = new DataTable();
            MainDt.Columns.Add("类型");
            MainDt.Columns.Add("名称");
            MainDt.Columns.Add("售价");
            MainDt.Columns.Add("进价");
            MainDt.Columns.Add("质保");
            MainDt.Columns.Add("DBID");

            ShowDt = new DataTable();
            //DataColumn dc = new DataColumn();
            //dc.DataType = typeof(ComboBox);

            //ShowDt.Columns.Add(;
            ShowDt.Columns.Add("类型");
            ShowDt.Columns.Add("名称");
            ShowDt.Columns.Add("售价");
            ShowDt.Columns.Add("进价");
            ShowDt.Columns.Add("质保");
            //ShowDt.Columns.Add("ID");

            dataGridView1.DataSource = null;
     
            if (Form1.trial)
            {
                this.Text += " 试用版";
                //label1.Text = "试用版";
                MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，希望您购买正版！\n本软件最低售价仅10元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //label1.Text = "已注册";

            }
            ReadCongFile();
            for (int i = 0; i <= 17; i++)
            {
                checkedListBox1.SetItemChecked(i, true);

            }
            reloadcheckedListBox_and_search();

            try
            {
                canvas = new Canvas();
                canvas.Children = (DataTable)dataGridView1.DataSource;
                un = new UndoRedo(canvas);
                un.SetStateForUndoRedo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void 插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isedited = true;
            try
            {


                if (dataGridView1.RowCount > 0)
                {
                    int RowNumber = dataGridView1.SelectedCells[0].RowIndex;
                    DataRow row = ShowDt.NewRow();
                    row[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                    row[1] = " ";
                    row[2] = "0";
                    row[3] = "0";
                    row[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                    ShowDt.Rows.InsertAt(row, RowNumber);

                    DataRow row2 = MainDt.NewRow();
                    row2[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                    row2[1] = " ";
                    row2[2] = "0";
                    row2[3] = "0";
                    row2[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                    MainDt.Rows.InsertAt(row2, showmain[RowNumber]);
                }
                else
                {
                    DataRow row = ShowDt.NewRow();
                    row[0] = " ";
                    row[1] = " ";
                    row[2] = "0";
                    row[3] = "0";
                    row[4] = "0";

                    ShowDt.Rows.InsertAt(row, 0);

                    DataRow row2 = MainDt.NewRow();
                    row2[0] = " ";
                    row2[1] = " ";
                    row2[2] = "0";
                    row2[3] = "0";
                    row2[4] = "0";
                    MainDt.Rows.InsertAt(row2, 0);

                }
                //MainDt.Rows[showmain[RowNumber]][2] = ShowDt.Rows[i][2];

            }
            catch (Exception ex)
            {
                MessageBox.Show("插入错误！" + ex.ToString());
            }
         

        }
        private void reloadcheckedListBox_and_search()
        {
            try
            {
                int visable_row_count = 0;
                dataGridView1.DataSource = null;
                ShowDt.Rows.Clear();
                string searchstring = textBoxsearch.Text.ToUpper();


                /*
                        * 0=CPU
                        * 1=AMD CPU
                        * 2=主板
                        * 3=内存
                        * 4=硬盘
                        * 5=固态硬盘
                        * 6=显卡
                        * 7=显示器
                        * 8=机箱
                        * 9=散热器
                        * 10=电源
                        * 11=光驱
                        * 12=键盘
                 *        13=鼠标
                        * 14=耳机
                        * 15=摄像头
                        * 16=音响
                        * 17=其他
                        * 
                        */
                bool cpuc = checkedListBox1.GetItemChecked(0);
                bool acpuc = checkedListBox1.GetItemChecked(1);
                bool two = checkedListBox1.GetItemChecked(2);
                bool three = checkedListBox1.GetItemChecked(3);
                bool four = checkedListBox1.GetItemChecked(4);
                bool five = checkedListBox1.GetItemChecked(5);
                bool six = checkedListBox1.GetItemChecked(6);
                bool seven = checkedListBox1.GetItemChecked(7);
                bool eight = checkedListBox1.GetItemChecked(8);
                bool nine = checkedListBox1.GetItemChecked(9);
                bool ten = checkedListBox1.GetItemChecked(10);
                bool eleven = checkedListBox1.GetItemChecked(11);
                bool twelve = checkedListBox1.GetItemChecked(12);
                bool thirteen = checkedListBox1.GetItemChecked(13);
                bool fourteen = checkedListBox1.GetItemChecked(14);
                bool fifteen = checkedListBox1.GetItemChecked(15);
                bool sixteen = checkedListBox1.GetItemChecked(16);
                bool seventeen = checkedListBox1.GetItemChecked(17);





                for (int i = 0; i < MainDt.Rows.Count; i++)
                {
                    if (MainDt.Rows[i][0].ToString() == "CPU" && cpuc && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;
                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;
                    }
                    if (MainDt.Rows[i][0].ToString() == "AMD CPU" && acpuc && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;
                    }
                    if (MainDt.Rows[i][0].ToString() == "主板" && two && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;
                    }
                    if (MainDt.Rows[i][0].ToString() == "内存" && three && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "硬盘" && four && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "固态硬盘" && five && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "显卡" && six && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "显示器" && seven && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "机箱" && eight && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "散热器" && nine && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "电源" && ten && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "光驱" && eleven && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "键盘" && twelve && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "鼠标" && thirteen && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "耳机" && fourteen && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "摄像头" && fifteen && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "音响" && sixteen && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    if (MainDt.Rows[i][0].ToString() == "其他" && seventeen && MainDt.Rows[i][1].ToString().ToUpper().Contains(searchstring))
                    {
                        //if ()
                        showmain[ShowDt.Rows.Count] = i;

                        DataRow row = ShowDt.NewRow();
                        row[0] = MainDt.Rows[i][0];
                        row[1] = MainDt.Rows[i][1];
                        row[2] = MainDt.Rows[i][2];
                        row[3] = MainDt.Rows[i][3];
                        row[4] = MainDt.Rows[i][4];
                        ShowDt.Rows.Add(row);
                        visable_row_count++;

                    }
                    dataGridView1.DataSource = ShowDt;
                    dataGridView1.Columns[0].Width = 70;
                    dataGridView1.Columns[1].Width = 250;
                    dataGridView1.Columns[2].Width = 50;
                    dataGridView1.Columns[3].Width = 50;
                    dataGridView1.Columns[4].Width = 50;

                }

                labelstatus.Text = "当前显示数据: " + visable_row_count.ToString() + " 条";
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Search();

            reloadcheckedListBox_and_search();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("此操作将对所有显示项目进行设置，且不可恢复，确认继续？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) { return; }

            isedited = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Visible && dataGridView1.Rows[i].Cells[0].Value.ToString() != "")
                    {
                        ShowDt.Rows[i][4] = textBoxzhibao.Text;
                        MainDt.Rows[showmain[i]][4] = ShowDt.Rows[i][4];

                        //dataGridView1.Rows[i].Cells[4].Value = textBoxzhibao.Text;
                    }
                }
                catch { }
            }
        }
        #endregion
        #region DataBaseOperator
        private void ReadCongFile()
        {
            try
            {
                //dataGridView1.Rows.Clear();
                MainDt.Rows.Clear();
                foreach (var item in SData.allHwKind)
                {
                    foreach (var hwItems in item.HW)
                    {
                        if (hwItems != null && hwItems.Name != "自动选择")
                        {
                            DataRow row = MainDt.NewRow();
                            row[0] = item.KindNameCh;
                            row[1] = hwItems.Name;
                            row[2] = hwItems.SellPrice;
                            row[3] = hwItems.BuyPrice;
                            row[4] = hwItems.Warranty;
                            row[5] = hwItems.DBID;
                            MainDt.Rows.Add(row);
                        }
                    }
                }

                dataGridView1.DataSource = MainDt;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }



        }
        private void AutoBackup()
        {
            if (!Directory.Exists(Form1.userpath + "\\AutoBackup")) { Directory.CreateDirectory(Form1.userpath + "\\AutoBackup"); }
            DeleteOldBackupFile();
            Compress.CompressFile(SettingItems.MdbPath, Form1.userpath + "\\AutoBackup\\" + System.DateTime.Now.ToFileTime() + ".mdb.zip");

        }
        private void SaveMDBFile(bool isQuiet)
        {
            SaveMDBFile(null, true);
        }

        private void SaveMDBFile()
        {
            SaveMDBFile(null, false);
        }
        private void SaveMDBFile(FormClosingEventArgs e)
        {
            SaveMDBFile(e, false);
        }
        private void SaveMDBFile(FormClosingEventArgs e, bool isQuiet)
        {
            //if (File.Exists(Form1.userpath + "\\AutoBackup\\DataTableTempBackup.xml"))
            //{
            //   e.Cancel = true;
            //}
            AutoBackup();
            string savelog = string.Empty;
            OleDbConnection con = MDBHelper.OpenConnection(Form1.mainDbConStr);
            //if (File.Exists(Application.StartupPath + "\\tempsave.mdb")) { File.Delete(Application.StartupPath + "\\tempsave.mdb"); }
            //File.Copy(Application.StartupPath + "\\data.mdb", Application.StartupPath + "\\tempsave.mdb");
            //

            //string hwaddConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;
            //OleDbConnection hwaddConnection = new OleDbConnection(hwaddConStr);
            ////2、打开连接   
            //hwaddConnection.Open();
            //////////////////////////////////////////////

            foreach (var item in SData.allHwKind)
            {

                string sql = "DELETE FROM [z_" + item.KindNameShort.ToLower() + "];";

                //OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                try
                {
                    MDBHelper.ExecuteNonQuery(con, sql);
                    //cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("配置文件存在错误\n" + ex.ToString());
                    Log.WriteLog("SaveMDBFile_DELETE_FROM.log", ex.ToString());
                }
                //finally
                //{
                //    cmd.Dispose();
                //}
            }


            #region OldCode
            //string sql;
            //sql = "DELETE FROM [z_cpu]";
            //OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_acpu]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_mb]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_ram]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_hdd]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_ssd]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_box]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_pow]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_lcd]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_hs]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_kb]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();

            //sql = "DELETE FROM [z_mou]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_cam]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_sp]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_o]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_fan]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_cdrom]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            //sql = "DELETE FROM [z_gpu]";
            //cmd = new OleDbCommand(sql, hwaddConnection);
            //cmd.ExecuteNonQuery();
            ///////////////////////////////////////////////////
            #endregion
            savelog = SmartCorrection(savelog);
            //try
            //{
            for (int i = 0; i < MainDt.Rows.Count; i++)
            {
                string hw = "";
                if (MainDt.Rows[i][1].ToString() == "集成显卡/核心显卡" || MainDt.Rows[i][1].ToString() == "盒装自带" || MainDt.Rows[i][1].ToString() == "机箱自带" || MainDt.Rows[i][1].ToString() == "套装自带") continue;
                switch (MainDt.Rows[i][0].ToString())
                {
                    case "CPU":
                        hw = "cpu";
                        break;
                    case "AMD CPU":
                        hw = "acpu";
                        break;
                    case "主板":
                        hw = "mb";
                        break;
                    case "内存":
                        hw = "ram";
                        break;
                    case "显卡":
                        hw = "gpu";
                        break;
                    case "硬盘":
                        hw = "hdd";
                        break;
                    case "固态硬盘":
                        hw = "ssd";
                        break;
                    case "机箱":
                        hw = "box";
                        break;
                    case "电源":
                        hw = "pow";
                        break;
                    case "散热器":
                        hw = "fan";
                        break;
                    case "显示器":
                        hw = "lcd";
                        break;
                    case "键盘":
                        hw = "kb";
                        break;
                    case "鼠标":
                        hw = "mou";
                        break;
                    case "光驱":
                        hw = "cdrom";
                        break;
                    case "摄像头":
                        hw = "cam";
                        break;
                    case "耳机":
                        hw = "hs";
                        break;
                    case "音响":
                        hw = "sp";
                        break;
                    case "其他":
                        hw = "o";
                        break;
                    default:
                        continue;

                        //...
                        //case "
                }
                hw = "z_" + hw;
                OleDbParameter[] pms = new OleDbParameter[]
                    {
                        new OleDbParameter ("@name",OleDbType.VarChar,255),
                        new OleDbParameter ("@bprice",OleDbType.VarChar,255),
                        new OleDbParameter ("@sprice",OleDbType.VarChar,255),
                        new OleDbParameter("@qa",OleDbType.VarChar,255),
                        new OleDbParameter("@DBID",OleDbType.BigInt )
                    };
                pms[0].Value = MainDt.Rows[i][1].ToString();
                pms[1].Value = MainDt.Rows[i][3].ToString();
                pms[2].Value = MainDt.Rows[i][2].ToString();
                pms[3].Value = MainDt.Rows[i][4].ToString();
                pms[4].Value = string.IsNullOrEmpty(MainDt.Rows[i][5].ToString()) ? 0 : Int64.Parse(MainDt.Rows[i][5].ToString());
                string sql = "insert into " + hw + "(name,bprice,sprice,qa,DBID)values(@name,@bprice,@sprice,@qa,@DBID);";

                try
                {
                    MDBHelper.ExecuteNonQuery(con, sql, pms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存出现严重错误\n" + ex.ToString());
                    Log.WriteLog("SaveMDBFile_insert.log", ex.ToString());

                    MDBHelper.CloseConnection(con);
                    File.Delete(Form1.userpath + "\\AutoBackup\\DataTableTempBackup.xml");
                    File.WriteAllText(Form1.userpath + "\\AutoBackup\\DataTableTempBackup.xml", DataTableSerializer.SerializeDataTableXml(MainDt, Form1.userpath + "DataTableTempBackup"));
                    //RestoreLastestBackup();



                    //DeCompressFile(SettingItems.MdbPath, Form1.userpath + "\\AutoBackup\\" + System.DateTime.Now.ToFileTime() + ".mdb.zip");

                }
                //string sql = "insert into " + hw + "(name,bprice,sprice,qa,DBID)values('" + MainDt.Rows[i][1].ToString() + "','" + MainDt.Rows[i][3].ToString() + "','" + MainDt.Rows[i][2].ToString() + "','" + MainDt.Rows[i][4].ToString() + "','" + MainDt.Rows[i][5].ToString() + "')";
                //OleDbCommand cmd = new OleDbCommand(sql, hwaddConnection);
                //cmd.ExecuteNonQuery();
                //cmd.Dispose();

            }
            if (con.State == ConnectionState.Open)
            {
                MDBHelper.CloseConnection(con);
            }
            #region ConOldCode
            //hwaddConnection.Close();
            //hwaddConnection.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("保存出现严重错误\n" + ex.ToString());

            //}
            #endregion
            if (File.Exists(Form1.userpath + "\\AutoBackup\\DataTableTempBackup.xml"))
            {
                if (e != null)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(savelog))
                {
                    if (!isQuiet)
                    {
                        MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    isedited = false;
                    //File.Delete(Application.StartupPath + "\\tempsave.mdb");
                }
                else
                {
                    isedited = false;
                    Log.WriteLog("Panel_Save.log", savelog);
                    if (DialogResult.Yes == MessageBox.Show("保存出现部分错误！\n详情查看日志文件Panel_Save.log\n是否现在打开？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    {
                        Log.OpenLogFile("Panel_Save.log");
                        //Process.Start(Form1.userpath + "\\logs\\Panel_Save.log");
                    }

                }
            }


        }
        private static void RestoreLastestBackup()
        {
            List<string> bkFileName = new List<string>();
            foreach (var item in Directory.GetFiles(Form1.userpath + "\\AutoBackup\\", "*.zip"))
            {
                bkFileName.Add(item);
            }
            bkFileName.Sort();
            try
            {
                Compress.DeCompressFile(bkFileName[bkFileName.Count - 1], Form1.userpath);
                MessageBox.Show("恢复备份成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("恢复备份文件出错+\n" + ex.ToString());
                Log.WriteLog("RestoreLastestBackup.log", ex.ToString());
            }
        }
        #endregion
        private string SmartCorrection(string savelog)
        {
            for (int i = 0; i < MainDt.Rows.Count; i++)
            {
                //智能纠错
                try
                {

                    string currentName = MainDt.Rows[i][1].ToString();
                    //MessageBox.Show(MainDt.Rows[i][1].ToString ());
                    if (currentName.Contains("k"))
                    { MainDt.Rows[i][1] = currentName.Replace("k", "K"); }

                    if (currentName.Contains("I3"))
                    { MainDt.Rows[i][1] = currentName.Replace("I", "i3"); }
                    if (currentName.Contains("I5"))
                    { MainDt.Rows[i][1] = currentName.Replace("I", "i5"); }
                    if (currentName.Contains("I7"))
                    { MainDt.Rows[i][1] = currentName.Replace("I", "i7"); }


                    if (currentName.Contains("（"))
                    { MainDt.Rows[i][1] = currentName.Replace("（", "("); }
                    if (currentName.Contains("）"))
                    { MainDt.Rows[i][1] = currentName.Replace("）", ")"); }
                    if (currentName.Contains("*"))
                    { MainDt.Rows[i][1] = currentName.Replace("*", "X"); }

                    if (string.IsNullOrEmpty(MainDt.Rows[i][2].ToString())) { dataGridView1.Rows[i].Cells[2].Value = "0"; }
                    if (string.IsNullOrEmpty(MainDt.Rows[i][3].ToString())) { dataGridView1.Rows[i].Cells[3].Value = "0"; }
                    if (string.IsNullOrEmpty(MainDt.Rows[i][4].ToString())) { dataGridView1.Rows[i].Cells[4].Value = "0"; }
                    if (MainDt.Rows[i][0].ToString() == "内存" || MainDt.Rows[i][0].ToString() == "硬盘")
                    {
                        //g替换为G,b替换为B,t替换为T
                        if (currentName.Contains("g"))
                        { MainDt.Rows[i][1] = currentName.Replace("g", "G"); }
                        if (currentName.Contains("b"))
                        { MainDt.Rows[i][1] = currentName.Replace("b", "B"); }
                        if (currentName.Contains("t"))
                        { MainDt.Rows[i][1] = currentName.Replace("t", "T"); }
                        //G替换为GB
                        if (currentName.Contains("G") && !currentName.Contains("B"))
                        { MainDt.Rows[i][1] = currentName.Replace("G", "GB"); }
                        //T替换为TB
                        if (currentName.Contains("T") && !currentName.Contains("B"))
                        { MainDt.Rows[i][1] = currentName.Replace("T", "TB"); }
                    }
                    else if (MainDt.Rows[i][0].ToString() == "主板")
                    {
                        bool isOK = false;
                        foreach (var item in SData.IntelChipest)
                        {
                            if (currentName.Contains(item))
                            {
                                isOK = true;
                                break;
                            }
                        }
                        if (!isOK)
                        {
                            foreach (var item in SData.AMDSocket)
                            {
                                if (currentName.Contains(item))
                                {
                                    isOK = true;
                                    break;
                                }
                            }
                        }
                        if (!isOK)
                        {
                            savelog += "第" + (i + 1).ToString() + "行" + MainDt.Rows[i][1].ToString() + "未写明芯片组信息（Intel平台）或接口（AMD平台）或芯片组暂不支持！\n可能导致自动攒机时无法正常识别！" + "\r\n";
                        }

                    }
                    else if (MainDt.Rows[i][0].ToString().Contains("CPU"))
                    {
                        bool isOk = false;
                        foreach (var item in SData.IntelCpuSeries)
                        {
                            if (currentName.Contains(item))
                            {
                                isOk = true;
                                break;

                            }
                        }
                        if (!isOk)
                        {
                            foreach (var item in SData.AMDCpuSeries)
                            {
                                if (currentName.Contains(item))
                                {
                                    isOk = true;
                                    break;
                                }
                            }
                        }
                        if (!isOk)
                        {
                            savelog += "第" + (i + 1).ToString() + "行" + MainDt.Rows[i][1].ToString() + "未写明CPU型号或型号暂不支持！\n可能导致自动攒机时无法正常识别！" + "\r\n";
                        }
                        //if (!SData .IntelCpuSeries .Contains )
                        //if (!(MainDt.Rows[i][1].ToString().Contains("i3") || MainDt.Rows[i][1].ToString().Contains("i5") || MainDt.Rows[i][1].ToString().Contains("i7") || MainDt.Rows[i][1].ToString().Contains("E3") || MainDt.Rows[i][1].ToString().Contains("奔腾") || MainDt.Rows[i][1].ToString().Contains("赛扬") || MainDt.Rows[i][1].ToString().Contains("FX") || MainDt.Rows[i][1].ToString().Contains("A4") || MainDt.Rows[i][1].ToString().Contains("A6") || MainDt.Rows[i][1].ToString().Contains("A8") || MainDt.Rows[i][1].ToString().Contains("A10") || MainDt.Rows[i][1].ToString().Contains("速龙") || MainDt.Rows[i][1].ToString().Contains("羿龙")))
                        //{
                        //    savelog += "第" + (i + 1).ToString() + "行" + MainDt.Rows[i][1].ToString() + "未写明CPU型号或型号暂不支持！\n可能导致无法正常识别！" + "\r\n";

                        //    //MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n未写明CPU型号或型号暂不支持！\n可能导致无法正常识别！");
                        //}

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存出现严重错误！" + ex.ToString());
                }
            }
            return savelog;
        }
        private bool DataGridviewShowToExcel(DataGridView dgv, bool isShowExcle)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                    return false;
                //建立Excel对象      
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                excel.Visible = isShowExcle;
                //生成字段名称      
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }
                //填充数据      
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("此功能需要安装完整版MS OFFICE！\n" + ex.ToString());
                Log.WriteLog("DataGridviewShowToExcel.log", ex.ToString());
                return false;
            }
        }

        private void DeleteRow()
        {

            DialogResult RSS = MessageBox.Show(this, "确定要删除选中行数据码？\n此操作不可撤销！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (RSS == DialogResult.No) return;


            List<int> listDel = new List<int>();

            //MessageBox.Show(dataGridView1.SelectedRows.Count.ToString());
            //MessageBox.Show(this.dataGridView1.SelectedRows.Count.ToString());
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                isedited = true;
                if (!listDel.Contains(dataGridView1.SelectedCells[i].RowIndex))
                {
                    listDel.Add(dataGridView1.SelectedCells[i].RowIndex);
                }
            }
           
            listDel.Sort(new Comparison<int>((x, y) => y-x));
          
            foreach (var item in listDel)
            {
                try
                {
                    int rowIndex = item;
                    MainDt.Rows[showmain[rowIndex]].Delete();
                    ShowDt.Rows[rowIndex].Delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(searchstring))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        visable_row_count++;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }

            }
            cm.ResumeBinding();
            labelstatus.Text = "当前显示数据: " + visable_row_count.ToString() + " 条";

        }

        private void DeleteOldBackupFile()
        {
            DirectoryInfo TFolder = new DirectoryInfo(Form1.userpath + "\\AutoBackup");
            //MessageBox.Show(TFolder.GetFiles().Length.ToString());
            if (TFolder.GetFiles().Length < 5) return;
            FileInfo[] fileInfo = TFolder.GetFiles();


            Array.Sort<FileInfo>(fileInfo, new FileInfoSorterDesc());
            for (int i = 5; i < fileInfo.Length; i++)
            {

                fileInfo[i].Delete();
            }

            //FileInfo oldest = fileInfo[0];
            //foreach (FileInfo NextFile in fileInfo)
            //{
            //    if (CompareFile(NextFile, oldest) == 1)
            //    {
            //        oldest = NextFile;
            //    }
            //}
            //oldest.Delete();
            //遍历文件
            //this.listBox2.Items.Add(NextFile.Name);


        }
        void tsi_Click(object sender, EventArgs e)
        {
            isedited = true;
            try
            {


                //if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                //{
                //    int RowNumber = dataGridView1.SelectedCells[0].RowIndex;
                //    DataRow row = ShowDt.NewRow();
                //    row[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                //    row[1] = " ";
                //    row[2] = "0";
                //    row[3] = "0";
                //    row[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                //    ShowDt.Rows.InsertAt(row, RowNumber);

                //    DataRow row2 = MainDt.NewRow();
                //    row2[0] = dataGridView1.Rows[RowNumber].Cells[0].Value;
                //    row2[1] = " ";
                //    row2[2] = "0";
                //    row2[3] = "0";
                //    row2[4] = dataGridView1.Rows[RowNumber].Cells[4].Value;

                //    MainDt.Rows.InsertAt(row2, showmain[RowNumber]);
                //}
                //else
                //{
                DataRow row = ShowDt.NewRow();
                row[0] = ((HardWareKind)((ToolStripItem)sender).Tag).KindNameCh;
                row[1] = " ";
                row[2] = "0";
                row[3] = "0";
                row[4] = "0";

                ShowDt.Rows.InsertAt(row, 0);

                DataRow row2 = MainDt.NewRow();
                row2[0] = ((HardWareKind)((ToolStripItem)sender).Tag).KindNameCh;
                row2[1] = " ";
                row2[2] = "0";
                row2[3] = "0";
                row2[4] = "0";
                MainDt.Rows.InsertAt(row2, 0);

                //}
                //MainDt.Rows[showmain[RowNumber]][2] = ShowDt.Rows[i][2];

            }
            catch (Exception ex)
            {
                MessageBox.Show("插入错误！" + ex.ToString());
            }
        }

    }
    public class FileInfoSorterDesc : IComparer<FileInfo>
    {
        #region IComparer Members
        public int Compare(FileInfo x, FileInfo y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }
            FileInfo xInfo = x;
            FileInfo yInfo = y;


            //依名稱排序    
            //return xInfo.FullName.CompareTo(yInfo.FullName);//遞增    
            return yInfo.FullName.CompareTo(xInfo.FullName);//遞減    

            //依修改日期排序    
            //return xInfo.LastWriteTime.CompareTo(yInfo.LastWriteTime);//遞增    
            //return yInfo.LastWriteTime.CompareTo(xInfo.LastWriteTime);//遞減    
        }
        #endregion
    }

}
