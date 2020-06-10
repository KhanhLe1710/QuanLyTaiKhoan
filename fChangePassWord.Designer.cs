namespace Quan_ly_tai_khoan
{
    partial class fChangePassWord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcancel = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.txtnewpass2 = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.lbnewpass2 = new System.Windows.Forms.Label();
            this.lbnewpass = new System.Windows.Forms.Label();
            this.lboldpass = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btcancel);
            this.panel1.Controls.Add(this.btupdate);
            this.panel1.Controls.Add(this.txtnewpass2);
            this.panel1.Controls.Add(this.txtnewpass);
            this.panel1.Controls.Add(this.txtoldpass);
            this.panel1.Controls.Add(this.lbnewpass2);
            this.panel1.Controls.Add(this.lbnewpass);
            this.panel1.Controls.Add(this.lboldpass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 316);
            this.panel1.TabIndex = 0;
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(392, 245);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(108, 52);
            this.btcancel.TabIndex = 7;
            this.btcancel.Text = "Huỷ";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // btupdate
            // 
            this.btupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btupdate.Location = new System.Drawing.Point(153, 245);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(108, 52);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "Cập Nhật";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // txtnewpass2
            // 
            this.txtnewpass2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass2.Location = new System.Drawing.Point(277, 171);
            this.txtnewpass2.Name = "txtnewpass2";
            this.txtnewpass2.Size = new System.Drawing.Size(302, 30);
            this.txtnewpass2.TabIndex = 5;
            this.txtnewpass2.TextChanged += new System.EventHandler(this.txtnewpass2_TextChanged);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(277, 108);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(302, 30);
            this.txtnewpass.TabIndex = 4;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // txtoldpass
            // 
            this.txtoldpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpass.Location = new System.Drawing.Point(277, 19);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.PasswordChar = '*';
            this.txtoldpass.Size = new System.Drawing.Size(302, 30);
            this.txtoldpass.TabIndex = 3;
            this.txtoldpass.TextChanged += new System.EventHandler(this.txtoldpass_TextChanged);
            // 
            // lbnewpass2
            // 
            this.lbnewpass2.AutoSize = true;
            this.lbnewpass2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewpass2.Location = new System.Drawing.Point(32, 171);
            this.lbnewpass2.Name = "lbnewpass2";
            this.lbnewpass2.Size = new System.Drawing.Size(210, 22);
            this.lbnewpass2.TabIndex = 2;
            this.lbnewpass2.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // lbnewpass
            // 
            this.lbnewpass.AutoSize = true;
            this.lbnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewpass.Location = new System.Drawing.Point(32, 108);
            this.lbnewpass.Name = "lbnewpass";
            this.lbnewpass.Size = new System.Drawing.Size(132, 22);
            this.lbnewpass.TabIndex = 1;
            this.lbnewpass.Text = "Mật Khẩu Mới:";
            // 
            // lboldpass
            // 
            this.lboldpass.AutoSize = true;
            this.lboldpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboldpass.Location = new System.Drawing.Point(32, 27);
            this.lboldpass.Name = "lboldpass";
            this.lboldpass.Size = new System.Drawing.Size(120, 22);
            this.lboldpass.TabIndex = 0;
            this.lboldpass.Text = "Mật Khẩu Cũ:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeftChanged += new System.EventHandler(this.txtoldpass_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeftChanged += new System.EventHandler(this.txtnewpass2_TextChanged);
            // 
            // fChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(657, 336);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChangePassWord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.TextBox txtnewpass2;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.Label lbnewpass2;
        private System.Windows.Forms.Label lbnewpass;
        private System.Windows.Forms.Label lboldpass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}