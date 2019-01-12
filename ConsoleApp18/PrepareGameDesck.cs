using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class PrepareGameDesk

    {
        public ConsoleInputOutput inputOutput = new ConsoleInputOutput();
        public List<OneCard> newSomeDeck = CardDeck.DoOneDeck();

        public List<OneCard> DistributionCards(Gamer[] GamerArray)
        {
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();

            for (int i = 0; i < 2; i++)
            {
                oneRound.DoRound(GamerArray, newSomeDeck);
            }
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.CardsOnTable);

            return newSomeDeck;
        } 
    }
}
