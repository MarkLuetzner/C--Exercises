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
    class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private Random random = new Random();

        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }


        public Game()
        {
            PlayerName = "Ed";
            GameInProgress = true;
            Hand = new ObservableCollection<string>();
            ResetGame();
        }


        //(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)            
        //this.textBoxOnForm = textBoxOnForm;
        //    players = new List<Player>();
        //    players.Add(new Player(playerName, random, textBoxOnForm));
        //    foreach (string player in opponentNames)
        //        players.Add(new Player(player, random, textBoxOnForm));
        //    books = new Dictionary<Values, Player>();
        //    stock = new Deck();
        //Deal();
        //players[0].SortHand();

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();

            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if(!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Hand.Clear();
        }


        public void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
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
            players[0].AskForACard(players, myIndex, stock, players[0].Peek(selectedPlayerCard).Value);

            for (myIndex = 1; myIndex < players.Count; myIndex++)
            {
                players[myIndex].AskForACard(players, myIndex, stock);
            }

            foreach (Player player in players)
                if (PullOutBooks(player))
                {
                    player.TakeCard(stock.Deal());
                    AddProgress(player.Name + " drew a new hand " + Environment.NewLine);
                }

            players[0].SortHand();
            if (stock.Count == 0)
            {
                AddProgress("The stock is out of cards. Game Over!");
                GameInProgress = false;
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
                scoreString += name + " has " + scores[name] + " books." + Environment.NewLine;
            }
            return scoreString;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            GameInProgress = false;
            foreach (Player player in players)
                winners.Add(player.Name, 0);

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
            return winningString + " with " + mostBooks + " books. ";
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

        public void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = this.PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
