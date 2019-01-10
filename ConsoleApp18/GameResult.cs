using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class GameResult
    {
        public Gamer[] DoFinishResult(Gamer[] SomeGamersArray)
        {
            for (int i = 1; i < SomeGamersArray.Length; i++)
            {
                if (SomeGamersArray[0].GamerStatus == Gamer.GamerStatusEnum.Blackjack)
                {
                    if (SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Blackjack)
                    {
                        SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                    }
                    else
                    {
                        SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                    }

                }
                else if (SomeGamersArray[0].GamerStatus == Gamer.GamerStatusEnum.Enough)
                {
                    if (SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Blackjack || SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints > SomeGamersArray[0].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    else if (SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Many || SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints < SomeGamersArray[0].GamerPoints && SomeGamersArray[0].GamerPoints < 21)
                    {
                        SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        SomeGamersArray[i].GamerWinCash = 0;
                    }
                    else if (SomeGamersArray[i].GamerStatus == Gamer.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints <= 21 && SomeGamersArray[0].GamerPoints < SomeGamersArray[i].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    else
                    {
                        Console.WriteLine("Some troubles");
                    }
                }
                else
                {
                    if (SomeGamersArray[0].GamerStatus == Gamer.GamerStatusEnum.Many)
                    {

                        if (SomeGamersArray[i].GamerPoints < 20)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                            SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Win;
                        }
                        if (SomeGamersArray[i].GamerPoints == 21)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                            SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Blackjack;
                        }
                        else
                        {
                            SomeGamersArray[i].GamerWinCash = 0;
                            SomeGamersArray[i].GamerStatus = Gamer.GamerStatusEnum.Lose;
                            SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        }
                    }
                }
            }

            return SomeGamersArray;
        }
    }
}
