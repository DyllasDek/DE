namespace Methods
{
    class Euler
    {
        //Initial function for computing
        private static double Func(double x, double y) => (y / x - y - x);

        //Output X and Y of the Euler method
        public static double[] Graph(double x0, double y0,double X, uint N)
        {
            double h = (X - x0) / (N - 1);
            double[] arrayXY = new double[N];
            
            arrayXY[0] = y0;

            for (int i = 1; i < N; i++)
            {
                y0 += h * Func(x0, y0);
                x0 += h;
                arrayXY[i] = y0;
            }
            return arrayXY;
        }
    }
}