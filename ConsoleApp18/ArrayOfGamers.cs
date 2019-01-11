using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class ArrayOfGamers
    {
        public Gamer[] GenerateArrayOfGamers(int HowBots,string Name)
        {
            var gamerArray = new Gamer[HowBots];
            for (int i = 0; i < HowBots; i++)
            {
                gamerArray[i] = new Gamer();
                gamerArray[i].GamerIndex = i;
                gamerArray[i].GamerRate = 10;
                gamerArray[i].GamerName = $"Bot {i} ";
            }
            gamerArray[0].GamerName = "Casino";
            gamerArray[0].GamerRate = 0;
            gamerArray[1].GamerName = Name;

            return gamerArray;
        }      
    }
}
