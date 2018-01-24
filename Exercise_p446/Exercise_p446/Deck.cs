using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p446
{
    [Serializable]
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value < 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public void Remove(Deck cardsToRemove)
        {
            foreach (Card card in cardsToRemove.cards)
                cards.Remove(card);
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                newCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] stringarray = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                stringarray[i] = cards[i].Name;
            }

            return stringarray;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public bool ContainsValue(Values Value)
        {
            foreach (Card card in cards)
                if (card.Value == Value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count -1 ; i >= 0; i--)

                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool Hasbook(Values value)
        {
            int NumberofCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberofCards++;
            if (NumberofCards == 4)
                return true;
            else
                return false;
        }

    }
}
