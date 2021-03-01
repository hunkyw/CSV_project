using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int num = 4096;
            munBox.Text = Convert.ToString(num.ToString("G"));
        }

        private void makechart_Click(object sender, EventArgs e)
        {
            
            int num = (int)Convert.ToSingle(munBox.Text);
            munBox.Text = Convert.ToString(num.ToString("G"));
            //List<List<double>> RETa = CSV.wavefunction.rectangle1(num,100, 0, 800, 1, 4E-05, 2.9E-09, 2.9E-09);//传入波的各项参数
            //List<List<double>> RETb = CSV.wavefunction.rectangle1(num,80, 0, 800, 1, 4E-05, 2.9E-09, 2.9E-09);//传入波的各项参数
            //List<List<double>> RET = CSV.wavefunction.range(1, 1.00286, RETa,RETb);//传入x1,x2作为起止值
            //List<double> xData = RET[0];
            //List<double> yData = RET[1];
            List<List<double>> RETa = CSV.wavefunction.rectangle(100, 0, 1000, 0, 0.5);//传入波的各项参数
            List<List<double>> RETb = CSV.wavefunction.rectangle(800, 0, 1000, 0, 0.5);//传入波的各项参数
            
            List<double> xData = RETa[0];
            List<double> xData1 = RETb[0];
            List<double> xData2 = xData.Concat(xData1).ToList<double>();
            List<double> yData = RETa[1];
            List<double> yData1 = RETb[1];
            List<double> yData2 = yData.Concat(yData1).ToList<double>();
            //线条颜色
            firstChart.Series[0].Color = Color.Green;
            firstChart.Series[0].ChartType = SeriesChartType.Spline;
            //线条粗细
            firstChart.Series[0].BorderWidth = 3;
            firstChart.Series[0].Points.DataBindXY(xData2, yData2);
        }

    }
}
