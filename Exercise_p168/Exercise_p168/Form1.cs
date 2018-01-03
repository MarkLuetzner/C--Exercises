using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p168
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenüMacher menü = new MenüMacher();

            label1.Text = menü.MenüEintragHolen();
            label2.Text = menü.MenüEintragHolen();
            label3.Text = menü.MenüEintragHolen();
            label4.Text = menü.MenüEintragHolen();
            label5.Text = menü.MenüEintragHolen();
            label6.Text = menü.MenüEintragHolen();
            
        }
    }

    class MenüMacher
    {
        public Random Zufallszahl;


        string[] Fleisch = { "Roastbeef", "Salami", "Pute", "Speck", "Braten" };
        string[] Soßen = { "Süßer Senf", "Scharfer Senf", "Ketchup", "Mayo", "Aioli", "Remoulade" };
        string[] Brot = { "Gaubrot", "Weißbrot", "Toast", "Pumpernickel", "Ciabatta", "Brötchen" };

        public string MenüEintragHolen()
        {
            Zufallszahl = new Random();

            string zufallsFleisch = Fleisch[Zufallszahl.Next(Fleisch.Length)];
            string zufallsSoße = Soßen[Zufallszahl.Next(Soßen.Length)];
            string zufallsBrot = Brot[Zufallszahl.Next(Brot.Length)];

            return zufallsFleisch + " mit " + zufallsSoße + " auf " + zufallsBrot;
        }


    }



}
