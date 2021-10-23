
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series57 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series58 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series59 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series60 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            chartArea16.AxisX.MajorGrid.Enabled = false;
            chartArea16.AxisX.Title = "X";
            chartArea16.AxisY.MajorGrid.Enabled = false;
            chartArea16.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea16.AxisY.Title = "Y";
            chartArea16.Name = "ChartArea1";
            this.GS_chart.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.GS_chart.Legends.Add(legend16);
            this.GS_chart.Location = new System.Drawing.Point(12, 41);
            this.GS_chart.Name = "GS_chart";
            series51.BorderWidth = 2;
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series51.EmptyPointStyle.IsValueShownAsLabel = true;
            series51.Font = null;
            series51.LabelBorderWidth = 2;
            series51.Legend = "Legend1";
            series51.Name = "Exact solution";
            series52.BorderWidth = 2;
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series52.Font = null;
            series52.LabelBorderWidth = 2;
            series52.Legend = "Legend1";
            series52.Name = "Euler";
            series53.BorderWidth = 2;
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series53.Font = null;
            series53.LabelBorderWidth = 2;
            series53.Legend = "Legend1";
            series53.Name = "ImpEuler";
            series54.BorderWidth = 2;
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series54.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series54.Font = null;
            series54.LabelBorderWidth = 2;
            series54.Legend = "Legend1";
            series54.Name = "RK";
            this.GS_chart.Series.Add(series51);
            this.GS_chart.Series.Add(series52);
            this.GS_chart.Series.Add(series53);
            this.GS_chart.Series.Add(series54);
            this.GS_chart.Size = new System.Drawing.Size(650, 400);
            this.GS_chart.TabIndex = 0;
            this.GS_chart.Text = "chart1";
            title16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title16.Name = "Title1";
            title16.Text = "Graph of solutions";
            this.GS_chart.Titles.Add(title16);
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
            chartArea17.AxisX.MajorGrid.Enabled = false;
            chartArea17.AxisX.Title = "x";
            chartArea17.AxisY.MajorGrid.Enabled = false;
            chartArea17.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea17.AxisY.Title = "E";
            chartArea17.Name = "ChartArea1";
            this.LTE_chart.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.LTE_chart.Legends.Add(legend17);
            this.LTE_chart.Location = new System.Drawing.Point(12, 41);
            this.LTE_chart.Name = "LTE_chart";
            series55.BorderWidth = 2;
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series55.Legend = "Legend1";
            series55.Name = "Euler";
            series56.BorderWidth = 2;
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series56.Legend = "Legend1";
            series56.Name = "ImpEuler";
            series57.BorderWidth = 2;
            series57.ChartArea = "ChartArea1";
            series57.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series57.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series57.Legend = "Legend1";
            series57.Name = "RK";
            this.LTE_chart.Series.Add(series55);
            this.LTE_chart.Series.Add(series56);
            this.LTE_chart.Series.Add(series57);
            this.LTE_chart.Size = new System.Drawing.Size(650, 400);
            this.LTE_chart.TabIndex = 15;
            this.LTE_chart.Text = "chart2";
            title17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title17.Name = "Title1";
            title17.Text = "LTE";
            this.LTE_chart.Titles.Add(title17);
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
            chartArea18.AxisX.MajorGrid.Enabled = false;
            chartArea18.AxisX.Title = "N";
            chartArea18.AxisY.MajorGrid.Enabled = false;
            chartArea18.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea18.AxisY.Title = "En";
            chartArea18.Name = "ChartArea1";
            this.GTE_chart.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.GTE_chart.Legends.Add(legend18);
            this.GTE_chart.Location = new System.Drawing.Point(13, 41);
            this.GTE_chart.Name = "GTE_chart";
            series58.BorderWidth = 2;
            series58.ChartArea = "ChartArea1";
            series58.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series58.Legend = "Legend1";
            series58.Name = "Euler";
            series59.BorderWidth = 2;
            series59.ChartArea = "ChartArea1";
            series59.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series59.Legend = "Legend1";
            series59.Name = "ImpEuler";
            series60.BorderWidth = 2;
            series60.ChartArea = "ChartArea1";
            series60.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series60.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series60.Legend = "Legend1";
            series60.Name = "RK";
            this.GTE_chart.Series.Add(series58);
            this.GTE_chart.Series.Add(series59);
            this.GTE_chart.Series.Add(series60);
            this.GTE_chart.Size = new System.Drawing.Size(650, 400);
            this.GTE_chart.TabIndex = 20;
            this.GTE_chart.Text = "chart3";
            title18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title18.Name = "Title1";
            title18.Text = "GTE";
            this.GTE_chart.Titles.Add(title18);
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
            this.Name = "Comp_Pract";
            this.Text = "Form1";
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

