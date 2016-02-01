using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;

namespace LineRegressionPrediction
{
    public partial class MainForm : Form
    {
        List<Point> dataSet = new List<Point>();
        List<Point> learningSet = new List<Point>();
        List<Point> testingSet = new List<Point>();

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

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileData.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dataSet.Clear();
                var lines = File.ReadLines(openFileData.FileName);
                foreach (var line in lines)
                {
                    var values = line.Split(';');
                    dataSet.Add(new Point(double.Parse(values[0]), double.Parse(values[1])));
                }
            }
            labelDataCount.Text = "Liczba danych: " + dataSet.Count;
            numericLearningCount.Minimum = 1;
            numericLearningCount.Maximum = dataSet.Count - 1;
            numericLearningCount.Value = (int)(0.6f * dataSet.Count);
            drawPoints();
        }

        private void drawPoints()
        {
            Series pointSeries = new Series
            {
                ChartType = SeriesChartType.Point,
                Color = System.Drawing.Color.SeaGreen,
                Name = "Punkty"
            };
            foreach (Point point in dataSet)
            {
                pointSeries.Points.AddXY(point.X, point.Y);
            }
            mainChart.Series.Add(pointSeries);
        }

        private void numericLearningCount_ValueChanged(object sender, EventArgs e)
        {
            labelTestCount.Text = "Liczba w zbiorze testowym: " + (dataSet.Count - numericLearningCount.Value);
        }
    }

    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
