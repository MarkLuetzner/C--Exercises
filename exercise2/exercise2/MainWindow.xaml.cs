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

namespace exercise2
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

        private void textÄndern_Click(object sender, RoutedEventArgs e)
        {
            if (checkAktivieren.IsChecked == true)
            {

                if (labelText.HorizontalAlignment==HorizontalAlignment.Left)
                {
                    labelText.HorizontalAlignment = HorizontalAlignment.Right;
                    labelText.Text = "Rechts";

                }
                else 
                        {
                    labelText.HorizontalAlignment = HorizontalAlignment.Left;
                    labelText.Text = "Links";

                }

            }

                else
                {

                labelText.Text = "Textänderung deaktiviert";
                labelText.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }

        private void checkAktivieren_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
