using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class ES
    {
        private static double func_const(double x, double y)
        {
            return ((y+x)*Math.Pow(Math.E,x)/x);
        }

        public static double[,] Graph(double x0, double y0, double X, int N)
        {
            double h = (X - x0) / N;
            double[,] arrayXY = new double[N, 2];
            double C = func_const(x0, y0);
            arrayXY[0, 0] = x0;
            arrayXY[0, 1] = y0;
            for (int i = 1; i < N; i++)
            {
                x0 += h;
                arrayXY[i, 0] = x0;
                arrayXY[i, 1] = C * x0 / Math.Pow(Math.E, x0) - x0;
            }
            return arrayXY;
        }
    }
}
