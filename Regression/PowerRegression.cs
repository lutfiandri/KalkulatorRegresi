using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class PowerRegression : RegressionBase
    {
        public PowerRegression(double[] x, double[] y) : base(x, y)
        { }

        protected override Dictionary<string, double> Calculate()
        {

            double[] P = Numeric.Log10(X);
            double[] Q = Numeric.Log10(Y);
            LinearRegression lin = new LinearRegression(P, Q);

            double a = Math.Pow(10, lin.Constants["a"]);
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
            string b_text = Constants["b"] > 0 ? $"{Constants["b"]:0.000}" : $"(-{-Constants["b"]:0.000})";

            string equation = $"y = {a_text}x^{b_text}";

            return equation;
        }

        public override double f(double x)
        {
            return Constants["a"] * Math.Pow(x, Constants["b"]);
        }
    }
}
