using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorRegresi
{
    static class Program
    {
        /// <summary>
        /// Kalkulator Regresi. Aplikasi windows form untuk menentukan persamaan garis regresi dan koefisien determinasinya.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
