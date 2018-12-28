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
    public enum CardNumber
    {
        Ace = 11,
        King = 10,
        Queen = 10,
        Jack = 10,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2
    }
    public enum GamerStatus
    {
        Win = 1,
        Lost = 2,
        Plays = 3
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
                foreach (var cardNumber in Enum.GetNames(typeof(CardNumber)))
                {
                    cards.Add(new Card
                    {
                        Suit = suitName,
                        CardNumber = cardNumber
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
                int value = rnd.Next(0,DeckLength);
                return value;
            }
            else
                return 0;
        }
        public static int CardPoints(Card SomeCard)
        {
            string thisCard = SomeCard.CardNumber;
            CardNumber OneCard = (CardNumber)Enum.Parse(typeof(CardNumber), thisCard);
            int Points = (int)OneCard;
            return Points;
        }
    }

    public class Gamer
    {
        public string Name;
        public int Points;
        public 
    }

    class Program
    {

        static void Main(string[] args)
        {
            //int someI = 0;
            var newDeck = CardDeck.Deck();
            //foreach (var element in newDeck)
            //{
            //  Console.WriteLine("{0},{1}", element.CardNumber, element.Suit);
            //    someI++;
            //}
            //Console.WriteLine(someI+"   *************************************************************");

           
                var SomeCard = CardDeck.TakeSomeCard(newDeck);
                var points = CardDeck.CardPoints(SomeCard);
              
                
        }
    }
}
