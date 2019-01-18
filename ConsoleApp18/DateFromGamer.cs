using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class DateFromGamer
    {
        private ConsoleInput input = new ConsoleInput();
        private ConsoleOutput iutput = new ConsoleOutput();

        public void ShowStart()
        {
            iutput.ShowSomeOutput(TextCuts.StartGame);
            iutput.ShowSomeOutput(TextCuts.EnterName);
        }

        public string GetUserName()
        {
            string userName = input.InputString();

            return userName;
        }

        public int GetNumberOfBots()
        {
            iutput.ShowSomeOutput(TextCuts.HowManyBots,Settings.MaxBots);

            int howMany = input.InputInt(0, Settings.MaxBots);
            int howManyBots = howMany;

            return howManyBots;
        }

        public int GetGamerRate()
        {
            iutput.ShowSomeOutput(TextCuts.EnterValidRate, Settings.MinRateForGamer, Settings.MaxRateForGamer);

            int rate = input.InputInt(Settings.MinRateForGamer, Settings.MaxRateForGamer);

            iutput.ShowSomeOutput(TextCuts.ShowStartRaund);

            return rate;
        }
    }
}

