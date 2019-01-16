using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;


namespace BlackJackProject
{
    class ArrayOfBots
    {
        public Gamer[] GenerateArrayOfBots(int NumberOfBots,string Name, int BotRate)
        {
            var arrayOfBots = new Gamer[NumberOfBots];
            for (int i = 0; i < NumberOfBots; i++)
            {
                arrayOfBots[i] = new Gamer();
                arrayOfBots[i].Rate = BotRate;
                arrayOfBots[i].Name = Name;
            }
          
            return arrayOfBots;
        }      
    }
}
