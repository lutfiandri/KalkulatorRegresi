﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public abstract class Regression
    {
        private double[] array_x;
        private double[] array_y;
        private Dictionary<string, double> constants;
        private string equation;
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
        }

        protected abstract Dictionary<string, double> Calculate();
        protected abstract string GetEquation();

    }
}
