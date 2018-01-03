using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p282
{
    public partial class Form1 : Form
    {

        Königin königin;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            Arbeiterin[] arbeiter = new Arbeiterin[4];
            arbeiter[0] = new Arbeiterin(new string[] { "Nektar sammeln", "Honig herstellen" }, 175);
            arbeiter[1] = new Arbeiterin(new string[] { "Brutpflege", "Bienenschule" }, 114);
            arbeiter[2] = new Arbeiterin(new string[] { "Stockpflege", "Wachdienst" }, 149);
            arbeiter[3] = new Arbeiterin(new string[] { "Nektar sammeln", "Honig herstellen", "Brutpflege", "Bienenschule", "Stockpflege", "Wachdienst" }, 155);

            königin = new Königin(arbeiter, 275);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nix
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            //Nix
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (königin.ArbeitZuweisen(comboBox1.Text, (int)numericUpDown1.Value) == false)
                MessageBox.Show("Keine Arbeiterin für die Aufgabe '" + comboBox1.Text + "'verfügbar", "Die Königin spricht...");
            else
                MessageBox.Show("Die Aufgabe '" + comboBox1.Text + "'wird in" + numericUpDown1.Value + "Schichten erledigt", "Die Königin spricht...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text= königin.NächsteSchichtArbeiten();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Nix
        }
    }

    public class Biene
    {
        public const double HonigverbrauchProMg = .25;
        public double GewichtMg { get; private set; }
        public Biene(double gewichtMg)
        {
            GewichtMg = gewichtMg;
        }

        virtual public double Honigverbrauch()
        {
            return GewichtMg * HonigverbrauchProMg;
        }

    }

    public class Arbeiterin : Biene
    {
        private string aktuelleAufgabe = "";
        public string AktuelleArbeit { get { return aktuelleAufgabe; } }
        public int OffeneSchichten { get { return schichtAnzahl - erledigteSchichten;}}
        private string[] möglicheArbeiten;
        private int schichtAnzahl;
        private int erledigteSchichten;
        public const double HonigverbrauchProSchicht = 0.65;

        //Constructor: Biene muss wissen welche arbeiten es verichten kann
        public Arbeiterin(string[] möglicheArbeiten, double gewichtMg) : base(gewichtMg)
        {
            this.möglicheArbeiten = möglicheArbeiten;
        }

        //Check if Bee has aktuelle Aufgabe and if not if she is capable of doing the new job: If yes allocate job
        public bool ArbeitAusführen(string job, int schichten)
        {
            if (!String.IsNullOrEmpty(this.aktuelleAufgabe))
                return false;
            for (int i = 0; i < möglicheArbeiten.Length; i++)
                if (this.möglicheArbeiten[i]==job)
            {
                this.schichtAnzahl = schichten;
                this.aktuelleAufgabe =job;
                this.erledigteSchichten = 0;
                return true;
            }
                return false;
        }

        //Bee erledigt schichten und resetet sich sollte die Arbeit abgeleistet sein
        public bool SchichtArbeiten()
        {
            if (String.IsNullOrEmpty(this.aktuelleAufgabe))
                return false;
            this.erledigteSchichten++;
            if (this.erledigteSchichten > this.schichtAnzahl)
            {
                schichtAnzahl = 0;
                erledigteSchichten = 0;
                aktuelleAufgabe = "";
                return true;
            }
            else
            {
                return false;
            }
            
        }

        override public double Honigverbrauch()
        {
            return base.Honigverbrauch() + erledigteSchichten*HonigverbrauchProSchicht;
        }
    }

    public class Königin : Biene
    {
        private Arbeiterin[] arbeiter;
        private int schichtNummer;
        private double gesamterHonigVerbrauch;
        
        //Constructor for passing initial variables
        public Königin(Arbeiterin[] arbeiter, double gewichtMg) : base(gewichtMg)
        {
            this.arbeiter = arbeiter;
        }
        
        //Checking if ArbeitAusführen delivers "true" for any bee. Then give boolean to the output message box
        public bool ArbeitZuweisen(string job, int schichten)
        {
            for (int i = 0; i < arbeiter.Length; i++)
            {
                if (arbeiter[i].ArbeitAusführen(job, schichten))
                    return true;
            }
                    return false;
        }
        //Provide the number of shift and let every bee work one shift and give output
        public string NächsteSchichtArbeiten()
        {
            schichtNummer++;
            string bericht = "Bericht für Schicht" + schichtNummer + "\r\n";
            for (int i = 0; i < arbeiter.Length; i++)
            {
                gesamterHonigVerbrauch += arbeiter[i].Honigverbrauch();
                if (arbeiter[i].SchichtArbeiten())
                    bericht += "Aufgabe von Arbeiterin " + (i + 1) + " erledigt\r\n";
                if (String.IsNullOrEmpty(arbeiter[i].AktuelleArbeit))
                    bericht += "Arbeiterin " + (i + 1) + " arbeitet nicht\r\n";
                else
                    if (arbeiter[i].OffeneSchichten > 0)
                    bericht += "Arbeiterin" + (i + 1) + "macht '" + arbeiter[i].AktuelleArbeit + "' für" + arbeiter[i].OffeneSchichten + "weitere Schichten \r\n";
                    else
                    bericht += "Arbeiterin" + (i + 1) + "ist nach dieser Schicht mit'" + arbeiter[i].AktuelleArbeit + "'fertig \r\n";
            }
            gesamterHonigVerbrauch += this.Honigverbrauch();
            bericht += "In dieser Schicht verbrauchter Honig:" + gesamterHonigVerbrauch + "Einheiten";
            return bericht;
        }

    }

}
