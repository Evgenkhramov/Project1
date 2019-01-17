using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Enums;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class Gamer
    {
        public string Name { get; set; }
        public int Rate { get; set; }
        public int Points { get; set; }
        public GamerStatus Status { get; set; }
        public int WinCash { get; set; }
        public GamerRole Role { get; set; }

        public Gamer()
        {
           
            Name = TextCuts.BotName;
            Rate = 0;
            Points = 0;
            Status = GamerStatus.None;
            WinCash = 0;
            Role = GamerRole.None;
        }
    }
}

