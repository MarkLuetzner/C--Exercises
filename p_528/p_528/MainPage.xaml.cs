﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace p_528
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    //sealed partial
    partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            //booksDisplay.DataContext = game;
            //progressDisplay.DataContext = game;
        }

        private void askForACard_Click(object sender, RoutedEventArgs e)
        {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            game.StartGame();
        }

        private void cards_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }

        private void progressDisplay_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }
    }
}
