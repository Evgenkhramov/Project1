using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class PrepareGamers
    {
        List<Gamer> allGamers = new List<Gamer>();

        public List<Gamer> GenerateList(Gamer gamer, int howManyBots)
        {
            for (int i = 0; i < howManyBots; i++)
            {  
                allGamers.Add(new Gamer() { Name = TextCuts.BotName + i, Rate = Settings.BotRate });
            }
            
            return allGamers;
        }

        public List<Gamer> AddPlayer(List<Gamer> allGamers, string name, int rate)
        {
            allGamers.Add(new Gamer() { Name = name, Rate = rate});
            return allGamers;
        }

    }
}
