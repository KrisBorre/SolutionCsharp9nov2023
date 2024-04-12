namespace ConsoleTweedeGraadsVergelijking13feb2024
{
    internal class TweedeGraadsVergelijking13feb2024
    {
        private decimal a, b, c;

        public TweedeGraadsVergelijking13feb2024(decimal a, decimal b, decimal c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public decimal YWaarde(decimal x)
        {
            return a * (decimal)Math.Pow((double)x, 2) + b * x + c;
        }

        public decimal Discriminant
        {
            get { return (decimal)Math.Pow((double)b, 2) - 4 * a * c; }
        }

        public void ZoekNulpunten(ref decimal x1, ref decimal x2, ref bool heeftNulpunten)
        {
            decimal d = Discriminant;
            if (d >= 0)
            {
                heeftNulpunten = true;
                x1 = (-b + (decimal)Math.Sqrt((double)d)) / (2 * a);
                x2 = (-b - (decimal)Math.Sqrt((double)d)) / (2 * a);
            }
            else heeftNulpunten = false;
        }

        public override string ToString()
        {
            return a + " * x * x + " + b + " * x + " + c;
        }
    }
}
