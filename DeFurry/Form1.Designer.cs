
namespace DeFurry
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.value_y0 = new System.Windows.Forms.TextBox();
            this.value_x0 = new System.Windows.Forms.TextBox();
            this.value_X = new System.Windows.Forms.TextBox();
            this.value_N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_S = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_GoS = new System.Windows.Forms.Button();
            this.button_LTE = new System.Windows.Forms.Button();
            this.button_GTE = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.value_N0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Exact Solution";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Euler";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "ImpEuler";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "RK";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(650, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Graph of solutions";
            this.chart1.Titles.Add(title1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(650, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "y\' = y/x - y - x";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // value_y0
            // 
            this.value_y0.Location = new System.Drawing.Point(668, 109);
            this.value_y0.Name = "value_y0";
            this.value_y0.Size = new System.Drawing.Size(100, 20);
            this.value_y0.TabIndex = 3;
            this.value_y0.Text = "0";
            // 
            // value_x0
            // 
            this.value_x0.Location = new System.Drawing.Point(668, 162);
            this.value_x0.Name = "value_x0";
            this.value_x0.Size = new System.Drawing.Size(100, 20);
            this.value_x0.TabIndex = 5;
            this.value_x0.Text = "1";
            // 
            // value_X
            // 
            this.value_X.Location = new System.Drawing.Point(669, 215);
            this.value_X.Name = "value_X";
            this.value_X.Size = new System.Drawing.Size(100, 20);
            this.value_X.TabIndex = 7;
            this.value_X.Text = "10";
            // 
            // value_N
            // 
            this.value_N.Location = new System.Drawing.Point(669, 268);
            this.value_N.Name = "value_N";
            this.value_N.Size = new System.Drawing.Size(100, 20);
            this.value_N.TabIndex = 9;
            this.value_N.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(668, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "y0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(668, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "x0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(668, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(668, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "N";
            // 
            // button_S
            // 
            this.button_S.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_S.Location = new System.Drawing.Point(668, 309);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(100, 28);
            this.button_S.TabIndex = 14;
            this.button_S.Text = "Submit";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 41);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Exact Solution";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Euler";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "ImpEuler";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "RK";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(650, 400);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "LTE";
            this.chart2.Titles.Add(title2);
            this.chart2.Visible = false;
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
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(13, 41);
            this.chart3.Name = "chart3";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Exact Solution";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Euler";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "ImpEuler";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series12.Legend = "Legend1";
            series12.Name = "RK";
            this.chart3.Series.Add(series9);
            this.chart3.Series.Add(series10);
            this.chart3.Series.Add(series11);
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(650, 400);
            this.chart3.TabIndex = 20;
            this.chart3.Text = "chart3";
            title3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "GTE";
            this.chart3.Titles.Add(title3);
            this.chart3.Visible = false;
            // 
            // value_N0
            // 
            this.value_N0.Location = new System.Drawing.Point(669, 215);
            this.value_N0.Name = "value_N0";
            this.value_N0.Size = new System.Drawing.Size(100, 20);
            this.value_N0.TabIndex = 21;
            this.value_N0.Text = "1";
            this.value_N0.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(783, 499);
            this.Controls.Add(this.value_N0);
            this.Controls.Add(this.button_GTE);
            this.Controls.Add(this.button_LTE);
            this.Controls.Add(this.button_GoS);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value_N);
            this.Controls.Add(this.value_X);
            this.Controls.Add(this.value_x0);
            this.Controls.Add(this.value_y0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox value_y0;
        private System.Windows.Forms.TextBox value_x0;
        private System.Windows.Forms.TextBox value_X;
        private System.Windows.Forms.TextBox value_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Button button_GoS;
        private System.Windows.Forms.Button button_LTE;
        private System.Windows.Forms.Button button_GTE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox value_N0;
    }
}

