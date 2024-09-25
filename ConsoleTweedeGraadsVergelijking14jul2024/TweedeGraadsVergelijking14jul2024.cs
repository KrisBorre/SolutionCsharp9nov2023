namespace ConsoleTweedeGraadsVergelijking14jul2024
{
    // by Phi 3, but adapted to make it build
    internal class TweedeGraadsVergelijking14jul2024
    {
        private decimal a, b, c;

        public TweedeGraadsVergelijking14jul2024(decimal a, decimal b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string ToString()
        {
            return $"{a} * x^2 + {b} * x + {c} = 0";
        }

        public bool ZoekNulpunten(ref decimal x1, ref decimal x2, ref bool zijnGevonden)
        {
            // Calculate the discriminant
            decimal discriminant = b * b - 4 * a * c;

            // Check if the discriminant is negative, which means there are no real roots
            if (discriminant < 0)
            {
                zijnGevonden = false;
                return false;
            }

            // Calculate the roots
            x1 = (-b + (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
            x2 = (-b - (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
            zijnGevonden = true;
            return true;
        }

        public decimal YWaarde(decimal x)
        {
            return a * x * x + b * x + c;
        }
    }
}
