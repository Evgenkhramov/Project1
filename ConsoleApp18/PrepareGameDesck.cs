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
        public ConsoleInputOutput inputOutput = new ConsoleInputOutput();
        public List<OneCard> newSomeDeck = PrepareCardDeck.DoOneDeck();


        public List<OneCard> DistributionCards(Gamer[] GamerArray)
        {
            inputOutput.ShowSomeOutput(TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();

            for (int i = 0; i < 2; i++)
            {
                oneRound.DoRound(GamerArray, newSomeDeck);
            }
            inputOutput.ShowSomeOutput(TextCuts.CardsOnTable);

            return newSomeDeck;
        } 
    }
}
