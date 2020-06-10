using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_tai_khoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = txtnamelogin.Text;
            string pass = txtpassword.Text;
            DataProvider d = new DataProvider();
            if (username != "" && pass != "")
                d.login(username, pass);
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtnamelogin.Text = "admin";
            txtpassword.Text = "1234";
        }
    }
}
