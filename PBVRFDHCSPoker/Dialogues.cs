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
            Console.WriteLine($"{ProjectVariables.Results[0]} \t- of \tRoyal Flushes");
            Console.WriteLine($"{ProjectVariables.Results[1]} \t- of \tStraight Flushes");
            Console.WriteLine($"{ProjectVariables.Results[2]} \t- of \tFour of a Kind's");
            Console.WriteLine($"{ProjectVariables.Results[3]} \t- of \tFull Houses");
            Console.WriteLine($"{ProjectVariables.Results[4]} \t- of \tFlushes");
            Console.WriteLine($"{ProjectVariables.Results[5]} \t- of \tStraights");
            Console.WriteLine($"{ProjectVariables.Results[6]} \t- of \tThree of a Kind's");
            Console.WriteLine($"{ProjectVariables.Results[7]} \t- of \tTwo Pairs");
            Console.WriteLine($"{ProjectVariables.Results[8]} \t- of \tPairs");
            Console.WriteLine($"{ProjectVariables.Results[9]} \t- of \tHigh Cards");
        }
    }
}
