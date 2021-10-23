namespace Methods
{
    public class Imp_Euler
    {
        private static double Func(double x, double y) => (y / x - y - x);

        public static double[,] Graph(double x0, double y0, double X, uint N)
        {
            double h = (X - x0) / N;
            double[,] arrayXY = new double[N,2];

            arrayXY[0, 0] = x0;
            arrayXY[0, 1] = y0;

            for (int i = 1; i < N;i++)
            { 
                y0 += Func(x0 + h / 2, y0 + Func(x0, y0)*h / 2) * h;
                x0 += h;
                arrayXY[i, 0] = x0;
                arrayXY[i, 1] = y0;
            }
            return arrayXY;
        }
    }
}

