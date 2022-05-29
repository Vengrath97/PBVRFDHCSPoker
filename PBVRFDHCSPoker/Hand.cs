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

        public Hand()
        {
            Random rnd = new Random();
            int[] randomID = new int[5];
            randomID[0] = rnd.Next(24);
            int temp = rnd.Next(24);
            int i = 1;
            while (i < 5)
            {
                if (!randomID.Contains(temp))
                {
                    randomID[i] = temp;
                    i += 1;
                }
                else
                {
                    temp = rnd.Next();
                }
            }
            Card[] returnValue = new Card[5];
            for (int j=0; j<5; j++)
            {
                returnValue[j] = new Card(randomID[j]);
            }
            Cards = returnValue;
        }
        public void ShowHand()
        {

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"-------------------------");
                Console.WriteLine($"- {Cards[i].Figure} of {Cards[i].Suit} \t-");
                i += 1;
            }
            Console.WriteLine($"-------------------------");
            Console.WriteLine($" ");
        }
        private bool containsFigure(Category.Figure figure)
        {
            for (int i = 0; i<5; i++)
            {
                if (this.Cards[i].Figure == figure)
                {
                    return true;
                }
            }
            return false;
        }


        private bool isFlush()
        {
            if (this.Cards[0].Suit == this.Cards[1].Suit && this.Cards[0].Suit == this.Cards[2].Suit && this.Cards[0].Suit == this.Cards[3].Suit && this.Cards[0].Suit == this.Cards[4].Suit)
            {
                return true;
            }
            return false;
        }
        private bool isRoyal()
        {
            if(this.containsFigure((Category.Figure)0) && this.containsFigure((Category.Figure)1) && this.containsFigure((Category.Figure)2) && this.containsFigure((Category.Figure)3) && this.containsFigure((Category.Figure)4))
            {
                return true;
            }
            return false;
        }
        private bool isStraight()
        {
            for (int i = 0; i<10; i++)
            {
                if ((this.containsFigure((Category.Figure)i) && this.containsFigure((Category.Figure)i+1) && this.containsFigure((Category.Figure)i + 2) && this.containsFigure((Category.Figure)i + 3) && this.containsFigure((Category.Figure)i + 4)))
                {
                    return true;
                }
            }
            return false;
        }
        private bool isFourOfAKind()
        {
            int same = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j<5;j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        same += 1;
                    }
                }
            }
            if (same > 15)
            {
                return true;
            }
            return false;
        }
        private bool isFullHouse()
        {
            int same = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        same += 1;
                    }
                }
            }
            if (same == 13)
            {
                return true;
            }
            return false;
        }
        private bool isThreeOfAKind()
        {
            int same = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        same += 1;
                    }
                }
            }
            if (same == 11)
            {
                return true;
            }
            return false;
        }
        private bool isTwoPairs()
        {
            int same = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        same += 1;
                    }
                }
            }
            if (same > 8)
            {
                return true;
            }
            return false;
        }
        private bool isPair()
        {
            int same = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (this.Cards[i].Figure == this.Cards[j].Figure)
                    {
                        same += 1;
                    }
                }
            }
            if (same > 5)
            {
                return true;
            }
            return false;
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
            else
            {
                return 10;
            }
        }
    }
}