namespace 攒机助手专业版
{
    partial class Profit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsum = new System.Windows.Forms.TextBox();
            this.textBoxcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxprofit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcostmargins = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "总售价";
            // 
            // textBoxsum
            // 
            this.textBoxsum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxsum.Location = new System.Drawing.Point(110, 13);
            this.textBoxsum.Name = "textBoxsum";
            this.textBoxsum.ReadOnly = true;
            this.textBoxsum.Size = new System.Drawing.Size(100, 23);
            this.textBoxsum.TabIndex = 1;
            // 
            // textBoxcost
            // 
            this.textBoxcost.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxcost.Location = new System.Drawing.Point(110, 46);
            this.textBoxcost.Name = "textBoxcost";
            this.textBoxcost.ReadOnly = true;
            this.textBoxcost.Size = new System.Drawing.Size(100, 23);
            this.textBoxcost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "总成本";
            // 
            // textBoxprofit
            // 
            this.textBoxprofit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxprofit.Location = new System.Drawing.Point(110, 80);
            this.textBoxprofit.Name = "textBoxprofit";
            this.textBoxprofit.ReadOnly = true;
            this.textBoxprofit.Size = new System.Drawing.Size(100, 23);
            this.textBoxprofit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "总利润";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "成本利润率";
            // 
            // textBoxcostmargins
            // 
            this.textBoxcostmargins.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxcostmargins.Location = new System.Drawing.Point(110, 114);
            this.textBoxcostmargins.Name = "textBoxcostmargins";
            this.textBoxcostmargins.ReadOnly = true;
            this.textBoxcostmargins.Size = new System.Drawing.Size(100, 23);
            this.textBoxcostmargins.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(135, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxcostmargins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxprofit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxcost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxsum);
            this.Controls.Add(this.label1);
            this.Icon = global::攒机助手专业版.Properties.Resources.ico;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profit";
            this.Text = "利润显示";
            this.Load += new System.EventHandler(this.Profit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsum;
        private System.Windows.Forms.TextBox textBoxcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxprofit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcostmargins;
        private System.Windows.Forms.Button button1;
    }
}