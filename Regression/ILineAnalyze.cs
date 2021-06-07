using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    interface ILineAnalyze
    {
        double DT();
        double LSE();
        double GetDeterminationCoef();
    }
}
