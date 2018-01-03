using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p233
{
    public partial class Form1 : Form
    {

        Abendessen abendessen;
        public Form1()
        {
            InitializeComponent();
            abendessen = new Abendessen((int)numericUpDown1.Value, trockenBox.Checked, exklusivBox.Checked);
            KostenAnzeigen();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.Personenanzahl = (int)numericUpDown1.Value;
            KostenAnzeigen();
        }

        private void dekoCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.ExklusiverAbend = exklusivBox.Checked;
            KostenAnzeigen();
        }

        private void trockenerAbendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.TrockenerAbend = trockenBox.Checked;
            KostenAnzeigen();
        }

        private void KostenAnzeigen()
        {
            decimal Kosten = abendessen.Kosten;
            kostenLabel.Text = Kosten.ToString("c");           
        }

    }

    class Abendessen
    {
        public int Personenanzahl { get; set;}
        public bool ExklusiverAbend { get; set; }
        public bool TrockenerAbend { get; set; }

        private decimal dekoKosten;
        private decimal getränkeKostenProPerson;
        
        private decimal kosten;
        public decimal Kosten
        {
            get
            {
                DekokostenBerechnen();
                GetränkeProPersonBerechnen();

                if (TrockenerAbend == true)
                {
                    kosten = 0.95M * (this.getränkeKostenProPerson*this.Personenanzahl + this.dekoKosten + 25 * this.Personenanzahl);
                }
                else
                {

                    kosten = (getränkeKostenProPerson*this.Personenanzahl + this.dekoKosten + 25 * this.Personenanzahl);
                }
                return kosten;
            }
        }

        public Abendessen(int personenanzahl, bool trockenerAbend, bool exklusiverAbend)
        {
            this.Personenanzahl = personenanzahl;
            this.TrockenerAbend = trockenerAbend;
            this.ExklusiverAbend = exklusiverAbend;
            
        }

        private decimal DekokostenBerechnen()

        {
            if (this.ExklusiverAbend == true)
            {
                this.dekoKosten = 50 + 15 * this.Personenanzahl;            
            }
            else
            {

                this.dekoKosten = 30 + 7.5M * this.Personenanzahl;
            }
            return this.dekoKosten;
        }

        private decimal GetränkeProPersonBerechnen()

        {
            if (this.TrockenerAbend == true)
            {
                this.getränkeKostenProPerson = 5;
            }
            else
            {
                this.getränkeKostenProPerson = 20;

            }

            return this.getränkeKostenProPerson;

        }

    }
}
