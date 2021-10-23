using System;
namespace Errors
{
    public class LTE
    {
        //Output X and Y of the Local Errors of the method
        public static double[,] Local_Err(double[,] Exact, double[,] Approx, uint N)
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
