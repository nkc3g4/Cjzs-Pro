/*  public static string FileToMD5(string path)
    {
        try
        {
            FileStream get_file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            MD5CryptoServiceProvider get_md5 = new MD5CryptoServiceProvider();
            byte[] hash_byte = get_md5.ComputeHash(get_file);
            string resule = System.BitConverter.ToString(hash_byte);
            resule = resule.Replace("-", "");
            return resule.ToUpper();
        }
        catch (Exception e) { return e.ToString(); }
    }*/
#region 201510172947
//private void label14_Click(object sender, EventArgs e)
//{
//    System.Diagnostics.Process.Start("http://litianchang.cn");
//}

//private void Comboboxcpu_MouseHover(object sender, System.EventArgs e)
//{
//    //toolTip1.SetToolTip(this.ComboBoxcpu , ComboBoxcpu .SelectedItem .ToString ());
//}
//private void Comboboxmb_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxmb, ComboBoxmb.SelectedItem.ToString());
//}
//private void Comboboxgpu_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxgpu, ComboBoxgpu.SelectedItem.ToString());
//}
//private void Comboboxram_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxram, ComboBoxram.SelectedItem.ToString());
//}
//private void Comboboxhdd_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxhdd, ComboBoxhdd.SelectedItem.ToString());
//}
//private void Comboboxlcd_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxlcd, ComboBoxlcd.SelectedItem.ToString());
//}
//private void Comboboxbox_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxbox, ComboBoxbox.SelectedItem.ToString());
//}
//private void Comboboxfan_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxfan, ComboBoxfan.SelectedItem.ToString());
//}
//private void Comboboxpower_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxpower, ComboBoxpower.SelectedItem.ToString());
//}
//private void Comboboxcdrom_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxcdrom, ComboBoxcdrom.SelectedItem.ToString());
//}
//private void Comboboxkb_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxkb, ComboBoxkb.SelectedItem.ToString());
//}
//private void Comboboxssd_MouseHover(object sender, System.EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxssd, ComboBoxssd.SelectedItem.ToString());
//}


//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
//{
//    //if (trial == 1&&frestart==0)
//    //{
//    //    System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
//    //    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请联系作者购买！\nQQ:1409231794 官方网站 cuanji.luobotou.pw", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    //}

//    //try
//    //{

//    //    if (threadupdate.IsAlive) //判断thread1是否存在，不能撤消一个不存在的线程，否则会引发异常
//    //    {
//    //        threadupdate.Abort();
//    //    }
//    //}
//    //catch { }
//    //try { if (threadreport.IsAlive) { threadreport.Abort(); } }
//    //catch { }

//}

//private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
//{

//}


//private void 反馈建议ToolStripMenuItem_Click(object sender, EventArgs e)
//{

//}


//private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
//{

//}

//private void 启动时自动检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
//{

//}

//private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
//{

//}

//private void toolTip1_Popup(object sender, PopupEventArgs e)
//{

//}



//private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
//{

//}

//private void TextBoxcpu1_TextChanged(object sender, EventArgs e)
//{

//}
//private void TextBoxcpu1_Click(object sender, EventArgs e)
//{
//    if (TextBoxcpu.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxcpu.Text)));
//}

//private void TextBoxmb1_Click(object sender, EventArgs e)
//{
//    if (TextBoxmb.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxmb.Text)));
//}

//private void TextBoxram1_Click(object sender, EventArgs e)
//{
//    if (TextBoxram.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxram.Text)));
//}

//private void TextBoxhdd1_Click(object sender, EventArgs e)
//{
//    if (TextBoxhdd.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxhdd.Text)));
//}

//private void textBoxssd1_Click(object sender, EventArgs e)
//{
//    if (TextBoxssd.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxssd.Text)));
//}

//private void TextBoxgpu1_Click(object sender, EventArgs e)
//{
//    if (TextBoxgpu.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxgpu.Text)));
//}

//private void TextBoxlcd1_Click(object sender, EventArgs e)
//{
//    if (TextBoxlcd.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxlcd.Text)));
//}

//private void TextBoxbox1_Click(object sender, EventArgs e)
//{
//    if (TextBoxbox.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxbox.Text)));
//}

//private void TextBoxfan1_Click(object sender, EventArgs e)
//{
//    if (TextBoxfan.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxfan.Text)));
//}

//private void TextBoxpower1_Click(object sender, EventArgs e)
//{
//    if (TextBoxpower.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxpower.Text)));
//}

//private void textBoxcdrom1_Click(object sender, EventArgs e)
//{
//    if (TextBoxcdrom.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxcdrom.Text)));
//}

//private void textBoxkb1_Click(object sender, EventArgs e)
//{
//    if (TextBoxkb.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxkb.Text)));
//}

//private void 去打印版权ToolStripMenuItem_Click(object sender, EventArgs e)
//{

//}

//private void 去打印版权ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
//{
//    //if (trial == true)
//    //{
//    //    System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
//    //    MessageBox.Show("试用版无此功能，如果您喜欢本软件，请联系作者购买！\nQQ:1409231794 官方网站 cuanji.luobotou.pw", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    //    return;
//    //}
//    //copyright = !去打印版权ToolStripMenuItem.Checked;
//}

//private void checkBox1_CheckedChanged(object sender, EventArgs e)
//{

//}


//private void cpuz_CheckedChanged(object sender, EventArgs e)
//{
//    totalprice();
//    //if (TextBoxcpu.Text ==" ") { return; }
//    //if (cpuz.Checked)
//    //{
//    //    cpu1[0] = 0;
//    //    totalprice();
//    //}
//    //else 
//    //{
//    //    if (ComboBoxcpu.SelectedIndex == 0)
//    //    { cpu1[0] = SData.hwCpu.HWChoice.Price; }
//    //    else { cpu1[0] = cpu1[ComboBoxcpu.SelectedIndex]; }
//    //    totalprice();
//    //}

//}

//private void comboBoxhs_MouseHover(object sender, EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxhs, ComboBoxhs.SelectedItem.ToString());

//}

//private void comboBoxcam_MouseHover(object sender, EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxcam, ComboBoxcam.SelectedItem.ToString());
//}


//private void comboBoxsp_MouseHover(object sender, EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxsp, ComboBoxsp.SelectedItem.ToString());
//}

//private void comboBoxo_MouseHover(object sender, EventArgs e)
//{
//    toolTip1.SetToolTip(this.ComboBoxo, ComboBoxo.SelectedItem.ToString());
//}

//private void mbz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (trial == true)
//    //{
//    //    //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
//    //    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    //}
//    //if (TextBoxmb.Text == " ") { return; }
//    //if (mbz.Checked) {mb1[0] = 0; } else{ mb1[0] = mb1[mb_choice ];}
//    totalprice();

//}

//private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
//{

//}

//private void ramz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxram.Text == " ") { return; }
//    //if (ramz.Checked) { ram1[0] = 0; } else { ram1[0] = ram1[ram_choice]; }
//    totalprice();

//}

//private void hddz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxhdd.Text == " ") { return; }
//    //if (hddz.Checked) { hdd1[0] = 0; } else { hdd1[0] = hdd1[hdd_choice]; }
//    totalprice();

//}

//private void ssdz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxssd.Text == " ") { return; }
//    //if (ssdz.Checked) { ssd1[0] = 0; } else { ssd1[0] = ssd1[ssd_choice]; }
//    totalprice();

//}

//private void gpuz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxgpu.Text == " ") { return; }
//    //if (gpuz.Checked) { gpu1[0] = 0; } else { gpu1[0] = gpu1[gpu_choice ]; }
//    totalprice();

//}

//private void lcdz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxlcd.Text == " ") { return; }
//    //if (lcdz.Checked) { lcd1[0] = 0; } else { lcd1[0] = lcd1[lcd_choice]; }
//    totalprice();

//}

//private void boxz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxbox.Text == " ") { return; }
//    //if (boxz.Checked) { box1[0] = 0; } else { box1[0] = box1[box_choice]; }
//    totalprice();

//}

//private void fanz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxfan.Text == " ") { return; }
//    //if (fanz.Checked) { fan1[0] = 0; } else { fan1[0] = fan1[fan_choice]; }
//    totalprice();

//}

//private void powerz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (TextBoxpower.Text == " ") { return; }
//    //if (powerz.Checked) { power1[0] = 0; } else { power1[0] = power1[power_choice]; }
//    totalprice();

//}

//private void cdromz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxcdrom.Text == " ") { return; }
//    //if (cdromz.Checked) { cdrom1[0] = 0; } else { cdrom1[0] = cdrom1[cdrom_choice]; }
//    totalprice();

//}

//private void kbz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxkb.Text == " ") { return; }
//    //if (cdromz.Checked) { cdrom1[0] = 0; } else { cdrom1[0] = cdrom1[kb_choice]; }
//    totalprice();

//}

//private void hsz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxhs.Text == " ") { return; }
//    //if (hsz.Checked) { hs1[0] = 0; } else { hs1[0] = hs1[hs_choice]; }
//    totalprice();

//}

//private void camz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxcam.Text == " ") { return; }
//    //if (camz.Checked) { cam1[0] = 0; } else { cam1[0] = cam1[cam_choice]; }
//    totalprice();

//}

//private void spz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxsp.Text == " ") { return; }
//    //if (spz.Checked) { sp1[0] = 0; } else { sp1[0] = sp1[sp_choice]; }
//    totalprice();

//}

//private void oz_CheckedChanged(object sender, EventArgs e)
//{
//    //if (textBoxo.Text == " ") { return; }
//    //if (oz.Checked) { o1[0] = 0; } else { o1[0] = o1[o_choice]; }
//    totalprice();

//}
///// <summary>
///// //////////////////////
///// </summary>
///// <param name="sender"></param>
///// <param name="e"></param>
//private void ComboBoxmb_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxmb.Text == " ") { return; }
//    CbbSelIndexChanged(sender);
//    //if (ComboBoxmb.SelectedIndex != 0)
//    //{
//    //    mb_choice = ComboBoxmb.SelectedIndex;
//    //    //mb[0] = mb[ComboBoxmb.SelectedIndex];
//    //    //mb1[0] = mb1[ComboBoxmb.SelectedIndex];
//    //}
//    //else
//    //{
//    //    if (fixmode) { c_mb(); }
//    //    else { mb_choice = 0; }
//    //    //if (mb_choice == 0 || mb_choice == -1) { mb[0] = " "; mb1[0] = 0; }
//    //    //else
//    //    //{
//    //    //    //mb[0] = mb[mb_choice];
//    //    //    //mb1[0] = mb1[mb_choice];
//    //    //}
//    //}
//    ////if (mbz.Checked) { mb1[0] = 0; }

//    //totalprice();

//}

//private void ComboBoxram_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxram.Text == " ") { return; }
//    CbbSelIndexChanged(sender);
//    //if (ComboBoxram.SelectedIndex != 0)
//    //{
//    //    ram_choice = ComboBoxram.SelectedIndex;
//    //    //ram[0] = ram[ComboBoxram.SelectedIndex];
//    //    //ram1[0] = ram1[ComboBoxram.SelectedIndex];
//    //}
//    //else
//    //{
//    //    if (fixmode) { c_ram(); }
//    //    else { ram_choice = 0; }

//    //    //if (ram_choice == 0) 
//    //    //{ 
//    //    //    ram[0] = " "; ram1[0] = 0; 
//    //    //}
//    //    //else
//    //    //{
//    //    //    ram[0] = ram[ram_choice];
//    //    //    ram1[0] = ram1[ram_choice];
//    //    //}
//    //}
//    ////if (ramz.Checked) { ram1[0] = 0; }

//    //totalprice();

//}
//private void comboBoxsp_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxsp.Text == " ") { return; }
//    CbbSelIndexChanged(sender);

//}

//private void comboBoxssd_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxssd.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxgpu_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxgpu.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxlcd_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxlcd.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxbox_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxbox.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxfan_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxfan.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxpower_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxpower.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void ComboBoxcdrom_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxcdrom.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void comboBoxhs_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxhs.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void comboBoxcam_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxcam.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}

//private void comboBoxo_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (textBoxo.Text == " ") { return; }
//    CbbSelIndexChanged(sender);


//}
//private void ComboBoxhdd_SelectedIndexChanged(object sender, EventArgs e)
//{
//    //if (TextBoxhdd.Text == " ") { return; }
//    CbbSelIndexChanged(sender);

//}

//private void comboBoxkb_SelectedIndexChanged(object sender, EventArgs e)
//{
//    CbbSelIndexChanged(sender);


//}

//private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
//{

//}

//private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
//{

//}

//private void hezhuangcpu_CheckedChanged(object sender, EventArgs e)
//{
//    //if (checkCuste3.CheckState == CheckState.Checked && checkCustBoxedCpu.Checked) { MessageBox.Show("E3 CPU无盒装"); checkCustBoxedCpu.Checked = false; }
//    //if (checkCustBoxedCpu.Checked) { cpusr2 = "盒"; } else { cpusr2 = ""; }

//}

//private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
//{

//}

//private void groupBox3_Enter(object sender, EventArgs e)
//{

//}

//private void comboBoxmou_SelectedIndexChanged(object sender, EventArgs e)
//{
//    CbbSelIndexChanged(sender);
//    //if (ComboBoxmou.SelectedIndex != 0)
//    //{
//    //    mou_choice = ComboBoxmou.SelectedIndex;
//    //}
//    //else
//    //{
//    //    if (fixmode) c_mou();
//    //    else mou_choice = 0;

//    //}


//    //totalprice();

//}

//private void textBoxmou1_Click(object sender, EventArgs e)
//{
//    if (TextBoxmou.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxmou.Text)));

//}

//private void textBoxhs1_Click(object sender, EventArgs e)
//{
//    if (TextBoxhs.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxhs.Text)));

//}

//private void textBoxcam1_Click(object sender, EventArgs e)
//{
//    if (TextBoxcam.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxcam.Text)));

//}

//private void textBoxsp1_Click(object sender, EventArgs e)
//{
//    if (TextBoxsp.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxsp.Text)));

//}

//private void textBoxo1_Click(object sender, EventArgs e)
//{
//    if (TextBoxo.Text == "") { return; }
//    System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(TextBoxo.Text)));

//}

//private void textBoxmou1_TextChanged(object sender, EventArgs e)
//{
//    //if (textBoxmou.Text == "") { return; }
//    //System.Diagnostics.Process.Start("http://www.baidu.com/s?wd=" + System.Text.Encoding.GetEncoding("gbk").GetString(System.Text.Encoding.Default.GetBytes(textBoxmou.Text)));

//}


//TBLogin tbl = new TBLogin();
//tbl.LoginTaobao("microsoft5133@126.com", "microsoft7410Q");
//CPU CP = new CPU();
//CP.P1 = 100;
//GPU GP = new GPU();
//GP.P1 = 200;
//MessageBox.Show(CP.P1.ToString());


//object PageType = Word.WdPrintOutPages.wdPrintAllPages;
//object PrintToFile = false;
//object Collate = false;
//object ActivePrinterMacGX = missing;
//object ManualDuplexPrint = false;
//object PrintZoomColumn = 1;
//object PrintZoomRow = 1;

//this.PrintOut(ref Background, ref missing, ref Range, ref missing,
//    ref missing, ref missing, ref missing, ref Copies,
//    ref missing, ref PageType, ref PrintToFile, ref Collate,
//    ref missing, ref ManualDuplexPrint, ref PrintZoomColumn,
//    ref PrintZoomRow, ref missing, ref missing);

//private void ComboBoxInitialization(ComboBox cbb)
//{
//    cbb.Items.Clear();
//    cbb.Items.Add("自动选择");
//    cbb.SelectedIndex = 0;
//}


#region OldCode
//string sql;
//sql = "insert into cuanji(时间,程序版本,客户名称,联系电话,备注,总价,CPU,CPU价格,主板,主板价格,内存,内存价格,硬盘,硬盘价格,固态硬盘,固态硬盘价格,
//显卡,显卡价格,显示器,显示器价格,机箱,机箱价格,散热器,散热器价格,电源,电源价格,光驱,光驱价格,键盘,键盘价格,鼠标,鼠标价格,耳机,耳机价格,摄像头
//,摄像头价格,音响,音响价格,其他,其他价格)values('" + System.DateTime.Now + "','" + Application.ProductVersion 
//+ "','" + textBoxname.Text + "','" + textBoxphone.Text + "','" + textBoxcomments.Text + "','" +
//sum + "','" + TextBoxcpu.Text + "','" + TextBoxcpu1.Text + "','" + TextBoxmb.Text + "','" + TextBoxmb1.Text +
//"','" + TextBoxram.Text + "','" + TextBoxram1.Text + "','" + TextBoxhdd.Text + "','" + TextBoxhdd1.Text + "','" + TextBoxssd.Text 
//    + "','" + TextBoxssd1.Text + "','" + TextBoxgpu.Text + "','" + TextBoxgpu1.Text + "','" + 
//    TextBoxlcd.Text + "','" + TextBoxlcd1.Text + "','" + TextBoxbox.Text + "
//','" + TextBoxbox1.Text + "','" + TextBoxfan.Text + "','" + TextBoxfan1.Text +
//"','" + TextBoxpower.Text + "','" + TextBoxpower1.Text + "','" + 
//    TextBoxcdrom.Text + "','" + TextBoxcdrom1.Text + "','" + TextBoxkb.Text + "','" + 
//    TextBoxkb1.Text + "','" + TextBoxmou.Text + "','" + TextBoxmou1.Text + "','" + 
//    TextBoxhs.Text + "','" + TextBoxhs1.Text + "','" + TextBoxcam.Text + "','" + 
//    TextBoxcam1.Text + "','" + TextBoxsp.Text + "','" + TextBoxsp1.Text + "','" +
//    TextBoxo.Text + "','" + TextBoxo1.Text + "')";

//OleDbCommand cmd = new OleDbCommand(sql, odcConnection);
//cmd.ExecuteNonQuery();
//odcConnection.Close();
#endregion

//choice = Closest.cauto(cpu, cpu1, money / 5, incpart, notincpart, cpusr);
// choice = closest(cpu1, money / 5);


//if (choice == 0 || choice == -1)
//{
//    acpu_choice = 0;
//    //cpu[0] = "没有找到符合要求的配件。"; cpu1[0] = 0;
//}
//else
//{
//    acpu_choice = choice;
//    //cpu[0] = acpu[choice];
//    //cpu1[0] = acpu1[choice];
//    //cpu2[0] = acpu2[choice];

//}
// ivb = cpu[choice].IndexOf("7");
//if (ComboBoxmb.SelectedIndex != 0)
//{
//    mbchoice = ComboBoxmb.SelectedIndex;
//}
//else
//{

//string mbChip = string.Empty;
//int mbMoney = 0;

//mbchoice = Closest.cauto(mb, mb1, 600, "Z87", mbsr);
//if (mbchoice == 0 || mbchoice == -1)
//{
//    mbchoice = Closest.cauto(mb, mb1, 800, "Z97", mbsr);
//}
//if (mbchoice == 0 || mbchoice == -1)
//{
//    mbchoice = Closest.cauto(mb, mb1, 400, "B85", mbsr);
//}
//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 400, "H87", mbsr); }


//if (mbchoice == 0 || mbchoice == -1) 
//{ 
//    mbchoice = Closest.cauto(mb, mb1, 500, "H81", mbsr);
//}
//if (mbchoice == 0 || mbchoice == -1) 
//{
//    mbchoice = Closest.cauto(mb, mb1, 500, "H87", mbsr); 
//}


//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 600, "H87", mbsr); }
//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 600, "H81", mbsr); }
//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 600, "Z87", mbsr); }
//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 800, "Z97", mbsr); }

//mbchoice = Closest.cauto(mb, mb1, 500, "B85", mbsr); 

//if (mbchoice == 0 || mbchoice == -1) 
//{ 
//    mbchoice = Closest.cauto(mb, mb1, 500, "H61", mbsr); 
//}



#endregion



//if (comboBox1.SelectedIndex == 0) //机箱
//{
//    ReadCustomRatio(SData.hwBox.CuanJiPofile);
//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.boxp1.ToString();
//    //textBoxp21.Text = Form1.boxp1.ToString();
//    //textBoxp22.Text = Form1.boxp2.ToString();
//    //textBoxp31.Text = Form1.boxp2.ToString();
//    //textBoxp32.Text = Form1.boxp3.ToString();
//    //textBoxp41.Text = Form1.boxp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.boxk1.ToString();
//    //textBoxk2.Text = Form1.boxk2.ToString();
//    //textBoxk3.Text = Form1.boxk3.ToString();
//    //textBoxk4.Text = Form1.boxk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 1)//电源
//{
//    ReadCustomRatio(SData.hwPower.CuanJiPofile);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.powp1.ToString();
//    //textBoxp21.Text = Form1.powp1.ToString();
//    //textBoxp22.Text = Form1.powp2.ToString();
//    //textBoxp31.Text = Form1.powp2.ToString();
//    //textBoxp32.Text = Form1.powp3.ToString();
//    //textBoxp41.Text = Form1.powp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.powk1.ToString();
//    //textBoxk2.Text = Form1.powk2.ToString();
//    //textBoxk3.Text = Form1.powk3.ToString();
//    //textBoxk4.Text = Form1.powk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 2) //光驱
//{
//    ReadCustomRatio(Form1.cjcdrom);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.cdromp1.ToString();
//    //textBoxp21.Text = Form1.cdromp1.ToString();
//    //textBoxp22.Text = Form1.cdromp2.ToString();
//    //textBoxp31.Text = Form1.cdromp2.ToString();
//    //textBoxp32.Text = Form1.cdromp3.ToString();
//    //textBoxp41.Text = Form1.cdromp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.cdromk1.ToString();
//    //textBoxk2.Text = Form1.cdromk2.ToString();
//    //textBoxk3.Text = Form1.cdromk3.ToString();
//    //textBoxk4.Text = Form1.cdromk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 3)//键盘
//{
//    ReadCustomRatio(Form1.cjkb);

//    //                textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.kbp1.ToString();
//    //textBoxp21.Text = Form1.kbp1.ToString();
//    //textBoxp22.Text = Form1.kbp2.ToString();
//    //textBoxp31.Text = Form1.kbp2.ToString();
//    //textBoxp32.Text = Form1.kbp3.ToString();
//    //textBoxp41.Text = Form1.kbp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.kbk1.ToString();
//    //textBoxk2.Text = Form1.kbk2.ToString();
//    //textBoxk3.Text = Form1.kbk3.ToString();
//    //textBoxk4.Text = Form1.kbk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 4)//鼠标
//{
//    ReadCustomRatio(Form1.cjmou);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.moup1.ToString();
//    //textBoxp21.Text = Form1.moup1.ToString();
//    //textBoxp22.Text = Form1.moup2.ToString();
//    //textBoxp31.Text = Form1.moup2.ToString();
//    //textBoxp32.Text = Form1.moup3.ToString();
//    //textBoxp41.Text = Form1.moup3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.mou1.ToString();
//    //textBoxk2.Text = Form1.mouk2.ToString();
//    //textBoxk3.Text = Form1.mouk3.ToString();
//    //textBoxk4.Text = Form1.mouk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 5)//耳机
//{
//    ReadCustomRatio(Form1.cjhs);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.hsp1.ToString();
//    //textBoxp21.Text = Form1.hsp1.ToString();
//    //textBoxp22.Text = Form1.hsp2.ToString();
//    //textBoxp31.Text = Form1.hsp2.ToString();
//    //textBoxp32.Text = Form1.hsp3.ToString();
//    //textBoxp41.Text = Form1.hsp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.hsk1.ToString();
//    //textBoxk2.Text = Form1.hsk2.ToString();
//    //textBoxk3.Text = Form1.hsk3.ToString();
//    //textBoxk4.Text = Form1.hsk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 6)//摄像头
//{
//    ReadCustomRatio(Form1.cjcam);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.camp1.ToString();
//    //textBoxp21.Text = Form1.camp1.ToString();
//    //textBoxp22.Text = Form1.camp2.ToString();
//    //textBoxp31.Text = Form1.camp2.ToString();
//    //textBoxp32.Text = Form1.camp3.ToString();
//    //textBoxp41.Text = Form1.camp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.camk1.ToString();
//    //textBoxk2.Text = Form1.camk2.ToString();
//    //textBoxk3.Text = Form1.camk3.ToString();
//    //textBoxk4.Text = Form1.camk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 7)//音响
//{
//    ReadCustomRatio(Form1.cjsp);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.spp1.ToString();
//    //textBoxp21.Text = Form1.spp1.ToString();
//    //textBoxp22.Text = Form1.spp2.ToString();
//    //textBoxp31.Text = Form1.spp2.ToString();
//    //textBoxp32.Text = Form1.spp3.ToString();
//    //textBoxp41.Text = Form1.spp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.spk1.ToString();
//    //textBoxk2.Text = Form1.spk2.ToString();
//    //textBoxk3.Text = Form1.spk3.ToString();
//    //textBoxk4.Text = Form1.spk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 8)//内存
//{
//    ReadCustomRatio(Form1.cjram);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.ramp1.ToString();
//    //textBoxp21.Text = Form1.ramp1.ToString();
//    //textBoxp22.Text = Form1.ramp2.ToString();
//    //textBoxp31.Text = Form1.ramp2.ToString();
//    //textBoxp32.Text = Form1.ramp3.ToString();
//    //textBoxp41.Text = Form1.ramp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.ramk1.ToString();
//    //textBoxk2.Text = Form1.ramk2.ToString();
//    //textBoxk3.Text = Form1.ramk3.ToString();
//    //textBoxk4.Text = Form1.ramk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 9)//硬盘
//{
//    ReadCustomRatio(Form1.cjhdd);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.hddp1.ToString();
//    //textBoxp21.Text = Form1.hddp1.ToString();
//    //textBoxp22.Text = Form1.hddp2.ToString();
//    //textBoxp31.Text = Form1.hddp2.ToString();
//    //textBoxp32.Text = Form1.hddp3.ToString();
//    //textBoxp41.Text = Form1.hddp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.hddk1.ToString();
//    //textBoxk2.Text = Form1.hddk2.ToString();
//    //textBoxk3.Text = Form1.hddk3.ToString();
//    //textBoxk4.Text = Form1.hddk4.ToString();

//}
//else if (comboBox1.SelectedIndex == 10)//固态硬盘
//{
//    ReadCustomRatio(Form1.cjssd);

//    //textBoxp11.Text = "0";

//    ////textBoxp11.Text = Form1.boxp1.ToString ();
//    //textBoxp12.Text = Form1.ssdp1.ToString();
//    //textBoxp21.Text = Form1.ssdp1.ToString();
//    //textBoxp22.Text = Form1.ssdp2.ToString();
//    //textBoxp31.Text = Form1.ssdp2.ToString();
//    //textBoxp32.Text = Form1.ssdp3.ToString();
//    //textBoxp41.Text = Form1.ssdp3.ToString();
//    //textBoxp42.Text = "999999";
//    //textBoxk1.Text = Form1.ssdk1.ToString();
//    //textBoxk2.Text = Form1.ssdk2.ToString();
//    //textBoxk3.Text = Form1.ssdk3.ToString();
//    //textBoxk4.Text = Form1.ssdk4.ToString();

//}


//if (checkBoxhidead.Checked) { Form1.hidead = "1"; }
//else { Form1.hidead = "0"; }
//if (checkBoxautoupdate.Checked) { Form1.autoupdate = "1"; }
//else { Form1.autoupdate = "0"; }
//Form1.mdbpath = textBox1.Text;
//Form1.mdbpw = textBoxmdbpw.Text;
//if (radioButtonprintrich.Checked) { Form1.printmode = "0"; }
//else { Form1.printmode = "1"; }//0:按模板,1:纯文本
//if (radioButtonsaverich.Checked) { Form1.savemode = "0"; }
//else { Form1.savemode = "1"; }
//if (checkBoxbbs.Checked)
//{
//    showbbs = "1";
//}
//else showbbs = "0";

//if (checkBoxcostprice.Checked) 
//{
//    if (radioButtonchengben.Checked) 
//    {
//        Form1.costprice = "1";

//    }
//    else if (radioButtonlirun.Checked) { Form1.costprice = "2"; }
//    else { Form1.costprice = "3"; }
//}
//else { Form1.costprice = "0"; }

//IniFile.WriteVal("Main", "Hidead", Form1.hidead, Form1.settingsini);
//IniFile.WriteVal("Main", "AutoUpdate", Form1.autoupdate, Form1.settingsini);
//IniFile.WriteVal("Main", "MdbPath", si.MdbPath, Form1.settingsini);
//IniFile.WriteVal("Main", "MdbPw", Form1.mdbpw, Form1.settingsini);

//IniFile.WriteVal("Main", "Align", checkBoxalign.Checked.ToString(), Form1.settingsini);
//IniFile.WriteVal("Main", "Print", Form1.printmode, Form1.settingsini);
//IniFile.WriteVal("Main", "Save", Form1.savemode, Form1.settingsini);
//IniFile.WriteVal("Main", "ShowBBS", Form1.showbbs, Form1.settingsini);
//IniFile.WriteVal("Main", "CostPrice", Form1.costprice, Form1.settingsini);

//IniFile.WriteVal("Advanced", "Box", textBoxp12.Text + "|" + textBoxp22.Text + "|" + textBoxp32.Text +"|"+ textBoxk1.Text + "|" + textBoxk2.Text + "|" + textBoxk3.Text + "|" + textBoxk4.Text, Form1.settingsini);


//hidead = IniFile.ReadVal("Main", "Hidead", settingsini);
//autoupdate = IniFile.ReadVal("Main", "AutoUpdate", settingsini);
//mdbpath = IniFile.ReadVal("Main", "MdbPath", settingsini);
//align = IniFile.ReadVal("Main", "Align", settingsini);
//printmode = IniFile.ReadVal("Main", "Print", settingsini);
//savemode = IniFile.ReadVal("Main", "Save", settingsini);
//showbbs = IniFile.ReadVal("Main", "ShowBBS", settingsini);
//costprice = IniFile.ReadVal("Main", "CostPrice", settingsini);


//if (SettingItems.PrintMode == SettingItems.ModeEnum.Txt) { radioButtonprinttext.Checked = true; }
//if (!SettingItems.ShowAd) { checkBoxhidead.Checked = true; }
//else { checkBoxhidead.Checked = false; }
//if (Form1.autoupdate == "1") { checkBoxautoupdate.Checked = true; }
//else { checkBoxautoupdate.Checked = false; }
//if (Form1.align == "True") { checkBoxalign.Checked = true; }



/*FileStream fs0 = new FileStream(Application.StartupPath + "\\settings.ini", FileMode.Create , FileAccess.Write );
fs0.SetLength(0);
StreamWriter sw0 = new StreamWriter(fs0, Encoding.Default);
string ws0 = "";
try
{
    ws0 = "Hidead=" + hidead;
    sw0.WriteLine(ws0);
    ws0 = "Autoupdate=" + autoupdate;
    sw0.WriteLine(ws0);
    ws0 = "MdbPath=" + mdbpath;
    sw0.WriteLine(ws0);
}
catch { }
sw0.Close();
this.Close();*/


//string hidead;
//string autoupdate;
//string mdbpath;
//string align;
//string settingsini=Application.StartupPath + "\\settings.ini";
//string printmode;
//string savemode;
//string costprice;
//int interval1;
//int interval2;
//string showbbs;


//textBoxp11.Text = "0";

//textBoxp11.Text = Form1.boxp1.ToString ();
//textBoxp12.Text = Form1.boxp1.ToString();
//textBoxp21.Text = Form1.boxp1.ToString();
//textBoxp22.Text = Form1.boxp2.ToString();
//textBoxp31.Text = Form1.boxp2.ToString();
//textBoxp32.Text = Form1.boxp3.ToString();
//textBoxp41.Text = Form1.boxp3.ToString();
//textBoxp42.Text = "999999";
//textBoxk1.Text = Form1.boxk1.ToString();
//textBoxk2.Text = Form1.boxk2.ToString();
//textBoxk3.Text = Form1.boxk3.ToString();
//textBoxk4.Text = Form1.boxk4.ToString();

//MessageBox.Show(mdbpath);


/*
           StreamReader objReader = new StreamReader(Application.StartupPath + "\\settings.ini",Encoding .Default );

           //HIDEAD
           string sLine = objReader.ReadLine();

           hidead = sLine.Substring(sLine.Length - 1, 1);

           sLine = objReader.ReadLine();
           autoupdate = sLine.Substring(sLine.Length - 1, 1);

           sLine = objReader.ReadLine();
           mdbpath = sLine.Substring(sLine.IndexOf("=") + 1);
           objReader.Close();

           if (hidead == "1") { checkBoxhidead.Checked = true; }
           else { checkBoxhidead.Checked = false; }
           if (autoupdate == "1") { checkBoxautoupdate.Checked = true; }
           else { checkBoxautoupdate.Checked = false; }

           */

//MessageBox.Show(((int)SettingItems.CostPrice).ToString ());
//Console.WriteLine(SettingItems.CostPrice);
//MessageBox.Show(cjbox.RG1 );
//if (!File.Exists(Application.StartupPath + "\\settings.ini"))
//{
//    //issetup = true;
//}
//else
//{
//    userpath = Application.StartupPath;
//}
//if (issetup)
//{


//mbChip = "H81";
//mbMoney = 300;
//mbchoice = Closest.cauto(mb, mb1, 300, "H81", mbsr);
//if (mbchoice == 0 || mbchoice == -1) { mbchoice = Closest.cauto(mb, mb1, 300, "B85", mbsr); }
#region OldCode
//for (z = 1; z <= 499; z++)
//{
//    if (checkedListBox1.GetItemChecked(6) && Form1.gpu1[z] != 0) { Form1.cpu1[z] = GetZolPrice(Form1.gpu[z], Form1.gpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(0) && Form1.cpu1[z] != 0) { Form1.gpu1[z] = GetZolPrice(Form1.fan[z], Form1.cpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(1) && Form1.acpu1[z] != 0) { Form1.hdd1[z] = GetZolPrice(Form1.acpu[z], Form1.acpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(4) && Form1.hdd1[z] != 0) { Form1.acpu1[z] = GetZolPrice(Form1.hdd[z], Form1.hdd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(3) && Form1.ram1[z] != 0) { Form1.ram1[z] = GetZolPrice(Form1.lcd[z], Form1.ram1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(2) && Form1.mb1[z] != 0) { Form1.mb1[z] = GetZolPrice(Form1.fan[z], Form1.mb1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(7) && Form1.lcd1[z] != 0) { Form1.lcd1[z] = GetZolPrice(Form1.box[z], Form1.lcd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(9) && Form1.fan1[z] != 0) { Form1.fan1[z] = GetZolPrice(Form1.fan[z], Form1.fan1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(8) && Form1.box1[z] != 0) { Form1.box1[z] = GetZolPrice(Form1.box[z], Form1.box1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(10) && Form1.power1[z] != 0) { Form1.power1[z] = GetZolPrice(Form1.power[z], Form1.power1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(11) && Form1.cdrom1[z] != 0) { Form1.cdrom1[z] = GetZolPrice(Form1.cdrom[z], Form1.cdrom1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(12) && Form1.kb1[z] != 0) { Form1.kb1[z] = GetZolPrice(Form1.kb[z], Form1.kb1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(13) && Form1.mou1[z] != 0) { Form1.mou1[z] = GetZolPrice(Form1.mou[z], Form1.mou1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(14) && Form1.hs1[z] != 0) { Form1.hs1[z] = GetZolPrice(Form1.hs[z], Form1.hs1[z]); }
//    if (!shouldcontinue) { break; }


//    if (checkedListBox1.GetItemChecked(5) && Form1.ssd1[z] != 0) { Form1.ssd1[z] = GetZolPrice(Form1.ssd[z], Form1.ssd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(15) && Form1.cam1[z] != 0) { Form1.cam1[z] = GetZolPrice(Form1.cam[z], Form1.cam1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(16) && Form1.sp1[z] != 0) { Form1.sp1[z] = GetZolPrice(Form1.sp[z], Form1.sp1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(17) && Form1.o1[z] != 0) { Form1.o1[z] = GetZolPrice(Form1.o[z], Form1.o1[z]); }
//    if (!shouldcontinue) { break; }


//}
#endregion
#region OldCode
//for (z = 1; z <= 499; z++)
//{
//    if (checkedListBox1.GetItemChecked(6) && Form1.gpu1[z] != 0) { Form1.gpu1[z] = GetZolPrice(Form1.gpu[z], Form1.gpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(0) && Form1.cpu1[z] != 0) { Form1.cpu1[z] = GetZolPrice(Form1.cpu[z], Form1.cpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(1) && Form1.acpu1[z] != 0) { Form1.acpu1[z] = GetZolPrice(Form1.acpu[z], Form1.acpu1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(4) && Form1.hdd1[z] != 0) { Form1.hdd1[z] = GetZolPrice(Form1.hdd[z], Form1.hdd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(3) && Form1.ram1[z] != 0) { Form1.ram1[z] = GetZolPrice(Form1.ram[z], Form1.ram1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(2) && Form1.mb1[z] != 0) { Form1.mb1[z] = GetZolPrice(Form1.mb[z], Form1.mb1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(7) && Form1.lcd1[z] != 0) { Form1.lcd1[z] = GetZolPrice(Form1.lcd[z], Form1.lcd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(9) && Form1.fan1[z] != 0) { Form1.fan1[z] = GetZolPrice(Form1.fan[z], Form1.fan1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(8) && Form1.box1[z] != 0) { Form1.box1[z] = GetZolPrice(Form1.box[z], Form1.box1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(10) && Form1.power1[z] != 0) { Form1.power1[z] = GetZolPrice(Form1.power[z], Form1.power1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(11) && Form1.cdrom1[z] != 0) { Form1.cdrom1[z] = GetZolPrice(Form1.cdrom[z], Form1.cdrom1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(12) && Form1.kb1[z] != 0) { Form1.kb1[z] = GetZolPrice(Form1.kb[z], Form1.kb1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(13) && Form1.mou1[z] != 0) { Form1.mou1[z] = GetZolPrice(Form1.mou[z], Form1.mou1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(14) && Form1.hs1[z] != 0) { Form1.hs1[z] = GetZolPrice(Form1.hs[z], Form1.hs1[z]); }
//    if (!shouldcontinue) { break; }


//    if (checkedListBox1.GetItemChecked(5) && Form1.ssd1[z] != 0) { Form1.ssd1[z] = GetZolPrice(Form1.ssd[z], Form1.ssd1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(15) && Form1.cam1[z] != 0) { Form1.cam1[z] = GetZolPrice(Form1.cam[z], Form1.cam1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(16) && Form1.sp1[z] != 0) { Form1.sp1[z] = GetZolPrice(Form1.sp[z], Form1.sp1[z]); }
//    if (!shouldcontinue) { break; }

//    if (checkedListBox1.GetItemChecked(17) && Form1.o1[z] != 0) { Form1.o1[z] = GetZolPrice(Form1.o[z], Form1.o1[z]); }
//    if (!shouldcontinue) { break; }


//}
#endregion
//foreach (HardWareKind item in checkedListBox1.SelectedItems)
//{
//    foreach (var hwItem in item.HW)
//    {
//        hwItem.SellPrice = GetTaobaoPrice(hwItem.Name, hwItem.SellPrice);
//    }
//}
#region OldCode
//             for (z = 1; z <= 499; z++)
//             {
//                 /*
//       * 0=CPU
//       * 1=AMD CPU
//       * 2=主板
//       * 3=内存
//       * 4=硬盘
//       * 5=固态硬盘
//       * 6=显卡
//       * 7=显示器
//       * 8=机箱
//       * 9=散热器
//       * 10=电源
//       * 11=光驱
//       * 12=键盘
//*        13=鼠标
//       * 14=耳机
//       * 15=摄像头
//       * 16=音响
//       * 17=其他
//       * 
//       */

//                 //

//                 //if (checkedListBox1.Items[checkedListBox1 .get])

//                 //if (checkedListBox1.GetItemChecked(6) && Form1.gpu1[z] != 0) { Form1.gpu1[z] = GetTaobaoPrice(Form1.gpu[z], Form1.gpu1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(0) && Form1.cpu1[z] != 0) { Form1.cpu1[z] = GetTaobaoPrice(Form1.cpu[z], Form1.cpu1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(1) && Form1.acpu1[z] != 0) { Form1.acpu1[z] = GetTaobaoPrice(Form1.acpu[z], Form1.acpu1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(4) && Form1.hdd1[z] != 0) { Form1.hdd1[z] = GetTaobaoPrice(Form1.hdd[z], Form1.hdd1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(3) && Form1.ram1[z] != 0) { Form1.ram1[z] = GetTaobaoPrice(Form1.ram[z], Form1.ram1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(2) && Form1.mb1[z] != 0) { Form1.mb1[z] = GetTaobaoPrice(Form1.mb[z], Form1.mb1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(7) && Form1.lcd1[z] != 0) { Form1.lcd1[z] = GetTaobaoPrice(Form1.lcd[z], Form1.lcd1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(9) && Form1.fan1[z] != 0) { Form1.fan1[z] = GetTaobaoPrice(Form1.fan[z], Form1.fan1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(8) && Form1.box1[z] != 0) { Form1.box1[z] = GetTaobaoPrice(Form1.box[z], Form1.box1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(10) && Form1.power1[z] != 0) { Form1.power1[z] = GetTaobaoPrice(Form1.power[z], Form1.power1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(11) && Form1.cdrom1[z] != 0) { Form1.cdrom1[z] = GetTaobaoPrice(Form1.cdrom[z], Form1.cdrom1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(12) && Form1.kb1[z] != 0) { Form1.kb1[z] = GetTaobaoPrice(Form1.kb[z], Form1.kb1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(13) && Form1.mou1[z] != 0) { Form1.mou1[z] = GetTaobaoPrice(Form1.mou[z], Form1.mou1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(14) && Form1.hs1[z] != 0) { Form1.hs1[z] = GetTaobaoPrice(Form1.hs[z], Form1.hs1[z]); }
//                 //if (!shouldcontinue) { break; }


//                 //if (checkedListBox1.GetItemChecked(5) && Form1.ssd1[z] != 0) { Form1.ssd1[z] = GetTaobaoPrice(Form1.ssd[z], Form1.ssd1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(15) && Form1.cam1[z] != 0) { Form1.cam1[z] = GetTaobaoPrice(Form1.cam[z], Form1.cam1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(16) && Form1.sp1[z] != 0) { Form1.sp1[z] = GetTaobaoPrice(Form1.sp[z], Form1.sp1[z]); }
//                 //if (!shouldcontinue) { break; }

//                 //if (checkedListBox1.GetItemChecked(17) && Form1.o1[z] != 0) { Form1.o1[z] = GetTaobaoPrice(Form1.o[z], Form1.o1[z]); }
//                 //if (!shouldcontinue) { break; }


//             }
#endregion

//checkedListBox1.ValueMember = "student_id";
//checkedListBox1.DisplayMember = "student_name";

//foreach (var item in SData.allHwKind)
//{
//    checkedListBox1.DataBindings.Clear();
//    //BindingSource bs = new BindingSource();
//    //bs.DataSource = EsdNameKey;
//    //comboBox1.DataSource = bs;
//    //comboBox1.DisplayMember = "Key";
//    //comboBox1.ValueMember = "Value";
//    //comboBox1.SelectedIndex = 0;
//    ////Binding bd = new Binding(;

//    //checkedListBox1.DataSource = bs;
//    //checkedListBox1.DisplayMember = "KindNameCh";
//    checkedListBox1.DataBindings.Add("Text", item, "KindNameCh", false, DataSourceUpdateMode.Never);

//    //checkedListBox1 .DataBindings  
//    //checkedListBox1.DataSource = item;
//}

#region OldCode
/////////////////////////////////AMD CPU/////////////////////////////////
//cmd = new OleDbCommand("SELECT [simplename],[ID] FROM acpu", objConnection);
//Dictionary<string, int> acpuDict = new Dictionary<string, int>();
//using (OleDbDataReader reader = cmd.ExecuteReader())
//{

//    while (reader.Read())
//    {
//        string newStr = reader.GetValue(0).ToString().Replace('?', ' ').Trim();
//        if (acpuDict.ContainsKey(newStr)) continue;
//        acpuDict.Add(newStr, reader.GetInt32(1));
//    }
//}
//foreach (var item in SData.hwCpu.HW)
//{
//    if (item.DBID != 0)
//    {
//        continue;
//    }
//    foreach (KeyValuePair<string, int> dictItem in acpuDict)
//    {

//        if (item.Name.ToUpper ().Contains(dictItem.Key.ToUpper ()))
//        {
//            if (Regex.IsMatch(Regex.Replace(item.Name.ToUpper().Trim(), @"\([^\(]*\)", string.Empty), "E|B|D"))
//            {
//                if (Regex.IsMatch(dictItem.Key.ToUpper(), "E|B|U|T|K"))
//                {
//                    item.DBID = dictItem.Value;
//                    break;
//                }
//            }
//            else
//            {
//                item.DBID = dictItem.Value;
//                break;
//            }

//        }
//    }
//}
#endregion





//dataGridView1.Rows.Insert(RowNumber + 1);
//dataGridView1.Rows[RowNumber + 1].Cells[0].Value = dataGridView1.Rows[RowNumber].Cells[0].Value;
//dataGridView1.Rows[RowNumber + 1].Cells[1].Value = " ";
//dataGridView1.Rows[RowNumber + 1].Cells[2].Value = "0";
//dataGridView1.Rows[RowNumber + 1].Cells[3].Value = "0";
//dataGridView1.Rows[RowNumber + 1].Cells[4].Value = dataGridView1.Rows[RowNumber].Cells[4].Value; 

//string mdbpath;
//string settingsini = Application.StartupPath + "\\settings.ini";
//private int CompareFile(Object o1, Object o2)
//{
//    FileInfo fi1 = o1 as FileInfo;
//    FileInfo fi2 = o2 as FileInfo;
//    return fi1.LastAccessTime.CompareTo(fi2.LastAccessTime);
//}

//int cauto(string[] soc, int[] soc1, long paid, string zhengze, String zhengze1)
//{
//    int lastestreturn = 0;
//    long minsubtraction = 100000;
//    long subtraction = 0;
//    int i = 0;
//    foreach (long pri in soc1)
//    {

//        i++;
//        if (pri == 0) { continue; }

//        if (soc[i - 1] != null && soc[i - 1].Contains(includepart1))
//        {
//            if (zhengze != null)
//            {
//                Regex r = new Regex(zhengze); // 定义一个Regex对象实例

//                Match m = r.Match(soc[i - 1]); // 在字符串中匹配

//                if (m.Success)
//                {
//                    subtraction = Math.Abs(pri - paid);

//                    if (subtraction < minsubtraction)
//                    {
//                        minsubtraction = subtraction;
//                        lastestreturn = i;

//                    }
//                }
//            }
//            else
//            {
//                subtraction = Math.Abs(pri - paid);

//                if (subtraction < minsubtraction)
//                {
//                    minsubtraction = subtraction;
//                    lastestreturn = i;

//                }

//            }
//        }

//    }

//    return lastestreturn - 1;

//}

#region OldConCode
//string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + SettingItems.MdbPath + ";Jet OLEDB:Database Password=" + SettingItems.MdbPw;

//OleDbConnection odcConnection = new OleDbConnection(strConn);
//odcConnection.Open();


//bool iserror = false;
#endregion


#region 旧的代码
//if(!(SData .IntelChipest.Contains (currentName)||SData.AMDSocket.Contains(currentName ))
//{ 
//    savelog += "第" + (i + 1).ToString() + "行" + MainDt.Rows[i][1].ToString() + "未写明芯片组信息（Intel平台）或接口（AMD平台）或芯片组暂不支持！\n可能导致无法正常识别！" + "\r\n";

//}
//if (!(MainDt.Rows[i][1].ToString().Contains("H61") || MainDt.Rows[i][1].ToString().Contains("H67") || MainDt.Rows[i][1].ToString().Contains("Z68") || MainDt.Rows[i][1].ToString().Contains("P67") || MainDt.Rows[i][1].ToString().Contains("H71") || MainDt.Rows[i][1].ToString().Contains("H77") || MainDt.Rows[i][1].ToString().Contains("B75") || MainDt.Rows[i][1].ToString().Contains("Z77") || MainDt.Rows[i][1].ToString().Contains("X79") || MainDt.Rows[i][1].ToString().Contains("H81") || MainDt.Rows[i][1].ToString().Contains("H85") || MainDt.Rows[i][1].ToString().Contains("H87") || MainDt.Rows[i][1].ToString().Contains("B85") || MainDt.Rows[i][1].ToString().Contains("Z87") || MainDt.Rows[i][1].ToString().Contains("AM3") || MainDt.Rows[i][1].ToString().Contains("FM1") || MainDt.Rows[i][1].ToString().Contains("FM2") || MainDt.Rows[i][1].ToString().Contains("Z97") || MainDt.Rows[i][1].ToString().Contains("H97")))
//{
//    savelog += "第" + (i + 1).ToString() + "行" + MainDt.Rows[i][1].ToString() + "未写明芯片组信息（Intel平台）或接口（AMD平台）或芯片组暂不支持！\n可能导致无法正常识别！" + "\r\n";
//    //MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n未写明芯片组信息（Intel平台）或接口（AMD平台）或芯片组暂不支持！\n可能导致无法正常识别！");
//}
#endregion

//#region OldCode
//public static int boxp1 = 2000;
//public static int boxp2 = 5000;
//public static int boxp3 = 12000;
//public static float boxk1 = 150;
//public static float boxk2 = 200;
//public static float boxk3 = 300;
//public static float boxk4 = 400;
//public static string boxregex1 = "";
//public static string boxregex2 = "";
//public static string boxregex3 = "";
//public static string boxregex4 = "";

//public static int moup1 = 2000;
//public static int moup2 = 5000;
//public static int moup3 = 12000;
//public static float mouk1 = 150;
//public static float mouk2 = 200;
//public static float mouk3 = 300;
//public static float mouk4 = 400;
//public static string mouregex1 = "";
//public static string mouregex2 = "";
//public static string mouregex3 = "";
//public static string mouregex4 = "";

//public static int powp1 = 3000;
//public static int powp2 = 7000;
//public static int powp3 = 10000;
//public static float powk1 = 200;
//public static float powk2 = 400;
//public static float powk3 = 600;
//public static float powk4 = 800;
//public static string powregex1 = "";
//public static string powregex2 = "";
//public static string powregex3 = "";
//public static string powregex4 = "";

//public static int kbp1 = 2000;
//public static int kbp2 = 5000;
//public static int kbp3 = 12000;
//public static float kbk1 = 0.03F;
//public static float kbk2 = 0.03F;
//public static float kbk3 = 0.03F;
//public static float kbk4 = 0.03F;
//public static string kbregex1 = "";
//public static string kbregex2 = "";
//public static string kbregex3 = "";
//public static string kbregex4 = "";

//public static int hsp1 = 2000;
//public static int hsp2 = 5000;
//public static int hsp3 = 12000;
//public static float hsk1 = 0.03F;
//public static float hsk2 = 0.03F;
//public static float hsk3 = 0.03F;
//public static float hsk4 = 0.03F;
//public static string hsregex1 = "";
//public static string hsregex2 = "";
//public static string hsregex3 = "";
//public static string hsregex4 = "";

//public static int camp1 = 2000;
//public static int camp2 = 5000;
//public static int camp3 = 12000;
//public static float camk1 = 0.03F;
//public static float camk2 = 0.03F;
//public static float camk3 = 0.03F;
//public static float camk4 = 0.03F;
//public static string camregex1 = "";
//public static string camregex2 = "";
//public static string camregex3 = "";
//public static string camregex4 = "";

//public static int spp1 = 2000;
//public static int spp2 = 5000;
//public static int spp3 = 12000;
//public static float spk1 = 0.03F;
//public static float spk2 = 0.03F;
//public static float spk3 = 0.03F;
//public static float spk4 = 0.03F;
//public static string spregex1 = "";
//public static string spregex2 = "";
//public static string spregex3 = "";
//public static string spregex4 = "";

//public static int cdromp1 = 2000;
//public static int cdromp2 = 5000;
//public static int cdromp3 = 12000;
//public static float cdromk1 = 0.03F;
//public static float cdromk2 = 0.03F;
//public static float cdromk3 = 0.03F;
//public static float cdromk4 = 0.03F;
//public static string cdromregex1 = "";
//public static string cdromregex2 = "";
//public static string cdromregex3 = "";
//public static string cdromregex4 = "";

//public static int ramp1 = 2000;
//public static int ramp2 = 5500;
//public static int ramp3 = 12000;
//public static float ramk1 = 250;
//public static float ramk2 = 300;
//public static float ramk3 = 400;
//public static float ramk4 = 800;
//public static string ramregex1 = "";
//public static string ramregex2 = "";
//public static string ramregex3 = "";
//public static string ramregex4 = "";

//public static int hddp1 = 3000;
//public static int hddp2 = 6000;
//public static int hddp3 = 10000;
//public static float hddk1 = 200;
//public static float hddk2 = 300;
//public static float hddk3 = 400;
//public static float hddk4 = 500;
//public static string hddregex1 = "";
//public static string hddregex2 = "";
//public static string hddregex3 = "";
//public static string hddregex4 = "";

//public static int ssdp1 = 5000;
//public static int ssdp2 = 10000;
//public static int ssdp3 = 12000;
//public static float ssdk1 = 0.14F;
//public static float ssdk2 = 0.1F;
//public static float ssdk3 = 0.1F;
//public static float ssdk4 = 0.1F;
//public static string ssdregex1 = "";
//public static string ssdregex2 = "";
//public static string ssdregex3 = "";
//public static string ssdregex4 = "";
//#endregion
//static bool copyright=false ;


#region UnUsedCode
//CuanJiProfile cjpbox = new CuanJiProfile();
//cjpbox.P1 = 100;
//cjpbox.P2 = 200;

//cjpbox.K1 = Convert .tof

//cjpow.

//string temp = "";
//temp = IniFile.ReadVal("Box", "P1", Form1.settingsini);
//if (temp != "") 
//{
//    //testob.P1 = Int32.Parse(temp);
//    Int32.TryParse(temp, out boxp1);
//}
//temp = IniFile.ReadVal("Box", "P2", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out boxp2);
//}
//temp = IniFile.ReadVal("Box", "P3", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out boxp3);
//}
//temp = IniFile.ReadVal("Box", "K1", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out boxk1);
//}
//temp = IniFile.ReadVal("Box", "K2", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out boxk2);
//} 
//temp = IniFile.ReadVal("Box", "K3", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out boxk3);
//} 
//temp = IniFile.ReadVal("Box", "K4", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out boxk4);
//}
//boxregex1 = IniFile.ReadVal("Box", "R1", Form1.settingsini);
//boxregex2 = IniFile.ReadVal("Box", "R2", Form1.settingsini);
//boxregex3 = IniFile.ReadVal("Box", "R3", Form1.settingsini);
//boxregex4 = IniFile.ReadVal("Box", "R4", Form1.settingsini);
//////////////////////////////////////////////////////////////////
//temp = IniFile.ReadVal("Power", "P1", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out powp1);
//}
//temp = IniFile.ReadVal("Power", "P2", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out powp2);
//}
//temp = IniFile.ReadVal("Power", "P3", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out powp3);
//}
//temp = IniFile.ReadVal("Power", "K1", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out powk1);
//}
//temp = IniFile.ReadVal("Power", "K2", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out powk2);
//}
//temp = IniFile.ReadVal("Power", "K3", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out powk3);
//}
//temp = IniFile.ReadVal("Power", "K4", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out powk4);
//}
//powregex1 = IniFile.ReadVal("Power", "R1", Form1.settingsini);
//powregex2 = IniFile.ReadVal("Power", "R2", Form1.settingsini);
//powregex3 = IniFile.ReadVal("Power", "R3", Form1.settingsini);
//powregex4 = IniFile.ReadVal("Power", "R4", Form1.settingsini);
///////////////////////////////////////////////////////////////////
//temp = IniFile.ReadVal("Cdrom", "P1", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out cdromp1);
//}
//temp = IniFile.ReadVal("Cdrom", "P2", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out cdromp2);
//}
//temp = IniFile.ReadVal("Cdrom", "P3", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out cdromp3);
//}
//temp = IniFile.ReadVal("Cdrom", "K1", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out cdromk1);
//}
//temp = IniFile.ReadVal("Cdrom", "K2", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out cdromk2);
//}
//temp = IniFile.ReadVal("Cdrom", "K3", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out cdromk3);
//}
//temp = IniFile.ReadVal("Cdrom", "K4", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out cdromk4);
//}
//cdromregex1 = IniFile.ReadVal("Cdrom", "R1", Form1.settingsini);
//cdromregex2 = IniFile.ReadVal("Cdrom", "R2", Form1.settingsini);
//cdromregex3 = IniFile.ReadVal("Cdrom", "R3", Form1.settingsini);
//cdromregex4 = IniFile.ReadVal("Cdrom", "R4", Form1.settingsini);
////////////////
//temp = IniFile.ReadVal("Kb", "P1", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out kbp1);
//}
//temp = IniFile.ReadVal("Kb", "P2", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out kbp2);
//}
//temp = IniFile.ReadVal("Kb", "P3", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out kbp3);
//}
//temp = IniFile.ReadVal("Kb", "K1", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out kbk1);
//}
//temp = IniFile.ReadVal("Kb", "K2", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out kbk2);
//}
//temp = IniFile.ReadVal("Kb", "K3", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out kbk3);
//}
//temp = IniFile.ReadVal("Kb", "K4", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out kbk4);
//}
//kbregex1 = IniFile.ReadVal("Kb", "R1", Form1.settingsini);
//kbregex2 = IniFile.ReadVal("Kb", "R2", Form1.settingsini);
//kbregex3 = IniFile.ReadVal("Kb", "R3", Form1.settingsini);
//kbregex4 = IniFile.ReadVal("Kb", "R4", Form1.settingsini);
////////////////
//temp = IniFile.ReadVal("Mou", "P1", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out moup1);
//}
//temp = IniFile.ReadVal("Mou", "P2", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out moup2);
//}
//temp = IniFile.ReadVal("Mou", "P3", Form1.settingsini);
//if (temp != "")
//{
//    Int32.TryParse(temp, out moup3);
//}
//temp = IniFile.ReadVal("Mou", "K1", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out mouk1);
//}
//temp = IniFile.ReadVal("Mou", "K2", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out mouk2);
//}
//temp = IniFile.ReadVal("Mou", "K3", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out mouk3);
//}
//temp = IniFile.ReadVal("Mou", "K4", Form1.settingsini);
//if (temp != "")
//{
//    float.TryParse(temp, out mouk4);
//}
//mouregex1 = IniFile.ReadVal("Mou", "R1", Form1.settingsini);
//mouregex2 = IniFile.ReadVal("Mou", "R2", Form1.settingsini);
//mouregex3 = IniFile.ReadVal("Mou", "R3", Form1.settingsini);
//mouregex4 = IniFile.ReadVal("Mou", "R4", Form1.settingsini);
#endregion



//int closest(int[] finds, long Budget)
//{
//    int lastestreturn = 0;
//    long minsubtraction = 500000;
//    long subtraction = 0;
//    int i = 0;
//    foreach (long pri in finds)
//    {

//        i++;


//        if (pri == 0) { continue; }
//        subtraction = Math.Abs(pri - Budget);
//        //MessageBox.Show(subtraction.ToString()+"   "+minsubtraction );
//        // MessageBox.Show(subtraction.ToString());
//        if (subtraction < minsubtraction)
//        {
//            minsubtraction = subtraction;
//            lastestreturn = i;
//            //MessageBox.Show(i.ToString ());
//        }
//        //List<long> items = new List<long>();
//        //items.Add(subtraction);
//        //MessageBox.Show(pri.ToString ());
//    }
//    //MessageBox.Show(lastestreturn.ToString());
//    return lastestreturn - 1;
//}

////int Closest.cauto(string[] soc, int[] soc1, long paid, string zhengze, String zhengze1)
////{
////    int lastestreturn = 0;
////    long minsubtraction = 100000;
////    long subtraction = 0;
////    int i = 0;
////    foreach (long pri in soc1)
////    {

////        i++;
////        if (pri == 0) { continue; }

////        if (soc[i - 1] != null && soc[i - 1].Contains(includepart1))
////        {
////            if (zhengze != null)
////            {
////                Regex r = new Regex(zhengze); // 定义一个Regex对象实例

////                Match m = r.Match(soc[i - 1]); // 在字符串中匹配

////                if (m.Success)
////                {
////                    subtraction = Math.Abs(pri - paid);

////                    if (subtraction < minsubtraction)
////                    {
////                        minsubtraction = subtraction;
////                        lastestreturn = i;

////                    }
////                }
////            }
////            else
////            {
////                subtraction = Math.Abs(pri - paid);

////                if (subtraction < minsubtraction)
////                {
////                    minsubtraction = subtraction;
////                    lastestreturn = i;

////                }

////            }
////        }

////    }

////    return lastestreturn - 1;

////}

//int Closest.cauto(string[] soc, int[] soc1, long paid, string includepart1, string zhengze)
//{
//    int lastestreturn = 0;
//    long minsubtraction = 100000;
//    long subtraction = 0;
//    int i = 0;
//    foreach (long pri in soc1)
//    {

//        i++;
//        if (pri == 0) { continue; }

//        if (soc[i - 1] != null && soc[i - 1].Contains(includepart1))
//        {
//            if (zhengze != null)
//            {
//                Regex r = new Regex(zhengze); // 定义一个Regex对象实例

//                Match m = r.Match(soc[i - 1]); // 在字符串中匹配

//                if (m.Success)
//                {
//                    subtraction = Math.Abs(pri - paid);

//                    if (subtraction < minsubtraction)
//                    {
//                        minsubtraction = subtraction;
//                        lastestreturn = i;

//                    }
//                }
//            }
//            else
//            {
//                subtraction = Math.Abs(pri - paid);

//                if (subtraction < minsubtraction)
//                {
//                    minsubtraction = subtraction;
//                    lastestreturn = i;

//                }

//            }
//        }

//    }

//    return lastestreturn - 1;

//}
//int Closest.cauto(string[] soc, int[] soc1, long paid, string includepart1, string zhengze, string notincludepart)
//{

//    int lastestreturn = 0;
//    long minsubtraction = 100000;
//    long subtraction = 0;
//    int i = 0;
//    foreach (long pri in soc1)
//    {

//        i++;
//        if (pri == 0) { continue; }

//        if (soc[i - 1] != null && soc[i - 1].Contains(includepart1) && !soc[i - 1].Contains(notincludepart))
//        {
//            Regex r = new Regex(zhengze); // 定义一个Regex对象实例

//            Match m = r.Match(soc[i - 1]); // 在字符串中匹配

//            if (m.Success)
//            {
//                subtraction = Math.Abs(pri - paid);

//                if (subtraction < minsubtraction)
//                {
//                    minsubtraction = subtraction;
//                    lastestreturn = i;

//                }
//            }
//        }

//    }

//    return lastestreturn - 1;
//}
//int Closest.cauto(string[] soc, int[] soc1, long paid, string zhengze)
//{

//    int lastestreturn = 0;
//    long minsubtraction = 100000;
//    long subtraction = 0;
//    int i = 0;
//    foreach (long pri in soc1)
//    {



//        i++;
//        if (pri == 0) { continue; }
//        Regex r = new Regex(zhengze); // 定义一个Regex对象实例
//        if (soc[i - 1] != null)
//        {
//            Match m = r.Match(soc[i - 1]); // 在字符串中匹配
//            if (m.Success)
//            {
//                subtraction = Math.Abs(pri - paid);

//                if (subtraction < minsubtraction)
//                {
//                    minsubtraction = subtraction;
//                    lastestreturn = i;

//                }
//            }
//        }

//    }

//    return lastestreturn - 1;
//}
//int Closest.cauto(string[] soc, int[] soc1, long paid, ArrayList includepart, ArrayList notincludepart, string zhengze)
//{

//    int lastestreturn = 0;
//    long minsubtraction = 0;
//    long subtraction = 0;
//    int i = -1;
//    int choicenum = 0;//所有条件符合的第几个硬件
//    foreach (long pri in soc1)
//    {
//        bool isgood = true;
//        i++;
//        if (pri == 0) { continue; }
//        foreach (string hwnamerequire in includepart)
//        {
//            if (!soc[i].Contains(hwnamerequire)) { isgood = false; break; }
//        }
//        if (!isgood) { continue; }
//        foreach (string notrequire in notincludepart)
//        {
//            if (soc[i].Contains(notrequire)) { isgood = false; break; }

//        }
//        if (!isgood) { continue; }
//        Regex r = new Regex(zhengze); // 定义一个Regex对象实例
//        Match m = r.Match(soc[i]); // 在字符串中匹配
//        if (!m.Success) { continue; }
//        choicenum++;
//        subtraction = Math.Abs(pri - paid);
//        if (choicenum == 1)
//        {
//            minsubtraction = subtraction; lastestreturn = i;
//        }
//        else
//        {
//            if (subtraction < minsubtraction)
//            {
//                minsubtraction = subtraction;
//                lastestreturn = i;
//            }
//        }
//    }
//    return lastestreturn;
//}

//int Closest.custom_cauto(string[] soc, int[] soc1, long paid, string regex1, string regex2)
//{

//    int lastestreturn = 0;
//    long minsubtraction = 0;
//    long subtraction = 0;
//    int i = -1;
//    int choicenum = 0;//所有条件符合的第几个硬件
//    foreach (long pri in soc1)
//    {
//        i++;
//        if (pri == 0) { continue; }
//        Regex r = new Regex(regex1); // 定义一个Regex对象实例
//        Match m = r.Match(soc[i]); // 在字符串中匹配
//        Regex p = new Regex(regex2); // 定义一个Regex对象实例
//        Match n = p.Match(soc[i]); // 在字符串中匹配

//        if (!m.Success || !n.Success) { continue; }
//        choicenum++;
//        subtraction = Math.Abs(pri - paid);
//        if (choicenum == 1)
//        {
//            minsubtraction = subtraction; lastestreturn = i;
//        }
//        else
//        {
//            if (subtraction < minsubtraction)
//            {
//                minsubtraction = subtraction;
//                lastestreturn = i;
//            }
//        }
//    }
//    return lastestreturn;
//}


#region OldCode
//mb_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//ram_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//hdd_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//ssd_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//gpu_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//lcd_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//box_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//fan_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//power_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//cdrom_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//kb_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//mou_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);

//hs_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//cam_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//sp_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
//o_choice = Int32.Parse(shorter.Substring(0, shorter.IndexOf("#")));
//shorter = shorter.Substring(shorter.IndexOf("#") + 1);
#endregion


//private void report()
//{
//    string pageHtml;
//    try
//    {

//        WebClient MyWebClient = new WebClient();

//        MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于对向Internet资源的请求进行身份验证的网络凭据。

//        Byte[] pageData = MyWebClient.DownloadData("http://bbs.luobotou.org/app/cjzs_pro.txt"); //从指定网站下载数据

//        pageHtml = Encoding.Default.GetString(pageData);
//        //MessageBox.Show(pageHtml);
//        int index = pageHtml.IndexOf("webreport=");

//        if (pageHtml.Substring(index + 10, 1) == "1")
//        {
//            string strURL = "http://myapp.luobotou.org/statistics.aspx?name=cjzspro&ver=" + Application.ProductVersion + "&an=" + AuthKeyManager.AuthName();
//            System.Net.HttpWebRequest request;
//            // 创建一个HTTP请求
//            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
//            //request.Method="get";
//            System.Net.HttpWebResponse response;
//            response = (System.Net.HttpWebResponse)request.GetResponse();
//            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
//            string responseText = myreader.ReadToEnd();
//            myreader.Close();

//        }


//    }
//    catch (WebException webEx)
//    {

//        Console.WriteLine(webEx.Message.ToString());

//    }

//}
//string GetCpuID()
//{
//    try
//    {
//        //获取CPU序列号代码
//        string cpuInfo = "";//cpu序列号
//        ManagementClass mc = new ManagementClass("Win32_Processor");
//        ManagementObjectCollection moc = mc.GetInstances();
//        foreach (ManagementObject mo in moc)
//        {
//            cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
//        }
//        moc = null;
//        mc = null;
//        return cpuInfo;
//    }
//    catch
//    {
//        return "unknow";
//    }
//    finally
//    {
//    }

//}

//private bool IsRegeditExit(string name)
//{
//    bool _exit = false;
//    string[] subkeyNames;
//    RegistryKey hkml = Registry.CurrentUser;
//    RegistryKey software = hkml.OpenSubKey("software", true);
//    subkeyNames = software.GetSubKeyNames();
//    foreach (string keyName in subkeyNames)
//    {
//        if (keyName == name)
//        {
//            _exit = true;
//            return _exit;
//        }
//    }
//    return _exit;
//}
//private string GetRegistData(string name)
//{
//    string registData;
//    RegistryKey hkml = Registry.CurrentUser;
//    RegistryKey software = hkml.OpenSubKey("software", true);
//    RegistryKey aimdir = software.OpenSubKey(Application.ProductName, true);
//    registData = aimdir.GetValue(name).ToString();
//    return registData;
//}
//private void WTRegedit(string name, string tovalue)
//{
//    RegistryKey hklm = Registry.CurrentUser;
//    RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
//    RegistryKey aimdir = software.CreateSubKey(Application.ProductName);
//    aimdir.SetValue(name, tovalue);
//}
//private void buttonexpand_Click(object sender, EventArgs e)
//{
//    //if (trial == true)
//    //{
//    //    //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
//    //    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    //}

//    //if (buttonexpand.Text.Contains("<"))
//    //{
//    //    this.Width = this.Width -(int)(((double)this.Width) * 0.45);
//    //    tableLayoutPanel1.ColumnStyles[2].Width = 0;
//    //    buttonexpand.Text = ">";
//    //}
//    //else 
//    //{
//    //    this.Width = (int)(((double)this.Width) / 0.55);
//    //    tableLayoutPanel1.ColumnStyles[2].Width = 45f;
//    //    buttonexpand.Text = "<";
//    //}

//}


#region Sp
//speaker
//if (sp1[1] != 0)
//{
//    if (checkBoxsp.Checked)
//    {
//        if (comboBoxsp.SelectedIndex != 0) { choice = comboBoxsp.SelectedIndex; }
//        else
//        {
//            int price1 = 0;
//            int price2 = 0;
//            int price3 = 0;
//            int price4 = 0;
//            if (spk1 < 1) { price1 = (int)(spk1 * realmoney); } else { price1 = (int)spk1; }
//            if (spk2 < 1) { price2 = (int)(spk2 * realmoney); } else { price2 = (int)spk2; }
//            if (spk3 < 1) { price3 = (int)(spk3 * realmoney); } else { price3 = (int)spk3; }
//            if (spk4 < 1) { price4 = (int)(spk4 * realmoney); } else { price4 = (int)spk4; }

//            if (realmoney < spp1) { choice = Closest.custom_cauto(sp, sp1, price1, spregex1, spsr); }
//            else if (realmoney >= spp1 && realmoney <= spp2) { choice = Closest.custom_cauto(sp, sp1, price2, spregex1, spsr); }
//            else if (realmoney >= spp2 && realmoney <= spp3) { choice = Closest.custom_cauto(sp, sp1, price3, spregex1, spsr); }
//            else if (realmoney >= spp3) { choice = Closest.cauto(sp, sp1, price4, spregex1, spsr); }

//            //choice = Closest.cauto(sp, sp1, money / 20, "", spsr);
//        }
//        if (choice == 0 || choice == -1)
//        {
//            sp_choice = 0;
//            //sp[0] = "没有找到符合要求的配件。"; sp1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            sp_choice = choice;

//            //sp[0] = sp[choice];
//            //sp1[0] = sp1[choice];
//            //sp2[0] = sp2[choice];

//        }

//    }
//}

#endregion

#region Cam
//Camera
//if (cam1[1] != 0)
//{
//    if (checkBoxcam.Checked)
//    {
//        if (comboBoxcam.SelectedIndex != 0) { choice = comboBoxcam.SelectedIndex; }
//        else
//        {
//            int price1 = 0;
//            int price2 = 0;
//            int price3 = 0;
//            int price4 = 0;
//            if (camk1 < 1) { price1 = (int)(camk1 * realmoney); } else { price1 = (int)camk1; }
//            if (camk2 < 1) { price2 = (int)(camk2 * realmoney); } else { price2 = (int)camk2; }
//            if (camk3 < 1) { price3 = (int)(camk3 * realmoney); } else { price3 = (int)camk3; }
//            if (camk4 < 1) { price4 = (int)(camk4 * realmoney); } else { price4 = (int)camk4; }

//            if (realmoney < camp1) { choice = Closest.custom_cauto(cam, cam1, price1, camregex1, camsr); }
//            else if (realmoney >= camp1 && realmoney <= camp2) { choice = Closest.custom_cauto(cam, cam1, price2, camregex2, camsr); }
//            else if (realmoney >= camp2 && realmoney <= camp3) { choice = Closest.custom_cauto(cam, cam1, price3, camregex3, camsr); }
//            else if (realmoney >= camp3) { choice = Closest.cauto(cam, cam1, price4, camregex4, camsr); }

//            //choice = Closest.cauto(cam, cam1, money / 20, "", camsr); 
//        }
//        if (choice == 0 || choice == -1)
//        {
//            cam_choice = 0;
//            //cam[0] = "没有找到符合要求的配件。"; cam1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            cam_choice = choice;

//            //cam[0] = cam[choice];
//            //cam1[0] = cam1[choice];
//            //cam2[0] = cam2[choice];

//        }

//    }
//}
#endregion
#region HS
//Headset
//if (hs1[1] != 0)
//{
//    if (checkBoxhs.Checked)
//    {
//        if (comboBoxhs.SelectedIndex != 0) { choice = comboBoxhs.SelectedIndex; }
//        else
//        {
//            int price1 = 0;
//            int price2 = 0;
//            int price3 = 0;
//            int price4 = 0;
//            if (hsk1 < 1) { price1 = (int)(hsk1 * realmoney); } else { price1 = (int)hsk1; }
//            if (hsk2 < 1) { price2 = (int)(hsk2 * realmoney); } else { price2 = (int)hsk2; }
//            if (hsk3 < 1) { price3 = (int)(hsk3 * realmoney); } else { price3 = (int)hsk3; }
//            if (hsk4 < 1) { price4 = (int)(hsk4 * realmoney); } else { price4 = (int)hsk4; }

//            if (realmoney < hsp1) { choice = Closest.custom_cauto(hs, hs1, price1, hsregex1, hssr); }
//            else if (realmoney >= hsp1 && realmoney <= hsp2) { choice = Closest.custom_cauto(hs, hs1, price2, hsregex2, hssr); }
//            else if (realmoney >= hsp2 && realmoney <= hsp3) { choice = Closest.custom_cauto(hs, hs1, price3, hsregex3, hssr); }
//            else if (realmoney >= hsp3) { choice = Closest.cauto(hs, hs1, price4, hsregex4, hssr); }

//            //choice = Closest.cauto(hs, hs1, money / 20, "", hssr); 
//        }
//        if (choice == 0 || choice == -1)
//        {

//            hs_choice = 0;
//            //hs[0] = "没有找到符合要求的配件。"; hs1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            hs_choice = choice;

//            //hs[0] = hs[choice];
//            //hs1[0] = hs1[choice];
//            //hs2[0] = hs2[choice];

//        }

//    }
//} 
#endregion

#region Mou
//CJViaPofile(cjmou, mou, mou1, ref mou_choice, mousr, ComboBoxmou);

//int price1 = 0;
//int price2 = 0;
//int price3 = 0;
//int price4 = 0;
//if (mouk1 < 1) { price1 = (int)(mouk1 * realmoney); } else { price1 = (int)mouk1; }
//if (mouk2 < 1) { price2 = (int)(mouk2 * realmoney); } else { price2 = (int)mouk2; }
//if (mouk3 < 1) { price3 = (int)(mouk3 * realmoney); } else { price3 = (int)mouk3; }
//if (mouk4 < 1) { price4 = (int)(mouk4 * realmoney); } else { price4 = (int)mouk4; }
////MessageBox.Show(((int)boxk2).ToString ());
//if (ComboBoxbox.SelectedIndex != 0) { choice = ComboBoxbox.SelectedIndex; }
//else if (realmoney < moup1) { choice = Closest.cauto(mou, mou1, price1, mouregex1, mousr); }
//else if (realmoney >= moup1 && realmoney < moup2) { choice = Closest.cauto(mou, mou1, price2, mouregex2, mousr); }
//else if (realmoney >= moup2 && realmoney < moup3) { choice = Closest.cauto(mou, mou1, price3, mouregex3, mousr); }
//else { choice = Closest.cauto(mou, mou1, price4, mouregex4, mousr); } 
#endregion


#region c_kb()OldCode
//keyboard
//if (kb1[1] != 0)
//{
//    if (checkBoxkb.Checked)
//    {
//        if (comboBoxkb.SelectedIndex != 0) { choice = comboBoxkb.SelectedIndex; }
//        else
//        {
//            int price1 = 0;
//            int price2 = 0;
//            int price3 = 0;
//            int price4 = 0;
//            if (kbk1 < 1) { price1 = (int)(kbk1 * realmoney); } else { price1 = (int)kbk1; }
//            if (kbk2 < 1) { price2 = (int)(kbk2 * realmoney); } else { price2 = (int)kbk2; }
//            if (kbk3 < 1) { price3 = (int)(kbk3 * realmoney); } else { price3 = (int)kbk3; }
//            if (kbk4 < 1) { price4 = (int)(kbk4 * realmoney); } else { price4 = (int)kbk4; }

//            if (realmoney < kbp1) { choice = Closest.custom_cauto(kb, kb1, price1, kbregex1, kbsr); }
//            else if (realmoney >= kbp1 && realmoney <= kbp2) { choice = Closest.custom_cauto(kb, kb1, price2, kbregex2, kbsr); }
//            else if (realmoney >= kbp2 && realmoney <= kbp3) { choice = Closest.custom_cauto(kb, kb1, price3, kbregex3, kbsr); }
//            else if (realmoney >= kbp3) { choice = Closest.cauto(kb, kb1, price4, kbregex4, kbsr); }

//            //choice = Closest.cauto(kb, kb1, money / 30, "", kbsr);
//        }
//        if (choice == 0 || choice == -1)
//        {
//            kb_choice = 0;
//            //kb[0] = "没有找到符合要求的配件。"; kb1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            kb_choice = choice;

//            //kb[0] = kb[choice];
//            //kb1[0] = kb1[choice];
//            //kb2[0] = kb2[choice];

//        }

//    }
//} 
#endregion

#region c_cdrom_OldCode
//CJViaPofile(cjcdrom, cdrom, cdrom1, ref cdrom_choice, cdromsr, ComboBoxcdrom);

//    if (ComboBoxcdrom.SelectedIndex != 0)
//    {
//        choice = ComboBoxcdrom.SelectedIndex;

//    }
//    else
//    {
//        int price1 = 0;
//        int price2 = 0;
//        int price3 = 0;
//        int price4 = 0;
//        if (cdromk1 < 1) { price1 = (int)(cdromk1 * realmoney); } else { price1 = (int)cdromk1; }
//        if (cdromk2 < 1) { price2 = (int)(cdromk2 * realmoney); } else { price2 = (int)cdromk2; }
//        if (cdromk3 < 1) { price3 = (int)(cdromk3 * realmoney); } else { price3 = (int)cdromk3; }
//        if (cdromk4 < 1) { price4 = (int)(cdromk4 * realmoney); } else { price4 = (int)cdromk4; }

//        if (realmoney < cdromp1) { choice = Closest.custom_cauto(cdrom, cdrom1, price1, cdromregex1, cdromsr); }
//        else if (realmoney >= cdromp1 && realmoney <= cdromp2) { choice = Closest.custom_cauto(cdrom, cdrom1, price2, cdromregex2, cdromsr); }
//        else if (realmoney >= cdromp2 && realmoney <= cdromp3) { choice = Closest.custom_cauto(cdrom, cdrom1, price3, cdromregex3, cdromsr); }
//        else if (realmoney >= cdromp3) { choice = Closest.cauto(cdrom, cdrom1, price4, cdromregex4, cdromsr); }
//    }
//    if (choice == 0 || choice == -1) { cdrom_choice = 0; }
//    // MessageBox.Show(choice.ToString ());
//    else
//    {
//        cdrom_choice = choice;

//        //cdrom[0] = cdrom[choice];
//        //cdrom1[0] = cdrom1[choice];
//        //cdrom2[0] = cdrom2[choice];

//    }
//} 
#endregion

#region power
//CJViaPofile(cjpow, power, power1, ref power_choice, powersr, ComboBoxpower);

//int price1 = 0;
//int price2 = 0;
//int price3 = 0;
//int price4 = 0;
//if (powk1 < 1) { price1 = (int)(powk1 * realmoney); } else { price1 = (int)powk1; }
//if (powk2 < 1) { price2 = (int)(powk2 * realmoney); } else { price2 = (int)powk2; }
//if (powk3 < 1) { price3 = (int)(powk3 * realmoney); } else { price3 = (int)powk3; }
//if (powk4 < 1) { price4 = (int)(powk4 * realmoney); } else { price4 = (int)powk4; }

//if (realmoney < powp1) { choice = Closest.custom_cauto(power, power1, price1, powregex1, powersr); }
//else if (realmoney >= powp1 && realmoney <= powp2) { choice = Closest.custom_cauto(power, power1, price2, powregex2, powersr); }
//else if (realmoney >= powp2 && realmoney <= powp3) { choice = Closest.custom_cauto(power, power1, price3, powregex3, powersr); }
//else if (realmoney >= powp3) { choice = Closest.cauto(power, power1, price4, powregex4, powersr); } 
#endregion

#region OldCode
//CJViaPofile(cjbox, box, box1, ref hdd_choice, hddsr, ComboBoxhdd);

//if (checkBoxbox.Checked)
//{
//    int price1 = 0;
//    int price2 = 0;
//    int price3 = 0;
//    int price4 = 0;
//    if (boxk1 < 1) { price1 = (int)(boxk1 * realmoney); } else { price1 = (int)boxk1; }
//    if (boxk2 < 1) { price2 = (int)(boxk2 * realmoney); } else { price2 = (int)boxk2; }
//    if (boxk3 < 1) { price3 = (int)(boxk3 * realmoney); } else { price3 = (int)boxk3; }
//    if (boxk4 < 1) { price4 = (int)(boxk4 * realmoney); } else { price4 = (int)boxk4; }
//    //MessageBox.Show(((int)boxk2).ToString ());
//    if (ComboBoxbox.SelectedIndex != 0) { choice = ComboBoxbox.SelectedIndex; }
//    else if (realmoney < boxp1) { choice = Closest.custom_cauto(box, box1, price1, "", boxsr); }
//    else if (realmoney >= boxp1 && realmoney < boxp2) { choice = Closest.custom_cauto(box, box1, price2, "", boxsr); }
//    else if (realmoney >= boxp2 && realmoney < boxp3) { choice = Closest.custom_cauto(box, box1, price3, "", boxsr); }
//    else { choice = Closest.custom_cauto(box, box1, price4, "", boxsr); }
//    if (choice == 0 || choice == -1)
//    {
//        box_choice = 0;
//        //box[0] = "没有找到符合要求的配件。"; box1[0] = 0;
//    }
//    else
//    {
//        box_choice = choice;

//        //box[0] = box[choice];
//        //box1[0] = box1[choice];
//        //box2[0] = box2[choice];
//    }
//}
#endregion

#region UnUsed
//CJViaPofile(cjssd, ssd, ssd1, ref ssd_choice, ssdsr, ComboBoxssd);
//speaker
//if (ssd1[1] != 0)
//{
//    if (checkBoxssd.Checked)
//    {
//        if (comboBoxssd.SelectedIndex != 0) { choice = comboBoxssd.SelectedIndex; }
//        else
//        {
//            int price1 = 0;
//            int price2 = 0;
//            int price3 = 0;
//            int price4 = 0;
//            if (ssdk1 < 1) { price1 = (int)(ssdk1 * realmoney); } else { price1 = (int)ssdk1; }
//            if (ssdk2 < 1) { price2 = (int)(ssdk2 * realmoney); } else { price2 = (int)ssdk2; }
//            if (ssdk3 < 1) { price3 = (int)(ssdk3 * realmoney); } else { price3 = (int)ssdk3; }
//            if (ssdk4 < 1) { price4 = (int)(ssdk4 * realmoney); } else { price4 = (int)ssdk4; }

//            if (realmoney < ssdp1) { choice = Closest.custom_cauto(ssd, ssd1, price1, ssdregex1, ssdsr); }
//            else if (realmoney >= ssdp1 && realmoney <= ssdp2) { choice = Closest.custom_cauto(ssd, ssd1, price2, ssdregex1, ssdsr); }
//            else if (realmoney >= ssdp2 && realmoney <= ssdp3) { choice = Closest.custom_cauto(ssd, ssd1, price3, ssdregex1, ssdsr); }
//            else if (realmoney >= ssdp3) { choice = Closest.cauto(ssd, ssd1, price4, ssdregex1, ssdsr); }

//            //choice = Closest.cauto(sp, sp1, money / 20, "", spsr);
//        }
//        if (choice == 0 || choice == -1)
//        {
//            ssd_choice = 0;
//            //sp[0] = "没有找到符合要求的配件。"; sp1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            ssd_choice = choice;

//            //sp[0] = sp[choice];
//            //sp1[0] = sp1[choice];
//            //sp2[0] = sp2[choice];

//        }

//    }



//}
#endregion

#region OldCode
//CJViaPofile(cjhdd, hdd, hdd1, ref hdd_choice, hddsr, ComboBoxhdd);

//if (checkBoxhdd.Checked)
//{
//    int price1 = 0;
//    int price2 = 0;
//    int price3 = 0;
//    int price4 = 0;
//    if (hddk1 < 1) { price1 = (int)(hddk1 * realmoney); } else { price1 = (int)hddk1; }
//    if (hddk2 < 1) { price2 = (int)(hddk2 * realmoney); } else { price2 = (int)hddk2; }
//    if (hddk3 < 1) { price3 = (int)(hddk3 * realmoney); } else { price3 = (int)hddk3; }
//    if (hddk4 < 1) { price4 = (int)(hddk4 * realmoney); } else { price4 = (int)hddk4; }
//    if (ComboBoxbox.SelectedIndex != 0) { choice = ComboBoxbox.SelectedIndex; }
//    else if (realmoney < hddp1) { choice = Closest.custom_cauto(hdd, hdd1, price1, "", hddsr); }
//    else if (realmoney >= hddp1 && realmoney < hddp2) { choice = Closest.custom_cauto(hdd, hdd1, price2, "", hddsr); }
//    else if (realmoney >= hddp2 && realmoney < hddp3) { choice = Closest.custom_cauto(hdd, hdd1, price3, "", hddsr); }
//    else { choice = Closest.custom_cauto(hdd, hdd1, price4, "", hddsr); }
//    if (choice == 0 || choice == -1)
//    {
//        hdd_choice = 0;
//    }
//    else
//    {
//        hdd_choice = choice;

//    }
//}
//if (checkBoxhdd.Checked)
//{
//    if (ComboBoxhdd.SelectedIndex != 0) { choice = ComboBoxhdd.SelectedIndex; }
//    else if (money <= 3000)
//    {
//        choice = Closest.cauto(hdd, hdd1, 200, "", hddsr);
//    }
//    else if (money > 3000 && money <= 6000)
//    {
//        choice = Closest.cauto(hdd, hdd1, 300, "", hddsr);
//    }
//    else if (money > 6000 && money <= 10000)
//    {
//        choice = Closest.cauto(hdd, hdd1, 400, "", hddsr);
//    }
//    else { choice = Closest.cauto(hdd, hdd1, 500, "", hddsr); }

//    if (choice == 0 || choice == -1) {
//        hdd_choice = 0;
//        //hdd[0] = "没有找到符合要求的配件。"; hdd1[0] = 0;
//    }
//    else
//    {
//        hdd_choice = choice;

//        //hdd[0] = hdd[choice];
//        //hdd1[0] = hdd1[choice];
//        //hdd2[0] = hdd2[choice];

//    }
//}
#endregion

#region c_ram()OldCode
//CJViaPofile(cjram, ram, ram1, ref ram_choice, ramsr, ComboBoxram);

//if (checkram.Checked)
//{
//    int price1 = 0;
//    int price2 = 0;
//    int price3 = 0;
//    int price4 = 0;
//    if (ramk1 < 1) { price1 = (int)(ramk1 * realmoney); } else { price1 = (int)ramk1; }
//    if (ramk2 < 1) { price2 = (int)(ramk2 * realmoney); } else { price2 = (int)ramk2; }
//    if (ramk3 < 1) { price3 = (int)(ramk3 * realmoney); } else { price3 = (int)ramk3; }
//    if (ramk4 < 1) { price4 = (int)(ramk4 * realmoney); } else { price4 = (int)ramk4; }
//    if (ComboBoxbox.SelectedIndex != 0) { choice = ComboBoxbox.SelectedIndex; }
//    else if (realmoney < hddp1) { choice = Closest.custom_cauto(ram, ram1, price1, "", ramsr); }
//    else if (realmoney >= hddp1 && realmoney < hddp2) { choice = Closest.custom_cauto(ram, ram1, price2, "", ramsr); }
//    else if (realmoney >= hddp2 && realmoney < hddp3) { choice = Closest.custom_cauto(ram, ram1, price3, "", ramsr); }
//    else { choice = Closest.custom_cauto(ram, ram1, price4, "", ramsr); }
//    if (choice == 0 || choice == -1)
//    {
//        ram_choice = 0;
//    }
//    else
//    {
//        ram_choice = choice;

//    }
//}
//if (checkram.Checked)
//{
//    if (ComboBoxram.SelectedIndex != 0) { choice = ComboBoxram.SelectedIndex; }
//    else if (money < 2000)
//    {
//        choice = Closest.cauto(ram, ram1, 60, "2GB", ramsr);
//        //choice = 11;
//    }
//    else if (money >= 2000 && money <= 5500) { choice = Closest.cauto(ram, ram1, 100, "4GB", ramsr); }
//    else { choice = Closest.cauto(ram, ram1, 250, "8GB", ramsr); }
//    if (choice != -1)
//    {
//        ram_choice = choice;

//        //ram[0] = ram[choice];
//        //ram1[0] = ram1[choice];
//        //ram2[0] = ram2[choice];
//    }
//    else 
//    {
//        ram_choice = 0;
//    }
//}
#endregion

#region AccessOldCode
//OleDbCommand cmd;
//cmd = new OleDbCommand("SELECT * FROM z_cpu", odcConnection);
//OleDbDataReader reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }
//        //MessageBox.Show((reader[4].ToString()));
//        cpu[i] = reader[0].ToString();
//        cpu1[i] = System.Int32.Parse(reader[2].ToString());
//        cpu3[i] = System.Int32.Parse(reader[1].ToString());
//        //cpu4[i] = (long)System.Int32.Parse(reader[4].ToString());
//        cpu2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "CPU" + i.ToString() + ex.ToString() + "\r\n";
//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n"+ex.ToString ()); 
//    }
//}
/////////////////////
//cmd = new OleDbCommand("SELECT * FROM z_acpu", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        acpu[i] = reader[0].ToString();
//        acpu1[i] = System.Int32.Parse(reader[2].ToString());
//        acpu3[i] = System.Int32.Parse(reader[1].ToString());

//        acpu2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "ACPU" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_hdd", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }
//        hdd[i] = reader[0].ToString();
//        hdd1[i] = System.Int32.Parse(reader[2].ToString());
//        hdd3[i] = System.Int32.Parse(reader[1].ToString());

//        hdd2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "HDD" + i.ToString() + ex.ToString() + "\r\n";
//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_ram", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        ram[i] = reader[0].ToString();
//        ram1[i] = System.Int32.Parse(reader[2].ToString());
//        ram3[i] = System.Int32.Parse(reader[1].ToString());

//        ram2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "RAM" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_gpu", odcConnection);
//reader = cmd.ExecuteReader();
//gpu[1] = "集成显卡/核心显卡";
//gpu1[1] = 0;
//gpu2[1] = 0;
//gpu3[1] = 0;

//i = 2;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 498) { break; }

//        gpu[i] = reader[0].ToString();
//        gpu1[i] = System.Int32.Parse(reader[2].ToString());
//        gpu3[i] = System.Int32.Parse(reader[1].ToString());

//        gpu2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "GPU" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_lcd", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        lcd[i] = reader[0].ToString();
//        lcd1[i] = System.Int32.Parse(reader[2].ToString());
//        lcd3[i] = System.Int32.Parse(reader[1].ToString());

//        lcd2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "LCD" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_ssd", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        ssd[i] = reader[0].ToString();
//        ssd1[i] = System.Int32.Parse(reader[2].ToString());
//        ssd3[i] = System.Int32.Parse(reader[1].ToString());

//        ssd2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "SSD" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_box", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        box[i] = reader[0].ToString();
//        box1[i] = System.Int32.Parse(reader[2].ToString());
//        box3[i] = System.Int32.Parse(reader[1].ToString());

//        box2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "BOX" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_pow", odcConnection);
//reader = cmd.ExecuteReader();
//power[1] = "机箱自带";
//power1[1] = 0;
//power2[1] = 0;
//power3[1] = 0;
//i = 2;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 498) { break; }

//        power[i] = reader[0].ToString();
//        power1[i] = System.Int32.Parse(reader[2].ToString());
//        power3[i] = System.Int32.Parse(reader[1].ToString());

//        power2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "POWER" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_kb", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        kb[i] = reader[0].ToString();
//        kb1[i] = System.Int32.Parse(reader[2].ToString());
//        kb3[i] = System.Int32.Parse(reader[1].ToString());

//        kb2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "KB" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//if (MDBHelper.GetTables(odcConnection, "z_mou"))
//{
//    cmd = new OleDbCommand("SELECT * FROM z_mou", odcConnection);
//    reader = cmd.ExecuteReader();
//    mou[1] = "套装自带";
//    mou1[1] = 0;
//    mou2[1] = 0;
//    mou3[1] = 0;

//    i = 2;
//    while (reader.Read())
//    {
//        try
//        {
//            if (i > 498) { break; }

//            mou[i] = reader[0].ToString();
//            mou1[i] = System.Int32.Parse(reader[2].ToString());
//            mou3[i] = System.Int32.Parse(reader[1].ToString());

//            mou2[i++] = System.Int32.Parse(reader[3].ToString());
//        }
//        catch (Exception ex)
//        {
//            errorinfo += "MOU" + i.ToString() + ex.ToString() + "\r\n";

//            //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//        }

//    }
//}
//cmd = new OleDbCommand("SELECT * FROM z_hs", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        hs[i] = reader[0].ToString();
//        hs1[i] = System.Int32.Parse(reader[2].ToString());
//        hs3[i] = System.Int32.Parse(reader[1].ToString());

//        hs2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "HS" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_fan", odcConnection);
//reader = cmd.ExecuteReader();
//fan[1] = "盒装自带";
//fan1[1] = 0;
//fan2[1] = 0;
//fan3[1] = 0;
//i = 2;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        fan[i] = reader[0].ToString();
//        fan1[i] = System.Int32.Parse(reader[2].ToString());
//        fan3[i] = System.Int32.Parse(reader[1].ToString());

//        fan2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "FAN" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_sp", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        sp[i] = reader[0].ToString();
//        sp1[i] = System.Int32.Parse(reader[2].ToString());
//        sp3[i] = System.Int32.Parse(reader[1].ToString());

//        sp2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "SP" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_o", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        o[i] = reader[0].ToString();
//        o1[i] = System.Int32.Parse(reader[2].ToString());
//        o3[i] = System.Int32.Parse(reader[1].ToString());

//        o2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "O" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_mb", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        mb[i] = reader[0].ToString();
//        mb1[i] = System.Int32.Parse(reader[2].ToString());
//        mb3[i] = System.Int32.Parse(reader[1].ToString());

//        mb2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "MB" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString()); 
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_cam", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        cam[i] = reader[0].ToString();
//        cam1[i] = System.Int32.Parse(reader[2].ToString());
//        cam3[i] = System.Int32.Parse(reader[1].ToString());

//        cam2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "CAM" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//cmd = new OleDbCommand("SELECT * FROM z_cdrom", odcConnection);
//reader = cmd.ExecuteReader();
//i = 1;
//while (reader.Read())
//{
//    try
//    {
//        if (i > 499) { break; }

//        cdrom[i] = reader[0].ToString();
//        cdrom1[i] = System.Int32.Parse(reader[2].ToString());
//        cdrom3[i] = System.Int32.Parse(reader[1].ToString());

//        cdrom2[i++] = System.Int32.Parse(reader[3].ToString());
//    }
//    catch (Exception ex)
//    {
//        errorinfo += "CDROM" + i.ToString() + ex.ToString() + "\r\n";

//        //MessageBox.Show("配置文件存在部分错误，程序将继续加载其他部分！\n" + ex.ToString());
//    }

//}
//////////////////////
////
//oReader.Close();
#endregion

#region OldCode
//if (trial == true)
//{
//    //System.Diagnostics.Process.Start("http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057&fromuid=1");
//    MessageBox.Show("您正在使用试用版软件，如果您喜欢本软件，请支持正版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//}
//if (TextBox1.Text == "") { MessageBox.Show("请输入预算金额！"); return; }
//TextBoxcpu.Text = " ";
////TextBoxcpu1.Text = "0";

//TextBoxgpu.Text = " ";
////TextBoxgpu1.Text = "0";
//TextBoxmb.Text = " ";
////TextBoxmb1.Text = "0";
//TextBoxram.Text = " ";
////TextBoxram1.Text = "0";
//TextBoxhdd.Text = " ";
////TextBoxhdd1.Text = "0";
//TextBoxlcd.Text = " ";
////TextBoxlcd1.Text = "0";
//TextBoxfan.Text = " ";
////TextBoxfan1.Text = "0";
//TextBoxpower.Text = " ";
////TextBoxpower1.Text = "0";
//TextBoxbox.Text = " ";
////TextBoxbox1.Text = "0";
//TextBoxssd.Text = " ";
////textBoxssd1.Text = "0";
//TextBoxcdrom.Text = " ";
////textBoxcdrom1.Text = "0";
//TextBoxkb.Text = " ";
////textBoxkb1.Text = "0";
//TextBoxmou.Text = " ";
//TextBoxhs.Text = " ";
////textBoxhs1.Text = "0";

//TextBoxcam.Text = " ";
////textBoxcam1.Text = " ";
//TextBoxsp.Text = " ";
////textBoxsp1.Text = " ";
//TextBoxo.Text = " ";
////textBoxo1.Text = " ";

//////////////////////////
//cpu[0] = " ";
//cpu1[0] = 0;
//cpu2[0] = 0;
//cpu3[0] = 0;

//gpu[0] = " ";
//gpu1[0] = 0;
//gpu2[0] = 0;
//gpu3[0] = 0;

//mb[0] = " ";
//mb1[0] = 0;
//mb2[0] = 0;
//mb3[0] = 0;

//ram[0] = " ";
//ram1[0] = 0;
//ram2[0] = 0;
//ram3[0] = 0;

//box[0] = " ";
//box1[0] = 0;
//box2[0] = 0;
//box3[0] = 0;

//power[0] = " ";
//power1[0] = 0;
//power2[0] = 0;
//power3[0] = 0;

//lcd[0] = " ";
//lcd1[0] = 0;
//lcd2[0] = 0;
//lcd3[0] = 0;

//fan[0] = " ";
//fan1[0] = 0;
//fan2[0] = 0;
//fan3[0] = 0;

//hdd[0] = " ";
//hdd1[0] = 0;
//hdd2[0] = 0;
//hdd3[0] = 0;

//ssd[0] = " ";
//ssd1[0] = 0;
//ssd2[0] = 0;
//ssd3[0] = 0;

//cdrom[0] = " ";
//cdrom1[0] = 0;
//cdrom2[0] = 0;
//cdrom3[0] = 0;

//kb[0] = " ";
//kb1[0] = 0;
//kb2[0] = 0;
//kb3[0] = 0;

//mou[0] = " ";
//mou1[0] = 0;
//mou2[0] = 0;
//mou3[0] = 0;

//hs[0] = " ";
//hs1[0] = 0;
//hs2[0] = 0;
//hs3[0] = 0;

//sp[0] = " ";
//sp1[0] = 0;
//sp2[0] = 0;
//sp3[0] = 0;

//cam[0] = " ";
//cam1[0] = 0;
//cam2[0] = 0;
//cam3[0] = 0;

//o[0] = " ";
//o1[0] = 0;
//o2[0] = 0;
//o3[0] = 0;

////////////////////////
//cpusr = textBoxCpuSr.Text;
//mbsr = textBoxMbSr.Text;
//ramsr = textBoxRamSr.Text;
//hddsr = textBoxHddSr.Text;
//gpusr = textBoxGpusr.Text;
//ssdsr = textBoxSsdSr.Text;
//lcdsr = textBoxLcdSr.Text;
//boxsr = textBoxBoxsr.Text;
//fansr = textBoxFanSr.Text;
//powersr = textBoxPowerSr.Text;
//cdromsr = textBoxCdromSr.Text;
//kbsr = textBoxKbSr.Text;
//mousr = textBoxMouSr.Text;
//hssr = textBoxHsSr.Text;
//camsr = textBoxCamSr.Text;
//spsr = textBoxSpSr.Text;
//osr = textBoxOSr.Text;

/////////////////////////
////long  choice=0;
////int mbchoice=0;
////long money;
////long realmoney=0;
//choice = 0;
//cpu_choice = 0;
//acpu_choice = 0;
//mb_choice = 0;
//gpu_choice = 0;
//ram_choice = 0;
//power_choice = 0;
//lcd_choice = 0;
//box_choice = 0;
//hdd_choice = 0;
//ssd_choice = 0;
//fan_choice = 0;
//cdrom_choice = 0;
//kb_choice = 0;
//mou_choice = 0;
//hs_choice = 0;
//cam_choice = 0;
//sp_choice = 0;
//o_choice = 0;


#endregion
//Int32.TryParse ()

//if (choice == 0 || choice == -1)
//{
//    cpu_choice = 0;
//    //cpu[0] = "没有找到符合要求的配件。"; cpu1[0] = 0; 
//}
//else
//{
//    cpu_choice = choice;
//    //cpu[0] = cpu[choice];
//    //cpu1[0] = cpu1[choice];
//    //cpu2[0] = cpu2[choice];

//}

//if (checkBoxcpu.Checked || cpusrbox.Text == "K")
//{//(int)(((float)money) / 3.5)

//  choice = closest(cpu1, money / 4); 
//}
//else
//{
//    choice = Closest.cauto(cpu, cpu1, money / 4, "", cpusr ,"K");
//    //   choice = closest(cpu1, money / 5); 
//}




//if (ComboBoxcpu.SelectedIndex != 0)
//{
//    choice = ComboBoxcpu.SelectedIndex;

//}
//else
//{

//}
//if (choice == 0 || choice == -1)
//{
//    gpu_choice = 0;

//    //gpu[0] = "没有找到合适的显卡！"; gpu1[0] = 0; 
//}
//else
//{
//    gpu_choice = choice;

//    //gpu[0] = gpu[choice];
//    //gpu1[0] = gpu1[choice];
//    //gpu2[0] = gpu2[choice];
//}


#region totalprice()
//if (checkcpu.Checked)
//{
//    if (checkCustAmd.Checked)
//    {
//        //MessageBox.Show(acpu_choice.ToString ());
//        TextBoxcpu.Text = acpu[acpu_choice];
//        if (cpuz.Checked)
//        {
//            TextBoxcpu1.Text = "￥0";
//        }
//        else
//        {
//            TextBoxcpu1.Text = "￥" + acpu1[acpu_choice].ToString();
//            sum += acpu1[acpu_choice];
//        }
//        costsum += acpu3[acpu_choice];

//    }
//    else
//    {
//        TextBoxcpu.Text = cpu[cpu_choice];
//        if (cpuz.Checked)
//        {
//            TextBoxcpu1.Text = "￥0";
//        }
//        else
//        {
//            TextBoxcpu1.Text = "￥" + cpu1[cpu_choice].ToString();
//            sum += cpu1[cpu_choice];
//        }
//        costsum += cpu3[cpu_choice];
//    }
//}
//if (checkmb.Checked)
//{
//    TextBoxmb.Text = mb[mb_choice];
//    if (mbz.Checked) { TextBoxmb1.Text = "￥0"; }
//    else
//    {
//        TextBoxmb1.Text = "￥" + mb1[mb_choice].ToString();
//        sum += mb1[mb_choice];
//    }
//    costsum += mb3[mb_choice];
//}
//if (checkgpu.Checked)
//{
//    TextBoxgpu.Text = gpu[gpu_choice];
//    if (gpuz.Checked) { TextBoxgpu1.Text = "￥0"; }
//    else
//    {
//        TextBoxgpu1.Text = "￥" + gpu1[gpu_choice].ToString();
//        sum += gpu1[gpu_choice];
//    }
//    costsum += gpu3[gpu_choice];

//}
//if (checkram.Checked)
//{
//    TextBoxram.Text = ram[ram_choice];
//    if (ramz.Checked) { TextBoxram1.Text = "￥0"; }
//    else
//    {
//        TextBoxram1.Text = "￥" + ram1[ram_choice].ToString();
//        sum += ram1[ram_choice];
//    }
//    costsum += ram3[ram_choice];
//}
//if (checkhdd.Checked)
//{
//    TextBoxhdd.Text = hdd[hdd_choice];
//    if (hddz.Checked) { TextBoxhdd1.Text = "￥0"; }
//    else
//    {
//        TextBoxhdd1.Text = "￥" + hdd1[hdd_choice].ToString();
//        sum += hdd1[hdd_choice];
//    }
//    costsum += hdd3[hdd_choice];
//}
//if (checkbox.Checked)
//{
//    TextBoxbox.Text = box[box_choice];
//    if (boxz.Checked) { TextBoxbox1.Text = "￥0"; }
//    else
//    {
//        TextBoxbox1.Text = "￥" + box1[box_choice].ToString();
//        sum += box1[box_choice];
//    }
//    costsum += box3[box_choice];
//}
//if (checkfan.Checked)
//{

//    TextBoxfan.Text = fan[fan_choice];
//    if (fanz.Checked) { TextBoxfan1.Text = "￥0"; }
//    else
//    {
//        TextBoxfan1.Text = "￥" + fan1[fan_choice].ToString();
//        sum += fan1[fan_choice];
//    }
//    costsum += fan3[fan_choice];
//}
//if (Checklcd.Checked)
//{
//    TextBoxlcd.Text = lcd[lcd_choice];
//    if (lcdz.Checked) { TextBoxlcd1.Text = "￥0"; }
//    else
//    {
//        TextBoxlcd1.Text = "￥" + lcd1[lcd_choice].ToString();
//        sum += lcd1[lcd_choice];
//    }
//    costsum += lcd3[lcd_choice];
//}
//if (checkpower.Checked)
//{
//    TextBoxpower.Text = power[power_choice];
//    if (powerz.Checked) { TextBoxpower1.Text = "￥0"; }
//    else
//    {
//        TextBoxpower1.Text = "￥" + power1[power_choice].ToString();
//        sum += power1[power_choice];
//    }
//    costsum += power3[power_choice];
//}
//if (checkcdrom.Checked)
//{
//    TextBoxcdrom.Text = cdrom[cdrom_choice];
//    if (cdromz.Checked) { TextBoxcdrom1.Text = "￥0"; }
//    else
//    {
//        TextBoxcdrom1.Text = "￥" + cdrom1[cdrom_choice].ToString();
//        sum += cdrom1[cdrom_choice];
//    }
//    costsum += cdrom3[cdrom_choice];
//}
//if (checkkb.Checked)
//{
//    TextBoxkb.Text = kb[kb_choice];
//    if (kbz.Checked) { TextBoxkb1.Text = "￥0"; }
//    else
//    {
//        TextBoxkb1.Text = "￥" + kb1[kb_choice].ToString();
//        sum += kb1[kb_choice];
//    }
//    costsum += kb3[kb_choice];
//}
//if (checkmou.Checked)
//{
//    TextBoxmou.Text = mou[mou_choice];
//    if (mouz.Checked) { TextBoxmou1.Text = "￥0"; }
//    else
//    {
//        TextBoxmou1.Text = "￥" + mou1[mou_choice].ToString();
//        sum += mou1[mou_choice];
//    }
//    costsum += mou3[mou_choice];
//}
//if (checkssd.Checked)
//{
//    TextBoxssd.Text = ssd[ssd_choice];
//    if (ssdz.Checked) { TextBoxssd1.Text = "￥0"; }
//    else
//    {
//        TextBoxssd1.Text = "￥" + ssd1[ssd_choice].ToString();
//        sum += ssd1[ssd_choice];
//    }
//    costsum += ssd3[ssd_choice];
//}
//if (checkhs.Checked)
//{
//    TextBoxhs.Text = hs[hs_choice];
//    if (hsz.Checked) { TextBoxhs1.Text = "￥0"; }
//    else
//    {
//        TextBoxhs1.Text = "￥" + hs1[hs_choice].ToString();
//        sum += hs1[hs_choice];
//    }
//    costsum += hs3[hs_choice];
//}
//if (checkcam.Checked)
//{

//    TextBoxcam.Text = cam[cam_choice];
//    if (camz.Checked) { TextBoxcam1.Text = "￥0"; }
//    else
//    {
//        TextBoxcam1.Text = "￥" + cam1[cam_choice].ToString();
//        sum += cam1[cam_choice];
//    }
//    costsum += cam3[cam_choice];
//}
//if (checksp.Checked)
//{
//    TextBoxsp.Text = sp[sp_choice];
//    if (spz.Checked) { TextBoxsp1.Text = "￥0"; }
//    else
//    {
//        TextBoxsp1.Text = "￥" + sp1[sp_choice].ToString();
//        sum += sp1[sp_choice];
//    }
//    costsum += sp3[sp_choice];
//}
//if (checko.Checked)
//{
//    TextBoxo.Text = o[o_choice];
//    if (oz.Checked) { TextBoxo1.Text = "￥0"; }
//    else
//    {
//        TextBoxo1.Text = "￥" + o1[o_choice].ToString();
//        sum += o1[o_choice];
//    }
//    costsum += o3[o_choice];
//}
////// 
#endregion


//private void gift() 
//{
//    //判断赠品
//    if (cpuz.Checked) { cpu1[0] = 0; }
//    if (mbz.Checked) { mb1[0] = 0; }
//    if (gpuz.Checked) { gpu1[0] = 0; }
//    if (ramz.Checked) { ram1[0] = 0; }
//    if (hddz.Checked) { hdd1[0] = 0; }
//    if (boxz.Checked) { box1[0] = 0; }
//    if (lcdz.Checked) { lcd1[0] = 0; }
//    if (powerz.Checked) { power1[0] = 0; }
//    if (fanz.Checked) { fan1[0] = 0; }
//    if (cdromz.Checked) { cdrom1[0] = 0; }
//    if (kbz.Checked) { kb1[0] = 0; }
//    if (ssdz.Checked) { ssd1[0] = 0; }
//    if (hsz.Checked) { hs1[0] = 0; }
//    if (camz.Checked) { cam1[0] = 0; }
//    if (spz.Checked) { sp1[0] = 0; }
//    if (oz.Checked) { o1[0] = 0; }
//}


#region OldCode
//public static string[] cpu = new string[500]; public static int[] cpu1 = new int[500]; public static int[] cpu2 = new int[500]; public static int[] cpu3 = new int[500]; public static long[] cpu4 = new long[500];
//public static string[] acpu = new string[500]; public static int[] acpu1 = new int[500]; public static int[] acpu2 = new int[500]; public static int[] acpu3 = new int[500]; public static long[] acpu4 = new long[500];
//public static string[] mb = new string[500]; public static int[] mb1 = new int[500]; public static int[] mb2 = new int[500]; public static int[] mb3 = new int[500]; public static long[] mb4 = new long[500];
//public static string[] gpu = new string[500]; public static int[] gpu1 = new int[500]; public static int[] gpu2 = new int[500]; public static int[] gpu3 = new int[500]; public static long[] gpu4 = new long[500];
//public static string[] ram = new string[500]; public static int[] ram1 = new int[500]; public static int[] ram2 = new int[500]; public static int[] ram3 = new int[500]; public static long[] ram4 = new long[500];
//public static string[] power = new string[500]; public static int[] power1 = new int[500]; public static int[] power2 = new int[500]; public static int[] power3 = new int[500]; public static long[] power4 = new long[500];
//public static string[] lcd = new string[500]; public static int[] lcd1 = new int[500]; public static int[] lcd2 = new int[500]; public static int[] lcd3 = new int[500]; public static long[] lcd4 = new long[500];
//public static string[] box = new string[500]; public static int[] box1 = new int[500]; public static int[] box2 = new int[500]; public static int[] box3 = new int[500]; public static long[] box4 = new long[500];
//public static string[] hdd = new string[500]; public static int[] hdd1 = new int[500]; public static int[] hdd2 = new int[500]; public static int[] hdd3 = new int[500]; public static long[] hdd4 = new long[500];
//public static string[] ssd = new string[500]; public static int[] ssd1 = new int[500]; public static int[] ssd2 = new int[500]; public static int[] ssd3 = new int[500]; public static long[] ssd4 = new long[500];
//public static string[] fan = new string[500]; public static int[] fan1 = new int[500]; public static int[] fan2 = new int[500]; public static int[] fan3 = new int[500]; public static long[] fan4 = new long[500];
//public static string[] cdrom = new string[500]; public static int[] cdrom1 = new int[100]; public static int[] cdrom2 = new int[500]; public static int[] cdrom3 = new int[500]; public static long[] cdrom4 = new long[500];
//public static string[] kb = new string[500]; public static int[] kb1 = new int[500]; public static int[] kb2 = new int[500]; public static int[] kb3 = new int[500]; public static long[] kb4 = new long[500];
//public static string[] hs = new string[500]; public static int[] hs1 = new int[500]; public static int[] hs2 = new int[500]; public static int[] hs3 = new int[500]; public static long[] hs4 = new long[500];
//public static string[] cam = new string[500]; public static int[] cam1 = new int[500]; public static int[] cam2 = new int[500]; public static int[] cam3 = new int[500]; public static long[] cam4 = new long[500];
//public static string[] sp = new string[500]; public static int[] sp1 = new int[500]; public static int[] sp2 = new int[500]; public static int[] sp3 = new int[500]; public static long[] sp4 = new long[500];
//public static string[] o = new string[500]; public static int[] o1 = new int[500]; public static int[] o2 = new int[500]; public static int[] o3 = new int[500]; public static long[] o4 = new long[500];
//public static string[] mou = new string[500]; public static int[] mou1 = new int[500]; public static int[] mou2 = new int[500]; public static int[] mou3 = new int[500]; public static long[] mou4 = new long[500];
//int cpu_choice = 0;
//int acpu_choice = 0;
//int mb_choice = 0;
//int gpu_choice = 0;
//int ram_choice = 0;
//int power_choice = 0;
//int lcd_choice = 0;
//int box_choice = 0;
//int hdd_choice = 0;
//int ssd_choice = 0;
//int fan_choice = 0;
//int cdrom_choice = 0;
//int kb_choice = 0;
//int hs_choice = 0;
//int cam_choice = 0;
//int sp_choice = 0;
//int o_choice = 0;
//int mou_choice = 0;
//string cpusr;
//string mbsr;
//string ramsr;
//string hddsr;
//string gpusr;
//string ssdsr;
//string lcdsr;
//string boxsr;
//string fansr;
//string powersr;
//string cdromsr;
//string kbsr;
//string hssr;
//string camsr;
//string spsr;
//string osr;
//string mousr;
//string cpusr2 = "";
//public SettingItems si = new SettingItems();
//public static string mdbpath;
//public static string mdbpw;
#endregion



#region OldCode
//public static string hidead;
//public static string autoupdate;
//public static string align;
//public static string savemode;
//public static string printmode;
//public static string showbbs;
//public static string costprice;
#endregion

#region OldCode
//int z = 0;
//public static int[,] PriceInterval=new int [11,3];
//public static float[,] PriceK = new float[11, 4];
//public static string[,] NameRegex = new string[11,4];

/*
    * 0=机箱
       1=电源
       2=光驱
       3=键盘
       4=鼠标
       5=耳机
       6=摄像头
       7=音响
 * 8=内存
 * 9=硬盘
 * 10=固态硬盘
 */
//PriceInterval[0,0]=2000;
//PriceInterval[0,1]=5000;
//PriceInterval[0,2]=12000;
//public static CuanJiProfile cjbox = new CuanJiProfile();
//public static CuanJiProfile cjmou = new CuanJiProfile();
//public static CuanJiProfile cjpow = new CuanJiProfile();
//public static CuanJiProfile cjkb = new CuanJiProfile();
//public static CuanJiProfile cjhs = new CuanJiProfile();
//public static CuanJiProfile cjcam = new CuanJiProfile();
//public static CuanJiProfile cjsp = new CuanJiProfile();
//public static CuanJiProfile cjcdrom = new CuanJiProfile();
//public static CuanJiProfile cjram = new CuanJiProfile();
//public static CuanJiProfile cjhdd = new CuanJiProfile();
//public static CuanJiProfile cjssd = new CuanJiProfile();
#endregion

//String releaseurl = "http://bbs.luobotou.org/forum.php?mod=viewthread&tid=3057";
//ArrayList cbbArr = new ArrayList();
//ArrayList nameArr = new ArrayList();


#region
//hidead = IniFile.ReadVal("Main", "Hidead", settingsini);
//autoupdate = IniFile.ReadVal("Main", "AutoUpdate", settingsini);
//mdbpath = IniFile.ReadVal("Main", "MdbPath", settingsini);
//mdbpw = IniFile.ReadVal("Main", "MdbPw", settingsini);

//align = IniFile.ReadVal("Main", "Align", settingsini);
//printmode = IniFile.ReadVal("Main", "Print", settingsini);
//savemode = IniFile.ReadVal("Main", "Save", settingsini);
//showbbs = IniFile.ReadVal("Main", "ShowBBS", settingsini);
//costprice = IniFile.ReadVal("Main", "CostPrice", settingsini);
#endregion

#region memstringOldCode

//string memstring;
//memstring = IniFile.ReadVal("M2", "PZ1", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入记忆ToolStripMenuItem.Text = "存入1：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ1ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ1ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ2", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入2ToolStripMenuItem.Text = "存入2：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ2ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ2ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ3", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入3ToolStripMenuItem.Text = "存入3：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ3ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ3ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ4", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入4ToolStripMenuItem.Text = "存入4：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ4ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ4ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ5", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入5ToolStripMenuItem.Text = "存入5：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ5ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ5ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ6", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入6ToolStripMenuItem.Text = "存入6：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ6ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ6ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ7", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入7ToolStripMenuItem.Text = "存入7：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ7ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ7ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ8", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入8ToolStripMenuItem.Text = "存入8：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ8ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ8ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ9", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入9ToolStripMenuItem.Text = "存入9：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ9ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ9ToolStripMenuItem.Visible = true; }
//memstring = IniFile.ReadVal("M2", "PZ10", settingsini);
//if (memstring != "") { label46.Visible = true; this.存入10ToolStripMenuItem.Text = "存入10：" + memstring.Substring(0, memstring.IndexOf("~")); this.pZ10ToolStripMenuItem.Text = memstring.Substring(0, memstring.IndexOf("~")); this.pZ10ToolStripMenuItem.Visible = true; }
////
#endregion


//private void ReadCustomRatio(string kind,string p)
//{
//    //IniFile.WriteVal(kind, "P1", textBoxp12.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "P2", textBoxp22.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "P3", textBoxp32.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "K1", textBoxk1.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "K2", textBoxk2.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "K3", textBoxk3.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "K4", textBoxk4.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "R1", textBoxr1.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "R2", textBoxr2.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "R3", textBoxr3.Text, Form1.settingsini);
//    //IniFile.WriteVal(kind, "R4", textBoxr4.Text, Form1.settingsini);

//}

//public static int ConvertIntoInt(string content)
//{
//    string result;
//    if (Int32.TryParse(content, result)) 
//    {

//    }
//}

#region Loading OldCode
//foreach (var item in SData.allHwKind)
//{
//    if (item == SData.hwACpu) continue;
//    item.AddToComboBox();
//}
//for (int i = 0; i < cbbArr.Count; i++)
//{
//    ComboBoxInitialization((ComboBox)cbbArr[i]);
//}
//ComboBoxInitialization((ComboBox)cbbArr[0]);
//ComboBoxInitialization(ComboBoxmb);
//ComboBoxInitialization(ComboBoxram);
//ComboBoxInitialization(ComboBoxhdd);
//ComboBoxInitialization(ComboBoxgpu);
//ComboBoxInitialization(ComboBoxlcd);
//ComboBoxInitialization(ComboBoxbox);
//ComboBoxInitialization(ComboBoxfan);
//ComboBoxInitialization(ComboBoxssd);
//ComboBoxInitialization(ComboBoxpower);
//ComboBoxInitialization(ComboBoxcdrom);
//ComboBoxInitialization(ComboBoxkb);
//ComboBoxInitialization(ComboBoxmou);
//ComboBoxInitialization(ComboBoxhs);
//ComboBoxInitialization(ComboBoxcam);
//ComboBoxInitialization(ComboBoxsp);
//ComboBoxInitialization(ComboBoxo);



//for (z = 1; z <= 499; z++)
//{
//    AddToComboBox(ComboBoxgpu, gpu[z], gpu1[z]);
//    AddToComboBox(ComboBoxcpu, cpu[z], cpu1[z]);
//    AddToComboBox(ComboBoxhdd, hdd[z], hdd1[z]);
//    AddToComboBox(ComboBoxram, ram[z], ram1[z]);
//    AddToComboBox(ComboBoxmb, mb[z], mb1[z]);
//    AddToComboBox(ComboBoxlcd, lcd[z], lcd1[z]);
//    AddToComboBox(ComboBoxfan, fan[z], fan1[z]);
//    AddToComboBox(ComboBoxbox, box[z], box1[z]);
//    AddToComboBox(ComboBoxpower, power[z], power1[z]);
//    AddToComboBox(ComboBoxcdrom, cdrom[z], cdrom1[z]);
//    AddToComboBox(ComboBoxkb, kb[z], kb1[z]);
//    AddToComboBox(ComboBoxmou, mou[z], mou1[z]);
//    AddToComboBox(ComboBoxssd, ssd[z], ssd1[z]);
//    AddToComboBox(ComboBoxhs, hs[z], hs1[z]);
//    AddToComboBox(ComboBoxcam, cam[z], cam1[z]);
//    AddToComboBox(ComboBoxsp, sp[z], sp1[z]);
//    AddToComboBox(ComboBoxo, o[z], o1[z]);


//}
#endregion


//        private void CJViaPofile(CuanJiPofileStruct cjp, HardWareKind hwk)
//        {
//            //if (PriceArray[1] == 0)
//            //{

//            if (hwk.CBB.SelectedIndex != 0) { choice = hwk.CBB.SelectedIndex; }
//            else
//            {
//                int price1 = 0;
//                int price2 = 0;
//                int price3 = 0;
//                int price4 = 0;
//                if (cjp.K1 < 1) { price1 = (int)(cjp.K1 * realmoney); } else { price1 = (int)cjp.K1; }
//                if (cjp.K2 < 1) { price2 = (int)(cjp.K2 * realmoney); } else { price2 = (int)cjp.K2; }
//                if (cjp.K3 < 1) { price3 = (int)(cjp.K3 * realmoney); } else { price3 = (int)cjp.K3; }
//                if (cjp.K4 < 1) { price4 = (int)(cjp.K4 * realmoney); } else { price4 = (int)cjp.K4; }
//#warning 未实现
//                //if (realmoney < cjp.P1) { choice = Closest.custom_cauto(NameArray, PriceArray, price1, cjp.RG1, hwsr); }
//                //else if (realmoney >= cjp.P1 && realmoney <= cjp.P2) { choice = Closest.custom_cauto(NameArray, PriceArray, price2, cjp.RG2, hwsr); }
//                //else if (realmoney >= cjp.P2 && realmoney <= cjp.P3) { choice = Closest.custom_cauto(NameArray, PriceArray, price3, cjp.RG3, hwsr); }
//                //else if (realmoney >= cjp.P3) { choice = Closest.cauto(NameArray, PriceArray, price4, cjp.RG4, hwsr); }
//            }
//            if (choice == 0 || choice == -1)
//            {
//                hwk.HWChoice = HardWareKind.NoResult;
//            }
//            else
//            {
//                hwk.HWChoice = choice;
//            }
//            //}
//        }


#region c_o()
//if (o1[1] != 0)
//{

//    {
//        if (ComboBoxo.SelectedIndex != 0) { choice = ComboBoxo.SelectedIndex; }
//        else
//        {
//            o_choice = 0;
//            //o[0] = "没有找到符合要求的配件。"; o1[0] = 0;
//        }
//        if (choice == 0 || choice == -1)
//        {
//            o_choice = 0;
//            //o[0] = "没有找到符合要求的配件。"; o1[0] = 0; 
//        }
//        // MessageBox.Show(choice.ToString ());
//        else
//        {
//            o_choice = choice;

//            //o[0] = o[choice];
//            //o1[0] = o1[choice];
//            //o2[0] = o2[choice];

//        }

//    }
//}
#endregion

//if (choice == 0 || choice == -1)
//{
//    gpu_choice = 0;
//    //gpu[0] = "没有找到符合要求的配件。"; gpu1[0] = 0;
//}
//else
//{
//    gpu_choice = choice;

//    //gpu[0] = gpu[choice];
//    //gpu1[0] = gpu1[choice];
//    //gpu2[0] = gpu2[choice];
//}

//    choice = Closest.closest(lcd1, rest); 
////}
//if (choice == 0 || choice == -1)
//{
//    lcd_choice = 0;
//    //lcd[0] = "没有找到符合要求的配件。"; lcd1[0] = 0; 
//}
//else
//{
//    lcd_choice = choice;

//    //lcd[0] = lcd[choice];
//    //lcd1[0] = lcd1[choice];
//    //lcd2[0] = lcd2[choice];
//}


//if (choice == 0 || choice == -1)
//{
//    mou_choice = 0;
//    //box[0] = "没有找到符合要求的配件。"; box1[0] = 0;
//}
//else
//{
//    mou_choice = choice;

//    //box[0] = box[choice];
//    //box1[0] = box1[choice];
//    //box2[0] = box2[choice];
//}


#region AddToComboBoxOldCode
//private void AddToComboBox(ComboBox cbb, string name, int price)
//{
//    if (!string.IsNullOrEmpty(name))
//    {
//        cbb.Items.Add(name + CreateSpace(27 - System.Text.Encoding.Default.GetBytes(name).Length) + "    ￥" + price);
//    }
//}

//public static int GetLength(string str)
//{
//    //Control control;
//    //Graphics graphics = control.CreateGraphics();
//    //SizeF sizeF = graphics.MeasureString(str, new Font("微软雅黑", 9));
//    //MessageBox.Show(string.Format("字体宽度：{0}，高度：{1}", sizeF.Width, sizeF.Height));
//    //graphics.Dispose();
//    //MessageBox.Show("Test");
//    if (str.Length == 0) return 0;
//    ASCIIEncoding ascii = new ASCIIEncoding(); int tempLen = 0; byte[] s = ascii.GetBytes(str); for (int i = 0; i < s.Length; i++)
//    {
//        if ((int)s[i] == 63)
//        {
//            tempLen += 2;
//        }
//        else
//        {
//            tempLen += 1;
//        }
//    }
//    return tempLen;
//}
//string CreateSpace(int num)
//{
//    return "";
//    //if (align == "True")
//    //{
//    //    //MessageBox.Show("Test");
//    //    string space = "";
//    //    for (int i = 1; i <= num; i++)
//    //    {
//    //        space += " ";
//    //    }
//    //    return space;
//    //}
//    //else return "";
//}
#endregion

#region 清空OldCode
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
#endregion


#region OldCode
//for (int i = 1; i <= 499; i++)
//{
//    if (SData .hwCpu .HW !=null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "CPU";
//        row[1] = Form1.cpu[i];
//        row[2] = Form1.cpu1[i];
//        row[3] = Form1.cpu3[i];
//        row[4] = Form1.cpu2[i];
//        //row[5] = Form1.cpu4[i];
//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.acpu[i] != "" && Form1.acpu[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "AMD CPU";
//        row[1] = Form1.acpu[i];
//        row[2] = Form1.acpu1[i];
//        row[3] = Form1.acpu3[i];
//        row[4] = Form1.acpu2[i];
//        //row[5] = Form1.acpu4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.mb[i] != "" && Form1.mb[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "主板";
//        row[1] = Form1.mb[i];
//        row[2] = Form1.mb1[i];
//        row[3] = Form1.mb3[i];
//        row[4] = Form1.mb2[i];
//        //row[5] = Form1.mb4[i];
//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.hdd[i] != "" && Form1.hdd[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "硬盘";
//        row[1] = Form1.hdd[i];
//        row[2] = Form1.hdd1[i];
//        row[3] = Form1.hdd3[i];
//        row[4] = Form1.hdd2[i];
//        //row[5] = Form1.hdd4[i];
//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.ram[i] != "" && Form1.ram[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "内存";
//        row[1] = Form1.ram[i];
//        row[2] = Form1.ram1[i];
//        row[3] = Form1.ram3[i];
//        row[4] = Form1.ram2[i];
//        //row[5] = Form1.ram4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.gpu[i] != "" && Form1.gpu[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "显卡";
//        row[1] = Form1.gpu[i];
//        row[2] = Form1.gpu1[i];
//        row[3] = Form1.gpu3[i];
//        row[4] = Form1.gpu2[i];
//        //row[5] = Form1.gpu4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.lcd[i] != "" && Form1.lcd[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "显示器";
//        row[1] = Form1.lcd[i];
//        row[2] = Form1.lcd1[i];
//        row[3] = Form1.lcd3[i];
//        row[4] = Form1.lcd2[i];
//        //row[5] = Form1.lcd4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.ssd[i] != "" && Form1.ssd[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "固态硬盘";
//        row[1] = Form1.ssd[i];
//        row[2] = Form1.ssd1[i];
//        row[3] = Form1.ssd3[i];
//        row[4] = Form1.ssd2[i];
//        //row[5] = Form1.ssd4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//} for (int i = 1; i <= 499; i++)
//{
//    if (Form1.box[i] != "" && Form1.box[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "机箱";
//        row[1] = Form1.box[i];
//        row[2] = Form1.box1[i];
//        row[3] = Form1.box3[i];
//        row[4] = Form1.box2[i];
//        //row[5] = Form1.box4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.fan[i] != "" && Form1.fan[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "散热器";
//        row[1] = Form1.fan[i];
//        row[2] = Form1.fan1[i];
//        row[3] = Form1.fan3[i];
//        row[4] = Form1.fan2[i];
//        //row[5] = Form1.fan4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.power[i] != "" && Form1.power[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "电源";
//        row[1] = Form1.power[i];
//        row[2] = Form1.power1[i];
//        row[3] = Form1.power3[i];
//        row[4] = Form1.power2[i];
//        //row[5] = Form1.power4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.cdrom[i] != "" && Form1.cdrom[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "光驱";
//        row[1] = Form1.cdrom[i];
//        row[2] = Form1.cdrom1[i];
//        row[3] = Form1.cdrom3[i];
//        row[4] = Form1.cdrom2[i];
//        //row[5] = Form1.cdrom4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.kb[i] != "" && Form1.kb[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "键盘";
//        row[1] = Form1.kb[i];
//        row[2] = Form1.kb1[i];
//        row[3] = Form1.kb3[i];
//        row[4] = Form1.kb2[i];
//        //row[5] = Form1.kb4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.mou[i] != "" && Form1.mou[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "鼠标";
//        row[1] = Form1.mou[i];
//        row[2] = Form1.mou1[i];
//        row[3] = Form1.mou3[i];
//        row[4] = Form1.mou2[i];

//        MainDt.Rows.Add(row);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.hs[i] != "" && Form1.hs[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "耳机";
//        row[1] = Form1.hs[i];
//        row[2] = Form1.hs1[i];
//        row[3] = Form1.hs3[i];
//        row[4] = Form1.hs2[i];
//        //row[5] = Form1.hs4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.cam[i] != "" && Form1.cam[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "摄像头";
//        row[1] = Form1.cam[i];
//        row[2] = Form1.cam1[i];
//        row[3] = Form1.cam3[i];
//        row[4] = Form1.cam2[i];
//        //row[5] = Form1.cam4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}

//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.sp[i] != "" && Form1.sp[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "音响";
//        row[1] = Form1.sp[i];
//        row[2] = Form1.sp1[i];
//        row[3] = Form1.sp3[i];
//        row[4] = Form1.sp2[i];
//        //row[5] = Form1.sp4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
//for (int i = 1; i <= 499; i++)
//{
//    if (Form1.o[i] != "" && Form1.o[i] != null)
//    {
//        DataRow row = MainDt.NewRow();
//        row[0] = "其他";
//        row[1] = Form1.o[i];
//        row[2] = Form1.o1[i];
//        row[3] = Form1.o3[i];
//        row[4] = Form1.o2[i];
//        //row[5] = Form1.o4[i];

//        MainDt.Rows.Add(row);
//        //dataGridView1.Rows.Add("CPU", Form1.cpu[i], Form1.cpu1[i], Form1.cpu3[i], Form1.cpu2[i]);
//    }
//    else { break; }
//}
#endregion


//private int SelectRowsCount()
//{
//    int selrowcount = 0;
//    for (int i = 0; i < dataGridView1.SelectedCells.Count; i++) 
//    {
//        if (dataGridView1.Rows[dataGridView1.SelectedCells[i].RowIndex].Cells[0].Selected || dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Selected || dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Selected || dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Selected || dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Selected)
//        {
//            //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
//            selrowcount++;
//        }
//        else
//        {
//            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = false;

//        }

//    }
//}


#region CheckBoxamd_CheckedChangedOldCode
//ComboBoxcpu.Items.Clear();
//ComboBoxcpu.Items.Add("自动选择");
//ComboBoxcpu.SelectedIndex = 0;
//for (z = 1; z <= 499; z++)
//{

//    if (acpu[z] != "" && acpu1[z] != 0)
//    {
//        ComboBoxcpu.Items.Add(acpu[z] + CreateSpace(27 - System.Text.Encoding.Default.GetBytes(acpu[z]).Length) + "￥" + acpu1[z]);
//    }

//}
//ComboBoxcpu.Items.Clear();
//ComboBoxcpu.Items.Add("自动选择");
//ComboBoxcpu.SelectedIndex = 0;
//for (z = 1; z <= 499; z++)
//{

//    if (cpu[z] != "" && cpu1[z] != 0)
//    {
//        ComboBoxcpu.Items.Add(cpu[z] + CreateSpace(27 - System.Text.Encoding.Default.GetBytes(cpu[z]).Length) + "￥" + cpu1[z]);
//    }

//}
#endregion


//private void 启动时自动检查更新ToolStripMenuItem_Checked(object sender, EventArgs e)
//{

//    //if (启动时自动检查更新ToolStripMenuItem.Checked)
//    //{
//    //    //启动时自动检查更新ToolStripMenuItem.Checked = false;
//    //    WTRegedit("nevercheckupdate", "0");
//    //}

//    //if (!启动时自动检查更新ToolStripMenuItem.Checked)
//    //{
//    //    //启动时自动检查更新ToolStripMenuItem.Checked = true;
//    //    WTRegedit("nevercheckupdate", "1");
//    //}
//}

#region comboBoxsp_SelectedIndexChanged OldCode
//if (ComboBoxsp.SelectedIndex != 0)
//{
//    sp_choice = ComboBoxsp.SelectedIndex;
//    //sp[0] = sp[comboBoxsp.SelectedIndex];
//    //sp1[0] = sp1[comboBoxsp.SelectedIndex];
//}
//else
//{
//    if (fixmode) { c_sp(); }
//    else { sp_choice = 0; }
//    //if (sp_choice == 0) { sp[0] = " "; sp1[0] = 0; }
//    //else
//    //{


//    //    //sp[0] = sp[sp_choice];
//    //    //sp1[0] = sp1[sp_choice];
//    //}
//}
////if (spz.Checked) { sp1[0] = 0; }
//totalprice();
#endregion

//cbbArr.Add(ComboBoxcpu);
//cbbArr.Add(ComboBoxmb);
//cbbArr.Add(ComboBoxram);
//cbbArr.Add(ComboBoxhdd);
//cbbArr.Add(ComboBoxgpu);
//cbbArr.Add(ComboBoxlcd);
//cbbArr.Add(ComboBoxbox);
//cbbArr.Add(ComboBoxfan);
//cbbArr.Add(ComboBoxssd);
//cbbArr.Add(ComboBoxpower);
//cbbArr.Add(ComboBoxcdrom);
//cbbArr.Add(ComboBoxkb);
//cbbArr.Add(ComboBoxmou);
//cbbArr.Add(ComboBoxhs);
//cbbArr.Add(ComboBoxcam);
//cbbArr.Add(ComboBoxsp);
//cbbArr.Add(ComboBoxo);
//nameArr.Add(cpu);


//comboBoxHw.Add("机箱");
//comboBoxHw.Add("电源");
//comboBoxHw.Add("光驱");
//comboBoxHw.Add("键盘");
//comboBoxHw.Add("鼠标");
//comboBoxHw.Add("耳机");
//comboBoxHw.Add("摄像头");
//comboBoxHw.Add("音响");
//comboBoxHw.Add("内存");
//comboBoxHw.Add("硬盘");
//comboBoxHw.Add("固态硬盘");

//for (int i = this.dataGridView1.SelectedCells.Count; i > 0; i--)
//{

//    //listDel.Add ()
//    //dataGridView1.Rows.Remove(this.dataGridView1.SelectedRows[0]);
//    //int ID = Convert.ToInt32(dataGridView1.SelectedRows[i - 1].Cells[0].Value);
//    //MessageBox.Show(dataGridView1.SelectedCells[i - 1].RowIndex.ToString());
//    //MessageBox.Show(i.ToString());

//    //dataGridView1.Rows.RemoveAt(dataGridView1.); 

//    //使用获得的ID删除数据库的数据
//    //string SQL = "delete from UserInfo where UserId='" + ID.ToString() + "'";
//    //int s = Convert.ToInt32(cl.Execute(SQL)); //cl是操作类的一个对像，Execute()是类中的一个方法
//    //if (s != 0)
//    //{


//    //}
//}li


//dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[i - 1].RowIndex );
//MainDt.Rows.RemoveAt(showmain[dataGridView1.SelectedCells[i - 1].RowIndex]);




//CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
//cm.SuspendBinding(); //挂起数据绑定


//    for (int i = 0; i < dataGridView1.Rows.Count; i++)
//    {
//        for (int j = 0; j < checkedListBox1.Items.Count; j++)
//        {
//            if (!checkedListBox1.GetItemChecked(j))
//            {
//                if (dataGridView1.Rows[i].Cells[0].Value!=null&&dataGridView1.Rows[i].Cells[0].Value.ToString() == checkedListBox1.GetItemText(checkedListBox1.Items[j]))
//                {
//                    dataGridView1.Rows[i].Visible = false;
//                }
//            }
//            else
//            {
//                if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value.ToString() == checkedListBox1.GetItemText(checkedListBox1.Items[j]) && dataGridView1.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(searchstring))
//                {
//                    dataGridView1.Rows[i].Visible = true;
//                    visable_row_count++;
//                }

//            }
//        }



//    }
//cm.ResumeBinding();



//try
//{
//    int RowNumber = dataGridView1.CurrentCell.RowIndex;
//    dataGridView1.Rows.Insert(RowNumber);
//    dataGridView1.Rows[RowNumber].Cells[0].Value = dataGridView1.Rows[RowNumber + 1].Cells[0].Value;
//    dataGridView1.Rows[RowNumber].Cells[1].Value = " ";
//    dataGridView1.Rows[RowNumber].Cells[2].Value = 0;
//    dataGridView1.Rows[RowNumber].Cells[3].Value = 0;
//    dataGridView1.Rows[RowNumber].Cells[4].Value = dataGridView1.Rows[RowNumber + 1].Cells[4].Value;
//}
//catch (Exception ex) { MessageBox.Show(ex.ToString()); }



#region OldCode
//MessageBox.Show("第三方士大夫");

//DataTable table = new DataTable();
//table.Columns.Add("name");
//table.Columns.Add("sex");
//table.Columns.Add("age");
//for (int i = 0; i < 10; i++)
//{
//    DataRow row = table.NewRow();
//    row[0] = "1";
//    row[1] = "2";
//    row[2] = "3";
//    table.Rows.Add(row);
//}
//dataGridView1.DataSource = table;

//DataGridView  aaa;
//aaa = dataGridView1;
//dataGridView1 = aaa;


//readconfig();
//if (!System.IO.File.Exists(Application.StartupPath + "\\auth.key")) { MessageBox.Show("请联系作者购买正版软件！\nQQ:1443112740"); Application.Exit(); }
//StreamReader auth1 = new StreamReader(Application.StartupPath + "\\auth.key");
//string sLine1 = "";

//while (sLine1 != null)
//{
//    sLine1 = auth1.ReadLine();
//    try
//    {
//        if (sLine1.Contains("[EMAIL]"))
//        {
//            if (sLine1.Substring(sLine1.IndexOf("]") + 1) == "Trial")
//            {
//               
//            }

//            label1 .Text += sLine1.Substring(sLine1.IndexOf("]") + 1);
//        }
//    }
//    catch { }

//}
//auth1.Close();
#endregion
#region UnUsedCode
//if (IniFile.ReadVal("Main", "Print", Form1.settingsini) == "0")
//{
//    this.PrintMode = ModeEnum.Doc;
//}
//else
//{
//    this.PrintMode = ModeEnum.Txt;
////}
//if (IniFile.ReadVal("Main", "Save", Form1.settingsini) == "0")
//{
//    this.SaveMode = ModeEnum.Doc;
//}
//else
//{
//    this.SaveMode = ModeEnum.Txt;
//}
//string costprice = IniFile.ReadVal("Main", "CostPrice", Form1.settingsini);
//if (string.IsNullOrEmpty(costprice) || costprice == "0") this.CostPrice = CostPriceEnum.不显示;
//else if(costprice =="1"){this .CostPrice =CostPriceEnum .成本 ;}
//else if (costprice == "2") { this.CostPrice = CostPriceEnum.利润; }
//else { this.CostPrice = CostPriceEnum.利润率; }
#endregion