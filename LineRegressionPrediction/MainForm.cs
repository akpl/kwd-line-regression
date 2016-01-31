using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LineRegressionPrediction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            double y0 = Convert.ToDouble(beta0Field.Value);
            double y1 = Convert.ToDouble(beta0Field.Value) + Convert.ToDouble(beta1Field.Value);
            mainChart.Series.Clear();

            Series lineSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Regresja linowa"
            };
            lineSeries.Points.AddXY(0, y0);
            lineSeries.Points.AddXY(1, y1);
            mainChart.Series.Add(lineSeries);
        }
    }
}
