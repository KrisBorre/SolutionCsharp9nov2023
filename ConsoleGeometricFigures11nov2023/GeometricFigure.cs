namespace ConsoleGeometricFigures11nov2023
{
    internal abstract class GeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte { get { return BerekenOppervlakte(); } }

        protected abstract int BerekenOppervlakte();
    }
}
