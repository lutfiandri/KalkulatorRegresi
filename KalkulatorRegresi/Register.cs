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
    public partial class Register : Form
    {
        private User user;

        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "" || tb_Password.Text == "" || tb_Password2.Text == "" )
            {
                MessageBox.Show("Ketiga input tidak boleh kosong!");
                return;
            }

            if(tb_Password.Text != tb_Password2.Text)
            {
                MessageBox.Show("Kedua password harus sama");
                return;
            }

            using (var db = new UserModel())
            {
                user = new User()
                {
                    Username = tb_Username.Text,
                    Password = tb_Password.Text
                };

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Akun kamu telah terdaftar");
                Close();
            }
        }
    }
}
