
namespace DE
{
    partial class Comp_Pract
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_Pract));
            this.GS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FODE = new System.Windows.Forms.TextBox();
            this.value_y0 = new System.Windows.Forms.TextBox();
            this.value_x0 = new System.Windows.Forms.TextBox();
            this.value_X = new System.Windows.Forms.TextBox();
            this.value_N = new System.Windows.Forms.TextBox();
            this.Text_y0 = new System.Windows.Forms.Label();
            this.Text_x0 = new System.Windows.Forms.Label();
            this.Text_X = new System.Windows.Forms.Label();
            this.Text_N = new System.Windows.Forms.Label();
            this.button_S = new System.Windows.Forms.Button();
            this.LTE_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_GoS = new System.Windows.Forms.Button();
            this.button_LTE = new System.Windows.Forms.Button();
            this.button_GTE = new System.Windows.Forms.Button();
            this.GTE_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.value_N0 = new System.Windows.Forms.TextBox();
            this.checkBox_E_GoS = new System.Windows.Forms.CheckBox();
            this.checkBox_IE_GoS = new System.Windows.Forms.CheckBox();
            this.checkBox_RK_GoS = new System.Windows.Forms.CheckBox();
            this.checkBox_ES = new System.Windows.Forms.CheckBox();
            this.checkBox_RK_LTE = new System.Windows.Forms.CheckBox();
            this.checkBox_IE_LTE = new System.Windows.Forms.CheckBox();
            this.checkBox_E_LTE = new System.Windows.Forms.CheckBox();
            this.checkBox_RK_GTE = new System.Windows.Forms.CheckBox();
            this.checkBox_IE_GTE = new System.Windows.Forms.CheckBox();
            this.checkBox_E_GTE = new System.Windows.Forms.CheckBox();
            this.Text_n0 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GS_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTE_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTE_chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GS_chart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "ChartArea1";
            this.GS_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GS_chart.Legends.Add(legend1);
            this.GS_chart.Location = new System.Drawing.Point(12, 41);
            this.GS_chart.Name = "GS_chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Font = null;
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.Name = "Exact solution";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = null;
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.Name = "Euler";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = null;
            series3.LabelBorderWidth = 2;
            series3.Legend = "Legend1";
            series3.Name = "ImpEuler";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Font = null;
            series4.LabelBorderWidth = 2;
            series4.Legend = "Legend1";
            series4.Name = "RK";
            this.GS_chart.Series.Add(series1);
            this.GS_chart.Series.Add(series2);
            this.GS_chart.Series.Add(series3);
            this.GS_chart.Series.Add(series4);
            this.GS_chart.Size = new System.Drawing.Size(650, 400);
            this.GS_chart.TabIndex = 0;
            this.GS_chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Graph of solutions";
            this.GS_chart.Titles.Add(title1);
            // 
            // FODE
            // 
            this.FODE.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FODE.Location = new System.Drawing.Point(12, 9);
            this.FODE.Name = "FODE";
            this.FODE.ReadOnly = true;
            this.FODE.Size = new System.Drawing.Size(650, 32);
            this.FODE.TabIndex = 1;
            this.FODE.Text = "y\' = y/x - y - x";
            this.FODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // value_y0
            // 
            this.value_y0.Location = new System.Drawing.Point(3, 27);
            this.value_y0.Name = "value_y0";
            this.value_y0.Size = new System.Drawing.Size(100, 20);
            this.value_y0.TabIndex = 3;
            this.value_y0.Text = "0";
            // 
            // value_x0
            // 
            this.value_x0.Location = new System.Drawing.Point(3, 80);
            this.value_x0.Name = "value_x0";
            this.value_x0.Size = new System.Drawing.Size(100, 20);
            this.value_x0.TabIndex = 5;
            this.value_x0.Text = "1";
            // 
            // value_X
            // 
            this.value_X.Location = new System.Drawing.Point(3, 127);
            this.value_X.Name = "value_X";
            this.value_X.Size = new System.Drawing.Size(100, 20);
            this.value_X.TabIndex = 7;
            this.value_X.Text = "10";
            // 
            // value_N
            // 
            this.value_N.Location = new System.Drawing.Point(3, 221);
            this.value_N.Name = "value_N";
            this.value_N.Size = new System.Drawing.Size(100, 20);
            this.value_N.TabIndex = 9;
            this.value_N.Text = "100";
            // 
            // Text_y0
            // 
            this.Text_y0.AutoSize = true;
            this.Text_y0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_y0.Location = new System.Drawing.Point(3, 3);
            this.Text_y0.Name = "Text_y0";
            this.Text_y0.Size = new System.Drawing.Size(28, 21);
            this.Text_y0.TabIndex = 10;
            this.Text_y0.Text = "y0";
            // 
            // Text_x0
            // 
            this.Text_x0.AutoSize = true;
            this.Text_x0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_x0.Location = new System.Drawing.Point(3, 56);
            this.Text_x0.Name = "Text_x0";
            this.Text_x0.Size = new System.Drawing.Size(28, 21);
            this.Text_x0.TabIndex = 11;
            this.Text_x0.Text = "x0";
            // 
            // Text_X
            // 
            this.Text_X.AutoSize = true;
            this.Text_X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_X.Location = new System.Drawing.Point(3, 103);
            this.Text_X.Name = "Text_X";
            this.Text_X.Size = new System.Drawing.Size(23, 21);
            this.Text_X.TabIndex = 12;
            this.Text_X.Text = "X";
            // 
            // Text_N
            // 
            this.Text_N.AutoSize = true;
            this.Text_N.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_N.Location = new System.Drawing.Point(3, 197);
            this.Text_N.Name = "Text_N";
            this.Text_N.Size = new System.Drawing.Size(23, 21);
            this.Text_N.TabIndex = 13;
            this.Text_N.Text = "N";
            // 
            // button_S
            // 
            this.button_S.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_S.Location = new System.Drawing.Point(671, 273);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(100, 28);
            this.button_S.TabIndex = 14;
            this.button_S.Text = "Submit";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // LTE_chart
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "x";
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "E";
            chartArea2.Name = "ChartArea1";
            this.LTE_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.LTE_chart.Legends.Add(legend2);
            this.LTE_chart.Location = new System.Drawing.Point(12, 41);
            this.LTE_chart.Name = "LTE_chart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Euler";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "ImpEuler";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "RK";
            this.LTE_chart.Series.Add(series5);
            this.LTE_chart.Series.Add(series6);
            this.LTE_chart.Series.Add(series7);
            this.LTE_chart.Size = new System.Drawing.Size(650, 400);
            this.LTE_chart.TabIndex = 15;
            this.LTE_chart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "LTE";
            this.LTE_chart.Titles.Add(title2);
            this.LTE_chart.Visible = false;
            // 
            // button_GoS
            // 
            this.button_GoS.Location = new System.Drawing.Point(12, 447);
            this.button_GoS.Name = "button_GoS";
            this.button_GoS.Size = new System.Drawing.Size(150, 23);
            this.button_GoS.TabIndex = 17;
            this.button_GoS.Text = "Graph of solutions";
            this.button_GoS.UseVisualStyleBackColor = true;
            this.button_GoS.Click += new System.EventHandler(this.button_GoS_Click);
            // 
            // button_LTE
            // 
            this.button_LTE.Location = new System.Drawing.Point(262, 447);
            this.button_LTE.Name = "button_LTE";
            this.button_LTE.Size = new System.Drawing.Size(150, 23);
            this.button_LTE.TabIndex = 18;
            this.button_LTE.Text = "LTE";
            this.button_LTE.UseVisualStyleBackColor = true;
            this.button_LTE.Click += new System.EventHandler(this.button_LTE_Click);
            // 
            // button_GTE
            // 
            this.button_GTE.Location = new System.Drawing.Point(512, 447);
            this.button_GTE.Name = "button_GTE";
            this.button_GTE.Size = new System.Drawing.Size(150, 23);
            this.button_GTE.TabIndex = 19;
            this.button_GTE.Text = "GTE";
            this.button_GTE.UseVisualStyleBackColor = true;
            this.button_GTE.Click += new System.EventHandler(this.button_GTE_Click);
            // 
            // GTE_chart
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "N";
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "En";
            chartArea3.Name = "ChartArea1";
            this.GTE_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GTE_chart.Legends.Add(legend3);
            this.GTE_chart.Location = new System.Drawing.Point(13, 41);
            this.GTE_chart.Name = "GTE_chart";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Euler";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "ImpEuler";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.Name = "RK";
            this.GTE_chart.Series.Add(series8);
            this.GTE_chart.Series.Add(series9);
            this.GTE_chart.Series.Add(series10);
            this.GTE_chart.Size = new System.Drawing.Size(650, 400);
            this.GTE_chart.TabIndex = 20;
            this.GTE_chart.Text = "chart3";
            title3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "GTE";
            this.GTE_chart.Titles.Add(title3);
            this.GTE_chart.Visible = false;
            // 
            // value_N0
            // 
            this.value_N0.Location = new System.Drawing.Point(3, 174);
            this.value_N0.Name = "value_N0";
            this.value_N0.Size = new System.Drawing.Size(100, 20);
            this.value_N0.TabIndex = 21;
            this.value_N0.Text = "10";
            // 
            // checkBox_E_GoS
            // 
            this.checkBox_E_GoS.AutoSize = true;
            this.checkBox_E_GoS.Checked = true;
            this.checkBox_E_GoS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_E_GoS.Location = new System.Drawing.Point(669, 318);
            this.checkBox_E_GoS.Name = "checkBox_E_GoS";
            this.checkBox_E_GoS.Size = new System.Drawing.Size(80, 17);
            this.checkBox_E_GoS.TabIndex = 22;
            this.checkBox_E_GoS.Text = "Show Euler";
            this.checkBox_E_GoS.UseVisualStyleBackColor = true;
            this.checkBox_E_GoS.CheckedChanged += new System.EventHandler(this.checkBox_E_GoS_CheckedChanged);
            // 
            // checkBox_IE_GoS
            // 
            this.checkBox_IE_GoS.AutoSize = true;
            this.checkBox_IE_GoS.Checked = true;
            this.checkBox_IE_GoS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IE_GoS.Location = new System.Drawing.Point(669, 341);
            this.checkBox_IE_GoS.Name = "checkBox_IE_GoS";
            this.checkBox_IE_GoS.Size = new System.Drawing.Size(100, 17);
            this.checkBox_IE_GoS.TabIndex = 23;
            this.checkBox_IE_GoS.Text = "Show Imp Euler";
            this.checkBox_IE_GoS.UseVisualStyleBackColor = true;
            this.checkBox_IE_GoS.CheckedChanged += new System.EventHandler(this.checkBox_IE_CheckedChanged);
            // 
            // checkBox_RK_GoS
            // 
            this.checkBox_RK_GoS.AutoSize = true;
            this.checkBox_RK_GoS.Checked = true;
            this.checkBox_RK_GoS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RK_GoS.Location = new System.Drawing.Point(669, 364);
            this.checkBox_RK_GoS.Name = "checkBox_RK_GoS";
            this.checkBox_RK_GoS.Size = new System.Drawing.Size(71, 17);
            this.checkBox_RK_GoS.TabIndex = 24;
            this.checkBox_RK_GoS.Text = "Show RK";
            this.checkBox_RK_GoS.UseVisualStyleBackColor = true;
            this.checkBox_RK_GoS.CheckedChanged += new System.EventHandler(this.checkBox_RK_GoS_CheckedChanged);
            // 
            // checkBox_ES
            // 
            this.checkBox_ES.AutoSize = true;
            this.checkBox_ES.Checked = true;
            this.checkBox_ES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ES.Location = new System.Drawing.Point(669, 387);
            this.checkBox_ES.Name = "checkBox_ES";
            this.checkBox_ES.Size = new System.Drawing.Size(104, 17);
            this.checkBox_ES.TabIndex = 25;
            this.checkBox_ES.Text = "Show Exact Sol.";
            this.checkBox_ES.UseVisualStyleBackColor = true;
            this.checkBox_ES.CheckedChanged += new System.EventHandler(this.checkBox_ES_CheckedChanged);
            // 
            // checkBox_RK_LTE
            // 
            this.checkBox_RK_LTE.AutoSize = true;
            this.checkBox_RK_LTE.Checked = true;
            this.checkBox_RK_LTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RK_LTE.Location = new System.Drawing.Point(669, 364);
            this.checkBox_RK_LTE.Name = "checkBox_RK_LTE";
            this.checkBox_RK_LTE.Size = new System.Drawing.Size(71, 17);
            this.checkBox_RK_LTE.TabIndex = 28;
            this.checkBox_RK_LTE.Text = "Show RK";
            this.checkBox_RK_LTE.UseVisualStyleBackColor = true;
            this.checkBox_RK_LTE.CheckedChanged += new System.EventHandler(this.checkBox_RK_LTE_CheckedChanged);
            // 
            // checkBox_IE_LTE
            // 
            this.checkBox_IE_LTE.AutoSize = true;
            this.checkBox_IE_LTE.Checked = true;
            this.checkBox_IE_LTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IE_LTE.Location = new System.Drawing.Point(669, 341);
            this.checkBox_IE_LTE.Name = "checkBox_IE_LTE";
            this.checkBox_IE_LTE.Size = new System.Drawing.Size(100, 17);
            this.checkBox_IE_LTE.TabIndex = 27;
            this.checkBox_IE_LTE.Text = "Show Imp Euler";
            this.checkBox_IE_LTE.UseVisualStyleBackColor = true;
            this.checkBox_IE_LTE.CheckedChanged += new System.EventHandler(this.checkBox_IE_LTE_CheckedChanged);
            // 
            // checkBox_E_LTE
            // 
            this.checkBox_E_LTE.AutoSize = true;
            this.checkBox_E_LTE.Checked = true;
            this.checkBox_E_LTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_E_LTE.Location = new System.Drawing.Point(669, 318);
            this.checkBox_E_LTE.Name = "checkBox_E_LTE";
            this.checkBox_E_LTE.Size = new System.Drawing.Size(80, 17);
            this.checkBox_E_LTE.TabIndex = 26;
            this.checkBox_E_LTE.Text = "Show Euler";
            this.checkBox_E_LTE.UseVisualStyleBackColor = true;
            this.checkBox_E_LTE.CheckedChanged += new System.EventHandler(this.checkBox_E_LTE_CheckedChanged);
            // 
            // checkBox_RK_GTE
            // 
            this.checkBox_RK_GTE.AutoSize = true;
            this.checkBox_RK_GTE.Checked = true;
            this.checkBox_RK_GTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RK_GTE.Location = new System.Drawing.Point(669, 364);
            this.checkBox_RK_GTE.Name = "checkBox_RK_GTE";
            this.checkBox_RK_GTE.Size = new System.Drawing.Size(71, 17);
            this.checkBox_RK_GTE.TabIndex = 31;
            this.checkBox_RK_GTE.Text = "Show RK";
            this.checkBox_RK_GTE.UseVisualStyleBackColor = true;
            this.checkBox_RK_GTE.CheckedChanged += new System.EventHandler(this.checkBox_RK_GTE_CheckedChanged);
            // 
            // checkBox_IE_GTE
            // 
            this.checkBox_IE_GTE.AutoSize = true;
            this.checkBox_IE_GTE.Checked = true;
            this.checkBox_IE_GTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IE_GTE.Location = new System.Drawing.Point(669, 341);
            this.checkBox_IE_GTE.Name = "checkBox_IE_GTE";
            this.checkBox_IE_GTE.Size = new System.Drawing.Size(100, 17);
            this.checkBox_IE_GTE.TabIndex = 30;
            this.checkBox_IE_GTE.Text = "Show Imp Euler";
            this.checkBox_IE_GTE.UseVisualStyleBackColor = true;
            this.checkBox_IE_GTE.CheckedChanged += new System.EventHandler(this.checkBox_IE_GTE_CheckedChanged);
            // 
            // checkBox_E_GTE
            // 
            this.checkBox_E_GTE.AutoSize = true;
            this.checkBox_E_GTE.Checked = true;
            this.checkBox_E_GTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_E_GTE.Location = new System.Drawing.Point(669, 318);
            this.checkBox_E_GTE.Name = "checkBox_E_GTE";
            this.checkBox_E_GTE.Size = new System.Drawing.Size(80, 17);
            this.checkBox_E_GTE.TabIndex = 29;
            this.checkBox_E_GTE.Text = "Show Euler";
            this.checkBox_E_GTE.UseVisualStyleBackColor = true;
            this.checkBox_E_GTE.CheckedChanged += new System.EventHandler(this.checkBox_E_GTE_CheckedChanged);
            // 
            // Text_n0
            // 
            this.Text_n0.AutoSize = true;
            this.Text_n0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_n0.Location = new System.Drawing.Point(3, 150);
            this.Text_n0.Name = "Text_n0";
            this.Text_n0.Size = new System.Drawing.Size(28, 21);
            this.Text_n0.TabIndex = 32;
            this.Text_n0.Text = "n0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.value_y0);
            this.panel1.Controls.Add(this.Text_n0);
            this.panel1.Controls.Add(this.Text_y0);
            this.panel1.Controls.Add(this.Text_x0);
            this.panel1.Controls.Add(this.value_x0);
            this.panel1.Controls.Add(this.Text_X);
            this.panel1.Controls.Add(this.value_X);
            this.panel1.Controls.Add(this.value_N0);
            this.panel1.Controls.Add(this.value_N);
            this.panel1.Controls.Add(this.Text_N);
            this.panel1.Location = new System.Drawing.Point(668, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 248);
            this.panel1.TabIndex = 33;
            // 
            // Comp_Pract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(783, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_ES);
            this.Controls.Add(this.checkBox_RK_GoS);
            this.Controls.Add(this.checkBox_E_GoS);
            this.Controls.Add(this.button_GTE);
            this.Controls.Add(this.button_LTE);
            this.Controls.Add(this.button_GoS);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.FODE);
            this.Controls.Add(this.GS_chart);
            this.Controls.Add(this.LTE_chart);
            this.Controls.Add(this.GTE_chart);
            this.Controls.Add(this.checkBox_E_GTE);
            this.Controls.Add(this.checkBox_E_LTE);
            this.Controls.Add(this.checkBox_RK_GTE);
            this.Controls.Add(this.checkBox_RK_LTE);
            this.Controls.Add(this.checkBox_IE_GoS);
            this.Controls.Add(this.checkBox_IE_GTE);
            this.Controls.Add(this.checkBox_IE_LTE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comp_Pract";
            this.Text = "Computational Practicum DE";
            ((System.ComponentModel.ISupportInitialize)(this.GS_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTE_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTE_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FODE;
        private System.Windows.Forms.TextBox value_y0;
        private System.Windows.Forms.TextBox value_x0;
        private System.Windows.Forms.TextBox value_X;
        private System.Windows.Forms.TextBox value_N;
        private System.Windows.Forms.Label Text_y0;
        private System.Windows.Forms.Label Text_x0;
        private System.Windows.Forms.Label Text_X;
        private System.Windows.Forms.Label Text_N;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_GoS;
        private System.Windows.Forms.Button button_LTE;
        private System.Windows.Forms.Button button_GTE;
        private System.Windows.Forms.DataVisualization.Charting.Chart GS_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LTE_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GTE_chart;
        private System.Windows.Forms.TextBox value_N0;
        private System.Windows.Forms.CheckBox checkBox_E_GoS;
        private System.Windows.Forms.CheckBox checkBox_IE_GoS;
        private System.Windows.Forms.CheckBox checkBox_RK_GoS;
        private System.Windows.Forms.CheckBox checkBox_ES;
        private System.Windows.Forms.CheckBox checkBox_RK_LTE;
        private System.Windows.Forms.CheckBox checkBox_IE_LTE;
        private System.Windows.Forms.CheckBox checkBox_E_LTE;
        private System.Windows.Forms.CheckBox checkBox_RK_GTE;
        private System.Windows.Forms.CheckBox checkBox_IE_GTE;
        private System.Windows.Forms.CheckBox checkBox_E_GTE;
        private System.Windows.Forms.Label Text_n0;
        private System.Windows.Forms.Panel panel1;
    }
}

