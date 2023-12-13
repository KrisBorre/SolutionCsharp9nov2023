﻿using LibraryFrameworkDifferentialEquationDog9nov2023;
using LibraryFrameworkDifferentialEquations9nov2023;
using SolutionCsharp9nov2023;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsFrameworkDogTextBox13dec2023
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Chart chart;
        private TextBox textBox1;
        private Button button1;
        private Label label2;

        public Form1()
        {
            InitializeComponent();

            // Add Reference -> Assemblies -> Framework -> System.Windows.Forms.DataVisualization -> check -> Ok

            this.Text = "Solving a system of differential equations: master-and-dog problem.";

            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.label2 = new Label();

            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(653, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 22);
            this.textBox1.TabIndex = 0;

            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new MouseEventHandler(this.button1_MouseClick);

            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ratio:";

            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(46, 18);
            this.label1.TabIndex = 0;

            this.label1.Text = "Solving a system of differential equations: master-and-dog problem.";

            this.chart = new Chart();

            this.chart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);

            this.chart.Size = new Size(800, 450 - 40);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";

            ChartArea chartArea = new ChartArea();
            chartArea.Name = "chartArea";

            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "Y";
            chart.ChartAreas.Add(chartArea);
            chart.Location = new Point(0, 40);
            chart.Name = "chart";

            const double ratio = 1.0 / 2; // v / w
                                          // Dog is twice as fast as the master.

            System.Globalization.NumberFormatInfo provider = new System.Globalization.NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            this.textBox1.Text = ratio.ToString(provider);

            this.Calculate(ratio);

            Controls.Add(chart);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string input = textBox1.Text;

            System.Globalization.NumberFormatInfo provider = new System.Globalization.NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            if (double.TryParse(s: input, style: System.Globalization.NumberStyles.AllowDecimalPoint, provider: provider, result: out double ratio))
            {
                this.Calculate(ratio);
            }
        }

        private void Calculate(double ratio)
        {
            Console.WriteLine("Don’t wait for your feelings to change to take the action. Take the action and your feelings will change.");

            // Solving ODEs I (2000) page 14 master-and-dog problem
            // We solve 2 first order differential equations using a sophisticated RK61 method with f(x, y) dependency. For RK61 see page 194 Butcher (2008)

            // A master and her dog are going for a walk and the dog runs towards the master with the intent to join.
            // The dog is in the graph at the top-right. The master walks from the bottom-left along the y-axis. The dog runs straight to the master.
            // Probably because during previous walks she waited to let the dog reach her, but now she doesn't stop and continues to walk.
            // The result is that the dog will run in an arc towards his master.

            // If the dog is twice as fast as the master, then the ratio is 0.5.
            // The ratio is v / w
            // You can type a ratio in the TextBox and press the Calculate Button.
            // We stop calculating when the dog reaches the master.

            // https://mathcurve.com/courbes2d.gb/poursuite/poursuite.shtml           

            ulong number_of_steps = 1000;
            Console.WriteLine("master-and-dog problem with enum");

            DifferentialEquationsSolver13dec2023 solver = new DifferentialEquationsSolver13dec2023(new DifferentialEquationsDog10nov2023(ratio), Method.RK61);

            double b = 0; // 1.0; //-1.0; // 0; //-1.0; // This is the location where the master starts walking.
            //y1[0] = 0.0; // This is the location where the master starts walking.
            //y2[0] = 0.0;

            // This is the distance at the outset of the problem between the dog and the master.
            const double a = 1.0; // This is the location where the dog starts running.
            double x_end = 0;
            double interval = Math.Abs(x_end - a); // 1.0; // interval is from 1 to 0
            const double c = -1; // 1; // 0;
            ConditionInitial ic = new ConditionInitial(a, b, c);
            //ic.X = a; // x_begin                

            solver.Solve(initialCondition: ic, number_of_steps: number_of_steps, out double delta_x, out NumericalSolutions solutions, number_of_solutions: 1000, interval: interval, sophisticated: true, x_end: x_end);

            Series series = new Series();
            series.ChartArea = "chartArea";
            series.ChartType = SeriesChartType.Point;
            series.Name = "series";

            for (int i = 0; i < solutions.numericalSolutions.Length; i++)
            {
                NumericalSolution solution = solutions.numericalSolutions[i];
                series.Points.Add(new DataPoint(solution.X, solution.Y[0]));
            }

            this.chart.Series.Clear();
            this.chart.Series.Add(series);
        }

    }
}
