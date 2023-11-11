namespace ConsoleGeometricFigures11nov2023
{
    internal class Rechthoek : GeometricFigure
    {
        protected override int BerekenOppervlakte()
        {
            return Breedte * Hoogte;
        }
    }
}
