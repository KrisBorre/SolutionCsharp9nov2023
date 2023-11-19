using LibraryFrameworkIntegration19nov2023;

namespace LibraryFrameworkFunctionExamples19nov2023
{
    public class Square7oct2023 : IntegrandAbstractClass7oct2023
    {
        public override double Function(double x)
        {
            return x * x;
        }

        public override string ToString()
        {
            return "x^2";
        }
    }
}