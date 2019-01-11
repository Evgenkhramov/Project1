using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class DateFromGamer
    {
        int maxRate = 50;
        int maxBot = 6;
        public ConsoleInputOutput inputOutput = new ConsoleInputOutput();

        public void ShowStart()
        {
            inputOutput.ShowSomeOutput("Game Start!");
            inputOutput.ShowSomeOutput("Enter your name please:");
        }

        public string GetUserName()
        {
            string userName = inputOutput.StringInput();

            return userName;
        }
        public int GetNumberOfBots()
        {
            inputOutput.ShowSomeOutput("How many bots? (1-6)");
            int howMany = inputOutput.IntInput(0, maxBot);
            int howManyBots = howMany + 2;

            return howManyBots;
        }
        public int GetGamerRate()
        {
            inputOutput.ShowSomeOutput("Enter your Rate please from 1 $ to 50 $");
            int rate = inputOutput.IntInput(1, maxRate);
            inputOutput.ShowSomeOutput("New round Start!");

            return rate;
        }       
    }
}

