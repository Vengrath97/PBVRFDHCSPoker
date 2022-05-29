using System;

namespace PokerProject
{
    class Program
    {
        static bool ConfigMode = false;
        public static int[] Results = new int[10];
        static Hand CurrentObject;
        static int SampleSize = 100;
        static bool ShowHand = false;
        static void ShowResults()
        {
            Console.WriteLine($"{Results[0]} - of Royal Flushes");
            Console.WriteLine($"{Results[1]} - of Straight Flushes");
            Console.WriteLine($"{Results[2]} - of Four of a Kind's");
            Console.WriteLine($"{Results[3]} - of Full Houses");
            Console.WriteLine($"{Results[4]} - of Flushes");
            Console.WriteLine($"{Results[5]} - of Straights");
            Console.WriteLine($"{Results[6]} - of Three of a Kind's");
            Console.WriteLine($"{Results[7]} - of Two Pairs");
            Console.WriteLine($"{Results[8]} - of Pairs");
            Console.WriteLine($"{Results[9]} - of High Cards");
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
            for (int i=0; i< SampleSize; i++)
            {
                CurrentObject = new Hand();
                if (ShowHand)
                {
                    CurrentObject.ShowHand();
                }
                Results[CurrentObject.DetermineHand() - 1] += 1;
            }
            ShowResults();
        }
    }
}