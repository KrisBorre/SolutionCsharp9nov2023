namespace ConsoleTweedeGraadsVergelijking17nov2023
{
    internal class TweedeGraadsVergelijking
    {
        private double a, b, c;

        public TweedeGraadsVergelijking(double a, double b, double c)
        { 
            this.a = a; this.b = b; this.c = c; 
        }

        public double YWaarde(double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        public double Discriminant
        { 
            get { return Math.Pow(b, 2) - 4 * a * c; } 
        }

        public void ZoekNulpunten(ref double x1, ref double x2, ref bool heeftNulpunten)
        {
            double d = this.Discriminant;
            if (d >= 0)
            {
                heeftNulpunten = true;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else heeftNulpunten = false;
        }

        public override string ToString()
        {
            return a + " * x * x + " + b + " * x + " + c;
        }
    }
}
