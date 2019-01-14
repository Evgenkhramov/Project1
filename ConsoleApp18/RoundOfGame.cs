using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Enums;
using BlackJackProject.Constanta;


namespace BlackJackProject
{
    class RoundOfGame
    {
        public static ConsoleInputOutput inputOutput = new ConsoleInputOutput();

        public static void DoRoundForGamer(Gamer SomeGamer, List<OneCard> newSomeDeck)
        {
            if (SomeGamer.Name == TextCuts.DealerName)
            {
                if (SomeGamer.Points < Settings.MinimumCasinoPointsLevel)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.Status = GamerStatus.Enough;
                }
            }
            if (/*SomeGamer.Index == 1 && */SomeGamer.Status != GamerStatus.Enough)
            {
                inputOutput.ShowSomeOutput(TextCuts.NowYouHave + SomeGamer.Points);
                inputOutput.ShowSomeOutput(TextCuts.DoYouWantCard);

                string answer = Console.ReadLine();
                if (answer == TextCuts.Yes)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                else
                {
                    SomeGamer.Status = GamerStatus.Enough;
                    Console.WriteLine(SomeGamer.Status);
                }
            }
            else
            {
                if (SomeGamer.Status != GamerStatus.Enough)
                {
                    if (GetRandom() == 1)
                    {
                        DoPoints(SomeGamer, newSomeDeck);
                    }
                    else
                    {
                        SomeGamer.Status = GamerStatus.Enough;
                    }
                }
            }
        }

        public static void DoGamerStatus(Gamer SomeGamer)
        {
            if (SomeGamer.Points < Settings.BlackJeckPoints)
            {
                SomeGamer.Status = GamerStatus.Plays;
            }
            else if (SomeGamer.Points == Settings.BlackJeckPoints)
            {
                SomeGamer.Status = GamerStatus.Blackjack;
            }
            else
            {
                SomeGamer.Status = GamerStatus.Many;
            }
        }

        public static void DoPoints(Gamer SomeGamer, List<OneCard> newSomeDeck)
        {
            inputOutput.ShowSomeOutput(SomeGamer.Name);
            var element = PrepareCardDeck.GetSomeCard(newSomeDeck);
            var cardPoints = OneCard.CardPointDict[element.CardNumber];
            SomeGamer.Points += cardPoints;
            DoGamerStatus(SomeGamer);
            inputOutput.ShowResult(element.CardNumber, element.CardSuit, SomeGamer.Points);
            Console.WriteLine(SomeGamer.Status);
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
