namespace 攒机助手专业版
{
    partial class DataBaseViewer
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuanjiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuanjiBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 292);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Controls.Add(this.buttonsave, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxsearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 256);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(825, 32);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonsave
            // 
            this.buttonsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsave.Location = new System.Drawing.Point(711, 4);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(111, 24);
            this.buttonsave.TabIndex = 1;
            this.buttonsave.Text = "保存";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Visible = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(567, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "导出Excel文档";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(61, 4);
            this.textBoxsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(449, 23);
            this.textBoxsearch.TabIndex = 4;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(52, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "搜索";
            // 
            // DataBaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::攒机助手专业版.Properties.Resources.ico;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataBaseViewer";
            this.Text = "数据库简易查看器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.databaseview_FormClosing);
            this.Load += new System.EventHandler(this.databaseview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cuanjiBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource cuanjiBindingSource;
        //private dataDataSetTableAdapters.cuanjiTableAdapter cuanjiTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 程序版本DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 客户名称DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 总价DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cPUDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cPU价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 主板DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 主板价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 内存DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 内存价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 硬盘DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 硬盘价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sSDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sSD价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 显卡DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 显卡价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 显示器DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 显示器价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 机箱DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 机箱价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 散热器DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 散热器价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 电源DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 电源价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 光驱DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 光驱价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 键鼠DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 键鼠价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 其它DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 其它价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 耳机DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 耳机价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 摄像头DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 摄像头价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 音响DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn 音响价格DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label label1;
    }
}