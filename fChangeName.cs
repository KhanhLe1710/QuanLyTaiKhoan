﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

namespace Quan_ly_tai_khoan
{
    public partial class fchangname : Form
    {
        public fchangname()
        {
            InitializeComponent();
        }

        private void fchangname_Load(object sender, EventArgs e) 
        {
            txtoldname.Text = "admin";
        }


        private void txtoldname_TextChanged(object sender, EventArgs e) 
        {
            txtoldname.MaxLength = 35;
            if (Regex.IsMatch(txtoldname.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(this.txtoldname, "Vui lòng nhập tên!");
            }
        }

        private void txtnewname_TextChanged(object sender, EventArgs e) 
        {
            txtnewname.MaxLength = 35;
            if (Regex.IsMatch(txtnewname.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtnewname, "Vui lòng nhập tên!");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e) 
        {
            txtpassword.MaxLength = 35;
            if (Regex.IsMatch(txtpassword.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.txtpassword, "Vui lòng nhập mật khẩu!");
            }
        }

        private void txtpassword1_TextChanged(object sender, EventArgs e) 
        {
            txtpassword1.MaxLength = 35;
            if (Regex.IsMatch(txtpassword1.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.txtpassword1, "Vui lòng nhập lại mật khẩu!");
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string oldname = txtoldname.Text;
            string newname = txtnewname.Text;
            string password = txtpassword.Text;
            string password1 = txtpassword1.Text;

            if (oldname != "") 
            {
                if (newname == "") 
                { 
                    MessageBox.Show("Chưa nhập thông tin. Vui lòng thử lại..");
                }
                else 
                {
                    if (password.ToString() != password1.ToString()) 
                    {
                        MessageBox.Show("Mật khẩu chưa khớp. Thử lại?", "Thông báo", MessageBoxButtons.RetryCancel);
                    }
                    else 
                    {
                        MessageBox.Show("Cập nhật thành công.");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại.");
            }
        }

    }
}
