using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class ExponentialRegression : Regression
    {
        public ExponentialRegression(double[] x, double[] y) : base(x, y)
        { }

        protected override Dictionary<string, double> Calculate()
        {

            double[] Q = Numeric.Log(Y);
            LinearRegression lin = new LinearRegression(X, Q);

            double a = Math.Exp(lin.Constants["a"]);
            double b = lin.Constants["b"];

            return new Dictionary<string, double>()
            {
                {"a", a },
                {"b", b }
            };
        }

        protected override string GetEquation()
        {
            string a_text = Constants["a"] > 0 ? $"{Constants["a"]:0.000}" : $"- {-Constants["a"]:0.000}";
            string b_text = Constants["b"] > 0 ? $"{Constants["b"]:0.000}x" : $"(-{-Constants["b"]:0.000}x)";

            string equation = $"y = {a_text}e^{b_text}";

            return equation;
        }

        public override double f(double x)
        {
            return Constants["a"] * Math.Exp(Constants["b"] * x);
        }
    }
}
