using System.Linq.Expressions;

namespace ConsoleGeometricFigures11nov2023
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Geometrische Figuren!");
            {
                Vierkant vierkant = new Vierkant(4);
                Console.WriteLine("Een vierkant met zijde 4 heeft oppervlakte: " + vierkant.Oppervlakte);
            }
            {
                GeometricFigure vierkant2 = new Vierkant(2, 3);
                Console.WriteLine("Een vierkant met zijde 2 heeft oppervlakte: " + vierkant2.Oppervlakte);
            }
            {
                Rechthoek vierkant3 = new Vierkant(6);
                Console.WriteLine("Een vierkant met zijde 6 heeft oppervlakte: " + vierkant3.Oppervlakte);
            }
            {
                Rechthoek rechthoek1 = new Rechthoek();
                rechthoek1.Breedte = 4;
                rechthoek1.Hoogte = 5;
                Console.WriteLine("Een rechthoek van 4 bij 5 heeft oppervlakte: " + rechthoek1.Oppervlakte);
            }
            {
                GeometricFigure rechthoek2 = new Rechthoek();
                rechthoek2.Breedte = 6;
                rechthoek2.Hoogte = 5;
                Console.WriteLine("Een rechthoek van 6 bij 5 heeft oppervlakte: " + rechthoek2.Oppervlakte);
            }
            {
                Driehoek driehoek1 = new Driehoek();
                driehoek1.Breedte = 3;
                driehoek1.Hoogte = 2;
                Console.WriteLine($"Een driehoek met breedte {driehoek1.Breedte} en hoogte {driehoek1.Hoogte} heeft oppervlakte: " + driehoek1.Oppervlakte);
            }
            {
                GeometricFigure driehoek2 = new Driehoek();
                driehoek2.Breedte = 1;
                driehoek2.Hoogte = 2;
                Console.WriteLine($"Een driehoek met breedte {driehoek2.Breedte} en hoogte {driehoek2.Hoogte} heeft oppervlakte: " + driehoek2.Oppervlakte);
            }

            string WhatIsMyName = "Hello World";
            ExampleFunction(x => WhatIsMyName); // WhatIsMyName

            GeometricFigure rechthoek = new Rechthoek();
            GeometricFigure driehoek = new Driehoek();

            //Toon0(x => rechthoek);
            Toon1(x => rechthoek); // rechthoek
            //Toon2(x => rechthoek);
            Toon3(x => rechthoek); // rechthoek

            //Toon0(x => driehoek);
            Toon1(x => driehoek); // driehoek
            //Toon2(x => driehoek);
            Toon3(x => driehoek); // driehoek

            Console.ReadLine();
        }

        public static void ExampleFunction(Expression<Func<string, string>> f)
        {
            Console.WriteLine((f.Body as MemberExpression).Member.Name);
        }

        //public static void Toon0(Expression<Func<string, string>> f)
        //{
        //    Console.WriteLine((f.Body as MemberExpression).Member.Name);
        //}

        public static void Toon1(Expression<Func<string, GeometricFigure>> f)
        {
            Console.WriteLine((f.Body as MemberExpression).Member.Name);
        }

        //public static void Toon2(Expression<Func<GeometricFigure, string>> f)
        //{
        //    Console.WriteLine((f.Body as MemberExpression).Member.Name);
        //}

        public static void Toon3(Expression<Func<GeometricFigure, GeometricFigure>> f)
        {
            Console.WriteLine((f.Body as MemberExpression).Member.Name);
        }
    }
}