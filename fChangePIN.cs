using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_tai_khoan
{
    public partial class fChangePIN : Form
    {
        public fChangePIN()
        {
            InitializeComponent();
        }

        private void txtoldPIN_TextChanged(object sender, EventArgs e)
        {
            txtoldPIN.MaxLength = 4;
            long n;
            if (long.TryParse(txtoldPIN.Text, out n))
            {
                lb1.ForeColor = Color.Green;
                lb1.Text = "Nhập mật khẩu cũ thành công!";
            }
            else
            {
                lb1.ForeColor = Color.Red;
                lb1.Text = "Nhập sai. Yêu cầu nhập số khác!";
            }
        }

        

        private void txtnewPIN2_TextChanged(object sender, EventArgs e)
        {
            txtnewPIN2.MaxLength = 4;
            long n;
            if (long.TryParse(txtnewPIN2.Text, out n))
            {
                lb3.ForeColor = Color.Green;
                lb3.Text = "Nhập mật khẩu mới thành công!";
            }
            else
            {
                lb3.ForeColor = Color.Red;
                lb3.Text = "Nhập sai. Yêu cầu nhập lại số!";
            }

        }

        private void btupdate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Đã lưu mã PIN mới.");
            this.Close();
        }

        private void txtnewPIN_TextChanged(object sender, EventArgs e)
        {
            txtnewPIN.MaxLength = 4;
            long n;
            if (long.TryParse(txtnewPIN.Text, out n))
            {
                lb2.ForeColor = Color.Green;
                lb2.Text = "Nhập mật khẩu mới thành công!";
            }
            else
            {
                lb2.ForeColor = Color.Red;
                lb2.Text = "Nhập sai. Yêu cầu nhập lại số!";
            }
        }
    }
}
