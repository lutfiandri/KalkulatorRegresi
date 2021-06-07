using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorRegresi
{
    public partial class Login : Form
    {
        private Register register;
        private Home home;
        private User _user;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_GoToRegister_Click(object sender, EventArgs e)
        {
            register = new Register();
            register.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Ketiga input tidak boleh kosong!");
                return;
            }

            using(var db = new UserModel())
            {
                var query = from user in db.Users where user.Username == tb_Username.Text select user;
                foreach(var item in query)
                {
                    _user = new User()
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                    };
                }
            }

            if(_user.Password == tb_Password.Text)
            {
                home = new Home(_user);
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username/Password salah");
            }

        }
    }
}
