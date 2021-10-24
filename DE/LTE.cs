using System;
namespace Errors
{
    public class LTE
    {
        //Output X and Y of the Local Errors of the method
        public static double[] Local_Err(double[] Exact, double[] Approx, uint N)
        {
            double[] Err = new double[N];
            for (int i = 0; i < N; i++)
            {
                Err[i] = Math.Abs(Exact[i] - Approx[i]);
            }
            return Err;
        }
    }
}
