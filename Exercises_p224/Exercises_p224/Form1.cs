using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_p224
{
    public partial class Form1 : Form
    {

        Bauer bauer;
        public Form1()
        {
            InitializeComponent();
            bauer = new Bauer(15, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bauer.AnzahlKühe = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ich brauche {0}", bauer.SäckeFutter);
        }

    }

    class Bauer
    {

        public int SäckeFutter
        { get; private set; }

        private int futterMultiplikator;
        public int FutterMultiplikator
        {
            get
            {
                return futterMultiplikator;
            }
        }

        private int anzahlKühe;
        public int AnzahlKühe
        {
            get
            {
                return anzahlKühe;
            }
            set
            {
                anzahlKühe = value;
                SäckeFutter = anzahlKühe * this.FutterMultiplikator;
            }
        }

        public Bauer(int anzahlKühe, int futterMultiplikator)
        {
            this.futterMultiplikator = futterMultiplikator;
            AnzahlKühe = anzahlKühe;
        }

    }
}
