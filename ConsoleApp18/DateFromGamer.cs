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
        public ConsoleInput Input = new ConsoleInput();
        public ConsoleOutput Output = new ConsoleOutput();

        public void ShowStart()
        {
            Output.ShowSomeOutput(TextCuts.StartGame);
            Output.ShowSomeOutput(TextCuts.EnterName);
        }

        public string GetUserName()
        {
            string userName = Input.InputString();

            return userName;
        }

        public int GetNumberOfBots()
        {
            Output.ShowSomeOutput(TextCuts.HowManyBots,Settings.MaxBots);

            int howMany = Input.InputInt(0, Settings.MaxBots);
            int howManyBots = howMany;

            return howManyBots;
        }

        public int GetGamerRate()
        {
            Output.ShowSomeOutput(TextCuts.EnterValidRate, Settings.MinRateForGamer, Settings.MaxRateForGamer);

            int rate = Input.InputInt(Settings.MinRateForGamer, Settings.MaxRateForGamer);

            Output.ShowSomeOutput(TextCuts.ShowStartRaund);

            return rate;
        }
    }
}

