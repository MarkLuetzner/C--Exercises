using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p375
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            List<Card> deck = new List<Card>();
            int listlength = 5;
            Console.WriteLine("Five random cards");

            for (int i = 0; i < listlength; i++)
            {
                int randomNumber = random.Next(1, 14);
                int randomNumber_Suits = random.Next(4);
                Card card = new Card((Suits)randomNumber_Suits, (Values)randomNumber);
                deck.Add(card);
                Console.WriteLine(deck[i].Name);
            }
            Console.ReadKey();
            Console.WriteLine("Those same cards, sorted:");
            deck.Sort(new CardComparer_byValue());

            foreach (Card card in deck)
            {
                Console.WriteLine(card.Name);
            }


            Console.ReadKey();

        }
    }


    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13

    }

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }

        }
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            else
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



}
