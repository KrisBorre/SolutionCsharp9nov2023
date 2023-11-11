namespace ConsoleGeometricFigures11nov2023
{
    internal class Driehoek : GeometricFigure
    {
        protected override int BerekenOppervlakte()
        {
            return (int)((Hoogte * Breedte) / 2.0);
        }
    }
}
