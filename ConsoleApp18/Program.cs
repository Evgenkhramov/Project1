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
            //Console.WriteLine("Select the number of players from 2 to 6!");
            //int numberOfPlayers = Int32.Parse(Console.ReadLine());
            //Gamer[] AllGamers = new Gamer[numberOfPlayers];
            //for (int i = 0; i < numberOfPlayers; i++)
            //{

            //    Console.WriteLine("Enter the name of {0} Gamer", i + 1);
            //    string Name = Console.ReadLine();

            //    AllGamers[i] = new Gamer { GamerIndex = i, GamerPoints = 0, GamerName = Name, Status = Gamer.GamerStatusArray[2] };
            //}
            //for (int i = 0; i < numberOfPlayers; i++)
            //{
            //    Console.WriteLine("Index = {0},Name = {1}, Gaimer Points = {2}, Status = {3}", AllGamers[i].GamerIndex, AllGamers[i].GamerName, AllGamers[i].GamerPoints, AllGamers[i].Status);
            //}

            var elementDict = Cards.CardPointDict["Two"];

            var newSomeDeck = CardDeck.Deck();
            var element = CardDeck.TakeSomeCard(newSomeDeck);
            Console.WriteLine("{0},{1}", element.CardNumber, element.Suit);




        }
    }
}
