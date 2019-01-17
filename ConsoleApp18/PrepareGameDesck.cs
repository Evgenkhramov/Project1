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

        public List<Gamer> DistributionCards(List<Gamer> gamer, List<OneCard> cardDeck)
        {
            output.ShowSomeOutput(TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();
            foreach (Gamer player in gamer)
            {
                oneRound.DoRound(player, cardDeck);
            }
            output.ShowSomeOutput(TextCuts.CardsOnTable);

            return gamer;
        }
        //public Gamer DistributionCards(Gamer gamer, List<OneCard> cardDeck)
        //{

        //    var oneRound = new DistributionOfPlayingCards();
        //    oneRound.DoRound(gamer, cardDeck);

        //    return gamer;
        //}
    }
}
