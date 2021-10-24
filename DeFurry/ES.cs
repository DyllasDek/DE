using System;
namespace Methods
{
    class ES
    {
        //Initial function for computing
        private static double Func(double x, double C) => (C * x / Math.Pow(Math.E, x) - x);

        //Get the const for the Exact Solution
        private static double Const(double x, double y) => ((y + x) * Math.Pow(Math.E, x) / x);

        //Output X and Y of the Exact Solution
        public static double[] Graph(double x0, double y0, double X, uint N)
        {
            double h = (X - x0) / N;
            double[] arrayXY = new double[N];
            double C = Const(x0, y0);
            
            for (int i = 1; i < N; i++)
            {
                x0 += h;
                arrayXY[i] = Func(x0, C);
            }
            return arrayXY;
        }
    }
}
