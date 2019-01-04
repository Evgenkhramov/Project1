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
            Console.WriteLine("Game Start!");
            Console.WriteLine("Enter your name please:");
            string UserName = Console.ReadLine();
            Console.WriteLine("How many bots? (1-6)");
            int HowMany = int.Parse(Console.ReadLine());
            int HowManyBots = HowMany + 2;
            Gamer[] GamerArray = new Gamer[HowManyBots];
            for (int i = 0; i < HowManyBots; i++)
            {
                GamerArray[i] = new Gamer();
                GamerArray[i].GamerIndex = i;
                GamerArray[i].GamerRate = 10;
            }
            GamerArray[0].GamerName = "Casino";
            GamerArray[0].GamerRate = 0;
            GamerArray[1].GamerName = UserName;
            


            Console.WriteLine("******** New round Start! ********");
            Console.WriteLine("Enter your Rate please from 1 $ to 50 $");
            var newSomeDeck = CardDeck.Deck();
            GamerArray[1].GamerRate = int.Parse(Console.ReadLine());
            Console.WriteLine("******** New Cards! ********");
            FirstRound OneGame = new FirstRound();
            for (int i = 0; i < 2; i++)
            {
                OneGame.DoRound(GamerArray, newSomeDeck);
            }
            Console.WriteLine("******** Cards on Table! ********");
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
            for (int i = 0; i < GamerArray.Length; i++)
            {
                Console.WriteLine("Gamer Name:{0} , Gamer Status: {1}, Gamer WinCash {2} ", GamerArray[i].GamerName, GamerArray[i].GamerStatus, GamerArray[i].GamerWinCash);
            }



        }
    }
}
