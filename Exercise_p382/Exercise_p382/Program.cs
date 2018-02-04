using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p382
{
    class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

    }

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

    }

    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            else
                return 0;
        }
    }
}
