using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Gamer
    {
        public static string[] GamerStatusArray = new string[] { "Win", "Lost", "Plays","BlackJeck" };

        public int GamerIndex = 0;
        public string GamerName = "Gamer";
        public int GamerRate = 0;
        public int GamerPoints = 0;
        public string GamerStatus = GamerStatusArray[2];
        public int GamerWinCash = 0;
    }
}
