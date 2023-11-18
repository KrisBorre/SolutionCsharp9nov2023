using LibraryFrameworkInterpolation17nov2023;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFrameworkInterpolation17nov2023
{
    public partial class Form1 : Form
    {
        private Chart chart;

        public Form1()
        {
            InitializeComponent();

            // Add Reference -> Assemblies -> Framework -> System.Windows.Forms.DataVisualization -> check -> Ok

            chart = new Chart();

            ChartArea chartArea = new ChartArea();
            chartArea.Name = "ChartArea";
            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "Y";
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(0, 60);
            chart.Name = "chart";
            chart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            chart.Size = new Size(800, 450 - 40);
            chart.TabIndex = 0;
            chart.Text = "chart";

            Controls.Add(chart);

            comboBox1.Items.AddRange(new string[] { "Dataset 1", "Dataset 2", "Dataset 3", "Dataset 4", "Dataset 5" });
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new string[] { "Linear", "Poly", "Rat", "Spline" });
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interpolate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interpolate();
        }

        private void Interpolate()
        {
            if (chart.Series != null) chart.Series.Clear();

            Series seriesData = new Series();
            Series seriesInterpolation = new Series();

            seriesInterpolation.ChartArea = "ChartArea";
            seriesData.ChartType = SeriesChartType.Point;
            seriesData.Name = "seriesData";
            seriesInterpolation.ChartType = SeriesChartType.Point;
            seriesInterpolation.Name = "seriesInterpolation";

            double x_minimum = -0.5;
            double x_maximum = 10.5;

            double[] x = null;
            double[] y = null;

            if (comboBox1.SelectedIndex == 0)
            {
                int n = 10;
                x = new double[n];
                y = new double[n];

                for (int i = 0; i < n; i++)
                {
                    x[i] = i;
                    y[i] = Math.Sin(x[i] / 6.0) + x[i] / 4.0;
                    seriesData.Points.Add(new DataPoint(x[i], y[i]));
                }

                x_minimum = -0.5;
                x_maximum = 10.5;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int n2 = 6;
                x = new double[n2];
                y = new double[n2];

                for (int i = 0; i < n2; i++)
                {
                    x[i] = i;
                    y[i] = -Math.Sin(x[i] / 8.0) + x[i] / 6.0;
                    seriesData.Points.Add(new DataPoint(x[i], y[i]));
                }

                x_minimum = 0;
                x_maximum = 6.0;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int n3 = 10;
                x = new double[n3];
                y = new double[n3];

                for (int i = 0; i < n3; i++)
                {
                    x[i] = i;
                    y[i] = Math.Tan(x[i] / 6.0) + x[i] / 4.0;
                    seriesData.Points.Add(new DataPoint(x[i], y[i]));
                }

                x_minimum = 0;
                x_maximum = 10;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int n4 = 5;
                x = new double[n4];
                y = new double[n4];

                for (int i = 0; i < n4; i++)
                {
                    x[i] = i + 1.0;
                    y[i] = Math.Sin(x[i] / 9.0) - x[i] / 3.0;
                    seriesData.Points.Add(new DataPoint(x[i], y[i]));
                }

                x_minimum = 0;
                x_maximum = 6;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                int n5 = 7;
                x = new double[n5];
                y = new double[n5];

                for (int i = 0; i < n5; i++)
                {
                    x[i] = i;
                    y[i] = -Math.Sin(x[i] / 7.0) + x[i] / 6.0;
                    seriesData.Points.Add(new DataPoint(x[i], y[i]));
                }

                x_minimum = 0.2;
                x_maximum = 7.8;
            }


            if (x != null && x.Length > 0)
            {
                InterpolationAbstractClass7oct2023 myfunc = null;

                if (comboBox2.SelectedIndex == 0)
                {
                    myfunc = new InterpolationLinear7oct2023(x, y);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    myfunc = new InterpolationPoly7oct2023(x, y, 2);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    myfunc = new InterpolationRat7oct2023(x, y, 4);
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    myfunc = new InterpolationSpline7oct2023(x, y);
                }

                if (myfunc != null)
                {
                    const int N = 53;
                    for (int i = 0; i <= N; i++)
                    {
                        double x_interp = (x_maximum - x_minimum) * ((double)i / N) + x_minimum;
                        double y_interp = myfunc.Interp(x_interp);

                        seriesInterpolation.Points.Add(new DataPoint(x_interp, y_interp));
                    }
                }

                chart.Series.Add(seriesData);
                chart.Series.Add(seriesInterpolation);
            }

        }

    }
}
