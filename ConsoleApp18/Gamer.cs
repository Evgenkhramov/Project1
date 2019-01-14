using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18.Enums;

namespace ConsoleApp18
{
    public class Gamer
    {
        public int GamerIndex { get; set; }
        public string GamerName { get; set; }
        public int GamerRate { get; set; }
        public int GamerPoints { get; set; }
        public GamerStatusEnum GamerStatus { get; set; }
        public int GamerWinCash { get; set; }

        public Gamer()
        {
            GamerIndex = 0;
            GamerName = TextCuts.TextCuts.BotName;
            GamerRate = 0;
            GamerPoints = 0;
            GamerStatus = GamerStatusEnum.Plays;
            GamerWinCash = 0;
        }
    }
}

