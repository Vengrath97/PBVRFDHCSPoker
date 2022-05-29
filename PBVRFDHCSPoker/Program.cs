using System;

namespace PokerProject
{
    class Program
    {
        static bool ConfigMode = false;
        public static int[] Results = new int[10];
        static Hand CurrentObject;
        static int SampleSize = 100000;
        static bool ShowHand = false;
        static void ShowResults()
        {
            Console.WriteLine($"{Results[0]} \t- of Royal Flushes");
            Console.WriteLine($"{Results[1]} \t- of Straight Flushes");
            Console.WriteLine($"{Results[2]} \t- of Four of a Kind's");
            Console.WriteLine($"{Results[3]} \t- of Full Houses");
            Console.WriteLine($"{Results[4]} \t- of Flushes");
            Console.WriteLine($"{Results[5]} \t- of Straights");
            Console.WriteLine($"{Results[6]} \t- of Three of a Kind's");
            Console.WriteLine($"{Results[7]} \t- of Two Pairs");
            Console.WriteLine($"{Results[8]} \t- of Pairs");
            Console.WriteLine($"{Results[9]} \t- of High Cards");
        }
        static void Config()
        {
            Console.WriteLine("Witam w konfiguracji. Wprowadź wymagane dane konfiguracyjne:");
            Console.WriteLine("Ilość danych (zestawów kart) do przetestowania:");
            SampleSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz 1 jeśli chcesz każdorazowo widzieć wylosowaną rękę:");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                ShowHand = true;
            }
        }
        static void Main()
        {
            if (ConfigMode)
            {
                Config();
            }
            while(true)
            {
                for (int i = 0; i < SampleSize; i++)
                {
                    CurrentObject = new Hand();
                    if (ShowHand)
                    {
                        CurrentObject.ShowHand();
                    }
                    Results[CurrentObject.DetermineHand() - 1] += 1;
                }
                ShowResults();
                Console.ReadLine();
                Console.Clear();
                Results = new int[10];
            }
        }
    }
}