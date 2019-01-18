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
    public class RoundOfGame
    {
         private static ConsoleOutput output = new ConsoleOutput();

        public void DoRoundForGamer(Gamer SomeGamer, List<OneCard> newSomeDeck)
        {
            if (SomeGamer.Role == GamerRole.Dealer)
            {
                if (SomeGamer.Points < Settings.MinimumCasinoPointsLevel)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                if(SomeGamer.Points >= Settings.MinimumCasinoPointsLevel)
                {
                    SomeGamer.Status = GamerStatus.Enough;
                }
            }
            if (SomeGamer.Role == GamerRole.Gamer && SomeGamer.Status != GamerStatus.Enough)
            {
                output.ShowSomeOutput(TextCuts.NowYouHave + SomeGamer.Points);
                output.ShowSomeOutput(TextCuts.DoYouWantCard);

                string answer = Console.ReadLine();
                if (answer == TextCuts.Yes)
                {
                    DoPoints(SomeGamer, newSomeDeck);
                }
                if(answer != TextCuts.Yes)
                {
                    SomeGamer.Status = GamerStatus.Enough;
                    output.ShowSomeOutput(SomeGamer.Status);
                }
            }
            if(SomeGamer.Role == GamerRole.Bot)
            {
                if (SomeGamer.Status != GamerStatus.Enough)
                {
                    if (GetRandom(2) == 1)
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
            OneCard element = PrepareCardDeck.GetSomeCard(newSomeDeck);
            int cardPoints = CardPointDictionary.cardPointDict[element.CardNumber];
            SomeGamer.Points += cardPoints;
            DoGamerStatus(SomeGamer);
            output.ShowResult(element.CardNumber, element.CardSuit, SomeGamer.Points);
            output.ShowSomeOutput(SomeGamer.Status);
            output.ShowSomeOutput("");
        }

        public static int GetRandom(int maxNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(maxNumber);

            return randomNumber;
        }


    }
}
