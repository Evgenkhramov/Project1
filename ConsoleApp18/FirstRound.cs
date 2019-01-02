using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class FirstRound
    {
        public static void DoRound(Gamer[] GamerArray, List<Card> newSomeDeck)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(GamerArray[i].GamerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Cards.CardPointDict[element.CardNumber];
                GamerArray[i].GamerPoints += cardPoints;
                Console.WriteLine("{0},{1}, Total Points = {2}", element.CardNumber, element.Suit, GamerArray[i].GamerPoints);
            }
        }
    }
}
