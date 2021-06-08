using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorRegresi
{
    static class ArrayHelper
    {
        public static string DoubleArrayToString(double[] arr)
        {
            string text = "";
            for(int i = 0; i < arr.Length; i++)
            {
                text += Convert.ToString(arr[i]);
                if (i < arr.Length - 1) text += " ";
            }

            return text;
        }

        public static double[] StringToDoubleArray(string text)
        {
            string[] allNum = text.Split(' ');
            double[] result = allNum.Select(n => Convert.ToDouble(n)).ToArray();

            return result;

        }
    }
}
