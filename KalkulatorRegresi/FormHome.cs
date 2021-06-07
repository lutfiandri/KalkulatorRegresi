using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regression;

namespace KalkulatorRegresi
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            Input input = new Input(tb_X.Text, tb_Y.Text);
            if(input.X.Length != input.Y.Length)
            {
                MessageBox.Show("Banyak X dan Y harus sama!");
                return;
            }
            label_Koef.Text = Output.DoubleArrayToString(input.Y);

            if(radio_Linear.Checked)
            {
                LinearRegression reg = new LinearRegression(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
            else if(radio_Power.Checked)
            {
                PowerRegression reg = new PowerRegression(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
            else if(radio_Exp.Checked)
            {
                ExponentialRegression reg = new ExponentialRegression(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
            else if(radio_Poly1.Checked)
            {
                PolynomialRegression reg = new PolynomialRegression(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
            else if (radio_Poly2.Checked)
            {
                PolynomialRegression reg = new PolynomialRegression2(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
            else if (radio_Poly3.Checked)
            {
                PolynomialRegression reg = new PolynomialRegression3(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                label_Koef.Text = Convert.ToString(reg.DeterminationCoef);
            }
        }
    }
}
