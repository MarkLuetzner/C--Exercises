using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p177
{
    public partial class Tippspiel : Form
    {

        Random random = new Random();
        Statistik statistik = new Statistik();
        
        public Tippspiel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();

            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                schwierigkeitProgressBar.Value = 800 - timer1.Interval;
                statistik.Aktualisieren(true);
            }
            else
            {
                statistik.Aktualisieren(false);
            }

            richtigLabel.Text = "Richtig: " + statistik.Richtig;
            falschLabel.Text = "Falsch: " + statistik.Falsch;
            gesamtLabel.Text = "Trefferquote: " + statistik.Trefferquote + "%";

        }
    }

    class Statistik
    {
        public int Gesamt = 0;
        public int Falsch = 0;
        public int Richtig = 0;
        public int Trefferquote = 0;

        public void Aktualisieren(bool richtigTaste)
        {
            Gesamt++;
            if (!richtigTaste)
            {
                Falsch++;
            }
            else
            {
                Richtig++;
            }

            Trefferquote = 100 * Richtig / Gesamt;
            
        }

    }

}
