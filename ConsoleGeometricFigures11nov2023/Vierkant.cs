namespace ConsoleGeometricFigures11nov2023
{
    internal class Vierkant : Rechthoek
    {
        public Vierkant(int lengte, int breedte)
        {
            if (lengte != breedte)
            {
                breedte = lengte;
            }
            Hoogte = lengte;
            Breedte = breedte;
        }

        public Vierkant(int lengte) : this(lengte, lengte)
        {
        }
    }
}
