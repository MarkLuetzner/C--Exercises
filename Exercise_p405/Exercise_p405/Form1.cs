using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_p405
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakfastLine;

        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            
                Flapjack food;
                if (crispy.Checked == true)
                    food = Flapjack.Crispy;
                else if (soggy.Checked == true)
                    food = Flapjack.Soggy;
                else if (browned.Checked == true)
                    food = Flapjack.Browned;
                else
                    food = Flapjack.Banana;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
                RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack newLumberjack = new Lumberjack(name.Text);
            breakfastLine.Enqueue(newLumberjack);
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            line.Items.Add(lumberjack.Name);
            if (breakfastLine.Count == 0)
            {
                nextInLine.Text = "";
            }
            else
            {
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + "flapjacks.";
            }
        }

        private void EatFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.EatFlapjacks();
            breakfastLine.Dequeue();
            RedrawList();
        }
    }
}
