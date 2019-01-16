using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Enums;
using BlackJackProject.Constanta;
using BlackJackProject.Dictionary;


namespace BlackJackProject
{
    class RoundOfGame
    {
        public static ConsoleInput input = new ConsoleInput();
        public static ConsoleOutput output = new ConsoleOutput();

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
                output.ShowSomeOutput(TextCuts.NowYouHave + SomeGamer.Points);
                output.ShowSomeOutput(TextCuts.DoYouWantCard);

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
            output.ShowSomeOutput(SomeGamer.Name);
            var element = PrepareCardDeck.GetSomeCard(newSomeDeck);
            var cardPoints = CardPointDictionary.cardPointDict[element.CardNumber];
            SomeGamer.Points += cardPoints;
            DoGamerStatus(SomeGamer);
            output.ShowResult(element.CardNumber, element.CardSuit, SomeGamer.Points);
            Console.WriteLine(SomeGamer.Status);
            output.ShowSomeOutput("");
        }

        public static int GetRandom()
        {
            Random random = new Random(2);
            int randomNumber = random.Next(2);

            return randomNumber;
        }


    }
}
