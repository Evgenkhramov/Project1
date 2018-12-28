using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public enum Suit
    {
        Spades = 1,
        Hearts = 2,
        Diamonds = 3,
        Clubs = 4
    }

    //public enum CardNumber
    //{
    //    Ace = 11,
    //    King = 10,
    //    Queen = 10,
    //    Jack = 10,
    //    Ten = 10,
    //    Nine = 9,
    //    Eight = 8,
    //    Seven = 7,
    //    Six = 6,
    //    Five = 5,
    //    Four = 4,
    //    Three = 3,
    //    Two = 2
    //}
   
    public class Cards
    {
        public int Points;
        public string CardName;
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

    public class Card
    {
        public string Suit;
        public string CardNumber;
        public override string ToString()
        {
            return $"{Suit}:{CardNumber}";
        }

    }

    public class CardDeck
    {
        public static List<Card> Deck()
        {
            var cards = new List<Card>(52);
            foreach (var suitName in Enum.GetNames(typeof(Suit)))
            {
                foreach (KeyValuePair<string, int> keyValue in Cards.CardPointDict)
                {
                    cards.Add(new Card
                    {
                        Suit = suitName,
                        CardNumber = keyValue.Key
                    });
                }
            }

            return cards;
        }

        public static Card TakeSomeCard(List<Card> NewDeck)
        {

            int IndexCard = CardRandomIndex(NewDeck.Count);
            if (IndexCard >= 0)
            {
                var SomeCard = NewDeck[IndexCard];
                NewDeck.RemoveAt(IndexCard);
                return SomeCard;
            }
            else
                return NewDeck[0];
        }
        public static int CardRandomIndex(int DeckLength)
        {
            if (DeckLength > 0)
            {
                Random rnd = new Random();
                int value = rnd.Next(0, DeckLength);
                return value;
            }
            else
                return 0;
        }

    }

    public class Gamer
    {
        public static string[] GamerStatusArray = new string[] {"Win","Lost","Plays" };

        public int GamerIndex;
        public string GamerName;
        public int GamerPoints;
        public string Status;
    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Game Start!");
            Console.WriteLine("Select the number of players from 2 to 6!");
            int numberOfPlayers = Int32.Parse(Console.ReadLine());
            Gamer[] AllGamers = new Gamer[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {

                Console.WriteLine("Enter the name of {0} Gamer",i+1);
                string Name = Console.ReadLine();

                AllGamers[i] = new Gamer { GamerIndex = i, GamerPoints = 0, GamerName = Name, Status = Gamer.GamerStatusArray[2] };
            }
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Index = {0},Name = {1}, Gaimer Points = {2}, Status = {3}", AllGamers[i].GamerIndex, AllGamers[i].GamerName, AllGamers[i].GamerPoints, AllGamers[i].Status);
                    }

            var elementDict = Cards.CardPointDict["Two"];

            var newDeck = CardDeck.Deck();
           

            //for (int i = 1; i < 53; i++)
            //{
            //    var SomeCard = CardDeck.TakeSomeCard(newDeck);
            //    var pointsDict = Cards.CardPointDict[SomeCard.CardNumber];
            //    Console.WriteLine("{0} {1} {2} {3} ", i, SomeCard.CardNumber,SomeCard.Suit, pointsDict);
            //}






        }
    }
}
