using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class DillerRaund
    {
        public static void FirstRound(Diller SomeDiller, List<Card> newSomeDeck)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(SomeDiller.DillerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Cards.CardPointDict[element.CardNumber];
                SomeDiller.DillerPoints += cardPoints;

                DoDillerStatus(SomeDiller);
                Console.WriteLine(SomeDiller.DillerStatus);
                Console.WriteLine("{0},{1}", element.CardNumber, element.Suit);
                Console.WriteLine("Total Gamer Points = " + SomeDiller.DillerPoints);
                Console.WriteLine();
            }

        }
        public static void RoundForDiller(Diller SomeDiller, List<Card> newSomeDeck)
        {
            if (SomeDiller.DillerStatus != "Lost" && SomeDiller.DillerPoints < 17)
            {

                Console.WriteLine(SomeDiller.DillerName);
                var element = CardDeck.TakeSomeCard(newSomeDeck);
                var cardPoints = Cards.CardPointDict[element.CardNumber];
                SomeDiller.DillerPoints += cardPoints;
                Console.WriteLine("{0},{1}, Total Points = {2}", element.CardNumber, element.Suit, SomeDiller.DillerPoints);
                DoDillerStatus(SomeDiller);
                Console.WriteLine(SomeDiller.DillerStatus);
            }
            else
            { 
                SomeDiller.DillerStatus = Diller.DillerStatusArray[4];

                 Console.WriteLine(SomeDiller.DillerStatus); 
            }

        }
        public static void DoDillerStatus(Diller SomeDiller)
        {
            if (SomeDiller.DillerPoints < 21)
            {
                SomeDiller.DillerStatus = Diller.DillerStatusArray[2];
            }
            else if (SomeDiller.DillerPoints == 21)
            {
                SomeDiller.DillerStatus = Diller.DillerStatusArray[3];
            }
            else
            {
                SomeDiller.DillerStatus = Diller.DillerStatusArray[1];
            }

        }
      
    }
}
