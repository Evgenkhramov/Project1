using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Dictionary;

namespace BlackJackProject
{
    public class DistributionOfPlayingCards
    {
        private ConsoleOutput output = new ConsoleOutput();
        public void DoRound(Gamer gamer, List<OneCard> newSomeDeck)
        { 
            output.ShowSomeOutput(gamer.Name);

            OneCard SomeCard = PrepareCardDeck.GetSomeCard(newSomeDeck);
            int cardPoints = CardPointDictionary.cardPointDict[SomeCard.CardNumber];
            gamer.Points += cardPoints;

            output.ShowResult(SomeCard.CardNumber, SomeCard.CardSuit, gamer.Points);
        }
    }
}
