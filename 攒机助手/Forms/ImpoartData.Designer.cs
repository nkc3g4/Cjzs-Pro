namespace 攒机助手专业版
{
    partial class ImpoartData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonfree = new System.Windows.Forms.RadioButton();
            this.radioButtonexcel = new System.Windows.Forms.RadioButton();
            this.radioButtonpro = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxqa = new System.Windows.Forms.TextBox();
            this.textBoxbprice = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxsprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxautocorrect = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonupdateprice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanelOutside = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelmiddle = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonfreenew = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelbottom = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanelOutside.SuspendLayout();
            this.tableLayoutPanelmiddle.SuspendLayout();
            this.tableLayoutPanelbottom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 286);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(665, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonfree
            // 
            this.radioButtonfree.AutoSize = true;
            this.radioButtonfree.Location = new System.Drawing.Point(173, 4);
            this.radioButtonfree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonfree.Name = "radioButtonfree";
            this.radioButtonfree.Size = new System.Drawing.Size(146, 21);
            this.radioButtonfree.TabIndex = 3;
            this.radioButtonfree.Text = "免费版配置文件（旧）";
            this.radioButtonfree.UseVisualStyleBackColor = true;
            this.radioButtonfree.CheckedChanged += new System.EventHandler(this.radioButtonfree_CheckedChanged);
            // 
            // radioButtonexcel
            // 
            this.radioButtonexcel.AutoSize = true;
            this.radioButtonexcel.Checked = true;
            this.radioButtonexcel.ForeColor = System.Drawing.Color.Red;
            this.radioButtonexcel.Location = new System.Drawing.Point(88, 4);
            this.radioButtonexcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonexcel.Name = "radioButtonexcel";
            this.radioButtonexcel.Size = new System.Drawing.Size(55, 21);
            this.radioButtonexcel.TabIndex = 4;
            this.radioButtonexcel.TabStop = true;
            this.radioButtonexcel.Text = "Excel";
            this.radioButtonexcel.UseVisualStyleBackColor = true;
            this.radioButtonexcel.CheckedChanged += new System.EventHandler(this.radioButtonexcel_CheckedChanged);
            // 
            // radioButtonpro
            // 
            this.radioButtonpro.AutoSize = true;
            this.radioButtonpro.Location = new System.Drawing.Point(338, 4);
            this.radioButtonpro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonpro.Name = "radioButtonpro";
            this.radioButtonpro.Size = new System.Drawing.Size(159, 21);
            this.radioButtonpro.TabIndex = 5;
            this.radioButtonpro.Text = "专业版数据库(data.mdb)";
            this.radioButtonpro.UseVisualStyleBackColor = true;
            this.radioButtonpro.CheckedChanged += new System.EventHandler(this.radioButtonpro_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CPU",
            "AMD CPU",
            "主板",
            "内存",
            "硬盘",
            "固态硬盘",
            "显卡",
            "显示器",
            "机箱",
            "散热器",
            "电源",
            "光驱",
            "键盘",
            "鼠标",
            "音响",
            "摄像头",
            "耳机",
            "其他"});
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // textBoxqa
            // 
            this.textBoxqa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxqa.Location = new System.Drawing.Point(303, 44);
            this.textBoxqa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxqa.Multiline = true;
            this.textBoxqa.Name = "textBoxqa";
            this.textBoxqa.Size = new System.Drawing.Size(97, 238);
            this.textBoxqa.TabIndex = 7;
            this.textBoxqa.TextChanged += new System.EventHandler(this.textBoxqa_TextChanged);
            this.textBoxqa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxqa_KeyDown);
            // 
            // textBoxbprice
            // 
            this.textBoxbprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxbprice.Location = new System.Drawing.Point(203, 44);
            this.textBoxbprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxbprice.Multiline = true;
            this.textBoxbprice.Name = "textBoxbprice";
            this.textBoxbprice.Size = new System.Drawing.Size(94, 238);
            this.textBoxbprice.TabIndex = 8;
            this.textBoxbprice.TextChanged += new System.EventHandler(this.textBoxbprice_TextChanged);
            this.textBoxbprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxbprice_KeyDown);
            // 
            // textBoxname
            // 
            this.textBoxname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxname.Location = new System.Drawing.Point(3, 44);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(94, 238);
            this.textBoxname.TabIndex = 9;
            this.textBoxname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxname_KeyDown);
            // 
            // textBoxsprice
            // 
            this.textBoxsprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxsprice.Location = new System.Drawing.Point(103, 44);
            this.textBoxsprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxsprice.Multiline = true;
            this.textBoxsprice.Name = "textBoxsprice";
            this.textBoxsprice.Size = new System.Drawing.Size(94, 238);
            this.textBoxsprice.TabIndex = 10;
            this.textBoxsprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxsprice_KeyDown);
            this.textBoxsprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsprice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "质保(可选)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(203, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "进价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "售价(可选)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(409, 310);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分项导入（每行一一对应）";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxqa, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxbprice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxsprice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 286);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxautocorrect);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.radioButtonupdateprice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(831, 71);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxautocorrect
            // 
            this.checkBoxautocorrect.AutoSize = true;
            this.checkBoxautocorrect.Checked = true;
            this.checkBoxautocorrect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxautocorrect.Location = new System.Drawing.Point(392, 42);
            this.checkBoxautocorrect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxautocorrect.Name = "checkBoxautocorrect";
            this.checkBoxautocorrect.Size = new System.Drawing.Size(75, 21);
            this.checkBoxautocorrect.TabIndex = 23;
            this.checkBoxautocorrect.Text = "自动纠错";
            this.checkBoxautocorrect.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(302, 42);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "保留重复";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "重复项目：";
            // 
            // radioButtonupdateprice
            // 
            this.radioButtonupdateprice.AutoSize = true;
            this.radioButtonupdateprice.Checked = true;
            this.radioButtonupdateprice.Location = new System.Drawing.Point(128, 42);
            this.radioButtonupdateprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonupdateprice.Name = "radioButtonupdateprice";
            this.radioButtonupdateprice.Size = new System.Drawing.Size(146, 21);
            this.radioButtonupdateprice.TabIndex = 19;
            this.radioButtonupdateprice.TabStop = true;
            this.radioButtonupdateprice.Text = "更新售价、进价、质保";
            this.radioButtonupdateprice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(384, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "查看在线帮助";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "本功能可以导入Excel报价单和其他攒机助手配置文件。";
            // 
            // tableLayoutPanelOutside
            // 
            this.tableLayoutPanelOutside.ColumnCount = 1;
            this.tableLayoutPanelOutside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOutside.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanelOutside.Controls.Add(this.tableLayoutPanelmiddle, 0, 1);
            this.tableLayoutPanelOutside.Controls.Add(this.tableLayoutPanelbottom, 0, 2);
            this.tableLayoutPanelOutside.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanelOutside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOutside.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOutside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelOutside.Name = "tableLayoutPanelOutside";
            this.tableLayoutPanelOutside.RowCount = 4;
            this.tableLayoutPanelOutside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanelOutside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelOutside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOutside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelOutside.Size = new System.Drawing.Size(837, 500);
            this.tableLayoutPanelOutside.TabIndex = 18;
            // 
            // tableLayoutPanelmiddle
            // 
            this.tableLayoutPanelmiddle.ColumnCount = 6;
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.24113F));
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.24113F));
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87984F));
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87984F));
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87984F));
            this.tableLayoutPanelmiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87822F));
            this.tableLayoutPanelmiddle.Controls.Add(this.radioButtonfree, 2, 0);
            this.tableLayoutPanelmiddle.Controls.Add(this.radioButtonpro, 3, 0);
            this.tableLayoutPanelmiddle.Controls.Add(this.radioButtonfreenew, 4, 0);
            this.tableLayoutPanelmiddle.Controls.Add(this.radioButton1, 5, 0);
            this.tableLayoutPanelmiddle.Controls.Add(this.radioButtonexcel, 1, 0);
            this.tableLayoutPanelmiddle.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanelmiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelmiddle.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanelmiddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelmiddle.Name = "tableLayoutPanelmiddle";
            this.tableLayoutPanelmiddle.RowCount = 1;
            this.tableLayoutPanelmiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelmiddle.Size = new System.Drawing.Size(831, 47);
            this.tableLayoutPanelmiddle.TabIndex = 18;
            // 
            // radioButtonfreenew
            // 
            this.radioButtonfreenew.AutoSize = true;
            this.radioButtonfreenew.Location = new System.Drawing.Point(503, 4);
            this.radioButtonfreenew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonfreenew.Name = "radioButtonfreenew";
            this.radioButtonfreenew.Size = new System.Drawing.Size(146, 21);
            this.radioButtonfreenew.TabIndex = 7;
            this.radioButtonfreenew.Text = "免费版配置文件（新）";
            this.radioButtonfreenew.UseVisualStyleBackColor = true;
            this.radioButtonfreenew.CheckedChanged += new System.EventHandler(this.radioButtonfreenew_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(668, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 41);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "中关村在线数据\r\n一行一个网址";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelbottom
            // 
            this.tableLayoutPanelbottom.ColumnCount = 2;
            this.tableLayoutPanelbottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbottom.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanelbottom.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanelbottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelbottom.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanelbottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelbottom.Name = "tableLayoutPanelbottom";
            this.tableLayoutPanelbottom.RowCount = 1;
            this.tableLayoutPanelbottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelbottom.Size = new System.Drawing.Size(831, 318);
            this.tableLayoutPanelbottom.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(418, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(410, 310);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "整体导入（Excel数据只需包含名称和价格）";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "config.ini|config.ini|所有文件|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "data.mdb|config.ini|所有文件|*.*";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.04453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95547F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 463);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(831, 34);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // ImpoartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 500);
            this.Controls.Add(this.tableLayoutPanelOutside);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::攒机助手专业版.Properties.Resources.ico;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImpoartData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "攒机助手数据导入";
            this.Load += new System.EventHandler(this.impoart_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanelOutside.ResumeLayout(false);
            this.tableLayoutPanelmiddle.ResumeLayout(false);
            this.tableLayoutPanelmiddle.PerformLayout();
            this.tableLayoutPanelbottom.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonfree;
        private System.Windows.Forms.RadioButton radioButtonexcel;
        private System.Windows.Forms.RadioButton radioButtonpro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxqa;
        private System.Windows.Forms.TextBox textBoxbprice;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxsprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOutside;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelmiddle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelbottom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonfreenew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonupdateprice;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxautocorrect;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}