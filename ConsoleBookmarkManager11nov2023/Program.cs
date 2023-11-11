namespace ConsoleBookmarkManager11nov2023
{
    internal class Program
    {
        #region Bookmark Manager

        static void InvoerFavorieten(Bookmark11nov2023[] favorieten)
        {
            bool isIngegeven = false;
            for (int i = 0; i < favorieten.Length; i++)
            {
                if (favorieten[i] == null)
                {
                    Console.WriteLine("Geef de naam van je favoriete website: (exit is stop) ");
                    string naam = Console.ReadLine();
                    isIngegeven = true;
                    if (naam == "exit" || naam == "stop") break;
                    favorieten[i] = new Bookmark11nov2023();
                    favorieten[i].Naam = naam;
                    Console.WriteLine("Geef de URL van deze website: ");
                    string url = Console.ReadLine();
                    favorieten[i].URL = url;
                }
            }
            if (!isIngegeven)
            {
                Console.WriteLine("Onvoldoende plaats om nog favorieten toe te voegen.");
            }
        }

        static void ToonFavorieten(Bookmark11nov2023[] favorieten)
        {
            Console.WriteLine("FAVORIETEN:");
            for (int i = 1; i <= favorieten.Length; i++)
            {
                if (favorieten[i - 1] != null)
                {
                    Console.WriteLine(i + ":  " + favorieten[i - 1].Naam);
                }
            }
        }

        static void VerwijderFavoriet(Bookmark11nov2023[] favorieten)
        {
            Console.WriteLine("Geef de naam die je wil verwijderen: ");
            string naam = Console.ReadLine();

            bool isGevonden = false;
            int index = 0;
            for (int i = 0; i < favorieten.Length; i++)
            {
                if (favorieten[i] != null)
                {
                    if (favorieten[i].Naam == naam)
                    {
                        isGevonden = true;
                        index = i;
                        break;
                    }
                }
            }
            if (isGevonden)
            {
                favorieten[index] = null;
            }
        }

        static void OpenFavoriet(Bookmark11nov2023[] favorieten)
        {
            Console.WriteLine("Geef keuze: ");
            string sKeuze = Console.ReadLine();
            if (int.TryParse(sKeuze, out int keuze))
            {
                if (keuze >= 1 && keuze <= favorieten.Length)
                {
                    if (favorieten[keuze - 1] != null)
                    {
                        favorieten[keuze - 1].OpenSite();
                    }
                }
            }
        }

        static void PasFavorietAan(Bookmark11nov2023[] favorieten)
        {
            Console.WriteLine("Geef de naam die je wil aanpassen: ");
            string naam = Console.ReadLine();

            bool isGevonden = false;
            int index = 0;
            for (int i = 0; i < favorieten.Length; i++)
            {
                if (favorieten[i] != null)
                {
                    if (favorieten[i].Naam == naam)
                    {
                        isGevonden = true;
                        index = i;
                        break;
                    }
                }
            }
            if (isGevonden)
            {
                Console.WriteLine("Geef de nieuwe URL: ");
                string url = Console.ReadLine();
                favorieten[index].URL = url;
            }
        }

        #endregion

        private static void Main(string[] args)
        {
            #region Bookmark Manager
            {
                Console.WriteLine("Welkom bij Bookmark Manager!");

                const int AANTAL = 5;
                Bookmark11nov2023[] favorieten = new Bookmark11nov2023[AANTAL];

                InvoerFavorieten(favorieten);
                ToonFavorieten(favorieten);

                bool stop = false;
                while (!stop)
                {
                    Console.WriteLine("1 is invoer. 2 is verwijderen. 3 is aanpassen. 4 is openen. exit is stop.");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "stop":
                        case "exit":
                            stop = true;
                            break;
                        case "1":
                            InvoerFavorieten(favorieten);
                            ToonFavorieten(favorieten);
                            break;
                        case "2":
                            VerwijderFavoriet(favorieten);
                            ToonFavorieten(favorieten);
                            break;
                        case "3":
                            PasFavorietAan(favorieten);
                            ToonFavorieten(favorieten);
                            break;
                        case "4":
                            OpenFavoriet(favorieten);
                            ToonFavorieten(favorieten);
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine(@"https://app.pluralsight.com/profile/kris-borremans");
            }
            #endregion
        }
    }
}