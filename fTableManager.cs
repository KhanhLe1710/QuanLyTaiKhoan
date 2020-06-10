﻿using System;
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

        private void đổiTênTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fchangname f = new fchangname();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void đổiMậtKhẩuPINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePIN f = new fChangePIN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassWord f = new fChangePassWord();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn Thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }
    }
}