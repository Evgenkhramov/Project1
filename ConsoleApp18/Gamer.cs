using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Gamer
    {
         public enum GamerStatusEnum
        {
            Win,
            Many,
            Plays,
            Blackjack,
            Enough,
            Lose
        }

        public int GamerIndex = 0;
        public string GamerName = "Gamer Bot";
        public int GamerRate = 0;
        public int GamerPoints = 0;
        public GamerStatusEnum GamerStatus = GamerStatusEnum.Plays;
        public int GamerWinCash = 0;
    }
}
