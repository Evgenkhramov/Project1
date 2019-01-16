using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    class PrepareGameDesk
    {
        public ConsoleOutput output = new ConsoleOutput();
        public List<OneCard> newSomeDeck = PrepareCardDeck.DoOneDeck();


        public List<OneCard> DistributionCards(Gamer gamer)
        {
            output.ShowSomeOutput(TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();

            for (int i = 0; i < 2; i++)
            {
                oneRound.DoRound(gamer, newSomeDeck);
            }
            output.ShowSomeOutput(TextCuts.CardsOnTable);

            return newSomeDeck;
        }
    }
}
