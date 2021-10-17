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
using Err;

namespace DeFurry
{
    public partial class Form1 : Form
    {
        private double x0 = 1;
        private double y0 = 0;
        private double X = 10;
        private int N = 100;
        private int n0 = 1;
        public Form1()
        {
            InitializeComponent();
            GraphBuilder();
        }

        private void button_GoS_Click(object sender, EventArgs e)
        {
            label3.Text = "X";
            value_N0.Visible = false;
            value_X.Visible = true;
            value_x0.Visible = true;
            value_y0.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
        }

        private void button_LTE_Click(object sender, EventArgs e)
        {
            label3.Text = "X";
            value_N0.Visible = false;
            value_X.Visible = true;
            value_x0.Visible = true;
            value_y0.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
        }

        private void button_GTE_Click(object sender, EventArgs e)
        {
            label3.Text = "n0";
            value_N0.Visible = true;
            value_X.Visible = false;
            value_x0.Visible = false;
            value_y0.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series) series.Points.Clear();
            foreach (var series in chart2.Series) series.Points.Clear();
            foreach (var series in chart3.Series) series.Points.Clear();
            try
            {
                x0 = double.Parse(value_x0.Text);
                y0 = double.Parse(value_y0.Text);
                X = double.Parse(value_X.Text);
                N = int.Parse(value_N.Text);
                n0 = int.Parse(value_N0.Text);
                GraphBuilder();
            }
            catch(Exception EE)
            {

                MessageBox.Show(EE.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void GraphBuilder()
        {
            double[,] arrES = ES.Graph(x0, y0, X, N);
            double[,] arrE = Euler.Graph(x0, y0, X, N);
            double[,] arrIE = Imp_Euler.Graph(x0, y0, X, N);
            double[,] arrRK = RK.Graph(x0, y0, X, N);
            double[,] arrLE_E = LTE.Local_Err(arrES, arrE,N);
            double[,] arrLE_IE = LTE.Local_Err(arrES, arrIE,N);
            double[,] arrLE_RK = LTE.Local_Err(arrES, arrRK,N);
            double[,] arrGE_E = GTE.Global_Err("E",x0, y0, X, N, n0);
            double[,] arrGE_IE = GTE.Global_Err("IE", x0, y0, X, N, n0);
            double[,] arrGE_RK = GTE.Global_Err("RK", x0, y0, X, N, n0);

            for (int i = 0; i < N;i++)
            {
                chart1.Series[0].Points.AddXY(arrES[i, 0], arrES[i, 1]);
                chart1.Series[1].Points.AddXY(arrE[i, 0], arrE[i, 1]);
                chart1.Series[2].Points.AddXY(arrIE[i, 0], arrIE[i, 1]);
                chart1.Series[3].Points.AddXY(arrRK[i, 0], arrRK[i, 1]);
                chart2.Series[1].Points.AddXY(arrLE_E[i, 0], arrLE_E[i, 1]);
                chart2.Series[2].Points.AddXY(arrLE_IE[i, 0], arrLE_IE[i, 1]);
                chart2.Series[3].Points.AddXY(arrLE_RK[i, 0], arrLE_RK[i, 1]);
                chart3.Series[1].Points.AddXY(arrGE_E[i, 0], arrGE_E[i, 1]);
                chart3.Series[2].Points.AddXY(arrGE_IE[i, 0], arrGE_IE[i, 1]);
                chart3.Series[3].Points.AddXY(arrGE_RK[i, 0], arrGE_RK[i, 1]);
            }
        }

    }
}
