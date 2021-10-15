using System;
namespace DE
{
    public class RK
    {
        //Set of initial variables
        float x0;
        float y0;
        float X;
        float N;
        float h;

        /*
        Тут короче конструктор где x0 - начало диапазона, y0 - начальное значение, Х - конец диапазона, N - кол-во шагов и из него строим сам шаг
        */
        public Runge_Kutta(float x0, float y0, float X, float N)
        {
            this->x0 = x0;
            this->y0 = y0;
            this->X = X;
            this->N = N;
            this->h = (X - x0) / N;
        }

        private static float func(float x, float y)
        {
            return (y / x - y - x);
        }

        public static void Graph()
        {
            //тут надо как-то красиво что-то придумать
            float y = y0;
            float x = x0;

            //Тут должен быть график брат
            while (x < X)
            {
                /*
                 * https://ru.wikipedia.org/wiki/Метод_Рунге_—_Кутты
                 * float k1 = func(x,y);
                 * float k2 = func(x + h/2, y + k1*h/2);
                 * float k3 = func(x + h/2, y + k2*h/2);
                 * float k4 = func(x + h, y + h*k3);
                 * y = y + (k1 + 2*k2 + 2*k3 + k4)*h/6;
                 * x = x + h;
                */
            }

        }

    }
}
