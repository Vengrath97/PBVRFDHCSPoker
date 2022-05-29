using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    partial class Hand
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
        public void DisplayHand()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"-------------------------");
                Console.WriteLine($"- {card.Figure} of {card.Suit} \t-");
            }
            Console.WriteLine($"-------------------------");
            Console.WriteLine($" ");
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
    }
    //This Part of Partial class Hand contains condition-checking methods for a particular HandType for DetermineHandType() method.
    partial class Hand
    {
        //Flush is a combination of 5 cards of the same Suit
        private bool isFlush()
        {
            return (this.Cards[0].Suit == this.Cards[1].Suit &&
                    this.Cards[0].Suit == this.Cards[2].Suit &&
                    this.Cards[0].Suit == this.Cards[3].Suit &&
                    this.Cards[0].Suit == this.Cards[4].Suit);
        }
        //Straight is a combination, a 'chain' of figures that differ between eachother by 1
        private bool isStraight()
        {
            for (int i = 0; i < 10; i++)
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
        //Royal is a particular Straight that also contains (Figure)0 and a chain of figures below it
        //(Figure)0 is the highest figure possible
        private bool isRoyal()
        {
            return (this.containsFigure((Category.Figure)0) &&
                    this.isStraight());
        }
        //Four-of-a-Kind is a hand that contains 4 of the same Figures.
        //Due to how repetition() method works, a 17 means Four-of-a-Kind
        private bool isFourOfAKind()
        {
            return (repetitions() > 16);
        }
        //FullHouse is a hand that contains 3 of the same Figures, and 2 of the same(different) figures.
        //Due to how repetition() method works, a 13 means a FullHouse
        private bool isFullHouse()
        {
            return repetitions() == 13;
        }
        //Three-of-a-Kind is a hand that contains 3 of the same Figures
        //Due to how repetition() method works, an 11 means Three-of-a-Kind
        private bool isThreeOfAKind()
        {
            return repetitions() == 11;
        }
        //Two-Pairs is a hand that contains 2 sets of (different) paris of figures
        //Due to how repetition() method works, a 9 means Two-Pairs
        private bool isTwoPairs()
        {
            return repetitions() == 9;
        }
        //A Pair is a hand that contains 2 of the same figures.
        //Due to how repetition() method works, a 7 means Two-Pairs
        private bool isPair()
        {
            return repetitions() == 7;
        }
    }
    //This Part of Partial class Hand contains usefull tools that are being used by condition-checking methods in previous part of the method
    partial class Hand
    {
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
        //containsFigure(figure) method checks the current hand for a given figure.
        //if ANY card in the current hand is of a given figure, (there is a duplicate even with a different Suit)
        //then the method will return True
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
        //returns a table of a size equal to the hand size, filled with unique int-values
        //the values in the table will conform to the number of possible cards, even though
        //the constructor of Card class would parse them afterwards, because the ID are periodical - 
        // - that means an ID of 5 would create the same card as ID of 29 with a deck size of 24
        // ID%DeckSize basically.
        private int[] GenerateListOfUniqueIDs()
        {
            Random rnd = new Random();
            int[] returnValue = new int[ProjectVariables.HandSize];
            for (int i = 0; i < ProjectVariables.HandSize; i++)
            {
                int temp = rnd.Next(ProjectVariables.FigureCount * ProjectVariables.SuitCount);
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
    }
}