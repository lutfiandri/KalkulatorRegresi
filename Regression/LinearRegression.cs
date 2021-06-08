using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class LinearRegression : RegressionBase
    {
        public LinearRegression(double[] x, double[] y) : base(x, y)
        { }

        protected override Dictionary<string, double> Calculate()
        {
            
            double b = (N * Numeric.Sum(Numeric.Multiply(X, Y)) - Numeric.Sum(X) * Numeric.Sum(Y))
                     / (N * Numeric.Sum(Numeric.Multiply(X, X)) - Numeric.Sum(X) * Numeric.Sum(X));

            double a = YBar - b * XBar;

            return new Dictionary<string, double>()
            {
                {"a", a },
                {"b", b }
            };
        }

        protected override string GetEquation()
        {
            string a_text = Constants["a"] >= 0 ? $"{Constants["a"]:0.000}" : $"- {-Constants["a"]:0.000}";
            string b_text = Constants["b"] >= 0 ? $"+ {Constants["b"]:0.000}" : $"- {-Constants["b"]:0.000}";

            string equation = $"y = {a_text} {b_text}x";

            return equation;
        }

        public override double f(double x)
        {
            return Constants["a"] + Constants["b"] * x;
        }
    }
}
