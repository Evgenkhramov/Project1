using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Card
    {

        public string Suit;
        public string CardNumber;
        public override string ToString()
        {
            return $"{Suit}:{CardNumber}";
        }
    }
}
