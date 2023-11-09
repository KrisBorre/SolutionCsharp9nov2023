﻿namespace LibraryFrameworkDifferentialEquations9nov2023
{
    public class NumericalSolution
    {
        private int numberOfFirstOrderEquations;
        private double x = 0;
        private double[] y;

        /// <summary>
        /// x of de tijd t ;
        /// x or the time t ;
        /// </summary>
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double[] Y
        {
            get { return y; }
        }

        public NumericalSolution(params double[] y)
        {
            if (y != null)
            {
                this.numberOfFirstOrderEquations = y.Length;
                this.y = new double[numberOfFirstOrderEquations];
                for (int i = 0; i < numberOfFirstOrderEquations; i++)
                {
                    this.y[i] = y[i];
                }
            }
        }
    }
}
