using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Dictionary;

namespace BlackJackProject
{
    public class OneCard
    {
        public string CardSuit { get; set; }
        public string CardNumber { get; set; }

        public override string ToString()
        {
            return $"{CardSuit}:{CardNumber}";
        }          
    }
}
