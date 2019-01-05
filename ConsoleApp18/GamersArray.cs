using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class GamersArray
    {
        public Gamer[] DoGamerArray(int HowBots,string Name)
        {
            Gamer[] GamerArray = new Gamer[HowBots];
            for (int i = 0; i < HowBots; i++)
            {
                GamerArray[i] = new Gamer();
                GamerArray[i].GamerIndex = i;
                GamerArray[i].GamerRate = 10;
            }
            GamerArray[0].GamerName = "Casino";
            GamerArray[0].GamerRate = 0;
            GamerArray[1].GamerName = Name;
            return GamerArray;
        }
    }
}
