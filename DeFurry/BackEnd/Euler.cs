﻿using System;
namespace DE
{
    class Euler
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
        public Euler(float x0, float y0, float X, float N)
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
            while (x0 < X)
            {
                //y = y + h * func(x0, y);
                //x = x + h;
            }

        }
    }
}