using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    class Dialogues
    {
        public static void ShowResults()
        {
            Console.WriteLine($"{ProjectVariables.Results[0]} - of Royal Flushes");
            Console.WriteLine($"{ProjectVariables.Results[1]} - of Straight Flushes");
            Console.WriteLine($"{ProjectVariables.Results[2]} - of Four of a Kind's");
            Console.WriteLine($"{ProjectVariables.Results[3]} - of Full Houses");
            Console.WriteLine($"{ProjectVariables.Results[4]} - of Flushes");
            Console.WriteLine($"{ProjectVariables.Results[5]} - of Straights");
            Console.WriteLine($"{ProjectVariables.Results[6]} - of Three of a Kind's");
            Console.WriteLine($"{ProjectVariables.Results[7]} - of Two Pairs");
            Console.WriteLine($"{ProjectVariables.Results[8]} - of Pairs");
            Console.WriteLine($"{ProjectVariables.Results[9]} - of High Cards");
        }
    }
}
