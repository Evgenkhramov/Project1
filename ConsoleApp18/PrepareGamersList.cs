using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;
using BlackJackProject.Enums;

namespace BlackJackProject
{
    public class PrepareGamersList
    {
        public List<Gamer> GenerateBotList(List<Gamer> allGamers, int howManyBots)
        {
            for (int i = 0; i < howManyBots; i++)
            {  
                allGamers.Add(new Gamer() { Name = TextCuts.BotName + i, Rate = Settings.BotRate ,Status = GamerStatus.Plays, Role = GamerRole.Bot});
            }
            
            return allGamers;
        }

        public List<Gamer> AddPlayer(List<Gamer> allGamers, string name, int rate, GamerRole role, GamerStatus status)
        {
            allGamers.Add(new Gamer() { Name = name, Rate = rate, Status = status, Role = role});
            return allGamers;
        }

    }
}
