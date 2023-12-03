using LibraryFrameworkEllipticIntegrals20nov2023;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFrameworkEllipticIntegrals20nov2023
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
            chart.Location = new Point(0, 70);
            chart.Name = "chart";
            chart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            chart.Size = new Size(800, 400);
            chart.TabIndex = 0;
            chart.Text = "chart";
            Controls.Add(chart);

            comboBox1.Items.AddRange(new string[] { "Elliptic integral of the first kind: K(k)", "Elliptic integral of the second kind: E(k) " });
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart.Series != null) chart.Series.Clear();

            Series serie = new Series();

            serie.ChartType = SeriesChartType.Point;
            serie.Name = "serie";

            EllipticIntegralCalculator20nov2023 calculator = new EllipticIntegralCalculator20nov2023();

            double x_minimum = 0;
            double x_maximum = 0.999;

            const int N = 1000; // aantal punten in grafiek.

            for (int k = 0; k <= N; k++)
            {
                double x = (x_maximum - x_minimum) * ((double)k / N) + x_minimum;
                double y;

                if (comboBox1.SelectedIndex == 0)
                {
                    y = calculator.EllipticIntegralK(x);
                }
                else // if (comboBox1.SelectedIndex == 1)
                {
                    y = calculator.EllipticIntegralE(x);
                }

                serie.Points.Add(new DataPoint(x, y));
            }
            chart.Series.Add(serie);
        }
    }
}
