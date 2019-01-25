﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    public class Settings
    {

        public static int BotRate { get; private set; }
        public static int DealerRate { get; private set; }
        public static int BlackJeckPoints { get; private set; }
        public static int MinimumCasinoPointsLevel { get; private set; }
        public static int MaxRateForGamer { get; private set; }
        public static int MinRateForGamer { get; private set; }
        public static int MaxBots { get; private set; }
        public static int MinBots { get; private set; }
        public static int HowManyCardsInFirstRound { get; private set; }

        public static string HistoryDirectoryPath { get; private set; }
        public static string HistoryDirectorySubPath { get; private set; }
        public static string HistoryFileName { get; private set; }

        public Settings()
        {
            BotRate = 10;
            DealerRate = 0;
            BlackJeckPoints = 21;
            MinimumCasinoPointsLevel = 17;
            MaxRateForGamer = 50;
            MinRateForGamer = 1;
            MaxBots = 6;
            MinBots = 0;
            HowManyCardsInFirstRound = 2;

            HistoryDirectoryPath = @"C:\BlackJeck";
            HistoryDirectorySubPath = @"history";
            HistoryFileName = "HistoryText.txt";

        }
    }
}
