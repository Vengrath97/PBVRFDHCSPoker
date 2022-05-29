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
        public  Category.Figure Figure { get; set; }
        public  Category.Suit Suit { get; set; }
        public Card(int cardID)
        {
            int validID = cardID % (ProjectVariables.FigureCount * ProjectVariables.SuitCount);
            Figure = (Category.Figure)(validID % ProjectVariables.FigureCount);
            Suit = (Category.Suit)(validID / ProjectVariables.FigureCount);
        }
    }
}