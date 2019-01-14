using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18.Enums;

namespace ConsoleApp18
{
    class GameResult
    {
        public Gamer[] GetFinishResult(Gamer[] SomeGamersArray)
        {
            for (int i = 1; i < SomeGamersArray.Length; i++)
            {
                if (SomeGamersArray[0].GamerStatus == GamerStatusEnum.Blackjack)
                {
                    if (SomeGamersArray[i].GamerStatus == GamerStatusEnum.Blackjack)
                    {
                        SomeGamersArray[i].GamerStatus = GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                    }
                    else
                    {
                        SomeGamersArray[i].GamerStatus = GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                    }

                }
                else if (SomeGamersArray[0].GamerStatus == GamerStatusEnum.Enough)
                {
                    if (SomeGamersArray[i].GamerStatus == GamerStatusEnum.Blackjack || SomeGamersArray[i].GamerStatus == GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints > SomeGamersArray[0].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    if (SomeGamersArray[i].GamerStatus == GamerStatusEnum.Many || SomeGamersArray[i].GamerStatus == GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints < SomeGamersArray[0].GamerPoints && SomeGamersArray[0].GamerPoints < Settings.BlackJeckPoints)
                    {
                        SomeGamersArray[i].GamerStatus = GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        SomeGamersArray[i].GamerWinCash = 0;
                    }
                    if (SomeGamersArray[i].GamerStatus == GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints <= Settings.BlackJeckPoints && SomeGamersArray[0].GamerPoints < SomeGamersArray[i].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    
                }
                else
                {
                    if (SomeGamersArray[0].GamerStatus == GamerStatusEnum.Many)
                    {

                        if (SomeGamersArray[i].GamerPoints < Settings.BlackJeckPoints)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                            SomeGamersArray[i].GamerStatus = GamerStatusEnum.Win;
                        }
                        if (SomeGamersArray[i].GamerPoints == Settings.BlackJeckPoints)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                            SomeGamersArray[i].GamerStatus = GamerStatusEnum.Blackjack;
                        }
                        else
                        {
                            SomeGamersArray[i].GamerWinCash = 0;
                            SomeGamersArray[i].GamerStatus = GamerStatusEnum.Lose;
                            SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        }
                    }
                }
            }

            return SomeGamersArray;
        }
    }
}
