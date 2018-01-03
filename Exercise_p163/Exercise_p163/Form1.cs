using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p163
{
    public partial class Tauschen : Form
    {

        Elefant kunigunde;
        Elefant kunibert;

        public Tauschen()
        {
            InitializeComponent();
            kunigunde = new Elefant() { Name = "Kunigunde", Ohrengröße = 63 };
            kunibert = new Elefant() { Name = "Kunibert", Ohrengröße = 82 };
            kunibert.SprichMitMir("Hallo", kunigunde);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kunigunde.WerBinIch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kunibert.WerBinIch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elefant temp1 = kunigunde;
            Elefant temp2 = kunibert;

            kunibert = temp1;
            kunigunde = temp2;

            MessageBox.Show("Object getauscht");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kunibert = kunigunde;
            kunibert.Ohrengröße = 4321;
            kunibert.WerBinIch();
            kunibert.SprichMit(kunigunde, "Hallo");
        }
    }


    class Elefant
    {

        public string Name;
        public int Ohrengröße;

        public void WerBinIch()
        {

            MessageBox.Show("Meine Ohren sind" + Ohrengröße + "lang", Name + "sagt");

        }

        public void SprichMitMir(string nachricht, Elefant werHierSpricht)
        {

            MessageBox.Show(werHierSpricht.Name + "sagt:" + nachricht);

        }

        public void SprichMit(Elefant redeMit, string nachricht)
        {
            redeMit.SprichMitMir(nachricht, this);
        }

    }
}
