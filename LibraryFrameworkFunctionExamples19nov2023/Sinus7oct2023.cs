using LibraryFrameworkIntegration19nov2023;
using System;

namespace LibraryFrameworkFunctionExamples19nov2023
{
    public class Sinus7oct2023 : IntegrandAbstractClass7oct2023
    {
        public override double Function(double x)
        {
            return Math.Sin(x);
        }

        public override string ToString()
        {
            return "sin(x)";
        }
    }
}
