using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18;

namespace ConsoleApp18
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Game Start!");
            Console.WriteLine("Enter your name please:");
            string UserName = Console.ReadLine();
            Gamer[] GamerArray = new Gamer[2];
            for(int i = 0; i<2;i++)
            {
                GamerArray[i] = new Gamer();
            }
            GamerArray[0].GamerName = "Casino";
            GamerArray[1].GamerName = UserName;
           
          
            Console.WriteLine("******** New round Start! ********");
            Console.WriteLine("Enter your Rate please from 1 $ to 50 $");
            var newSomeDeck = CardDeck.Deck();
            GamerArray[1].GamerRate = int.Parse(Console.ReadLine());
            Console.WriteLine("******** New Cards! ********");
            for (int i = 0; i < 2; i++)
            {
                FirstRound.DoRound(GamerArray, newSomeDeck);
            }
           
            NextRound.RoundForGamer(GamerArray[0], newSomeDeck);
           
            NextRound.RoundForGamer(GamerArray[1], newSomeDeck);




        }
    }
}
