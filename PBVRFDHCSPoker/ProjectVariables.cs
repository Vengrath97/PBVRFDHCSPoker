using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    static class ProjectVariables
    {
        // === Constants ===

        // Changing the Hand Size would require to readjust the conditions for HandTypes,
        // but other HandSize doesn't make sense for Poker
        public const int HandSize = 5;

        // === Variables ===
        public static int[] Results = new int[Enum.GetNames(typeof(Category.HandType)).Length];
        public static Hand CurrentObject;

        // === Configurable Variables ===
        public static bool ConfigMode = false;
        public static bool ShowAllHands = false;
        public static int SampleSize = 100000000;
        public static int FigureCount = 6;
        public static int SuitCount = 4;
    }
}
