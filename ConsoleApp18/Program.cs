using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18;

namespace ConsoleApp18
{
    class Program
    {

        static void Main(string[] args)
        {
            int maxRate = 50;
            int maxBot = 6;
            InputOutput IOThisGame = new InputOutput();
            IOThisGame.SomeOutput("Game Start!");
            IOThisGame.SomeOutput("Enter your name please:");
            string UserName = Console.ReadLine();
            IOThisGame.SomeOutput("How many bots? (1-6)");
            int HowMany = IOThisGame.IntInput(0,maxBot);
            int HowManyBots = HowMany + 2;
            GamersArray ThisGameMembers = new GamersArray();
            Gamer[] GamerArray = ThisGameMembers.DoGamerArray(HowManyBots,UserName);

            IOThisGame.SomeOutput("New round Start!");

            IOThisGame.SomeOutput("Enter your Rate please from 1 $ to 50 $");
            var newSomeDeck = CardDeck.Deck();
            GamerArray[1].GamerRate = IOThisGame.IntInput(1, maxRate);
            IOThisGame.SomeOutput(" New Cards! ");
            FirstRound OneGame = new FirstRound();
            for (int i = 0; i < 2; i++)
            {
                OneGame.DoRound(GamerArray, newSomeDeck);
            }
            IOThisGame.SomeOutput(" Cards on Table!");
            for (int i = 0; i < GamerArray.Length; i++)
            {
                while (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Plays)
                {
                    NextRound.RoundForGamer(GamerArray[i], newSomeDeck);
                }
            }

       
            for (int i = 1; i < GamerArray.Length; i++)
            {
                if (GamerArray[0].GamerStatus == Gamer.GamerStatusEnum.Blackjack)
                {
                    if (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Blackjack)
                    {
                        GamerArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        GamerArray[i].GamerWinCash = GamerArray[i].GamerRate;
                    }
                    else
                    {
                        GamerArray[i].GamerStatus = Gamer.GamerStatusEnum.Lose;
                        GamerArray[0].GamerWinCash += GamerArray[i].GamerRate;
                    }

                }
                else if (GamerArray[0].GamerStatus == Gamer.GamerStatusEnum.Enough)
                {
                    if (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Blackjack || GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Enough && GamerArray[i].GamerPoints >= GamerArray[0].GamerPoints)
                    {
                        GamerArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        GamerArray[i].GamerWinCash = GamerArray[i].GamerRate * 3 / 2;
                    }
                    else if (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Many || GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Enough && GamerArray[i].GamerPoints < GamerArray[0].GamerPoints)
                    {
                        GamerArray[i].GamerStatus = Gamer.GamerStatusEnum.Lose;
                        GamerArray[0].GamerWinCash += GamerArray[i ].GamerRate;
                        GamerArray[i].GamerWinCash = 0;
                    }
                    else
                    {
                        Console.WriteLine("Some troubles");
                    }
                }
                else
                {
                    if (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Many)
                    {
                        GamerArray[0].GamerWinCash += GamerArray[i].GamerRate;
                    }

                }
            }
            IOThisGame.FinishGameOutput(GamerArray);
            Console.ReadLine();
            
        }
    }
}
