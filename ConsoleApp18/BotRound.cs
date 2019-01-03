using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class BotRound
    {
        public static void RoundForGamer(Gamer SomeGamer, List<Card> newSomeDeck)
        {
            if (SomeGamer.GamerStatus != "Lost" && SomeGamer.GamerPoints < 19)
            {
                Console.WriteLine("Do you what more cards? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine(SomeGamer.GamerName);
                    var element = CardDeck.TakeSomeCard(newSomeDeck);
                    var cardPoints = Cards.CardPointDict[element.CardNumber];
                    SomeGamer.GamerPoints += cardPoints;
                    Console.WriteLine("{0},{1}, Total Points = {2}", element.CardNumber, element.Suit, SomeGamer.GamerPoints);
                    DoGamerStatus(SomeGamer);
                    Console.WriteLine(SomeGamer.GamerStatus);
                }
                else
                {
                    SomeGamer.GamerStatus = Gamer.GamerStatusArray[4];

                    Console.WriteLine(Gamer.GamerStatusArray[4]);
                }
            }

        }
        public static void DoGamerStatus(Gamer SomeGamer)
        {
            if (SomeGamer.GamerPoints < 21)
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusArray[2];
            }
            else if (SomeGamer.GamerPoints == 21)
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusArray[3];
            }
            else
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusArray[1];
            }

        }
        public static int RandomAnswer()
        {
            Random rand = new Random(2);
            int rnd = rand.Next(2);
            return rnd;
        }
    }
}
