using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_p180
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelAnimator[] animatoren = new LabelAnimator[3];

        private void AnimationAnAus(int index, Label animator)
        {
            if (animatoren[index] == null)
            {
                animatoren[index] = new LabelAnimator();
                animatoren[index].DasLabel = animator;
            }
            else
            {
                animatoren[index] = null;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            AnimationAnAus(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnimationAnAus(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnimationAnAus(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i < 3; i++)
            {
                if (animatoren[i] !=null)
                {
                    animatoren[i].Bewegen();
                }        
            }
        }
    }


    class LabelAnimator
    {
        public Label DasLabel;

        public bool Vorwärts = true;

        public void Bewegen()
        {
            if (DasLabel != null)
            {
                if (Vorwärts == true)
                {
                    DasLabel.Left += 5;
                    if (DasLabel.Left >= DasLabel.Parent.Width - DasLabel.Width)
                    {
                        Vorwärts = false;
                    }
                    }
                else
                {
                    DasLabel.Left -= 5;
                    if (DasLabel.Left <= 0)
                    {
                        Vorwärts = true;
                    }

                }

            }

        }


    }

}
