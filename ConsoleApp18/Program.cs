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
           
            //Console.WriteLine("Select the number of players from 2 to 6!");
            //int numberOfPlayers = Int32.Parse(Console.ReadLine());
            //Gamer[] AllGamers = new Gamer[numberOfPlayers];
            //for (int i = 1; i < numberOfPlayers; i++)
            //{

            //    Console.WriteLine("Enter the name of {0} Gamer", i + 1);
            //    string Name = Console.ReadLine();

            //    AllGamers[i] = new Gamer { GamerIndex = i, GamerPoints = 0, GamerName = Name, GamerStatus = Gamer.GamerStatusArray[2] };
            //}
            Console.WriteLine("******** New round Start! ********");
            Console.WriteLine("Enter your Rate please from 1 $ to 50 $");
            var newSomeDeck = CardDeck.Deck();
            GamerArray[1].GamerRate = int.Parse(Console.ReadLine());
            Console.WriteLine("******** New Cards! ********");
            for (int i = 0; i < 2; i++)
            {
                FirstRound.DoRound(GamerArray, newSomeDeck);
            }
            NextRound.DoGamerStatus(GamerArray[0]);
            NextRound.RoundForGamer(GamerArray[0], newSomeDeck);
            NextRound.DoGamerStatus(GamerArray[1]);
            NextRound.RoundForGamer(GamerArray[1], newSomeDeck);




        }
    }
}
