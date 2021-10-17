using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Err
{
    public class GTE
    {
        public static double[,] Global_Err(string Name,double x0, double y0, double X, int N, int n0)
        {
            double[,] Err = new double[N, 2];
            for (int i = n0; i < N; i++)
            {
                switch (Name) {
                    case "E":
                        Err[i, 1] = MaxLocalErr(LTE.Local_Err(ES.Graph(x0, y0, X, i), Euler.Graph(x0, y0, X, i),i),i);
                        break;
                    case "IE":
                        Err[i, 1] = MaxLocalErr(LTE.Local_Err(ES.Graph(x0, y0, X, i), Imp_Euler.Graph(x0, y0, X, i),i), i);
                        break;
                    case "RK":
                        Err[i, 1] = MaxLocalErr(LTE.Local_Err(ES.Graph(x0, y0, X, i), RK.Graph(x0, y0, X, i),i), i);
                        break;
                }
            }
            return Err;
        }

        private static double MaxLocalErr(double[,] LR,int N)
        {
            double max = double.MinValue;
            for (int i = 0; i < N; i++)
            {
                if (LR[i,1] > max){
                    max = LR[i, 1];
                }
            }
            return max;
        }
    }
}

