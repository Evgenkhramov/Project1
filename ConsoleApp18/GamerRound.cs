using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class GamerRound
    {
        public static void FirstRound(Gamer SomeGamer, List<Card> newSomeDeck)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(SomeGamer.GamerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Cards.CardPointDict[element.CardNumber];
                SomeGamer.GamerPoints += cardPoints;

                DoGamerStatus(SomeGamer);
                Console.WriteLine(SomeGamer.GamerStatus);
                Console.WriteLine("{0},{1}", element.CardNumber, element.Suit);
                Console.WriteLine("Total Gamer Points = " + SomeGamer.GamerPoints);
                Console.WriteLine();
            }
            
        }
        public static void RoundForGamer(Gamer SomeGamer, List<Card> newSomeDeck)
        {
            if (SomeGamer.GamerStatus != "Many")
            {
                Console.WriteLine(SomeGamer.GamerName);

                Console.WriteLine("Do you what more cards? y/n");
                string answer = Console.ReadLine();
                if (answer == "y" || SomeGamer.HowManyRound < 2)
                {
                    var element = CardDeck.TakeSomeCard(newSomeDeck);
                    var cardPoints = Cards.CardPointDict[element.CardNumber];
                    SomeGamer.GamerPoints += cardPoints;

                    DoGamerStatus(SomeGamer);
                    Console.WriteLine(SomeGamer.GamerStatus);
                    Console.WriteLine("{0},{1}", element.CardNumber, element.Suit);
                    SomeGamer.HowManyRound++;
                }
                else
                {
                    SomeGamer.GamerStatus = Gamer.GamerStatusArray[4];

                    Console.WriteLine(Gamer.GamerStatusArray[4]);
                }


            }
            Console.WriteLine("Total Gamer Points = " + SomeGamer.GamerPoints);


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
    }
}
