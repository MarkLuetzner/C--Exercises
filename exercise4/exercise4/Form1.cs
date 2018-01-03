using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise4
{
    public partial class Bildform : Form
    {
        public Bildform()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            while (Visible)
                {
                for (int c = 0; c < 253; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }

                for (int c = 253; c > 0; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
            }
            

        }
    }
}
