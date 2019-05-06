using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountAge();
        }

        private static void CountAge()
        {
            string Name;
            int Year;
            int Wiek;
            IPerson Age = new Person();

            bool koniec = false;
            while (!koniec)
            {
                Console.WriteLine("Podaj swoje imię: ");
                Name = Console.ReadLine();

                Console.WriteLine("Podaj swój rok urodzenia: ");
                Year = Convert.ToInt32(Console.ReadLine());

                Wiek = Age.GetAge(Year);
                if (Wiek >= 0)
                    Console.WriteLine(Name + " ma aktualnie " + Age.GetAge(Year) + " lat");
                else
                    Console.WriteLine("Błąd, podany rok jeszcze nie wystąpił!");

                Console.Write("Naciśnij 'n' i Enter aby zakończyć działanie programu lub jakikolwiek inny przycisk i Enter aby kontynuować: ");
                if (Console.ReadLine() == "n")
                    koniec = true;
                Console.WriteLine("\n");
            }
        }
    }
}