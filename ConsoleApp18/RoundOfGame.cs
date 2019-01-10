using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class RoundOfGame
    {
        public static void DoRoundForGamer(Gamer SomeGamer, List<Card> newSomeDeck)
        {
            if (SomeGamer.GamerIndex == 0)
            {
                if (SomeGamer.GamerPoints < 17)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Enough;
                }
            }
            else if (SomeGamer.GamerIndex == 1 && SomeGamer.GamerStatus != Gamer.GamerStatusEnum.Enough)
            {
                Console.WriteLine("Are you want card? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Enough;
                    Console.WriteLine(SomeGamer.GamerStatus);
                }
            }
            else
            {
                if (SomeGamer.GamerStatus != Gamer.GamerStatusEnum.Enough)
                {
                    if (RandomAnswer() == 1)
                    {
                        DoPoints( SomeGamer, newSomeDeck);
                    }
                    else
                    {
                        SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Enough;
                    }
                }
            }  
        }
        public static void DoGamerStatus(Gamer SomeGamer)
        {
            if (SomeGamer.GamerPoints < 21)
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Plays;
            }
            else if (SomeGamer.GamerPoints == 21)
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Blackjack;
            }
            else
            {
                SomeGamer.GamerStatus = Gamer.GamerStatusEnum.Many;
            }    
        }
        public static void DoPoints(Gamer SomeGamer, List<Card> newSomeDeck)
        {
            Console.WriteLine(SomeGamer.GamerName);
            var element = CardDeck.TakeSomeCard(newSomeDeck);
            var cardPoints = Card.CardPointDict[element.CardNumber];
            SomeGamer.GamerPoints += cardPoints;
            DoGamerStatus(SomeGamer);
            Console.WriteLine("{0},{1}, Total Points = {2}", element.CardNumber, element.CardSuit, SomeGamer.GamerPoints);
            Console.WriteLine(SomeGamer.GamerStatus);
            Console.WriteLine();
        }
        public static int RandomAnswer()
        {
            Random rand = new Random(2);
            int rnd = rand.Next(2);
            return rnd;
        }
       

    }
}
