using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorRegresi
{
    public class Output
    {
        public static string DoubleArrayToString(double[] arr)
        {
            string text = "";
            foreach (var item in arr)
            {
                text += Convert.ToString(item);
                text += " ";
            }

            return text;
        }
    }
}
