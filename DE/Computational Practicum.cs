using System;
using System.Windows.Forms;
using Methods;
using Errors;

namespace DE
{
    public partial class Comp_Pract : Form
    {
        //Initial conditions
        private double x0 = 1;
        private double y0 = 0;
        private double X = 10;
        private uint N = 100;
        private uint n0 = 10;
        private double h;

        //Constructor of the form
        public Comp_Pract()
        {
            h = (X - x0) / (N-1f);
            InitializeComponent();
            GraphBuilder();
        }

        //Button of the GoS
        private void button_GoS_Click(object sender, EventArgs e)
        {
            checkBox_ES.Visible = true;

            checkBox_E_GoS.Visible = true;
            checkBox_E_LTE.Visible = false;
            checkBox_E_GTE.Visible = false;

            checkBox_IE_GoS.Visible = true;
            checkBox_IE_LTE.Visible = false;
            checkBox_IE_GTE.Visible = false;

            checkBox_RK_GoS.Visible = true;
            checkBox_RK_LTE.Visible = false;
            checkBox_RK_GTE.Visible = false;

            GS_chart.Visible = true;
            LTE_chart.Visible = false;
            GTE_chart.Visible = false;
        }

        //Button of the LTE
        private void button_LTE_Click(object sender, EventArgs e)
        {
            checkBox_ES.Visible = false;

            checkBox_E_GoS.Visible = false;
            checkBox_E_LTE.Visible = true;
            checkBox_E_GTE.Visible = false;

            checkBox_IE_GoS.Visible = false;
            checkBox_IE_LTE.Visible = true;
            checkBox_IE_GTE.Visible = false;
   
            checkBox_RK_GoS.Visible = false;
            checkBox_RK_LTE.Visible = true;
            checkBox_RK_GTE.Visible = false;

            GS_chart.Visible = false;
            LTE_chart.Visible = true;
            GTE_chart.Visible = false;
        }

        //Button of the GTE
        private void button_GTE_Click(object sender, EventArgs e)
        {
            checkBox_ES.Visible = false;

            checkBox_E_GoS.Visible = false;
            checkBox_E_LTE.Visible = false;
            checkBox_E_GTE.Visible = true;

            checkBox_IE_GoS.Visible = false;
            checkBox_IE_LTE.Visible = false;
            checkBox_IE_GTE.Visible = true;

            checkBox_RK_GoS.Visible = false;
            checkBox_RK_LTE.Visible = false;
            checkBox_RK_GTE.Visible = true;

            GS_chart.Visible = false;
            LTE_chart.Visible = false;
            GTE_chart.Visible = true;
        }

        //Submit new data button
        private void button_S_Click(object sender, EventArgs e)
        {
            try
            {
                //Initial values
                x0 = double.Parse(value_x0.Text);
                y0 = double.Parse(value_y0.Text);
                X = double.Parse(value_X.Text);
                N = uint.Parse(value_N.Text);
                n0 = uint.Parse(value_N0.Text);

                //Exceptions
                if ((y0 + x0) * Math.Pow(Math.E, x0) / x0 <= 0)
                {
                    throw new Exception("For such values Const will be less or equal zero.");
                }
                else if (X <= x0)
                {
                    throw new Exception("The value of \"X\" is less then \"x0\"");
                }
                else if ((X - x0) / N > 1)
                {
                    throw new Exception("The length of the interval exceeds the number of iterations. \"X - x0\" must be less than \"N\"");
                }
                else if ((X - x0) / n0 > 1)
                {
                    throw new Exception("The length of the interval exceeds the number of minimal iterations. \"X - x0\" must be less than \"n0\"");
                }
                

                //Clean the graphs
                foreach (var series in GS_chart.Series) series.Points.Clear();
                foreach (var series in LTE_chart.Series) series.Points.Clear();
                foreach (var series in GTE_chart.Series) series.Points.Clear();
                h = (X - x0) / (N - 1f);

                //Call Graph Builder
                GraphBuilder();
            }

            //Exceptions output
            catch(Exception EE)
            {
                MessageBox.Show(EE.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Builder of the graphs
        private void GraphBuilder()
        {
            //X and Y values of all graphs
            double[] arrES = ES.Graph(x0, y0, X, N);
            double[] arrE = Euler.Graph(x0, y0, X, N);
            double[] arrIE = Imp_Euler.Graph(x0, y0, X, N);
            double[] arrRK = RK.Graph(x0, y0, X, N);
            double[] arrLE_E = LTE.Local_Err(arrES, arrE,N);
            double[] arrLE_IE = LTE.Local_Err(arrES, arrIE,N);
            double[] arrLE_RK = LTE.Local_Err(arrES, arrRK,N);
            double[] arrGE_E = GTE.Global_Err("E",x0, y0, X, N, n0);
            double[] arrGE_IE = GTE.Global_Err("IE", x0, y0, X, N, n0);
            double[] arrGE_RK = GTE.Global_Err("RK", x0, y0, X, N, n0);
            double outx = x0;

            //Building the graphs
            for (int i = 0; i < N; i++)
            {
                //Building Solutions Graph
                if (arrES[i] != Double.NegativeInfinity) GS_chart.Series["Exact solution"].Points.AddXY(outx, arrES[i]);
                if (arrE[i] != Double.NegativeInfinity) GS_chart.Series["Euler"].Points.AddXY(outx, arrE[i]);
                if (arrIE[i] != Double.NegativeInfinity) GS_chart.Series["ImpEuler"].Points.AddXY(outx, arrIE[i]);
                if (arrRK[i] != Double.NegativeInfinity) GS_chart.Series["RK"].Points.AddXY(outx, arrRK[i]);

                //Building LTE graph
                if (arrLE_E[i] != Double.NegativeInfinity) LTE_chart.Series["Euler"].Points.AddXY(outx, arrLE_E[i]);
                if (arrLE_IE[i] != Double.NegativeInfinity) LTE_chart.Series["ImpEuler"].Points.AddXY(outx, arrLE_IE[i]);
                if (arrLE_RK[i] != Double.NegativeInfinity) LTE_chart.Series["RK"].Points.AddXY(outx, arrLE_RK[i]);

                outx += h;
            }
            for (int i = 0; i < N-n0+1; i++) {
                //Building GTE graph
                GTE_chart.Series["Euler"].Points.AddXY(i + n0, arrGE_E[i]);
                GTE_chart.Series["ImpEuler"].Points.AddXY(i + n0, arrGE_IE[i]);
                GTE_chart.Series["RK"].Points.AddXY(i + n0, arrGE_RK[i]);
            }
        }

        //Change visibility of Euler Graphs
        private void checkBox_E_GoS_CheckedChanged(object sender, EventArgs e)
        {
            GS_chart.Series["Euler"].Enabled = !GS_chart.Series["Euler"].Enabled;
        }
        private void checkBox_E_LTE_CheckedChanged(object sender, EventArgs e)
        {
            LTE_chart.Series["Euler"].Enabled = !LTE_chart.Series["Euler"].Enabled;
        }
        private void checkBox_E_GTE_CheckedChanged(object sender, EventArgs e)
        {
            GTE_chart.Series["Euler"].Enabled = !GTE_chart.Series["Euler"].Enabled;
        }


        //Change visibility of Improved Euler Graphs
        private void checkBox_IE_CheckedChanged(object sender, EventArgs e)
        {
            GS_chart.Series["ImpEuler"].Enabled = !GS_chart.Series["ImpEuler"].Enabled;

        }
        private void checkBox_IE_LTE_CheckedChanged(object sender, EventArgs e)
        {
            LTE_chart.Series["ImpEuler"].Enabled = !LTE_chart.Series["ImpEuler"].Enabled;
        }
        private void checkBox_IE_GTE_CheckedChanged(object sender, EventArgs e)
        {
            GTE_chart.Series["ImpEuler"].Enabled = !GTE_chart.Series["ImpEuler"].Enabled;
        }

        
        //Change visibility of Runge-Kutta Graphs
        private void checkBox_RK_GoS_CheckedChanged(object sender, EventArgs e)
        {
            GS_chart.Series["RK"].Enabled = !GS_chart.Series["RK"].Enabled;
        }
        private void checkBox_RK_LTE_CheckedChanged(object sender, EventArgs e)
        {
            LTE_chart.Series["RK"].Enabled = !LTE_chart.Series["RK"].Enabled;
        }
        private void checkBox_RK_GTE_CheckedChanged(object sender, EventArgs e)
        {
            GTE_chart.Series["RK"].Enabled = !GTE_chart.Series["RK"].Enabled;
        }

        
        //Change visibility of Exact solutin Graphs
        private void checkBox_ES_CheckedChanged(object sender, EventArgs e)
        {
            GS_chart.Series["Exact solution"].Enabled = !GS_chart.Series["Exact solution"].Enabled;
        }
    }
}
