using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class RoundOfGame
    {
        public static ConsoleInputOutput inputOutput = new ConsoleInputOutput();

        public static void DoRoundForGamer(Gamer SomeGamer, List<OneCard> newSomeDeck)
        {
            if (SomeGamer.GamerName == "Casino")
            {
                if (SomeGamer.GamerPoints < Settings.MinimumCasinoPointsLevel)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.GamerStatus = Enums.GamerStatusEnum.Enough;
                }
            }
            else if (SomeGamer.GamerIndex == 1 && SomeGamer.GamerStatus != Enums.GamerStatusEnum.Enough)
            {
                inputOutput.ShowSomeOutput(TextCuts.TextCuts.NowYouHave + SomeGamer.GamerPoints);
                inputOutput.ShowSomeOutput(TextCuts.TextCuts.DoYouWantCard);

                string answer = Console.ReadLine();
                if (answer == TextCuts.TextCuts.y)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.GamerStatus = Enums.GamerStatusEnum.Enough;
                    Console.WriteLine(SomeGamer.GamerStatus);
                }
            }
            else
            {
                if (SomeGamer.GamerStatus != Enums.GamerStatusEnum.Enough)
                {
                    if (GetRandom() == 1)
                    {
                        DoPoints(SomeGamer, newSomeDeck);
                    }
                    else
                    {
                        SomeGamer.GamerStatus = Enums.GamerStatusEnum.Enough;
                    }
                }
            }
        }

        public static void DoGamerStatus(Gamer SomeGamer)
        {
            if (SomeGamer.GamerPoints < Settings.BlackJeckPoints)
            {
                SomeGamer.GamerStatus = Enums.GamerStatusEnum.Plays;
            }
            else if (SomeGamer.GamerPoints == Settings.BlackJeckPoints)
            {
                SomeGamer.GamerStatus = Enums.GamerStatusEnum.Blackjack;
            }
            else
            {
                SomeGamer.GamerStatus = Enums.GamerStatusEnum.Many;
            }
        }

        public static void DoPoints(Gamer SomeGamer, List<OneCard> newSomeDeck)
        {
            Console.WriteLine(SomeGamer.GamerName);
            var element = CardDeck.GetSomeCard(newSomeDeck);
            var cardPoints = OneCard.CardPointDict[element.CardNumber];
            SomeGamer.GamerPoints += cardPoints;
            DoGamerStatus(SomeGamer);
            inputOutput.ShowResult(element.CardNumber, element.CardSuit, SomeGamer.GamerPoints);
            Console.WriteLine(SomeGamer.GamerStatus);
            inputOutput.ShowSomeOutput("");
        }

        public static int GetRandom()
        {
            Random random = new Random(2);
            int randomNumber = random.Next(2);

            return randomNumber;
        }


    }
}
