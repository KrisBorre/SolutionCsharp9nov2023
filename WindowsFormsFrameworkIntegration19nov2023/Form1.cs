using LibraryFrameworkFunctionExamples19nov2023;
using LibraryFrameworkIntegration19nov2023;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFrameworkIntegration19nov2023
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
            chart.Location = new Point(0, 80);
            chart.Name = "chart";
            chart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            chart.Size = new Size(800, 400);
            chart.TabIndex = 0;
            chart.Text = "chart";

            Controls.Add(chart);

            comboBox1.Items.AddRange(new string[] { "Square function: " + (new Square7oct2023()).ToString(),
                "Constant Times Power with 4 and 0.5: " + (new ConstantTimesPower7oct2023(4.0, 0.5)).ToString(),
                "Sinus: " + (new Sinus7oct2023()).ToString(),
                "Integrand1 with 0.5: " + (new Integrand1_7oct2023(0.5)).ToString(),
                "Integrand2 with 0.5 and 4: " + (new Integrand2_7oct2023(power1: 0.5, power2: 4)).ToString() });
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new string[] { "Trapezoidal method from 0 to 1",
                "Midpoint method from 0 to 1",
                "Trapezoidal method from 0 to pi",
                "Midpoint method from 0 to pi" });
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Integrate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Integrate();
        }

        private void Integrate()
        {
            if (chart.Series != null) chart.Series.Clear();

            Series serie = new Series();

            serie.ChartType = SeriesChartType.Point;
            serie.Name = "serie";

            IntegrandAbstractClass7oct2023 function = null;

            if (comboBox1.SelectedIndex == 0)
            {
                function = new Square7oct2023();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                function = new ConstantTimesPower7oct2023(4.0, 0.5);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                function = new Sinus7oct2023();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                function = new Integrand1_7oct2023(0.5);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                function = new Integrand2_7oct2023(power1: 0.5, power2: 4);
            }

            if (function != null)
            {
                IntegrationAbstractClass7oct2023 problem = null;
                double x_minimum = 0;
                double x_maximum = 1;

                if (comboBox2.SelectedIndex == 0)
                {
                    problem = new IntegrationTrapezoidal7oct2023(function, 0.0, 1.0);
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    problem = new IntegrationMidpoint7oct2023(function, 0.0, 1.0);
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    problem = new IntegrationTrapezoidal7oct2023(function, 0.0, Math.PI);
                    x_maximum = Math.PI;
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    problem = new IntegrationMidpoint7oct2023(function, 0.0, Math.PI);
                    x_maximum = Math.PI;
                }

                if (problem != null)
                {
                    const int N = 1000; // aantal punten in grafiek.

                    for (int k = 0; k <= N; k++)
                    {
                        double x = (x_maximum - x_minimum) * ((double)k / N) + x_minimum;
                        serie.Points.Add(new DataPoint(x, function.Function(x)));
                    }
                    chart.Series.Add(serie);

                    for (int i = 0; i < 10; i++)
                    {
                        problem.Next();
                    }

                    label3.Text = problem.ToString();
                }
            }
        }
    }
}
