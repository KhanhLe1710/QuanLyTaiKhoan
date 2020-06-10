namespace Quan_ly_tai_khoan
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bthuy = new System.Windows.Forms.Button();
            this.btlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtnamelogin = new System.Windows.Forms.TextBox();
            this.lbnamelogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 245);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bthuy);
            this.panel4.Controls.Add(this.btlogin);
            this.panel4.Location = new System.Drawing.Point(7, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 82);
            this.panel4.TabIndex = 1;
            // 
            // bthuy
            // 
            this.bthuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bthuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Location = new System.Drawing.Point(505, 14);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(105, 45);
            this.bthuy.TabIndex = 1;
            this.bthuy.Text = "Huỷ";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(343, 14);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(147, 45);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "Đăng Nhập";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtpassword);
            this.panel3.Controls.Add(this.lbpassword);
            this.panel3.Location = new System.Drawing.Point(7, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 84);
            this.panel3.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(226, 23);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(387, 34);
            this.txtpassword.TabIndex = 2;
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Location = new System.Drawing.Point(31, 23);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(126, 26);
            this.lbpassword.TabIndex = 1;
            this.lbpassword.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtnamelogin);
            this.panel2.Controls.Add(this.lbnamelogin);
            this.panel2.Location = new System.Drawing.Point(7, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 88);
            this.panel2.TabIndex = 0;
            // 
            // txtnamelogin
            // 
            this.txtnamelogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamelogin.Location = new System.Drawing.Point(223, 33);
            this.txtnamelogin.Name = "txtnamelogin";
            this.txtnamelogin.Size = new System.Drawing.Size(387, 34);
            this.txtnamelogin.TabIndex = 1;
            // 
            // lbnamelogin
            // 
            this.lbnamelogin.AutoSize = true;
            this.lbnamelogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnamelogin.Location = new System.Drawing.Point(28, 36);
            this.lbnamelogin.Name = "lbnamelogin";
            this.lbnamelogin.Size = new System.Drawing.Size(180, 26);
            this.lbnamelogin.TabIndex = 0;
            this.lbnamelogin.Text = "Tên Đăng Nhập:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bthuy;
            this.ClientSize = new System.Drawing.Size(657, 264);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN KHÁCH HÀNG CÁ NHÂN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnamelogin;
        private System.Windows.Forms.Label lbnamelogin;
    }
}

