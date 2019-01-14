using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    class DateFromGamer
    {
        public ConsoleInputOutput inputOutput = new ConsoleInputOutput();

        public void ShowStart()
        {
            inputOutput.ShowSomeOutput(TextCuts.StartGame);
            inputOutput.ShowSomeOutput(TextCuts.EnterName);
        }

        public string GetUserName()
        {
            string userName = inputOutput.StringInput();

            return userName;
        }

        public int GetNumberOfBots()
        {
            inputOutput.ShowSomeOutput(TextCuts.HowManyBots,Settings.MaxBots);

            int howMany = inputOutput.InputInt(0, Settings.MaxBots);
            int howManyBots = howMany;

            return howManyBots;
        }

        public int GetGamerRate()
        {
            inputOutput.ShowSomeOutput(TextCuts.EnterValidRate, Settings.MinRateForGamer, Settings.MaxRateForGamer);

            int rate = inputOutput.InputInt(Settings.MinRateForGamer, Settings.MaxRateForGamer);

            inputOutput.ShowSomeOutput(TextCuts.ShowStartRaund);

            return rate;
        }
    }
}

