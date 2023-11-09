using System;

namespace LibraryFrameworkDifferentialEquations9nov2023
{
    public abstract class DifferentialEquationsSolverBaseClass
    {
        protected DifferentialEquationsBaseClass differentialEquations;
        protected int numberOfFirstOrderEquations;


        public DifferentialEquationsSolverBaseClass(DifferentialEquationsBaseClass differentialEquations)
        {
            if (differentialEquations == null)
            {
                throw new Exception("Sorry, Runge Kutta is verkeerd aangeroepen. Hierop kan ik geen Runge Kutta methode uitvoeren.");
            }
            else
            {
                this.differentialEquations = differentialEquations;
                this.numberOfFirstOrderEquations = differentialEquations.NumberOfFirstOrderEquations;
            }
        }


        abstract protected void runge_kutta_step(double delta_x, double x, double[] y, out double[] term);


        public void Solve(ConditionInitial initialCondition, ulong number_of_steps, out double delta_x, out NumericalSolution solution, double interval = Math.PI, bool sophisticated = true, double x_end = Math.PI)
        {
            delta_x = interval / number_of_steps;

            double[] y = new double[numberOfFirstOrderEquations];

            double x = initialCondition.X;

            for (int i = 0; i < numberOfFirstOrderEquations; i++)
            {
                y[i] = initialCondition.Y[i];
            }

            double[] z = new double[numberOfFirstOrderEquations];
            double[] new_y = new double[numberOfFirstOrderEquations];
            double[] term;

            for (ulong k = 1; k <= number_of_steps; k++)
            {
                runge_kutta_step(delta_x, x, y, out term);

                for (int j = 0; j < numberOfFirstOrderEquations; j++)
                {
                    if (sophisticated)
                    {
                        term[j] += z[j];
                        new_y[j] = y[j] + term[j];
                        z[j] = term[j] - (new_y[j] - y[j]);
                        y[j] = new_y[j];
                    }
                    else
                    {
                        y[j] += term[j];
                    }

                }

                if (initialCondition.X > x_end)
                {
                    x = initialCondition.X - k * delta_x;
                }
                else
                {
                    x = initialCondition.X + k * delta_x;
                }

            }

            solution = new NumericalSolution(y);
            solution.X = x;
        }


    }
}

