using LibraryFrameworkDifferentialEquations9nov2023;
using System;

namespace SolutionCsharp9nov2023
{
    public enum Method
    {
        RK41,
        RK61,
        Crude,
        Sophisticated
    }

    public class DifferentialEquationsSolver13dec2023
    {
        private DifferentialEquationsSolverBaseClass differentialEquationsSolverBaseClass;

        public DifferentialEquationsSolver13dec2023(DifferentialEquationsBaseClass differentialEquations, Method method = Method.RK61)
        {
            switch (method)
            {
                case Method.RK41:
                    differentialEquationsSolverBaseClass = new DifferentialEquationsSolverRK41_5nov2023(differentialEquations);
                    break;
                case Method.RK61:
                    differentialEquationsSolverBaseClass = new DifferentialEquationsSolverRK61_5nov2023(differentialEquations);
                    break;
                default:
                    differentialEquationsSolverBaseClass = new DifferentialEquationsSolverRK61_5nov2023(differentialEquations);
                    break;
            }
        }

        public void Solve(ConditionInitial initialCondition, ulong number_of_steps, out double delta_x, out NumericalSolution solution, double interval = Math.PI, bool sophisticated = true, double x_end = Math.PI)
        {
            differentialEquationsSolverBaseClass.Solve(initialCondition, number_of_steps, out delta_x, out solution, interval, sophisticated, x_end);
        }

        public void Solve(ConditionInitial initialCondition, ulong number_of_steps, out double delta_x, out NumericalSolutions solutions, int number_of_solutions = 10000, double interval = Math.PI, bool sophisticated = true, double x_end = Math.PI)
        {
            differentialEquationsSolverBaseClass.Solve(initialCondition, number_of_steps, out delta_x, out solutions, number_of_solutions, interval, sophisticated, x_end);
        }
    }
}
