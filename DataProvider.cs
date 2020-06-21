using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_tai_khoan
{
    public class DataProvider
    {
        public void login(string id, string pass)
        {
            fTableManager f = new fTableManager();
            if (id == "admin" && pass == "1234")
                f.ShowDialog();
            else
               MessageBox.Show("Mật khẩu hoặc tài khoản không đúng.Mời nhập lại");
        }

       

    }
}
