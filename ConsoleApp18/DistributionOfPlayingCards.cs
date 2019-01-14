using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    class DistributionOfPlayingCards
    {    
        public void DoRound(Gamer[] GamerArray, List<OneCard> newSomeDeck)
        {
            ConsoleInputOutput inputOutput = new ConsoleInputOutput();
            for (int i = 0; i < GamerArray.Length; i++)
            {
                inputOutput.ShowSomeOutput(GamerArray[i].Name);

                OneCard element = PrepareCardDeck.GetSomeCard(newSomeDeck);

                int cardPoints = OneCard.CardPointDict[element.CardNumber];

                GamerArray[i].Points += cardPoints;

                inputOutput.ShowResult( element.CardNumber, element.CardSuit, GamerArray[i].Points);
            }
        }
    }
}
