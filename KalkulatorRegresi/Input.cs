using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KalkulatorRegresi
{
    public class Input
    {
        private double[] array_x;
        private double[] array_y;

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

        public Input(string input_x, string input_y)
        {
            X = MultilineToDoubleArray(input_x);
            Y = MultilineToDoubleArray(input_y);
        }

        public static double[] MultilineToDoubleArray(string text)
        {
            // Anticipate blank input
            string trimmedText = text.Replace(" ", "");
            if (trimmedText == "") return new double[] { };

            // Allow decimal separator . or ,
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string cleanText = Regex.Replace(text, "[.,]", separator);

            // Convert string to double[]
            string[] allLines = cleanText.Split('\n');
            double[] result = allLines.Select(n => Convert.ToDouble(n)).ToArray();

            return result;
        }
    }
}
