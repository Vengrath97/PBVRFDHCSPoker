using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    class MainStructure
    {
        public static void Run()
        {
            for (int i = 0; i < ProjectVariables.SampleSize; i++)
            {
                GenerateNewHand();
                ShowHandIfNecessary();
                AssignResult();
            }
            DisplayResults();
            Cleanup();
        }
        private static void ShowHandIfNecessary()
        {
            if (ProjectVariables.ShowAllHands)
            {
                ProjectVariables.CurrentObject.ShowHand();
            }
        }
        private static void GenerateNewHand()
        {
            ProjectVariables.CurrentObject = new Hand();
        }
        private static void AssignResult()
        {
            ProjectVariables.Results[(int)ProjectVariables.CurrentObject.DetermineHandType()] += 1;
        }
        private static void DisplayResults()
        {
            Dialogues.ShowResults();
            Console.ReadLine();
        }
        private static void Cleanup()
        {
            Console.Clear();
            ProjectVariables.Results = new int[10];
        }
    }
}
