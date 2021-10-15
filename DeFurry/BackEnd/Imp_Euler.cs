using System;

public class Imp_Euler {
    //Set of initial variables
    float x0;
    float y0;
    float X;
    float N;
    float h;

    /*
    ��� ������ ����������� ��� x0 - ������ ���������, y0 - ��������� ��������, � - ����� ���������, N - ���-�� ����� � �� ���� ������ ��� ���
    */
    public Imp_Euler(float x0, float y0, float X, float N) {
        this->x0 = x0;
        this->y0 = y0;
        this->X = X;
        this->N = N;
        this->h = (X - x0) / N;
    }

    private static float func(float x, float y) {
        return (y / x - y - x);
    }

    public static void Graph() {
        //��� ���� ���-�� ������� ���-�� ���������
        float y = y0;
        float x = x0;

        //��� ������ ���� ������ ����
        while (x < X)
        {
            /*
             * http://cyclowiki.org/wiki/�������������������_�����_������
             *y = y + func(x0 + h/2, y0 + func(x0,y0,)/2)*h;
             *x = x + h;
            */
        }

    }

}

