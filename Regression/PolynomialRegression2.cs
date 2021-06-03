using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class PolynomialRegression2 : PolynomialRegression
    {
        public PolynomialRegression2(double[] x, double[] y) : base(x, y)
        { }

        protected override Dictionary<string, double> Calculate()
        {
            (double[][] A, double[] B) = GetMatrix();
            GaussJordan gj = new GaussJordan(A, B);

            return new Dictionary<string, double>()
            {
                {"a0", gj.Ans[0] },
                {"a1", gj.Ans[1] },
                {"a2", gj.Ans[2] }
            };
        }

        protected override string GetEquation()
        {
            string a0_text = Constants["a0"] >= 0 ? $"{Constants["a0"]:0.000}" : $"- {-Constants["a0"]:0.000}";
            string a1_text = Constants["a1"] >= 0 ? $"+ {Constants["a1"]:0.000}" : $"- {-Constants["a1"]:0.000}";
            string a2_text = Constants["a2"] >= 0 ? $"+ {Constants["a2"]:0.000}" : $"- {-Constants["a2"]:0.000}";

            string equation = $"y = {a0_text} {a1_text}x {a2_text}x^2";

            return equation;
        }

        protected override (double[][], double[]) GetMatrix()
        {
            double sx = Numeric.Sum(X);
            double sx2 = Numeric.Sum(Numeric.Pow(X, 2));
            double sx3 = Numeric.Sum(Numeric.Pow(X, 3));
            double sx4 = Numeric.Sum(Numeric.Pow(X, 4));

            double sy = Numeric.Sum(Y);
            double sxy = Numeric.Sum(Numeric.Multiply(X, Y));
            double sx2y = Numeric.Sum(Numeric.Multiply(Numeric.Pow(X, 2), Y));

            double[][] A = {
                new double[] {N, sx, sx2},
                new double[] {sx, sx2, sx3},
                new double[] {sx2, sx3, sx4},
            };

            double[] B = { sy, sxy, sx2y };

            return (A, B);
        }
    }
}
