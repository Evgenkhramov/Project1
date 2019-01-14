using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;


namespace BlackJackProject
{
    class ArrayOfGamers
    {
        public Gamer[] GenerateArrayOfGamers(int NumberOfBots,string Name)
        {
            var gamerArray = new Gamer[NumberOfBots];
            for (int i = 0; i < NumberOfBots; i++)
            {
                gamerArray[i] = new Gamer();
                gamerArray[i].Rate = Settings.BotRate;
                gamerArray[i].Name = TextCuts.BotName + i;
            }
            gamerArray[0].Name = TextCuts.DealerName;
            gamerArray[0].Rate = 0;
            gamerArray[1].Name = Name;

            return gamerArray;
        }      
    }
}
