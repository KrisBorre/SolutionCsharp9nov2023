namespace ConsoleZiekenhuis13nov2023
{
    internal class VerzekerdePatient : Patient
    {
        public override double BerekenKost()
        {
            return base.BerekenKost() * 0.9;
        }
    }
}
