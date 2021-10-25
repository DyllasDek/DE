using System;

namespace Methods
{
    public class RK
    {
        //Initial function for computing
        private static double Func(double x, double y)
        {
            if (x != 0)
            {
                return y / x - y - x;
            }
            else
            {
                return Double.NegativeInfinity;
            }
        }

        //Output X and Y of the Runge-Kutta method
        public static double[] Graph(double x0, double y0, double X, uint N)
        {
            double h = (X - x0) / (N - 1f);
            double[] arrayXY = new double[N];
            double k1, k2, k3, k4;

            arrayXY[0] = y0;

            for (int i = 1; i < N; i++)
            {
                k1 = Func(x0, y0);
                k2 = Func(x0 + h / 2f, y0 + k1 * h / 2f);
                k3 = Func(x0 + h / 2f, y0 + k2 * h / 2f);
                k4 = Func(x0 + h, y0 + h * k3);
                y0 += (k1 + 2f * k2 + 2f * k3 + k4) * h / 6f;
                arrayXY[i] = y0;
                x0 += h;
            }
            return arrayXY;
        }

    }
}
