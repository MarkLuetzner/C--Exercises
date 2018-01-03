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
            abendessen.ExklusiveDeko = exklusivBox.Checked;
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

    class Party
    {
        public int Personenanzahl { get; set; }
        public bool ExklusiveDeko { get; set; }

        public const int EssenskostenProPerson = 25;
        public virtual decimal Kosten
        {
            get
                {
                decimal kosten = DekokostenBerechnen();
                kosten += EssenskostenProPerson * Personenanzahl;

                if (Personenanzahl > 12)
                    kosten += 100;
                return kosten;
                }
        }

        public decimal DekokostenBerechnen()
        {
            decimal dekokosten;
            if (ExklusiveDeko)
                dekokosten = (Personenanzahl * 15.00M) + 50M;
            else
                dekokosten = (Personenanzahl * 7.5M) + 30M;
            return dekokosten;
        }
}



    class Geburtstagsfeier : Party
    {

        public string KuchenText { get; set; }

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

        public Geburtstagsfeier(int personenanzahl, bool exklusivDeko, string kuchenText)
        {
            Personenanzahl = personenanzahl;
            ExklusiveDeko = exklusivDeko;
            KuchenText = kuchenText;
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

        override public decimal Kosten
        {
            get
            {
                decimal kosten = base.Kosten;

                decimal kuchenkosten;
                if (Kuchengröße() == 8)
                    kuchenkosten = 40M + TatslLänge * .25M;
                else
                    kuchenkosten = 75M + TatslLänge * .25M;
                return kosten + kuchenkosten;

            }
        }
    }


    class Abendessen : Party
    {
        public bool TrockenerAbend { get; set; }

        private decimal getränkeKostenProPerson;


        public override decimal Kosten
        {
            get
            {
                decimal kosten = base.Kosten;
                kosten += GetränkeProPersonBerechnen() * Personenanzahl;

                if (TrockenerAbend == true)
                {
                    kosten *= 0.95M;
                }
                return kosten;
            }
        }

        public Abendessen(int personenanzahl, bool trockenerAbend, bool exklusiverAbend)
        {
            Personenanzahl = personenanzahl;
            TrockenerAbend = trockenerAbend;
            ExklusiveDeko = exklusiverAbend;
        }

        private decimal GetränkeProPersonBerechnen()

        {
            if (TrockenerAbend == true)
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

