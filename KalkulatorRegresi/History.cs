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
    public partial class History : Form
    {
        private readonly int userId;
        private User user;
        private InputHistory[] ih;
        public InputData data;
        //private string text_X;
        //private string text_Y;

        public History(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void FetchHistories(object sender, EventArgs e)
        {
            using (var db = new InputHistoryModel())
            {
                var query = from user in db.Users where user.Id == userId select user;
                foreach (var item in query)
                {
                    user = new User()
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                        InputHistories = item.InputHistories
                    };
                }
            }

            foreach (var item in user.InputHistories)
            {
                string itemText = $"X: {item.X}  ----- Y: {item.Y}";
                listBox_Histories.Items.Add(itemText);
            }

            ih = user.InputHistories.ToArray();
        }

        private void History_Load(object sender, EventArgs e)
        {
            FetchHistories(sender, e);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if(listBox_Histories.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih salah satu dari list");
                return;
            }

            data = new InputData()
            {
                X = ih[listBox_Histories.SelectedIndex].X.Replace(" ", Environment.NewLine),
                Y = ih[listBox_Histories.SelectedIndex].Y.Replace(" ", Environment.NewLine)
            };

            Close();

            //btn_Delete.Text = Convert.ToString(listBox_Histories.SelectedIndex);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Histories.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih salah satu dari list");
                return;
            }

            int selectedId = ih[listBox_Histories.SelectedIndex].Id;

            using (var db = new InputHistoryModel())
            {
                db.InputHistories.RemoveRange(db.InputHistories.Where(item => item.Id == selectedId));
                db.SaveChanges();
            }

            listBox_Histories.Items.Clear();
            FetchHistories(sender, e);

        }
    }

    public struct InputData
    {
        public string X { get; set; }
        public string Y { get; set; }
    }
}
