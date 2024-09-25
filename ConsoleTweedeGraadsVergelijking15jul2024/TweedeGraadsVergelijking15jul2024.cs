namespace ConsoleTweedeGraadsVergelijking15jul2024
{
    // by OpenChat, adapted to make it build
    internal class TweedeGraadsVergelijking15jul2024
    {
        public decimal A { get; private set; }
        public decimal B { get; private set; }
        public decimal C { get; private set; }

        public TweedeGraadsVergelijking15jul2024(decimal a, decimal b, decimal c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void ZoekNulpunten(ref decimal x1, ref decimal x2, ref bool zijnGevonden)
        {
            decimal discriminant = B * B - 4 * A * C;

            if (discriminant > 0)
            {
                x1 = (-B + (decimal)Math.Sqrt((double)discriminant)) / (2 * A);
                x2 = (-B - (decimal)Math.Sqrt((double)discriminant)) / (2 * A);
                zijnGevonden = true;
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -B / (2 * A);
                zijnGevonden = true;
            }
            else
            {
                zijnGevonden = false;
            }
        }

        public decimal YWaarde(decimal x)
        {
            return A * (decimal)Math.Pow((double)x, 2) + B * x + C;
        }

        public override string ToString()
        {
            return "A: " + A + ", B: " + B + ", C: " + C;
        }
    }
}
