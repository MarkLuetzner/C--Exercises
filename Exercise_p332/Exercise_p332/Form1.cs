using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p332
{
    public partial class Form1 : Form
    {
        Ort aktuellerOrt;
        ZimmerMitTür wohnzimmer;
        Zimmer esszimmer;
        ZimmerMitTür küche;
        AußenMitTür vorgarten;
        Gelände garten;
        AußenMitTür terasse;
        Zimmer stairs;
        RoomWithHidingPlace upstairsHallway;

        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;
        OutsideWithHidingPlace driveway;

        Opponent feind;

        public static Ort startingLocation;

        public Form1()
        {
            InitializeComponent();
            ObjekteErstellen();
            startingLocation = vorgarten;
            aktuellerOrt = startingLocation;
            ZuOrtGehen(aktuellerOrt);
        }

        public void ObjekteErstellen()
        {
            wohnzimmer = new ZimmerMitTür("Wohnzimmer", "einen Perserteppich", "Truhe", "eine Eichentür mit Messinggriff");
            esszimmer = new Zimmer("Esszimmer", "Lampe");
            küche = new ZimmerMitTür("Küche", "Bild einer Giraffe", "Kühlschrank", "eine Eichentür mit Messinggriff");
            vorgarten = new AußenMitTür("Vorgarten", true, "Busch", "eine Eichentür mit Messinggriff");
            garten = new OutsideWithHidingPlace("Garten", true, "Shed");
            terasse = new AußenMitTür("Terasse", true, "Blumentopf", "eine Eichentür mit Messinggriff");
            stairs = new Zimmer("Stairs", "Monets");
            upstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "Picture of dog", "closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "large Bed", "large Bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "small Bed", "small Bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "Shower", "Shower");
            driveway = new OutsideWithHidingPlace("Driveway", true, "Garage");
            wohnzimmer.Ausgänge = new Ort[] { vorgarten, esszimmer , stairs };
            esszimmer.Ausgänge = new Ort[] { küche, wohnzimmer };
            küche.Ausgänge = new Ort[] { terasse, esszimmer };
            vorgarten.Ausgänge = new Ort[] { wohnzimmer, garten, driveway };
            garten.Ausgänge = new Ort[] { vorgarten, terasse, driveway };
            terasse.Ausgänge = new Ort[] { küche, garten };
            stairs.Ausgänge = new Ort[] { wohnzimmer, upstairsHallway };
            upstairsHallway.Ausgänge = new Ort[] { stairs, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Ausgänge = new Ort[] { upstairsHallway};
            secondBedroom.Ausgänge = new Ort[] { upstairsHallway };
            bathroom.Ausgänge = new Ort[] { upstairsHallway };
            driveway.Ausgänge = new Ort[] { vorgarten, garten };
            feind = new Opponent(vorgarten);

            wohnzimmer.TürOrt = vorgarten;
            küche.TürOrt = vorgarten;
            terasse.TürOrt = küche;
            vorgarten.TürOrt = wohnzimmer;

        }

        public void ZuOrtGehen(Ort neuerOrt)
        {
            aktuellerOrt = neuerOrt;
            ausgänge.Items.Clear();
            for (int i = 0; i < aktuellerOrt.Ausgänge.Length; i++)
            {
                ausgänge.Items.Add(aktuellerOrt.Ausgänge[i].Name);
            }
            ausgänge.SelectedIndex = 0;
            beschreibung.Text = aktuellerOrt.Beschreibung;

            checkButtons(aktuellerOrt);
        }

        private void checkButtons(Ort currentLocation)
        {
            if (currentLocation is IHatAußentür)
            {
                durchTürGehen.Visible = true;
            }
            else
            {
                durchTürGehen.Visible = false;
            }

            if (currentLocation is IHidingPlace)
            {
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }
        }

        private void durchTürGehen_Click(object sender, EventArgs e)
        {
            IHatAußentür mitTür = aktuellerOrt as IHatAußentür;
            ZuOrtGehen(mitTür.TürOrt);
        }

        private void hierhinGehen_Click(object sender, EventArgs e)
        {
            ZuOrtGehen(aktuellerOrt.Ausgänge[ausgänge.SelectedIndex]);
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (feind.Check(aktuellerOrt))
            {
                MessageBox.Show("No one is hiding here");
                System.Threading.Thread.Sleep(2000);
                RedrawForm();
            }
            else
            {
                MessageBox.Show("No one is hiding here");
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            for (int i=1; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(200);
                feind.Move();
                beschreibung.Text += i;
                Application.DoEvents();
            }
            beschreibung.Text = null;
            beschreibung.Text += "Ready or not here I come";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            check.Visible = true;
            durchTürGehen.Visible = true;
            hierhinGehen.Visible = true;
            ausgänge.Visible = true;
        }

        private void RedrawForm()
        {

            beschreibung.Text = null;
            aktuellerOrt = startingLocation;
            feind = new Opponent(vorgarten);
            check.Visible = false;
            hide.Visible = true;
            durchTürGehen.Visible = false;
            hierhinGehen.Visible = false;
            ausgänge.Visible = false;

        }
    }

    public abstract class Ort
    {
        public Ort(string name)
        {
            this.Name = name;
        }
        public Ort[] Ausgänge;
        public string Name { get; private set; }
        public virtual string Beschreibung
        {
            get
            {
                string beschreibung = "Sie stehen im " + Name + ". Es gibt Türen zu folgenden Orten: ";
                for (int i = 0; i < Ausgänge.Length; i++)
                {
                    beschreibung += " " + Ausgänge[i].Name;
                    if (i != Ausgänge.Length - 1)
                        beschreibung += ",";
                }
                beschreibung += ".";
                return beschreibung;

            }
        }
    }

    public class Gelände : Ort
    {
        private bool heiß;

        public Gelände(string name, bool heiß) : base(name)
        {

            this.heiß = heiß;
        }

        public override string Beschreibung
        {
            get
            {
                string neueBeschreibung = base.Beschreibung;
                if (heiß)
                    neueBeschreibung += "It's very hot.";
                return neueBeschreibung;
            }
        }

    }

    public class Zimmer : Ort
    {
        private string dekoration;

        public Zimmer(string name, string dekoration) : base(name)
        {
            this.dekoration = dekoration;
        }
        public override string Beschreibung
        {
            get
            {
                return base.Beschreibung + "Hier sehen Sie" + dekoration;
            }
        }
    }

    class AußenMitTür : OutsideWithHidingPlace, IHatAußentür
    {
        public string TürBeschreibung
        { get; set; }
        public Ort TürOrt
        { get; set; }


        public AußenMitTür(string name, bool heiß, string hidingPlace, string türBeschreibung) : base(name, heiß, hidingPlace)
        {
            this.TürBeschreibung = türBeschreibung;
        }

    }

    class ZimmerMitTür : RoomWithHidingPlace, IHatAußentür
    {
        public string TürBeschreibung
        { get; set; }
        public Ort TürOrt
        { get; set; }

        public ZimmerMitTür(string name, string dekoration, string hidingPlace, string türBeschreibung) : base(name, dekoration, hidingPlace)
        {
            this.TürBeschreibung = türBeschreibung;
        }
    }

    interface IHatAußentür
    {
        string TürBeschreibung
        { get; }
        Ort TürOrt
        { get; set; }
    }

    interface IHidingPlace
    {
        string HidingPlace
        { get; }
    }

    public class OutsideWithHidingPlace : Gelände, IHidingPlace
        {
        public string HidingPlace
        { get; }

        public OutsideWithHidingPlace(string name, bool heiß, string hidingPlace) : base(name, heiß)
        {
            HidingPlace = hidingPlace;
        }
    }

    public class RoomWithHidingPlace : Zimmer, IHidingPlace
    {
        public string HidingPlace
        { get; }

        public RoomWithHidingPlace(string name, string dekoration, string hidingPlace) : base(name, dekoration)
        {
            HidingPlace = hidingPlace;
        }

    }

    class Opponent
    {
        private Ort myLocation;
        private Random random;

        public Opponent(Ort startingLocation)
        {
            random = new Random();
            myLocation =startingLocation;
        }

        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHatAußentür)
                {
                    IHatAußentür locationWithDoor = myLocation as IHatAußentür;
                    if (random.Next(2) == 1)
                    {
                        myLocation = locationWithDoor.TürOrt;
                    }
                }

                int rand = random.Next(myLocation.Ausgänge.Length);
                myLocation = myLocation.Ausgänge[rand];

                if (myLocation is IHidingPlace)
                {
                    hidden = true;
                }
            }
        }

        public bool Check(Ort locationToCheck)
        {
            if (locationToCheck == this.myLocation)
                return true;
            else
                return false;
        }
    }
}
