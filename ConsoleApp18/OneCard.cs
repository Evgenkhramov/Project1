using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class OneCard
    {
        public string CardSuit;
        public string CardNumber;
        public override string ToString()
        {
            return $"{CardSuit}:{CardNumber}";
        }

        public enum Suit
        {
            Spades = 1,
            Hearts = 2,
            Diamonds = 3,
            Clubs = 4
        }
       
            public static Dictionary<string, int> CardPointDict = new Dictionary<string, int>
        {
            { "Ace",11},
            { "King",10},
            { "Queen",10},
            { "Jack",10},
            { "Ten",10},
            { "Nine",9},
            { "Eight",8},
            { "Seven",7},
            { "Six",6},
            { "Five",5},
            { "Four",4},
            { "Three",3},
            { "Two",2}
        };  
    }
}
