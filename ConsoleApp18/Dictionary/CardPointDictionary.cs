﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject.Dictionary
{

    public class CardPointDiction
    {
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
