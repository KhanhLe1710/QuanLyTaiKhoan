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
    public partial class fChangePIN : Form
    {
        public fChangePIN()
        {
            InitializeComponent();
        }
        private void txtoldPIN_TextChanged(object sender, EventArgs e)
        {
            txtoldPIN.MaxLength = 4;
            bool n;
            
        }
        private void txtnewPIN_TextChanged_1(object sender, EventArgs e)
        {
            txtnewPIN.MaxLength = 4;
            bool n;
            
        }
        private void txtnewPIN2_TextChanged(object sender, EventArgs e)
        {
            txtnewPIN2.MaxLength = 4;
            bool n;
            
        }
        public bool doimapin(int oldPIN ,int newPIN)
        {
            if (newPIN != oldPIN)
            {
                return true;
            }

            return false;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtnewPIN.TextLength != 4 || txtnewPIN2.TextLength != 4 || txtoldPIN.TextLength != 4 && txtoldPIN.Text != "1234")
                MessageBox.Show("Chưa đúng yêu cầu. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.RetryCancel);
            else
            {
                if (txtnewPIN2.Text != txtnewPIN.Text)
                    MessageBox.Show("Mật khẩu không trùng khớp");
                else
                {
                    bool ketqua;
                    ketqua = doimapin(1234, 1235);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Thay đổi mật khẩu PIN thành công");
                    }
                    else
                        MessageBox.Show("Không thay đổi được mật khẩu PIN");
                }
            }
        }
    }
}
