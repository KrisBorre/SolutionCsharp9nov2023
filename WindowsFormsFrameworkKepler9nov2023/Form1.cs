using LibraryFrameworkDifferentialEquationKepler9nov2023;
using LibraryFrameworkDifferentialEquations9nov2023;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFrameworkKepler9nov2023
{
    public partial class Form1 : Form
    {
        private Chart chart;

        public Form1()
        {
            InitializeComponent();

            // Add Reference -> Assemblies -> Framework -> System.Windows.Forms.DataVisualization -> check

            // Kepler's planetary motion.
            // Planet moves around the Sun in an elliptic orbit.
            // The equations of motion are ordinary differential equations and are numerically calculated using a Runge-Kutta method.
            // Comparison between crude Runge-Kutta calculation and sophisticated Runge-Kutta calculation.
            // The graph shows the numerical error of the calculation as a function of the stepsize for both, crude and sophisticated.
            // As the stepsize decrease the numerical error gets smaller until it reaches machine-epsilon using sophisticated Runge-Kutta.
            // When we use a Runge-Kutta algorithm - which I call crude Runge-Kutta - and continue to lower the stepsize in an attempt to improve the accuracy of the result, the accumulation of the numerical error starts to dominate over the solution, rendering our computational effort worthless.
            // We can study this pathological behaviour when we use a system of differential equations that we can solve analytically.
            // An Euler method or a higher order method will both have a similar accumulation error for a certain stepsize.
            // We can correct for this accumulation of numerical errors and I call this method sophisticated Runge-Kutta.
            // You read this graph from top-left to bottom-right.
            // With a large stepsize the error on the solution decreases when the stepsize is reduced.

            Text = "Sophisticated Runge-Kutta versus crude Runge-Kutta for Kepler's elliptic planetary motion";

            ChartArea chartArea = new ChartArea();
            Series series1 = new Series();
            Series series2 = new Series();

            chart = new Chart();
            chartArea.Name = "chartArea";

            chartArea.AxisX.Title = "Log10(delta_x)";
            chartArea.AxisY.Title = "Log10(abs(error))";
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.ChartArea = "chartArea";
            series1.ChartType = SeriesChartType.Point;
            series1.Name = "series1";

            series2.ChartArea = "chartArea";
            series2.ChartType = SeriesChartType.Point;
            series2.Name = "series2";

            const int kmax = 12; // 15; 

            const double eccentricity = 3.0 / 4.0; // 0.5; // 0;
            Console.WriteLine("eccentricity of the elliptic trajectory of the planet = " + eccentricity);

            DifferentialEquationsSolverBaseClass solver = new DifferentialEquationsSolverRK41_5nov2023(new DifferentialEquationsKepler());

            double interval = Math.PI;

            ulong number_of_steps = 200;

            for (int k = 0; k < kmax; k++)
            {
                Console.WriteLine("number_of_steps = " + number_of_steps);

                ConditionInitial ic = new ConditionInitial(0,
                                                         y1_zero_exact_function(eccentricity),
                                                         y2_zero_exact_function(eccentricity),
                                                         y3_zero_exact_function(eccentricity),
                                                         y4_zero_exact_function(eccentricity));
                //ic.X = 0;

                solver.Solve(initialCondition: ic, number_of_steps: number_of_steps, delta_x: out double delta_x, out NumericalSolution solutionSophisticated, interval: interval, sophisticated: true);
                solver.Solve(initialCondition: ic, number_of_steps: number_of_steps, delta_x: out double delta_x_crude, out NumericalSolution solutionCrude, interval: interval, sophisticated: false);

                double y1_pi_exact = y1_pi_exact_function(eccentricity);
                double y2_pi_exact = y2_pi_exact_function(eccentricity);
                double y3_pi_exact = y3_pi_exact_function(eccentricity);
                double y4_pi_exact = y4_pi_exact_function(eccentricity);

                double[] y_sophisticated = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    y_sophisticated[i] = solutionSophisticated.Y[i];
                }

                double[] y_crude = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    y_crude[i] = solutionCrude.Y[i];
                }

                double error_sophisticated = sqrt(Math.Pow((y1_pi_exact - y_sophisticated[0]), 2) + Math.Pow((y2_pi_exact - y_sophisticated[1]), 2) + Math.Pow((y3_pi_exact - y_sophisticated[2]), 2) + Math.Pow((y4_pi_exact - y_sophisticated[3]), 2));
                Console.WriteLine("error_sophisticated = " + error_sophisticated);

                double error_crude = sqrt(Math.Pow((y1_pi_exact - y_crude[0]), 2) + Math.Pow((y2_pi_exact - y_crude[1]), 2) + Math.Pow((y3_pi_exact - y_crude[2]), 2) + Math.Pow((y4_pi_exact - y_crude[3]), 2));
                Console.WriteLine("error_crude = " + error_crude);

                series1.Points.Add(new DataPoint(Math.Log10(delta_x), Math.Log10(abs(error_sophisticated))));
                series2.Points.Add(new DataPoint(Math.Log10(delta_x), Math.Log10(abs(error_crude))));

                number_of_steps *= 2;
            }

            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);

            chart.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);

            chart.TabIndex = 0;
            chart.Text = "chart";

            Controls.Add(chart);
        }


        static double sqrt(double x)
        {
            return Math.Pow(x, 0.5);
        }

        static double abs(double x)
        {
            return Math.Abs(x);
        }


        static double y1_zero_exact_function(double eccentricity)
        {
            return 1.0 - eccentricity;
        }

        static double y2_zero_exact_function(double eccentricity)
        {
            return 0.0;
        }

        static double y3_zero_exact_function(double eccentricity)
        {
            return 0.0;
        }

        static double y4_zero_exact_function(double eccentricity)
        {
            return sqrt((1.0 + eccentricity) / (1.0 - eccentricity));
        }


        static double y1_pi_exact_function(double eccentricity)
        {
            return -1.0 - eccentricity;
        }

        static double y2_pi_exact_function(double eccentricity)
        {
            return 0.0;
        }

        static double y3_pi_exact_function(double eccentricity)
        {
            return 0.0;
        }

        static double y4_pi_exact_function(double eccentricity)
        {
            return -sqrt((1.0 - eccentricity) / (1.0 + eccentricity)); // Notice the minus and plus sign!
        }

    }
}
