using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise_p391;

namespace Exercise_p391
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start the game yet");
                return;
            }
            game = new Game(textName.Text, new List<string> { "Joe", "Bob" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            listHand.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()

        {
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "The winner is ..." + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
                listHand.Enabled = false;
            }
            else
                UpdateForm();
        }

        private void textBooks_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Game
    {

        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;
        private Random random = new Random();

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            foreach (Player player in players)
            {
                for (int i = 0; i < 5; i++)
                {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (Player player in players)
                player.PullOutBooks();
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {

            int myIndex = 0;
            players[0].AskForACard(players,myIndex,stock, players[0].Peek(selectedPlayerCard).Value);

            for (myIndex = 1; myIndex < players.Count; myIndex++)
            {
                players[myIndex].AskForACard(players,myIndex,stock);
            }

            foreach (Player player in players)
                if (PullOutBooks(player))
                {
                    player.TakeCard(stock.Deal());
                    textBoxOnForm.Text += player.Name + " drew a new hand " + Environment.NewLine;
                }

            players[0].SortHand();
            if (stock.Count == 0)
            {
                textBoxOnForm.Text = "The stock is out of cards. Game Over!";
                    return true;
            }
            else
                return false;
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach (Values value in booksPulled)
            {
                books.Add(value, player);
            }

            if (player.CardCount == 0)
            {
                return true;
            }
                return false;
        }

        public string DescribeBooks()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            foreach (Player player in players)
                scores.Add(player.Name, 0);

            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (scores.ContainsKey(name))
                    scores[name]++;
            }
            string scoreString = "";
            foreach (string name in scores.Keys)
            {
                scoreString += name + " has " + scores[name] +" books." + Environment.NewLine;
            }
            return scoreString;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Player player in players)
            winners.Add(player.Name,0);

            //Populate winners dictionnary
            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
            }
            int mostBooks = 0;
            // Determine "most books"
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            //Find out if there is a tie with whom
            List<string> tiePlayers = new List<string>();
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks)
                    tiePlayers.Add(name);
            string winningString = "";
            if (tiePlayers.Count != 1)
            {
                for (int i = 0; i < tiePlayers.Count; i++)
                {
                    winningString += tiePlayers[i] + ",";
                    if (i == tiePlayers.Count - 1)
                    {
                        winningString += " and " + tiePlayers[i];
                    }
                }
                return " A tie between " + winningString + " with " + mostBooks + " books. ";
            }
            else
                winningString = tiePlayers[0];
            return     winningString + " with " + mostBooks + " books. ";
        } 

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card. " + Environment.NewLine;
                else
                    description += " cards. " + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left. ";
            return description;
        }
    }


    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.textBoxOnForm = textBoxOnForm;
            this.random = random;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + " has just joined the game" + Environment.NewLine;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i=1; i<= 13; i++)
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

        public Deck DoYouHaveAny(Values value)
        {
        Deck pulledCards = cards.PullOutValues(value);
            if (pulledCards == null)
            {
                textBoxOnForm.Text += this.name + " has no cards of " + value + Environment.NewLine;
            }
            else
            {
                textBoxOnForm.Text += this.name + " has " + pulledCards.Count + " of value " + value + Environment.NewLine;
            }
            return pulledCards; 
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values value = GetRandomValue();
            AskForACard(players, myIndex,  stock, value);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += name + " asks if anyone has a " + value + Environment.NewLine;


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
            if (totalCardsGiven == 0 & stock.Count>0)
            {
                textBoxOnForm.Text += Name + " must daw from the stock." + Environment.NewLine;
                cards.Add(stock.Deal());
            }


        }
    }

}
