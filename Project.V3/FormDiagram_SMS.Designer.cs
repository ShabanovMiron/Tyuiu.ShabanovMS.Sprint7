
namespace Project.V3
{
    partial class FormDiagram_SMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartControlTypeKrug_SMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartControlTypePalka_SMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTypeKrug_SMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTypePalka_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControlTypeKrug_SMS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartControlTypeKrug_SMS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControlTypeKrug_SMS.Legends.Add(legend1);
            this.chartControlTypeKrug_SMS.Location = new System.Drawing.Point(12, 12);
            this.chartControlTypeKrug_SMS.Name = "chartControlTypeKrug_SMS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartControlTypeKrug_SMS.Series.Add(series1);
            this.chartControlTypeKrug_SMS.Size = new System.Drawing.Size(448, 445);
            this.chartControlTypeKrug_SMS.TabIndex = 1;
            this.chartControlTypeKrug_SMS.Text = "chart2";
            // 
            // chartControlTypePalka_SMS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartControlTypePalka_SMS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartControlTypePalka_SMS.Legends.Add(legend2);
            this.chartControlTypePalka_SMS.Location = new System.Drawing.Point(477, 13);
            this.chartControlTypePalka_SMS.Name = "chartControlTypePalka_SMS";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartControlTypePalka_SMS.Series.Add(series2);
            this.chartControlTypePalka_SMS.Size = new System.Drawing.Size(504, 444);
            this.chartControlTypePalka_SMS.TabIndex = 2;
            this.chartControlTypePalka_SMS.Text = "chart1";
            // 
            // FormDiagram_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 469);
            this.Controls.Add(this.chartControlTypePalka_SMS);
            this.Controls.Add(this.chartControlTypeKrug_SMS);
            this.Name = "FormDiagram_SMS";
            this.Text = "Диаграммы";
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTypeKrug_SMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTypePalka_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControlTypeKrug_SMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControlTypePalka_SMS;
    }
}