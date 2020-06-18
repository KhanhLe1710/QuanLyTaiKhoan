using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_tai_khoan
{
    public partial class fChangePassWord : Form
    {
        public fChangePassWord()
        {
            InitializeComponent();
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
            txtoldpass.MaxLength = 35;
            if (Regex.IsMatch(txtoldpass.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(this.txtoldpass, "Vui lòng nhập mật khẩu!");

            }
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {

            txtnewpass.MaxLength = 35;
            if (Regex.IsMatch(txtnewpass.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtnewpass, "Vui lòng nhập mật khẩu!");

            }
        }

        private void txtnewpass2_TextChanged(object sender, EventArgs e)
        {

            txtnewpass2.MaxLength = 35;
            if (Regex.IsMatch(txtnewpass2.Text, "^[a-zA-Z0-9\x20]+$"))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(this.txtnewpass2, "Vui lòng nhập mật khẩu!");

            }

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            string oldpass = txtoldpass.Text;
            string newpass = txtnewpass.Text;
            string newpass2 = txtnewpass2.Text;
            DataProvider d = new DataProvider();

           
            if (oldpass != "1234")
            {
                if (newpass == "")
                {
                    MessageBox.Show("Chưa nhập thông tin. Vui lòng thử lại..");
                }
                else
                {
                    if (newpass.ToString() != newpass2.ToString())
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
