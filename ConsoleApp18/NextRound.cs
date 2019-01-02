using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class NextRound
    {
        public static void RoundForGamer(Gamer SomeGamer,  List<Card> newSomeDeck)
        {
            if (SomeGamer.GamerStatus != "Lost")
            {
                Console.WriteLine(SomeGamer.GamerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Cards.CardPointDict[element.CardNumber];
                SomeGamer.GamerPoints += cardPoints;
                Console.WriteLine("{0},{1}, Total Points = {2}", element.CardNumber, element.Suit, SomeGamer.GamerPoints);
            }
            
        }
        public static string DoGamerStatus(Gamer SomeGamer)
        {
            if (SomeGamer.GamerPoints < 21)
            {
                return Gamer.GamerStatusArray[2];
            }
            else if (SomeGamer.GamerPoints == 21)
            {
                return Gamer.GamerStatusArray[3];
            }
            else
            {
                return Gamer.GamerStatusArray[1];
            }
           
        }
    }
}
