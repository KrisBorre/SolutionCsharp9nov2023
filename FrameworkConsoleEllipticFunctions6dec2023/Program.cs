using LibraryFrameworkEllipticIntegrals20nov2023;
using System;

namespace FrameworkConsoleEllipticFunctions6dec2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new EllipticIntegralCalculator20nov2023();

            Console.WriteLine("   mc    u            sn              sn^2+cn^2   mc*sn^2+dn^2");

            double em = 0;
            {
                double uu = 0.1;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.2;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.5;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 1.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 2.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            em = 0.5;
            {
                double uu = 0.1;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.2;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.5;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 1.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 2.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            em = 1;
            {
                double uu = 0.1;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.2;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 0.5;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 1.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 2.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = 4.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = -0.2;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = -0.5;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = -1.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            {
                double uu = -2.0;
                double emmc = 1.0 - em;
                calc.sncndn(uu, emmc, out double sn, out double cn, out double dn);
                WriteRow(uu, em, emmc, sn, cn, dn);
            }

            Console.Read();
        }


        private static void WriteRow(double uu, double em, double emmc, double sn, double cn, double dn)
        {
            Console.WriteLine($"{emmc,5} {uu,5} {sn,20} {sn * sn + cn * cn,10} {em * sn * sn + dn * dn,10}");
        }


        /*
   mc    u            sn              sn^2+cn^2   mc*sn^2+dn^2
    1   0,1   0,0998334166468282          1          1
    1   0,2    0,198669330795061          1          1
    1   0,5    0,479425538604203          1          1
    1     1    0,841470984807897          1          1
    1     2    0,909297426825682          1          1
  0,5   0,1   0,0997506854746248          1          1
  0,5   0,2     0,19802174298197          1          1
  0,5   0,5    0,470750473655657          1          1
  0,5     1    0,803001824895644          1          1
  0,5     2    0,994662325358018          1          1
    0   0,1   0,0996679946249558          1          1
    0   0,2    0,197375320224904          1          1
    0   0,5     0,46211715726001          1          1
    0     1    0,761594155955765          1          1
    0     2    0,964027580075817          1          1
    0     4    0,999329299739067          1          1
    0  -0,2   -0,197375320224904          1          1
    0  -0,5    -0,46211715726001          1          1
    0    -1   -0,761594155955765          1          1
    0    -2   -0,964027580075817          1          1
        */
    }
}
