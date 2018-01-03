using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p240
{
    public partial class Form1 : Form
    {
        Abendessen abendessen;
        Geburtstagsfeier geburtstagsfeier;

        public Form1()
        {
            InitializeComponent();
            abendessen = new Abendessen((int)numericUpDown1.Value, trockenBox.Checked, exklusivBox.Checked);
            AbendessenKostenAnzeigen();

            geburtstagsfeier = new Geburtstagsfeier((int)anzahlGeburtstag.Value, exklusiverGeburtstag.Checked, kuchenText.Text);
            GeburtstagsfeierKostenAnzeigen();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            abendessen.Personenanzahl = (int)numericUpDown1.Value;
            AbendessenKostenAnzeigen();
        }

        private void exklusivBox_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.ExklusiverAbend = exklusivBox.Checked;
            AbendessenKostenAnzeigen();
        }

        private void trockenBox_CheckedChanged(object sender, EventArgs e)
        {
            abendessen.TrockenerAbend = trockenBox.Checked;
            AbendessenKostenAnzeigen();
        }

        private void anzahlGeburtstag_ValueChanged(object sender, EventArgs e)
        {
            geburtstagsfeier.Personenanzahl = (int)anzahlGeburtstag.Value;
            GeburtstagsfeierKostenAnzeigen();
        }

        private void exklusiverGeburtstag_CheckedChanged(object sender, EventArgs e)
        {
            geburtstagsfeier.ExklusiveDeko = exklusiverGeburtstag.Checked;
            GeburtstagsfeierKostenAnzeigen();
        }

        private void kuchenText_TextChanged(object sender, EventArgs e)
        {
            geburtstagsfeier.KuchenText = kuchenText.Text;
            GeburtstagsfeierKostenAnzeigen();
        }

        private void GeburtstagsfeierKostenAnzeigen()
        {
            zuLangLabel.Visible = geburtstagsfeier.KuchenTextZuLang;
            decimal kosten = geburtstagsfeier.Kosten;
            kostenGeburtstag.Text = kosten.ToString("c");
    }

        private void AbendessenKostenAnzeigen()
        {
            decimal Kosten = abendessen.Kosten;
            kostenLabel.Text = Kosten.ToString("c");
        }

    }

    class Geburtstagsfeier
    {
        public const int EssenskostenProPerson = 25;
        public int Personenanzahl { get; set; }

        public bool ExklusiveDeko { get; set; }

        public string KuchenText { get; set; }

        public Geburtstagsfeier(int personenanzahl, bool exklusivDeko, string kuchenText)
        {
            Personenanzahl = personenanzahl;
            ExklusiveDeko = exklusivDeko;
            KuchenText = kuchenText;
        }

        private int TatslLänge
        {
            get
            {
                if (KuchenText.Length > MaxTextLänge())
                    return MaxTextLänge();
                else
                    return KuchenText.Length;
            }
        }

        private int Kuchengröße()
        {
            if (Personenanzahl <= 4)
                return 8;
            else
                return 16;
        }


        private int MaxTextLänge()
        {
            if (Kuchengröße() == 8)
                return 16;
            else
                return 40;
        }


        public bool KuchenTextZuLang
        {
            get
            {
                if (KuchenText.Length > MaxTextLänge())
                    return true;
                else
                    return false;
            }
        }

        private decimal DekokostenBerechnen()
        {
            decimal dekokosten;
            if (ExklusiveDeko)
                dekokosten = (Personenanzahl * 15.00M) + 50M;
            else
                dekokosten = (Personenanzahl * 7.5M) + 30M;
            return dekokosten;
        }

        public decimal Kosten
        {
            get
            {
                decimal kuchenkosten;
                decimal kosten = DekokostenBerechnen();
                kosten += EssenskostenProPerson * Personenanzahl;
                if (Kuchengröße() == 8)
                    kuchenkosten = 40M + TatslLänge * .25M;
                else
                    kuchenkosten = 75M + TatslLänge * .25M;
                return kosten + kuchenkosten;

            }
        }
    }


    class Abendessen
    {
        public int Personenanzahl { get; set; }
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
                    kosten = 0.95M * (this.getränkeKostenProPerson * this.Personenanzahl + this.dekoKosten + 25 * this.Personenanzahl);
                }
                else
                {

                    kosten = (getränkeKostenProPerson * this.Personenanzahl + this.dekoKosten + 25 * this.Personenanzahl);
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

