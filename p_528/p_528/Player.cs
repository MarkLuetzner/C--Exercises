using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Collections.ObjectModel;

namespace p_528
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game;

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        public Player(String name, Random random, Game game)
        {
            this.name = name;
            this.game = game;
            this.random = random;
            this.cards = new Deck(new Card[] { });
            game.AddProgress(name + " has just joined the game" + Environment.NewLine);
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck pulledCards = cards.PullOutValues(value);

                game.AddProgress(this.name + " has " + pulledCards.Count + " "+ Card.Plural(value) + Environment.NewLine);

            return pulledCards;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                    if (howMany == 4)
                    {
                        books.Add(value);
                        cards.PullOutValues(value);
                    }
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            {
                int randomNumber = random.Next(1, 13);
                return (Values)randomNumber;
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values value = GetRandomValue();
            AskForACard(players, myIndex, stock, value);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            game.AddProgress(name + " asks if anyone has a " + value + Environment.NewLine);

            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        this.cards.Add(CardsGiven.Deal());
                }
            }

            if (totalCardsGiven == 0 & stock.Count > 0)
            {
                game.AddProgress(Name + " must draw from the stock." + Environment.NewLine);
                cards.Add(stock.Deal());
            }

        }

    }
   
}
