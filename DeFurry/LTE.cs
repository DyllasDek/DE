using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Err
{
    public class LTE
    {
        public static double[,] Local_Err(double[,] Exact, double[,] Approx, int N)
        {
            double[,] Err = new double[N,2];
            for (int i = 0; i < N; i++)
            {
                Err[i, 0] = Exact[i, 0];
                Err[i, 1] = Math.Abs(Exact[i, 1] - Approx[i, 1]);
            }
            return Err;
        }
    }
}
