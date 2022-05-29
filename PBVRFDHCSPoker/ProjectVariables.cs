using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    static class ProjectVariables
    {
        //variables
        public static int[] Results = new int[10];
        public static Hand CurrentObject;
        public const int HandSize = 5;

        //configuration variables
        public static bool ConfigMode = false;
        public static bool ShowAllHands = false;
        public static int SampleSize = 100000;
        public static int FigureCount = 6;
        public static int SuitCount = 4;
    }
}
