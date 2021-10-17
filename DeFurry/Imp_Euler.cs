using System;
namespace Methods
{
    public class Imp_Euler
    {
        //Set of initial variables
        /*
        ��� ������ ����������� ��� x0 - ������ ���������, y0 - ��������� ��������, � - ����� ���������, N - ���-�� ����� � �� ���� ������ ��� ���
        */
        private static double func(double x, double y)
        {
            return (y / x - y - x);
        }

        public static double[,] Graph(double x0, double y0, double X, int N)
        {

            double h = (X - x0) / N;
            double[,] arrayXY = new double[N,2];
            arrayXY[0, 0] = x0;
            arrayXY[0, 1] = y0;
            for (int i = 1; i < N;i++)
            { 
                y0 += func(x0 + h / 2, y0 + func(x0, y0) / 2) * h;
                x0 += h;
                arrayXY[i, 0] = x0;
                arrayXY[i, 1] = y0;
            }
            return arrayXY;
        }
    }
}

