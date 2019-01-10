using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class CardDeck
    {
        public static List<Card> DoDeck()
        {
            var cards = new List<Card>(52);
            foreach (var suitName in Enum.GetNames(typeof(Card.Suit)))
            {
                foreach (KeyValuePair<string, int> keyValue in Card.CardPointDict)
                {
                    cards.Add(new Card
                    {
                        CardSuit = suitName,
                        CardNumber = keyValue.Key
                    });
                }
            }

            return cards;
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
    }
}
