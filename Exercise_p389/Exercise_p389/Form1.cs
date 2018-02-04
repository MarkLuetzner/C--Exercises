using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p389
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers;

        public Form1()
        {
            InitializeComponent();

            retiredNumbers = new Dictionary<int, JerseyNumber>()
            {
                { 3, new JerseyNumber("Babe Ruth", 1948) },
                { 4, new JerseyNumber("Lou Gehrig", 1939) },
                { 5, new JerseyNumber("Joe DiMaggio", 1952) },
                { 7, new JerseyNumber("Mickey Mantle", 1969) },
                { 8, new JerseyNumber("Yogi Berra", 1972) },
                { 10, new JerseyNumber("Phil Rizzuto", 1985) },
            };

            foreach (int key in retiredNumbers.Keys)
            {
                number.Items.Add(key);
            }
        }

        class JerseyNumber
        {
            public string Player { get; private set; }
            public int YearRetired { get; private set; }

            public JerseyNumber(string player, int numberRetired)
            {
                Player = player;
                YearRetired = numberRetired;
            }

        }

        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)number.SelectedItem];
            nameLabel.Text = jerseyNumber.Player;
            yearLabel.Text = jerseyNumber.YearRetired.ToString();
        }
    }
}
