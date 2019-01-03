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
            Gamer RealGamer = new Gamer();
            RealGamer.GamerName = UserName;
            //GamerBot[] GamerBotArray = new GamerBot[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    GamerBotArray[i] = new GamerBot();
            //    GamerBotArray[i].GamerName = i + " Bot";
            //}


            Console.WriteLine("******** New round Start! ********");
            Console.WriteLine("Enter your Rate please from 1 $ to 50 $");
            RealGamer.GamerRate = int.Parse(Console.ReadLine());
            Diller OneDiller = new Diller();

            Console.WriteLine("******** New Cards! ********");
            var newSomeDeck = CardDeck.Deck();
            GamerRound.FirstRound(RealGamer, newSomeDeck);
            DillerRaund.FirstRound(OneDiller, newSomeDeck);


            DillerRaund.RoundForDiller(OneDiller, newSomeDeck);
            GamerRound.RoundForGamer(RealGamer, newSomeDeck);



        }
    }
}
