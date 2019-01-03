using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class GamerBot
    {
        public static string[] GamerStatusArray = new string[] { "Win", "Many", "Plays", "BlackJeck", "Enough" };

        public int GamerBotIndex = 0;
        public string GamerName = "GamerBot";
        public int GamerRate = 0;
        public int GamerPoints = 0;
        public string GamerStatus = GamerStatusArray[2];
        public int GamerWinCash = 0;
    }
}
