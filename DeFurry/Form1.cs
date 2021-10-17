using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Methods;

namespace DeFurry
{
    public partial class Form1 : Form
    {
        Euler E;
        Imp_Euler IE;
        RK RK;
        double x0 = 1;
        double y0 = 0;
        double X = 10;
        int N = 100;
        public Form1()
        {
            //E = new Euler(x0, y0, X, N);
            IE = new Imp_Euler(x0, y0, X, N);
            //RK = new RK(x0, y0, X, N);
            InitializeComponent();
        }

        private void button_GoS_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
        }

        private void button_LTE_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
        }

        private void button_GTE_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            x0 = double.Parse(value_x0.Text);
            y0 = double.Parse(value_y0.Text);
            X = double.Parse(value_X.Text);
            N = int.Parse(value_N.Text);

            IE.reBuild(x0,y0,X,N);
            GraphBuilder();
        }
        private void GraphBuilder()
        {
            double[,] arr = IE.Graph();
            for(int i = 0; i < 100;i++)
            { 
                chart1.Series[2].Points.AddXY(arr[i,0],arr[i,1]);
            }
        }
    }
}
