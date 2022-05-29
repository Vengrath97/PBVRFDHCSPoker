using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerProject;
namespace PokerProject
{
    class Card
    {
        public  Category.Figure Figure { get => figure; set => figure = value; }
        private Category.Figure figure;
        public  Category.Suit Suit { get => suit; set => suit = value; }
        private Category.Suit suit;

        public Card(int cardID)
        {
            int figureCount = (Enum.GetNames(typeof(Category.Figure)).Length);
            int validID = cardID % (figureCount*4);
            Figure = (Category.Figure)(validID % figureCount);
            Suit = (Category.Suit)(validID / figureCount);
        }
    }
}