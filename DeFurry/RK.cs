using System;
namespace Methods
{
    public class RK
    {


        /*
        Тут короче конструктор где x0 - начало диапазона, y0 - начальное значение, Х - конец диапазона, N - кол-во шагов и из него строим сам шаг
        */


        private static double func(double x, double y)
        {
            return (y / x - y - x);
        }

        public static double[,] Graph(double x0, double y0, double X, int N)
        {
            double h = (X - x0) / N;
            double[,] arrayXY = new double[N, 2];
            arrayXY[0, 0] = x0;
            arrayXY[0, 1] = y0;
            double k1, k2, k3, k4;
            for (int i = 1; i < N; i++)
            {
                k1 = func(x0, y0);
                k2 = func(x0 + h / 2, y0 + k1 * h / 2);
                k3 = func(x0 + h / 2, y0 + k2 * h / 2);
                k4 = func(x0 + h, y0 + h * k3);
                y0 += (k1 + 2 * k2 + 2 * k3 + k4) * h / 6;
                x0 += h;
                arrayXY[i, 0] = x0;
                arrayXY[i, 1] = y0;
            }
            return arrayXY;
        }

    }
}
