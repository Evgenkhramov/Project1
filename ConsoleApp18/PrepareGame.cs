using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class PrepareGame
    {
        public InputOutput inputOutput = new InputOutput();
        public List<Card> newSomeDeck = CardDeck.DoDeck();

        public List<Card> DoPrepare(Gamer[] GamerArray)
        {
           // List<Card> newSomeDeck = CardDeck.DoDeck();

            inputOutput.ShowSomeOutput(" New Cards! ");
            FirstRound oneRound = new FirstRound();

            for (int i = 0; i < 2; i++)
            {
                oneRound.DoRound(GamerArray, newSomeDeck);
            }
            inputOutput.ShowSomeOutput(" Cards on Table!");
            return newSomeDeck;
        }

    }
}
