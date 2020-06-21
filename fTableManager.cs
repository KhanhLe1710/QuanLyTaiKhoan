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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }
        private void đổiMậtKhẩuPINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePIN f = new fChangePIN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn Thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            txt1.Text = "ABC";
            txt2.Text = "01-01-19xx";
            txt3.Text = "371 Nguyễn Kiệm, Phường 3, Q. Gò Vấp, Tp.HCM";
            txt4.Text = "Quản lý";
            txt5.Text = "Quản trị viên";
        }
        private void đổiTênTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fchangname f = new fchangname();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
