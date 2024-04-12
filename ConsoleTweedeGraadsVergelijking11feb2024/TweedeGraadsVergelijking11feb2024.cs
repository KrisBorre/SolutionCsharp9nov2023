namespace ConsoleTweedeGraadsVergelijking11feb2024
{
    internal class TweedeGraadsVergelijking11feb2024
    {
        private float a, b, c;

        public TweedeGraadsVergelijking11feb2024(float a, float b, float c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public float YWaarde(float x)
        {
            return a * (float)Math.Pow(x, 2) + b * x + c;
        }

        public float Discriminant
        {
            get { return (float)Math.Pow(b, 2) - 4 * a * c; }
        }

        public void ZoekNulpunten(ref float x1, ref float x2, ref bool heeftNulpunten)
        {
            double d = this.Discriminant;
            if (d >= 0)
            {
                heeftNulpunten = true;
                x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
            }
            else heeftNulpunten = false;
        }

        public override string ToString()
        {
            return a + " * x * x + " + b + " * x + " + c;
        }
    }
}
