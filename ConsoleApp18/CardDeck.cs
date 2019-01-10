using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class CardDeck
    {
        public static List<OneCard> DoOneDeck()
        {
            var cards = new List<OneCard>(52);
            foreach (var suitName in Enum.GetNames(typeof(OneCard.Suit)))
            {
                foreach (KeyValuePair<string, int> keyValue in OneCard.CardPointDict)
                {
                    cards.Add(new OneCard
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
        public static OneCard TakeSomeCard(List<OneCard> NewCardDeck)
        {
            int IndexCard = CardRandomIndex(NewCardDeck.Count);
                if (IndexCard >= 0)
            {
                var SomeCard = NewCardDeck[IndexCard];
                NewCardDeck.RemoveAt(IndexCard);
                return SomeCard;
            }
            else
                return NewCardDeck[0];
        }
    }
}
