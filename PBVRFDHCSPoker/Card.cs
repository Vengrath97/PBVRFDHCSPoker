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
        //ID is being validated inside the constructor, but it is recommended to validate the ID
        //during ID generation, as to avoid Card-Duplication, because of the periodic nature
        //of the ID->Card generation process
        public Card(int cardID)
        {
            int validID = cardID % (ProjectVariables.FigureCount * ProjectVariables.SuitCount);
            Figure = (Category.Figure)(validID % ProjectVariables.FigureCount);
            Suit = (Category.Suit)(validID / ProjectVariables.FigureCount);
        }
    }
}