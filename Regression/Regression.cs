using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public abstract class Regression : ILineAnalyze, ILineFunction
    {
        private double[] array_x;
        private double[] array_y;
        private double[] array_y_regression; 
        private Dictionary<string, double> constants;
        private string equation;
        private double determinationCoef;
        private readonly int n;
        private readonly double x_bar; // rata-rata X
        private readonly double y_bar; // rata-rata Y

        public double[] X
        {
            get { return array_x; }
            set { array_x = value; }
        }

        public double[] Y
        { 
            get { return array_y; }
            set { array_y = value; }
        }

        public double[] YRegression
        {
            get { return array_y_regression; }
            set { array_y_regression = value; }
        }

        public Dictionary<string, double> Constants
        {
            get { return constants; }
            set { constants = value; }
        }

        public string Equation
        { 
            get { return equation; }
            set { equation = value; }
        }

        public double DeterminationCoef
        {
            get { return determinationCoef; }
            set { determinationCoef = value; }
        }

        public int N
        {
            get { return n; }
        }

        public double XBar
        {
            get { return x_bar; }
        }

        public double YBar
        {
            get { return y_bar; }
        }

        public Regression(double[] x, double[] y)
        {
            X = x;
            Y = y;
            x_bar = Numeric.Mean(X);
            y_bar = Numeric.Mean(Y);
            n = X.Length;

            // calculating
            Constants = Calculate();
            Equation = GetEquation();
            YRegression = F();
            DeterminationCoef = GetDeterminationCoef();
        }

        protected abstract Dictionary<string, double> Calculate();

        protected abstract string GetEquation();

        public abstract double f(double x);

        public double[] F()
        {
            double[] YRegression = new double[X.Length];
            for (int i = 0; i < X.Length; ++i)
            {
                YRegression[i] = f(X[i]);
            }
            return YRegression;
        }

        public double DT()
        {
            return Numeric.Sum(Numeric.Pow(Numeric.Subtract(Y, Numeric.Mean(Y)), 2));
        }

        public double LSE()
        {
            return Numeric.Sum(Numeric.Pow(Numeric.Subtract(Y, YRegression), 2));
        }

        public double GetDeterminationCoef()
        {
            double Dt = DT();
            double D = LSE();
            return Math.Sqrt((Dt - D) / Dt);
        }

    }
}
