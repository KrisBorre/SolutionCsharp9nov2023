using LibraryFrameworkIntegration19nov2023;
using System;

namespace LibraryFrameworkFunctionExamples19nov2023
{
    public class ConstantTimesPower7oct2023 : IntegrandAbstractClass7oct2023
    {
        private double c, p;

        public ConstantTimesPower7oct2023(double constant = 4.0, double power = 0.5)
        {
            this.c = constant;
            this.p = power;
        }

        public override double Function(double x)
        {
            return c * Math.Pow(x, p);
        }

        public override string ToString()
        {
            return $"{c} x^{p:F2}";
        }
    }
}
