using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    public class Settings
    {
        public static int BotRate { get; private set; }
        public static int BlackJeckPoints { get; private set; }
        public static int MinimumCasinoPointsLevel { get; private set; }
        public static int MaxRateForGamer { get; private set; }
        public static int MinRateForGamer { get; private set; }
        public static int MaxBots { get; private set; }

        public Settings()
        {
            BotRate = 10;
            BlackJeckPoints = 21;
            MinimumCasinoPointsLevel = 17;
            MaxRateForGamer = 50;
            MinRateForGamer = 1;
            MaxBots = 6;
        }
    }
}
