using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using Regression;

namespace KalkulatorRegresi
{
    public partial class Home : Form
    {
        private readonly User user;
        private readonly bool isAnonymous;
        private Input input;
        private History history;
        public RegressionBase reg;

        public Home(User user, bool isAnonymous=false)
        {
            this.user = user;
            this.isAnonymous = isAnonymous;
            InitializeComponent();
        }

        private bool ValidateInput(string textArr_X, string textArr_Y)
        {
            input = new Input(textArr_X, textArr_Y);
            if(input.X.Length != input.Y.Length)
            {
                MessageBox.Show("Banyak X dan Y harus sama!");
                return false;
            }
            if(input.X.Length == 0)
            {
                MessageBox.Show("Input X dan Y tidak boleh kosong");
                return false;
            }

            return true;
        }

        private void ShowResult(RegressionBase reg)
        {
            label_Persamaan.Text = reg.Equation;
            label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
        }

        private void PlotRegression(RegressionBase reg)
        {
            pv.Model = new PlotModel();
            var dots = new LineSeries()
            {
                Color = OxyColors.Blue,
                MarkerType = MarkerType.Circle,
                MarkerSize = 5,
                //MarkerStroke = OxyColors.White,
                MarkerFill = OxyColors.Blue,
                MarkerStrokeThickness = 0,
                LineStyle = LineStyle.None
            };

            for (int i = 0; i < reg.N; i++)
            {
                dots.Points.Add(new DataPoint(reg.X[i], reg.Y[i]));
            }
            pv.Model.Series.Add(dots);

            pv.Model.Series.Add(new FunctionSeries(reg.f, reg.X.Min(), reg.X.Max(), 0.1, reg.Equation));
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(tb_X.Text, tb_Y.Text)) return;

            if (radio_Linear.Checked)
            {
                reg = new LinearRegression(input.X, input.Y);
            }
            else if(radio_Power.Checked)
            {
                reg = new PowerRegression(input.X, input.Y);
            }
            else if(radio_Exp.Checked)
            {
                reg = new ExponentialRegression(input.X, input.Y);
            }
            else if (radio_Poly2.Checked)
            {
                reg = new PolynomialRegression2(input.X, input.Y);
            }
            else if (radio_Poly3.Checked)
            {
                reg = new PolynomialRegression3(input.X, input.Y);
            }

            ShowResult(reg);
            PlotRegression(reg);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(tb_X.Text, tb_Y.Text)) return;

            using(var db = new InputHistoryModel())
            {
                var inputHistory = new InputHistory()
                {
                    UserId = user.Id,
                    X = ArrayHelper.DoubleArrayToString(input.X),
                    Y = ArrayHelper.DoubleArrayToString(input.Y)
                };

                db.InputHistories.Add(inputHistory);
                db.SaveChanges();
                MessageBox.Show("Data X dan Y telah disimpan");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(isAnonymous)
            {
                btn_Save.Enabled = false;
                btn_History.Enabled = false;
            }
            label_LoggedInAs.Text = $"Masuk Sebagai : {user.Username}";
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            history = new History(user.Id);
            history.ShowDialog();
            InputData data = history.data;
            if (string.IsNullOrWhiteSpace(data.X)) return;
            tb_X.Text = data.X;
            tb_Y.Text = data.Y;
        }
    }
}
