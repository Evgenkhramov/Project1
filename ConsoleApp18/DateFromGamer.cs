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
        public InputOutput inputOutput = new InputOutput();

        public void ShowStart()
        {
            inputOutput.ShowSomeOutput("Game Start!");
            inputOutput.ShowSomeOutput("Enter your name please:");
        }

        public string GetUserName()
        {
            string UserName = inputOutput.StringInput();
            return UserName;
        }
        public int HowBots()
        {
            inputOutput.ShowSomeOutput("How many bots? (1-6)");
            int HowMany = inputOutput.IntInput(0, maxBot);
            int HowManyBots = HowMany + 2;
            return HowManyBots;
        }
        public int GamerRate()
        {
            inputOutput.ShowSomeOutput("Enter your Rate please from 1 $ to 50 $");
            int Rate = inputOutput.IntInput(1, maxRate);
            inputOutput.ShowSomeOutput("New round Start!");
            return Rate;
        }       
    }
}

