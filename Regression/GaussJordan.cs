using System;

namespace Regression
{
    public class GaussJordan
    {
        private double[][] Data_A { get; set; }
        private double[] Data_B { get; set; }
        public double[] Ans { get; set; }

        public GaussJordan(double[][] A, double[] B)
        {
            if (A.Length != B.Length)
            {
                throw new Exception("Pastikan matrix A dan B benar! A = array2D (n x n). B = array1D (n)");
            }

            Data_A = A;
            Data_B = B;
            Ans = Solve();
        }

        public double[] Solve()
        {
            double[][] A = Data_A;
            double[] B = Data_B;

            int size = B.Length;
            for (int i = 0; i < size; ++i)
            {
                if (B[i] != 0 && A[i][i] != 0)
                {
                    B[i] = B[i] / A[i][i];
                }
                A[i] = Numeric.Divide(A[i], A[i][i]);

                for (int j = 0; j < size; ++j)
                {
                    if (i == j) continue;
                    B[j] = B[j] - B[i] * A[j][i];
                    A[j] = Numeric.Subtract(A[j], Numeric.Multiply(A[i], A[j][i]));
                }
            }

            return B;
        }
    }
}
