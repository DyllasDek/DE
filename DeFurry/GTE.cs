using Methods;
using System;
namespace Errors
{
    public class GTE
    {
        //Output X and Y of the Global Errors of the method
        public static double[] Global_Err(string Name,double x0, double y0, double X, uint N, uint n0)
        {
            double[] Err = new double[N - n0 + 1];
            for (uint En = n0; En <= N; En++)
            {
                switch (Name) {
                    case "E":
                        Err[En - n0] = MaxLocalErr(LTE.Local_Err(ES.Graph(x0, y0, X, En), Euler.Graph(x0, y0, X, En),En),En);
                        Console.WriteLine(Err[En - n0]);
                        break;
                    case "IE":
                        Err[En - n0] = MaxLocalErr(LTE.Local_Err(ES.Graph(x0, y0, X, En), Imp_Euler.Graph(x0, y0, X, En),En), En);
                        break;
                    case "RK":
                        Err[En - n0] = MaxLocalErr( LTE.Local_Err(ES.Graph(x0, y0, X, En), RK.Graph(x0, y0, X, En),En), En);
                        break;
                }
            }
            return Err;
        }

        //Method of finding Maximum Locall Err
        private static double MaxLocalErr(double[,] LR,uint N)
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

