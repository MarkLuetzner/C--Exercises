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
    public class Game : INotifyPropertyChanged
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
            if (!GameInProgress)
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

        public void PlayOneRound(int selectedPlayerCard)
        {

            int myIndex = 0;
            players[0].AskForACard(players, myIndex, stock, players[0].Peek(selectedPlayerCard).Value);

            for (myIndex = 1; myIndex < players.Count; myIndex++)
            {
                players[myIndex].AskForACard(players, myIndex, stock);
            }

            foreach (Player player in players)
            {
                if (PullOutBooks(player))
                {
                    if (stock.Count < 3 && stock.Count > 0)
                    {
                        player.TakeCard(stock.Deal());
                        AddProgress(player.Name + " drew a new hand " + Environment.NewLine);
                    }
                    else
                    {

                        AddProgress("The stock is out of cards. Game Over!");
                        AddProgress("The winner is..." + GetWinnerName());
                        ResetGame();
                        OnPropertyChanged("Books");
                        players[0].SortHand();
                        return;
                    }
                }
                OnPropertyChanged("Books");
                players[0].SortHand();
            }

            foreach (Player player in players)
            {
                Hand.Clear();
                foreach (String cardName in GetPlayerCardNames())
                    Hand.Add(cardName);
                if (!GameInProgress)
                    AddProgress(DescribePlayerHands());
            }
        }

        private bool PullOutBooks(Player player)
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
            string scoreString = " ";
            foreach (Values value in books.Keys)
            {
                scoreString += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
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
            GameProgress = GameProgress + Environment.NewLine + progress;
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
