using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //FIll in code
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values()>;
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
            random = new Random();
            int randomNumber= random.Next(1, 13);
            for (int i = 0; i < Deck.//Number of cards in deck; i++)
            {


                if ((Values)randomNumber == Deck.card[i].Value)
                return randomNumber;
                (int)cards.Values
                else
                //No cards in deck
            }

        }

        public Deck DoYouHaveAny(Values value)
        {


        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {


        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {


        }

    }

    class Game
    {

        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
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
            //ADD code
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            //ADD code
        }

        public bool PullOutBooks(Player player)
        {
            //ADD code
        }

        public string DescribeBooks()
        {
            // write code
        }

        public GetWinnerName()
        {
            //


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
                description += players[i].Name + "has" + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += "card." + Environment.NewLine;
                else
                    description += "cards." + Environment.NewLine;
            }
            description += "The stock has" + stock.Count + "cards left.";
            return description;
        }

    }



}
