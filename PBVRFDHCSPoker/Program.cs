using System;

namespace PokerProject
{
    class Program
    {
        static void Main()
        {
            if (ProjectVariables.ConfigMode)
            {
                ProjectConfiguration.Config();
            }
            while(true)
            {
                MainStructure.Run();
            }
        }
    }
}