using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class PolynomialRegression : Regression
    {
        public PolynomialRegression(double[] x, double[] y) : base(x, y)
        { }

        protected override Dictionary<string, double> Calculate()
        {
            (double[][] A, double[] B) = GetMatrix();
            GaussJordan gj = new GaussJordan(A, B);

            return new Dictionary<string, double>()
            {
                {"a0", gj.Ans[0] },
                {"a1", gj.Ans[1] }
            };
        }

        protected override string GetEquation()
        {
            string a0_text = Constants["a0"] >= 0 ? $"{Constants["a0"]:0.000}" : $"- {-Constants["a0"]:0.000}";
            string a1_text = Constants["a1"] >= 0 ? $"+ {Constants["a1"]:0.000}" : $"- {-Constants["a1"]:0.000}";

            string equation = $"y = {a0_text} {a1_text}x";

            return equation;
        }

        protected virtual (double[][], double[]) GetMatrix()
        {
            double sx = Numeric.Sum(X);
            double sx2 = Numeric.Sum(Numeric.Pow(X, 2));

            double sy = Numeric.Sum(Y);
            double sxy = Numeric.Sum(Numeric.Multiply(X, Y));

            double[][] A = {
                new double[] {N, sx},
                new double[] {sx, sx2},
            };

            double[] B = { sy, sxy };

            return (A, B);
        }
    }
}
