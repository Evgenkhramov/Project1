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
        private IInput input;
        public DateFromGamer(IInput input)
        {
            this.input = input;
        }
        //private ConsoleInput input = new ConsoleInput();
        private ConsoleOutput output = new ConsoleOutput();

        public void ShowStart()
        {
            output.ShowSomeOutput(TextCuts.StartGame);
            output.ShowSomeOutput(TextCuts.EnterName);
        }

        public string GetUserName()
        {
            string userName = input.InputString();
            return userName;
        }

        public int GetNumberOfBots()
        {
            output.ShowSomeOutput(TextCuts.HowManyBots,Settings.MaxBots);

            int howManyBots = input.InputInt(Settings.MinBots, Settings.MaxBots);
         
            return howManyBots;
        }

        public int GetGamerRate()
        {
            output.ShowSomeOutput(TextCuts.EnterValidRate, Settings.MinRateForGamer, Settings.MaxRateForGamer);

            int rate = input.InputInt(Settings.MinRateForGamer, Settings.MaxRateForGamer);

            output.ShowSomeOutput(TextCuts.ShowStartRaund);

            return rate;
        }
    }
}

