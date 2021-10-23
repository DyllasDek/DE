using System;
using System.Windows.Forms;
using Methods;
using Errors;

namespace DE
{
    public partial class Comp_Pract : Form
    {
        private double x0 = 1;
        private double y0 = 0;
        private double X = 10;
        private uint N = 100;
        private uint n0 = 10;
        public Comp_Pract()
        {
            InitializeComponent();
            GraphBuilder();
        }

        private void button_GoS_Click(object sender, EventArgs e)
        {
            Text_X.Text = "X";
            value_N0.Visible = false;
            
            value_X.Visible = true;
            value_x0.Visible = true;
            value_y0.Visible = true;
            Text_y0.Visible = true;
            Text_x0.Visible = true;
            checkBox_ES.Visible = true;
            checkBox_E_LTE.Visible = false;
            checkBox_E_GTE.Visible = false;
            checkBox_E_GoS.Visible = true;
            checkBox_IE_LTE.Visible = false;
            checkBox_IE_GTE.Visible = false;
            checkBox_IE_GoS.Visible = true;
            checkBox_RK_LTE.Visible = false;
            checkBox_RK_GTE.Visible = false;
            checkBox_RK_GoS.Visible = true;

            GS_chart.Visible = true;
            LTE_chart.Visible = false;
            GTE_chart.Visible = false;
        }

        private void button_LTE_Click(object sender, EventArgs e)
        {
            Text_X.Text = "X";
            value_N0.Visible = false;
            
            value_X.Visible = true;
            value_x0.Visible = true;
            value_y0.Visible = true;
            Text_y0.Visible = true;
            Text_x0.Visible = true;
            checkBox_ES.Visible = false;
            checkBox_E_LTE.Visible = true;
            checkBox_E_GTE.Visible = false;
            checkBox_E_GoS.Visible = false;
            checkBox_IE_LTE.Visible = true;
            checkBox_IE_GTE.Visible = false;
            checkBox_IE_GoS.Visible = false;
            checkBox_RK_LTE.Visible = true;
            checkBox_RK_GTE.Visible = false;
            checkBox_RK_GoS.Visible = false;

            GS_chart.Visible = false;
            LTE_chart.Visible = true;
            GTE_chart.Visible = false;
        }

        private void button_GTE_Click(object sender, EventArgs e)
        {
            Text_X.Text = "n0";
            value_N0.Visible = true;
            
            value_X.Visible = false;
            value_x0.Visible = false;
            value_y0.Visible = false;
            Text_y0.Visible = false;
            Text_x0.Visible = false;
            checkBox_ES.Visible = false;
            checkBox_E_LTE.Visible = false;
            checkBox_E_GTE.Visible = true;
            checkBox_E_GoS.Visible = false;
            checkBox_IE_LTE.Visible = false;
            checkBox_IE_GTE.Visible = true;
            checkBox_IE_GoS.Visible = false;
            checkBox_RK_LTE.Visible = false;
            checkBox_RK_GTE.Visible = true;
            checkBox_RK_GoS.Visible = false;

            GS_chart.Visible = false;
            LTE_chart.Visible = false;
            GTE_chart.Visible = true;
        }

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
                if ((X-x0)/N > 1)
                {
                    throw new Exception("The length of the interval exceeds the number of iterations. \"X - x0\" must be less than \"N\"");
                }
                else if((X - x0) / n0 > 1)
                {
                    throw new Exception("The length of the interval exceeds the number of minimal iterations. \"X - x0\" must be less than \"n0\"");
                }
                else if(X <= x0)
                {
                    throw new Exception("The value of \"X\" is less then \"x0\"");
                }
                
                //Clean the graphs
                foreach (var series in GS_chart.Series) series.Points.Clear();
                foreach (var series in LTE_chart.Series) series.Points.Clear();
                foreach (var series in GTE_chart.Series) series.Points.Clear();
                
                //Call Graph Builder
                GraphBuilder();
            }

            //Exceptions output
            catch(Exception EE)
            {

                MessageBox.Show(EE.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void GraphBuilder()
        {
            //X and Y values of all graphs
            double[,] arrES = ES.Graph(x0, y0, X, N);
            double[,] arrE = Euler.Graph(x0, y0, X, N);
            double[,] arrIE = Imp_Euler.Graph(x0, y0, X, N);
            double[,] arrRK = RK.Graph(x0, y0, X, N);
            double[,] arrLE_E = LTE.Local_Err(arrES, arrE,N);
            double[,] arrLE_IE = LTE.Local_Err(arrES, arrIE,N);
            double[,] arrLE_RK = LTE.Local_Err(arrES, arrRK,N);
            double[] arrGE_E = GTE.Global_Err("E",x0, y0, X, N, n0);
            double[] arrGE_IE = GTE.Global_Err("IE", x0, y0, X, N, n0);
            double[] arrGE_RK = GTE.Global_Err("RK", x0, y0, X, N, n0);

            //Building the graphs
            for (int i = 0; i < N; i++)
            {
                GS_chart.Series["Exact solution"].Points.AddXY(arrES[i, 0], arrES[i, 1]);
                GS_chart.Series["Euler"].Points.AddXY(arrE[i, 0], arrE[i, 1]);
                GS_chart.Series["ImpEuler"].Points.AddXY(arrIE[i, 0], arrIE[i, 1]);
                GS_chart.Series["RK"].Points.AddXY(arrRK[i, 0], arrRK[i, 1]);
                
                LTE_chart.Series["Euler"].Points.AddXY(arrLE_E[i, 0], arrLE_E[i, 1]);
                LTE_chart.Series["ImpEuler"].Points.AddXY(arrLE_IE[i, 0], arrLE_IE[i, 1]);
                LTE_chart.Series["RK"].Points.AddXY(arrLE_RK[i, 0], arrLE_RK[i, 1]);
            }
            for (int i = 0; i < N-n0+1; i++) {
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
