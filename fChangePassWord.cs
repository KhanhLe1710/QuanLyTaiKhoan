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
            if ( Regex.IsMatch(txtoldpass.Text, "^[a-zA-Z0-9\x20]+$"))
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
            string newpass= txtnewpass.Text;
            string newpass2 = txtnewpass2.Text;
            DataProvider d = new DataProvider();
            if (oldpass != "" && newpass != "" && newpass2!= "" )
            {
                d.updatepassword(oldpass,newpass,newpass2);

            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
        }
    }
}
