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
                if (SomeGamersArray[0].GamerStatus == Enums.GamerStatusEnum.Blackjack)
                {
                    if (SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Blackjack)
                    {
                        SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                    }
                    else
                    {
                        SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                    }

                }
                else if (SomeGamersArray[0].GamerStatus == Enums.GamerStatusEnum.Enough)
                {
                    if (SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Blackjack || SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints > SomeGamersArray[0].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    else if (SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Many || SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints < SomeGamersArray[0].GamerPoints && SomeGamersArray[0].GamerPoints < 21)
                    {
                        SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Lose;
                        SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        SomeGamersArray[i].GamerWinCash = 0;
                    }
                    else if (SomeGamersArray[i].GamerStatus == Enums.GamerStatusEnum.Enough && SomeGamersArray[i].GamerPoints <= 21 && SomeGamersArray[0].GamerPoints < SomeGamersArray[i].GamerPoints)
                    {
                        SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Win;
                        SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                    }
                    
                }
                else
                {
                    if (SomeGamersArray[0].GamerStatus == Enums.GamerStatusEnum.Many)
                    {

                        if (SomeGamersArray[i].GamerPoints < 20)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate;
                            SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Win;
                        }
                        else if (SomeGamersArray[i].GamerPoints == 21)
                        {
                            SomeGamersArray[i].GamerWinCash = SomeGamersArray[i].GamerRate * 3 / 2;
                            SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Blackjack;
                        }
                        else
                        {
                            SomeGamersArray[i].GamerWinCash = 0;
                            SomeGamersArray[i].GamerStatus = Enums.GamerStatusEnum.Lose;
                            SomeGamersArray[0].GamerWinCash += SomeGamersArray[i].GamerRate;
                        }
                    }
                }
            }

            return SomeGamersArray;
        }
    }
}
