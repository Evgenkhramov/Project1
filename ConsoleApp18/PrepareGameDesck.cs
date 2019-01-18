using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class PrepareGameDesk
    {
        ConsoleOutput output = new ConsoleOutput();

        public List<Gamer> DistributionCards(List<Gamer> gamerList, List<OneCard> cardDeckList)
        {
            output.ShowSomeOutput(TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();
            foreach (Gamer player in gamerList)
            {
                oneRound.DoRound(player, cardDeckList);
            }
            output.ShowSomeOutput(TextCuts.CardsOnTable);

            return gamerList;
        }
    }
}
