using System;
namespace Methods
{
    public class Imp_Euler
    {
        //Set of initial variables
        double x0;
        double y0;
        double X;
        int N;
        double h;

        /*
        Тут короче конструктор где x0 - начало диапазона, y0 - начальное значение, Х - конец диапазона, N - кол-во шагов и из него строим сам шаг
        */
        public Imp_Euler(double x0, double y0, double X, int N)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.X = X;
            this.N = N;
            this.h = (X - x0) / N;
        }

        public void reBuild(double x0, double y0, double X, int N)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.X = X;
            this.N = N;
            this.h = (X - x0) / N;
        }
        private static double func(double x, double y)
        {
            return (y / x - y - x);
        }

        public double[,] Graph()
        {
            //тут надо как-то красиво что-то придумать
            double y = y0;
            double x = x0;

            double[,] arrayXY = new double[N,2];
            arrayXY[0, 0] = x;
            arrayXY[0, 1] = y;
            for (int i = 1; i < N;i++)
            { 
                y += func(x + h / 2, y + func(x, y) / 2) * h;
                x += h;
                arrayXY[i, 0] = x;
                arrayXY[i, 1] = y;
            }
            return arrayXY;
        }
    }
}

