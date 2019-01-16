using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Dictionary;

namespace BlackJackProject
{
    class DistributionOfPlayingCards
    {
        public void DoRound(Gamer gamer, List<OneCard> newSomeDeck)
        {
            ConsoleOutput output = new ConsoleOutput();

            output.ShowSomeOutput(gamer.Name);

            OneCard element = PrepareCardDeck.GetSomeCard(newSomeDeck);
            int cardPoints = CardPointDictionary.cardPointDict[element.CardNumber];
            gamer.Points += cardPoints;

            output.ShowResult(element.CardNumber, element.CardSuit, gamer.Points);

        }
    }
}
