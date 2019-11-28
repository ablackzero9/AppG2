using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmDangNhap : Form
    {
        string pathUserDataFile;
        public frmDangNhap()
        {
            InitializeComponent();

            pathUserDataFile = Application.StartupPath + @"\Data\student.txt";

            var user = LoginService.GetUser(pathUserDataFile);

            var listUserNoSort = LoginService.GetUser(pathUserDataFile);
            var listUser = listUserNoSort.OrderBy(x => x.Account).ToList();
            if (listUser == null)
                throw new Exception("Khong co tai khoan nao");
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*var newLoginListNoSort = LoginService.GetUser(pathUserDataFile);
            List<Login> newLoginList = newLoginListNoSort.OrderBy(x => x.Account).ToList();
            if(String.Compare(txtac.Text, , false)*/
            this.Hide();
            var f = new frmContact();
            f.ShowDialog();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
