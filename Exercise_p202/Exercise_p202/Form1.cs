using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p202
{
    public partial class Form1 : Form
    {
        Abendessen abendessen;

        public Form1()
        {
            InitializeComponent();
            abendessen = new Abendessen();
            abendessen.PersonenSetzen(0);
           // abendessen.TrockenerAbendWählen(false);
            abendessen.DekokostenBerechnen(false);
            AbendessenKostenAnzeigen();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.PersonenSetzen((int)numericUpDown1.Value);
            AbendessenKostenAnzeigen();
        }

        private void AbendessenKostenAnzeigen()
        {
            abendessen.DekokostenBerechnen(dekoCheckBox.Checked);
            decimal kosten = abendessen.KostenBerechnen(trockenCheckBox.Checked);
            kostenLabel.Text = kosten.ToString("c");
        }

        private void dekoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.DekokostenBerechnen(dekoCheckBox.Checked);
            AbendessenKostenAnzeigen();
        }

        private void trockenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //abendessen.TrockenerAbendWählen(trockenCheckBox.Checked);
            AbendessenKostenAnzeigen();

        }


    }

    class Abendessen
    {
        private int Personenanzahl;
   //     public decimal GetränkekostenProPerson;
        public decimal Dekokosten;
        public decimal Gesamtkosten;
        public const int EssenskostenProPerson = 25;

        public void TrockenerAbendWählen(bool k)
        {

        }

        public decimal DekokostenBerechnen(bool exclusiv)
        {
            if (exclusiv==true)
                {
                Dekokosten = 15M * this.Personenanzahl + 50M;
                }

            else
            {
                Dekokosten = 7.5M * this.Personenanzahl + 30M;
            }
            return Dekokosten;
        }

        public decimal KostenBerechnen(bool trocken)
        {
            if (trocken== true)

            {
                Gesamtkosten = 0.95M * (this.Dekokosten + (EssenskostenProPerson + 5) * Personenanzahl);
            }

            else
            {
                Gesamtkosten = (this.Dekokosten + (EssenskostenProPerson + 20) * Personenanzahl);
            }


            return Gesamtkosten;

        }

        public void PersonenSetzen(int personen)
        {
            this.Personenanzahl = personen;

        }


    }

}
