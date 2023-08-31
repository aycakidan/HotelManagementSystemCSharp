using HotelManagement.App.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.App
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            long pass = 0;
            try
            {
                pass = long.Parse(txtPassword.Text);
            }
            catch (Exception)
            {
                Helpers.ShowMessage("Şifreniz sayısal rakamlardan oluşmalıdır");
                return;
            }
            
            if (!string.IsNullOrWhiteSpace(user) || pass != 0)
            {

                hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();
                var sqlQuery = $"select * from employee where emp_username = '{user}' and  emp_pass = {pass} ";
                var getUser = db.Database.SqlQuery<employee>(sqlQuery).FirstOrDefault();

                if (getUser == null)
                {
                    Helpers.ShowMessage("Kullanıcı yada şifreniz yanlış");
                    return;
                }

                // Kullanıcı login işlemi başarılıyısa giriş sağlanacak..
                this.Hide();
                MainForm frm = new MainForm(getUser.emp_name.ToUpper() + " " + getUser.emp_surname.ToUpper());
                frm.Show();
                return;
            }
            Helpers.ShowMessage("Kullanıcı adı ve şifre girişi yapılmadı");
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
