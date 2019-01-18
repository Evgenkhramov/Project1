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
            ConsoleOutput Output = new ConsoleOutput();

            Output.ShowSomeOutput(gamer.Name);

            OneCard SomeCard = PrepareCardDeck.GetSomeCard(newSomeDeck);
            int cardPoints = CardPointDictionary.cardPointDict[SomeCard.CardNumber];
            gamer.Points += cardPoints;

            Output.ShowResult(SomeCard.CardNumber, SomeCard.CardSuit, gamer.Points);

        }
    }
}
