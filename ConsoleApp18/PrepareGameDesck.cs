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
        private IOutput _output;

       public  PrepareGameDesk(IOutput output)
        {
            _output = output;
        }

        public List<Gamer> DistributionCards(List<Gamer> gamerList, List<OneCard> cardDeckList)
        {
            _output.ShowSomeOutput(TextCuts.NewCards);
            var oneRound = new DistributionOfPlayingCards();
            for (int i = 0; i < Settings.HowManyCardsInFirstRound; i++)
            {
                foreach (Gamer player in gamerList)
                {
                    oneRound.DoRound(player, cardDeckList);
                }
            }
            _output.ShowSomeOutput(TextCuts.CardsOnTable);

            return gamerList;
        }
    }
}
