
namespace CSV
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.firstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.noiseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.makechart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.munBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // firstChart
            // 
            chartArea5.Name = "ChartArea1";
            this.firstChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.firstChart.Legends.Add(legend5);
            this.firstChart.Location = new System.Drawing.Point(361, 45);
            this.firstChart.Name = "firstChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.firstChart.Series.Add(series5);
            this.firstChart.Size = new System.Drawing.Size(1056, 442);
            this.firstChart.TabIndex = 0;
            this.firstChart.Text = "chart1";
            // 
            // noiseChart
            // 
            chartArea6.Name = "ChartArea1";
            this.noiseChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.noiseChart.Legends.Add(legend6);
            this.noiseChart.Location = new System.Drawing.Point(361, 513);
            this.noiseChart.Name = "noiseChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.noiseChart.Series.Add(series6);
            this.noiseChart.Size = new System.Drawing.Size(1056, 464);
            this.noiseChart.TabIndex = 1;
            this.noiseChart.Text = "chart2";
            // 
            // makechart
            // 
            this.makechart.Location = new System.Drawing.Point(116, 121);
            this.makechart.Name = "makechart";
            this.makechart.Size = new System.Drawing.Size(138, 42);
            this.makechart.TabIndex = 2;
            this.makechart.Text = "生成曲线";
            this.makechart.UseVisualStyleBackColor = true;
            this.makechart.Click += new System.EventHandler(this.makechart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "采样点";
            // 
            // munBox
            // 
            this.munBox.Location = new System.Drawing.Point(116, 78);
            this.munBox.Name = "munBox";
            this.munBox.Size = new System.Drawing.Size(100, 28);
            this.munBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 1024);
            this.Controls.Add(this.munBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makechart);
            this.Controls.Add(this.noiseChart);
            this.Controls.Add(this.firstChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.firstChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart firstChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart noiseChart;
        private System.Windows.Forms.Button makechart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox munBox;
    }
}

