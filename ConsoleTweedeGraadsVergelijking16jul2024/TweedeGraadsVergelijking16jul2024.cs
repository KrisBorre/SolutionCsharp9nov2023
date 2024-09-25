namespace ConsoleTweedeGraadsVergelijking16jul2024
{
    // by DeepSeek Coder 7B
    internal class TweedeGraadsVergelijking16jul2024
    {
        private decimal a;
        private decimal b;
        private decimal c;

        public TweedeGraadsVergelijking16jul2024(decimal a, decimal b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ZoekNulpunten(ref decimal x1, ref decimal x2, ref bool zijnGevonden)
        {
            decimal discriminant = b * b - 4 * a * c;
            if (discriminant >= 0)
            {
                decimal sqrtDiscriminant = (decimal)Math.Sqrt((double)discriminant);
                decimal denominator = 2 * a;
                x1 = (-b + sqrtDiscriminant) / denominator;
                x2 = (-b - sqrtDiscriminant) / denominator;
                zijnGevonden = true;
            }
        }

        public decimal YWaarde(decimal x)
        {
            return a * x * x + b * x + c;
        }

        public override string ToString()
        {
            return $"{a} * x * x + {b} * x + {c}";
        }
    }
}
