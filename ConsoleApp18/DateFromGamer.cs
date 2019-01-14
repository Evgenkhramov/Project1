using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18.TextCuts;

namespace ConsoleApp18
{
    class DateFromGamer
    {
        public ConsoleInputOutput inputOutput = new ConsoleInputOutput();

        public void ShowStart()
        {
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.StartGame);
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.EnterName);
        }

        public string GetUserName()
        {
            string userName = inputOutput.StringInput();

            return userName;
        }
        public int GetNumberOfBots()
        {
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.HowManyBots,Settings.MaxBots);
            int howMany = inputOutput.InputInt(0, Settings.MaxBots);
            int howManyBots = howMany + 2;

            return howManyBots;
        }
        public int GetGamerRate()
        {
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.EnterValidRate, Settings.MinRateForGamer, Settings.MaxRateForGamer);
            int rate = inputOutput.InputInt(1, Settings.MaxRateForGamer);
            inputOutput.ShowSomeOutput(TextCuts.TextCuts.ShowStartRaund);

            return rate;
        }
    }
}

