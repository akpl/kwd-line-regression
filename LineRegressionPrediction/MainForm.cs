using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace LineRegressionPrediction
{
    public partial class MainForm : Form
    {
        List<Point> dataSet = new List<Point>();
        List<Point> learningSet = new List<Point>();
        List<Point> testingSet = new List<Point>();
        double beta0 = 0, beta1 = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            groupUnkown.Enabled = true;
            linearRegression();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileData.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dataSet.Clear();
                try
                {
                    var lines = File.ReadLines(openFileData.FileName);
                    foreach (var line in lines)
                    {
                        var values = line.Split(';');
                        dataSet.Add(new Point(double.Parse(values[0]), double.Parse(values[1])));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Exception while loading data:" + Environment.NewLine + ex.ToString(), "Error reading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                labelDataCount.Text = "Liczba danych: " + dataSet.Count;
                groupUnkown.Enabled = false;
                if (dataSet.Count >= 3)
                {
                    numericLearningCount.Minimum = 2;
                    numericLearningCount.Maximum = dataSet.Count - 1;
                    numericLearningCount.Value = Math.Min(Math.Max((int)(0.6f * dataSet.Count), numericLearningCount.Minimum), numericLearningCount.Maximum);
                    drawButton.Enabled = true;
                    numericLearningCount.Enabled = true;
                    
                }
                else
                {
                    drawButton.Enabled = false;
                    numericLearningCount.Enabled = false;
                    MessageBox.Show("Program do poprawnego działania wymaga minimum 3 danych. Załadowano: " + dataSet.Count + " danych.", "Zbyt mała liczba danych");
                }
            }
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

        private void linearRegression()
        {
            learningSet = dataSet.GetRange(0, (int)numericLearningCount.Value);
            testingSet = dataSet.GetRange((int)numericLearningCount.Value, dataSet.Count - (int)numericLearningCount.Value);
            double sum1 = 0, sum2 = 0, avgX = 0, avgY = 0, sst = 0, ssr = 0, sse = 0;
            foreach (Point point in learningSet)
            {
                avgX += point.X;
                avgY += point.Y;
            }
            avgX /= learningSet.Count;
            avgY /= learningSet.Count;

            foreach (Point point in learningSet)
            {
                sum1 += (point.Y - avgY) * (point.X - avgX);
                sum2 += Math.Pow(point.X - avgX, 2);
            }

            beta1 = sum1 / sum2;
            beta0 = avgY - beta1 * avgX;

            foreach (Point point in learningSet)
            {
                double estimatedY = beta0 + beta1 * point.X;
                sst += Math.Pow(point.Y - avgY, 2);
                ssr += Math.Pow(estimatedY - avgY, 2);
                sse += Math.Pow(point.Y - estimatedY, 2);
            }

            double r2 = ssr / sst;
            double r2b = 1d - sse / sst;

            labelB0.Text = Math.Round(beta0, 4).ToString();
            labelB1.Text = Math.Round(beta1, 4).ToString();
            labelR2.Text = Math.Round(r2, 4).ToString();

            mainChart.Series.Clear();

            //draw learing set
            Series pointSeries = new Series
            {
                ChartType = SeriesChartType.Point,
                Color = System.Drawing.Color.SeaGreen,
                Name = "Zbiór uczący",
                MarkerStyle = MarkerStyle.Square
            };
            foreach (Point point in learningSet)
            {
                pointSeries.Points.AddXY(point.X, point.Y);
            }
            mainChart.Series.Add(pointSeries);

            //draw testing set
            Series testingPointSeries = new Series
            {
                ChartType = SeriesChartType.Point,
                Color = System.Drawing.Color.DarkOrchid,
                Name = "Zbiór testowy",
                MarkerStyle = MarkerStyle.Circle
            };
            foreach (Point point in testingSet)
            {
                testingPointSeries.Points.AddXY(point.X, point.Y);
            }
            mainChart.Series.Add(testingPointSeries);

            //draw linear regression
            Series lineSeries = new Series
            {
                ChartType = SeriesChartType.Line,
                Name = "Regresja linowa"
            };
            foreach (Point point in dataSet)
            {
                lineSeries.Points.AddXY(point.X, beta0 + beta1 * point.X);
            }
            mainChart.Series.Add(lineSeries);
        }

        private void numericLearningCount_ValueChanged(object sender, EventArgs e)
        {
            labelTestCount.Text = "Liczba w zbiorze testowym: " + (dataSet.Count - numericLearningCount.Value);
        }

        private void numericUnkownX_ValueChanged(object sender, EventArgs e)
        {
            double unkownX = (double)numericUnkownX.Value;
            double unkownY = beta0 + beta1 * unkownX;
            numericUnkownY.Value = (decimal)unkownY;
            Series unkownSeries = new Series
            {
                ChartType = SeriesChartType.Point,
                Color = System.Drawing.Color.DarkBlue,
                Name = "Unkown",
                MarkerStyle = MarkerStyle.Cross,
                MarkerSize = 10
            };
            unkownSeries.Points.AddXY(unkownX, unkownY);
            if (mainChart.Series.Count == 3)
                mainChart.Series.Add(unkownSeries);
            else
                mainChart.Series[3] = unkownSeries;

            //redraw linear regression
            Series lineSeries = mainChart.Series[2];
            lineSeries.Points.Clear();
            lineSeries.Points.AddXY(unkownX, unkownY);
            foreach (Point point in dataSet)
            {
                lineSeries.Points.AddXY(point.X, beta0 + beta1 * point.X);
            }

            mainChart.ChartAreas[0].RecalculateAxesScale();
            mainChart.Invalidate();
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
