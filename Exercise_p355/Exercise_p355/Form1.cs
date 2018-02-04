using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p355
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInteger = random.Next();

            Suits temp1 = (Suits)numberBetween0and3;
            Values temp2 = (Values)numberBetween1and13;

            Card card = new Card(temp1, temp2);
            MessageBox.Show(card.Name);
        }
    }

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get
            {
                return this.Value.ToString() + " of " + this.Suit.ToString();
            }
        }

    public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }



}
