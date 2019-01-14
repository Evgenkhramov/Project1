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
            foreach (var suitName in Enum.GetNames(typeof(Enums.SuitEnums)))
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

        public static int GetCardRandomIndex(int DeckLength)
        {
            if (DeckLength > 0)
            {
                var random = new Random();
                int value = random.Next(0, DeckLength);
                return value;
            }

            return 0;
        }

        public static OneCard GetSomeCard(List<OneCard> NewCardDeck)
        {
            int indexCard = GetCardRandomIndex(NewCardDeck.Count);
            if (indexCard >= 0)
            {
                var someCard = NewCardDeck[indexCard];
                NewCardDeck.RemoveAt(indexCard);

                return someCard;
            }

            return NewCardDeck[0];
        }
    }
}
