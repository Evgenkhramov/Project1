using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Gamer
    {
        public int GamerIndex = 0;
        public string GamerName = TextCuts.TextCuts.BotName;
        public int GamerRate = 0;
        public int GamerPoints = 0;
        public Enums.GamerStatusEnum GamerStatus = Enums.GamerStatusEnum.Plays;
        public int GamerWinCash = 0;
    }
}
// Вопрос с правильным именование (Заглавная буква?)
