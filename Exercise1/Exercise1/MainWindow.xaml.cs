using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

                dasLabel.Text = "Name ist" + name + "\nx ist" + x + "\nd ist " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x= 5;
            if (x==10)
            {
                dasLabel.Text = "x muss 10 sein";
            }
            else
            {
                dasLabel.Text = "x ist nicht 10";
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int einWert = 4;
            String name = "Richard";
            if ((einWert == 3 ) && (name.Equals("Tim")))

            {
                dasLabel.Text = "x ist 3 und der Name ist Tim.";
            }

            dasLabel.Text = "Diese Anweisung läuft immer";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int anzahl = 0;
            while(anzahl < 10)
            {
                anzahl = anzahl + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                anzahl = anzahl - 1;
            }
            dasLabel.Text = "Die ANtwort ist " + anzahl;

        }
    }
}
