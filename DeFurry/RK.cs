namespace Methods
{
    public class RK
    {
        //Initial function for computing
        private static double Func(double x, double y) => (y / x - y - x);

        //Output X and Y of the Runge-Kutta method
        public static double[,] Graph(double x0, double y0, double X, uint N)
        {
            double h = (X - x0) / N;
            double[,] arrayXY = new double[N, 2];
            double k1, k2, k3, k4;

            arrayXY[0, 0] = x0;
            arrayXY[0, 1] = y0;

            for (int i = 1; i < N; i++)
            {
                k1 = Func(x0, y0);
                k2 = Func(x0 + h / 2, y0 + k1 * h / 2);
                k3 = Func(x0 + h / 2, y0 + k2 * h / 2);
                k4 = Func(x0 + h, y0 + h * k3);
                y0 += (k1 + 2 * k2 + 2 * k3 + k4) * h / 6;
                x0 += h;
                arrayXY[i, 0] = x0;
                arrayXY[i, 1] = y0;
            }
            return arrayXY;
        }

    }
}
