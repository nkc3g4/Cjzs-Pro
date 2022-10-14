namespace 攒机助手专业版
{
    partial class ChangePW
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
            this.textBoxold = new System.Windows.Forms.TextBox();
            this.textBoxnew = new System.Windows.Forms.TextBox();
            this.textBoxrenew = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxold
            // 
            this.textBoxold.Location = new System.Drawing.Point(124, 11);
            this.textBoxold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxold.Name = "textBoxold";
            this.textBoxold.Size = new System.Drawing.Size(116, 23);
            this.textBoxold.TabIndex = 0;
            this.textBoxold.UseSystemPasswordChar = true;
            // 
            // textBoxnew
            // 
            this.textBoxnew.Location = new System.Drawing.Point(124, 54);
            this.textBoxnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxnew.Name = "textBoxnew";
            this.textBoxnew.Size = new System.Drawing.Size(116, 23);
            this.textBoxnew.TabIndex = 1;
            this.textBoxnew.UseSystemPasswordChar = true;
            // 
            // textBoxrenew
            // 
            this.textBoxrenew.Location = new System.Drawing.Point(124, 96);
            this.textBoxrenew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxrenew.Name = "textBoxrenew";
            this.textBoxrenew.Size = new System.Drawing.Size(116, 23);
            this.textBoxrenew.TabIndex = 2;
            this.textBoxrenew.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入原密码\r\n(默认为空)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "再次输入新密码";
            // 
            // changepw
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxrenew);
            this.Controls.Add(this.textBoxnew);
            this.Controls.Add(this.textBoxold);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::攒机助手专业版.Properties.Resources.ico;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changepw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.changepw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxold;
        private System.Windows.Forms.TextBox textBoxnew;
        private System.Windows.Forms.TextBox textBoxrenew;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}