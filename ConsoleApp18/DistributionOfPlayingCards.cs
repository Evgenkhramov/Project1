﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class DistributionOfPlayingCards
    {
       
        public void DoRound(Gamer[] GamerArray, List<Card> newSomeDeck)
        {
            
            for (int i = 0; i < GamerArray.Length; i++)
            {
                Console.WriteLine(GamerArray[i].GamerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Card.CardPointDict[element.CardNumber];
                GamerArray[i].GamerPoints += cardPoints;

                Console.WriteLine("{0},{1}, Total Points = {2}\n", element.CardNumber, element.CardSuit, GamerArray[i].GamerPoints);
            }
        }
    }
}