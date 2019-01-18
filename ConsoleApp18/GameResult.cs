using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Enums;

namespace BlackJackProject
{
    public class GameResult
    {
        public List<Gamer> GetFinishResult(List<Gamer> SomeGamersList)
        {
            Gamer dealer = new Gamer();
            foreach (Gamer player in SomeGamersList)
            {
                if (player.Role == GamerRole.Dealer)
                {
                    dealer = player;
                }
            }
            foreach (Gamer player in SomeGamersList)
            {
                if (player.Role != GamerRole.Dealer)
                {
                    if (player.Status == GamerStatus.Blackjack && dealer.Status != GamerStatus.Blackjack)
                    {
                        player.Status = GamerStatus.Win;
                        player.WinCash = 3 / 2 * player.Rate;
                    }
                    if (player.Status == GamerStatus.Blackjack && dealer.Status == GamerStatus.Blackjack)
                    {
                        player.Status = GamerStatus.Win;
                        player.WinCash = player.Rate;
                    }
                    if (player.Status == GamerStatus.Enough && dealer.Status == GamerStatus.Blackjack)
                    {
                        player.Status = GamerStatus.Win;
                        player.WinCash = 0;
                        dealer.WinCash += player.Rate;
                    }
                    if (player.Status == GamerStatus.Enough && player.Points >= dealer.Points && dealer.Status == GamerStatus.Enough)
                    {
                        player.Status = GamerStatus.Win;
                        player.WinCash = 3 / 2 * player.Rate;
                    }
                    if (player.Status == GamerStatus.Enough && player.Points < dealer.Points && dealer.Status == GamerStatus.Enough)
                    {
                        player.Status = GamerStatus.Lose;
                        player.WinCash = 0;
                        dealer.Rate += player.Rate;
                    }
                    if (player.Status == GamerStatus.Enough && player.Points < dealer.Points && dealer.Status == GamerStatus.Many)
                    {
                        player.Status = GamerStatus.Win;
                        player.WinCash = 3 / 2 * player.Rate;
                    }
                    if (player.Status == GamerStatus.Many && player.Points < dealer.Points && dealer.Status == GamerStatus.Many)
                    {
                        player.Status = GamerStatus.Lose;
                        player.WinCash = 0;
                        dealer.Rate += player.Rate;
                    }

                }
            }
            return SomeGamersList;
        }
    }
}
