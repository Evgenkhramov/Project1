using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Enums;

namespace BlackJackProject
{
    class GameResult
    {
        public Gamer[] GetFinishResult(Gamer[] SomeGamersArray)
        {
            for (int i = 1; i < SomeGamersArray.Length; i++)
            {
                if (SomeGamersArray[0].Status == GamerStatus.Blackjack)
                {
                    if (SomeGamersArray[i].Status == GamerStatus.Blackjack)
                    {
                        SomeGamersArray[i].Status = GamerStatus.Win;
                        SomeGamersArray[i].WinCash = SomeGamersArray[i].Rate;
                    }
                    else
                    {
                        SomeGamersArray[i].Status = GamerStatus.Lose;
                        SomeGamersArray[0].WinCash += SomeGamersArray[i].Rate;
                    }

                }
                else if (SomeGamersArray[0].Status == GamerStatus.Enough)
                {
                    if (SomeGamersArray[i].Status == GamerStatus.Blackjack || SomeGamersArray[i].Status == GamerStatus.Enough && SomeGamersArray[i].Points > SomeGamersArray[0].Points)
                    {
                        SomeGamersArray[i].Status = GamerStatus.Win;
                        SomeGamersArray[i].WinCash = SomeGamersArray[i].Rate * 3 / 2;
                    }
                    if (SomeGamersArray[i].Status == GamerStatus.Many || SomeGamersArray[i].Status == GamerStatus.Enough && SomeGamersArray[i].Points < SomeGamersArray[0].Points && SomeGamersArray[0].Points < Settings.BlackJeckPoints)
                    {
                        SomeGamersArray[i].Status = GamerStatus.Lose;
                        SomeGamersArray[0].WinCash += SomeGamersArray[i].Rate;
                        SomeGamersArray[i].WinCash = 0;
                    }
                    if (SomeGamersArray[i].Status == GamerStatus.Enough && SomeGamersArray[i].Points <= Settings.BlackJeckPoints && SomeGamersArray[0].Points < SomeGamersArray[i].Points)
                    {
                        SomeGamersArray[i].Status = GamerStatus.Win;
                        SomeGamersArray[i].WinCash = SomeGamersArray[i].Rate * 3 / 2;
                    }
                    
                }
                else
                {
                    if (SomeGamersArray[0].Status == GamerStatus.Many)
                    {

                        if (SomeGamersArray[i].Points < Settings.BlackJeckPoints)
                        {
                            SomeGamersArray[i].WinCash = SomeGamersArray[i].Rate;
                            SomeGamersArray[i].Status = GamerStatus.Win;
                        }
                        if (SomeGamersArray[i].Points == Settings.BlackJeckPoints)
                        {
                            SomeGamersArray[i].WinCash = SomeGamersArray[i].Rate * 3 / 2;
                            SomeGamersArray[i].Status = GamerStatus.Blackjack;
                        }
                        else
                        {
                            SomeGamersArray[i].WinCash = 0;
                            SomeGamersArray[i].Status = GamerStatus.Lose;
                            SomeGamersArray[0].WinCash += SomeGamersArray[i].Rate;
                        }
                    }
                }
            }

            return SomeGamersArray;
        }
    }
}
