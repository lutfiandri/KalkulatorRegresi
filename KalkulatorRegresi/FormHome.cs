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
            label_Koef.Text = Output.DoubleArrayToString(input.X);

            if(radio_Linear.Checked)
            {
                LinearRegression reg = new LinearRegression(input.X, input.Y);
                label_Persamaan.Text = reg.Equation;
                //label_Koef
            }
        }
    }
}
