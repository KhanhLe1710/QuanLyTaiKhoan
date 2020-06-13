namespace Quan_ly_tai_khoan
{
    partial class fChangePIN
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
            this.btcancel = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.txtnewPIN2 = new System.Windows.Forms.TextBox();
            this.txtoldPIN = new System.Windows.Forms.TextBox();
            this.lbnewPIN2 = new System.Windows.Forms.Label();
            this.lbnewPIN = new System.Windows.Forms.Label();
            this.lboldPIN = new System.Windows.Forms.Label();
            this.txtnewPIN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtnewPIN);
            this.panel1.Controls.Add(this.btcancel);
            this.panel1.Controls.Add(this.btupdate);
            this.panel1.Controls.Add(this.txtnewPIN2);
            this.panel1.Controls.Add(this.txtoldPIN);
            this.panel1.Controls.Add(this.lbnewPIN2);
            this.panel1.Controls.Add(this.lbnewPIN);
            this.panel1.Controls.Add(this.lboldPIN);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 336);
            this.panel1.TabIndex = 0;
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(308, 267);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(139, 55);
            this.btcancel.TabIndex = 7;
            this.btcancel.Text = "Huỷ";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.Location = new System.Drawing.Point(98, 267);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(139, 55);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "Cập Nhật";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // txtnewPIN2
            // 
            this.txtnewPIN2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewPIN2.Location = new System.Drawing.Point(283, 180);
            this.txtnewPIN2.Name = "txtnewPIN2";
            this.txtnewPIN2.Size = new System.Drawing.Size(215, 30);
            this.txtnewPIN2.TabIndex = 5;
            this.txtnewPIN2.TextChanged += new System.EventHandler(this.txtnewPIN2_TextChanged);
            // 
            // txtoldPIN
            // 
            this.txtoldPIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldPIN.Location = new System.Drawing.Point(283, 32);
            this.txtoldPIN.Name = "txtoldPIN";
            this.txtoldPIN.PasswordChar = '*';
            this.txtoldPIN.Size = new System.Drawing.Size(215, 30);
            this.txtoldPIN.TabIndex = 3;
            this.txtoldPIN.TextChanged += new System.EventHandler(this.txtoldPIN_TextChanged);
            // 
            // lbnewPIN2
            // 
            this.lbnewPIN2.AutoSize = true;
            this.lbnewPIN2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewPIN2.Location = new System.Drawing.Point(20, 180);
            this.lbnewPIN2.Name = "lbnewPIN2";
            this.lbnewPIN2.Size = new System.Drawing.Size(246, 22);
            this.lbnewPIN2.TabIndex = 2;
            this.lbnewPIN2.Text = "Nhập Lại Mật Khẩu PIN Mới:";
            // 
            // lbnewPIN
            // 
            this.lbnewPIN.AutoSize = true;
            this.lbnewPIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewPIN.Location = new System.Drawing.Point(20, 119);
            this.lbnewPIN.Name = "lbnewPIN";
            this.lbnewPIN.Size = new System.Drawing.Size(168, 22);
            this.lbnewPIN.TabIndex = 1;
            this.lbnewPIN.Text = "Mật Khẩu PIN Mới:";
            // 
            // lboldPIN
            // 
            this.lboldPIN.AutoSize = true;
            this.lboldPIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboldPIN.Location = new System.Drawing.Point(20, 35);
            this.lboldPIN.Name = "lboldPIN";
            this.lboldPIN.Size = new System.Drawing.Size(156, 22);
            this.lboldPIN.TabIndex = 0;
            this.lboldPIN.Text = "Mật Khẩu PIN Cũ:";
            // 
            // txtnewPIN
            // 
            this.txtnewPIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewPIN.Location = new System.Drawing.Point(283, 119);
            this.txtnewPIN.Name = "txtnewPIN";
            this.txtnewPIN.Size = new System.Drawing.Size(215, 30);
            this.txtnewPIN.TabIndex = 8;
            this.txtnewPIN.TextChanged += new System.EventHandler(this.txtnewPIN_TextChanged_1);
            // 
            // fChangePIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu PIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox txtnewPIN2;
        private System.Windows.Forms.Label lbnewPIN2;
        private System.Windows.Forms.Label lbnewPIN;
        private System.Windows.Forms.Label lboldPIN;
        private System.Windows.Forms.TextBox txtoldPIN;
        private System.Windows.Forms.TextBox txtnewPIN;
    }
}