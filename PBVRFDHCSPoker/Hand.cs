using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    class Hand
    {
        public  Card[] Cards { get => cards; set => cards = value; }
        private Card[] cards;
        private Category.HandType HandType;
        public Hand()
        {
            Card[] CardsInHand = new Card[ProjectVariables.HandSize];
            int[] IDList = GenerateListOfUniqueIDs();
            for (int i = 0; i < ProjectVariables.HandSize; i++)
            {
                CardsInHand[i] = new Card(IDList[i]);
            }
            Cards = CardsInHand;
            HandType = DetermineHandType();
        }
        private int[] GenerateListOfUniqueIDs()
        {
            Random rnd = new Random();
            int[] returnValue = new int[ProjectVariables.HandSize];
            for (int i = 0; i< ProjectVariables.HandSize; i++)
            {
                int temp = rnd.Next(ProjectVariables.FigureCount*ProjectVariables.SuitCount);
                if (returnValue.Contains(temp))
                {
                    i -= 1;
                }
                else
                {
                    returnValue[i] = temp;
                }
            }
            return returnValue;
        }
        public void ShowHand()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"-------------------------");
                Console.WriteLine($"- {card.Figure} of {card.Suit} \t-");
            }
            Console.WriteLine($"-------------------------");
            Console.WriteLine($" ");
        }
        public int DetermineHand()
        {
            if (this.isFlush() && this.isRoyal())
            {
                return 1;
            }
            else if (this.isFlush() && this.isStraight())
            {
                return 2;
            }
            else if (this.isFourOfAKind())
            {
                return 3;
            }
            else if (this.isFullHouse())
            {
                return 4;
            }
            else if (this.isFlush())
            {
                return 5;
            }
            else if (this.isStraight())
            {
                return 6;
            }
            else if (this.isThreeOfAKind())
            {
                return 7;
            }
            else if (this.isTwoPairs())
            {
                return 8;
            }
            else if (this.isPair())
            {
                return 9;
            }
            return 10;
        }
        public Category.HandType DetermineHandType()
        {
            if (this.isFlush() && this.isRoyal())
            {
                return (Category.HandType)0;
            }
            if (this.isFlush() && this.isStraight())
            {
                return (Category.HandType)1;
            }
            if (this.isFourOfAKind())
            {
                return (Category.HandType)2;
            }
            if (this.isFullHouse())
            {
                return (Category.HandType)3;
            }
            if (this.isFlush())
            {
                return (Category.HandType)4;
            }
            if (this.isStraight())
            {
                return (Category.HandType)5;
            }
            if (this.isThreeOfAKind())
            {
                return (Category.HandType)6;
            }
            if (this.isTwoPairs())
            {
                return (Category.HandType)7;
            }
            if (this.isPair())
            {
                return (Category.HandType)8;
            }
            return (Category.HandType)9;
        }

        // Helpful tools in determining a HandType conditions
        private int repetitions()
        {
            int repetitions = 0;
            for (int i = 0; i < ProjectVariables.HandSize; i++)
            {
                for (int j = 0; j < ProjectVariables.HandSize; j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        repetitions += 1;
                    }
                }
            }
            return repetitions;
        }
        private bool containsFigure(Category.Figure figure)
        {
            for (int i = 0; i < ProjectVariables.HandSize; i++)
            {
                if (this.Cards[i].Figure == figure)
                {
                    return true;
                }
            }
            return false;
        }

        //Determine if a hand meets the necessary minimal condition of a given HandType
        private bool isFlush()
        {
            return (this.Cards[0].Suit == this.Cards[1].Suit &&
                    this.Cards[0].Suit == this.Cards[2].Suit &&
                    this.Cards[0].Suit == this.Cards[3].Suit &&
                    this.Cards[0].Suit == this.Cards[4].Suit);
        }
        private bool isRoyal()
        {
            return (this.containsFigure((Category.Figure)0) && 
                    this.containsFigure((Category.Figure)1) && 
                    this.containsFigure((Category.Figure)2) && 
                    this.containsFigure((Category.Figure)3) && 
                    this.containsFigure((Category.Figure)4));
        }
        private bool isStraight()
        {
            for (int i = 0; i<10; i++)
            {
                if (this.containsFigure((Category.Figure)i) && 
                    this.containsFigure((Category.Figure)i + 1) && 
                    this.containsFigure((Category.Figure)i + 2) && 
                    this.containsFigure((Category.Figure)i + 3) && 
                    this.containsFigure((Category.Figure)i + 4))
                {
                    return true;
                }
            }
            return false;
        }
        private bool isFourOfAKind()
        {
            return (repetitions() > 16);
        }
        private bool isFullHouse()
        {
            return repetitions() == 13;
        }
        private bool isThreeOfAKind()
        {
            return repetitions() == 11;
        }
        private bool isTwoPairs()
        {
            return repetitions() == 9;
        }
        private bool isPair()
        {
            return repetitions() == 7;
        }
    }
}