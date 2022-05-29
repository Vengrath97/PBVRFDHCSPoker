using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    class ProjectConfiguration
    {
        public static void Config()
        {
            Console.WriteLine("Witam w konfiguracji. Wprowadź wymagane dane konfiguracyjne:");
            SettingSampleSize();
            SettingDisplayEveryHand();
        }
        private static void SettingSampleSize()
        {
            Console.WriteLine("Ilość danych (zestawów kart) do przetestowania:");
            ProjectVariables.SampleSize = int.Parse(Console.ReadLine());
        }
        private static void SettingDisplayEveryHand()
        {
            Console.WriteLine("Wpisz 1 jeśli chcesz każdorazowo widzieć wylosowaną rękę:");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                ProjectVariables.ShowHand = true;
            }
        }
    }
}
