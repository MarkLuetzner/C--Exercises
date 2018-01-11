using System;


namespace Exercise_p391
{

    public class Card
    {
        public Suits Suit { get;  set; }
        public Values Value { get; set; }
        public string Name
        {
            get
            {
                return this.Value.ToString() + " of " + this.Suit.ToString();
            }

        }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            } else
            {
                return false;
            }

        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
     }

}
