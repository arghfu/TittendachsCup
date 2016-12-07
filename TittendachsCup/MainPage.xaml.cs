using System;
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

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace TittendachsCup
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigationFrame.Navigate(typeof(PlayerPage));
            NavigationTextBlock.Text = "Players";
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationView.IsPaneOpen = !NavigationView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlayerListBoxItem.IsSelected)
            {
                NavigationFrame.Navigate(typeof(PlayerPage));
                NavigationTextBlock.Text = "Players";
            }
            else if (TeamListBoxItem.IsSelected)
            {
                NavigationFrame.Navigate(typeof(TeamPage));
            }
            else if (TableListBoxItem.IsSelected)
            {
                NavigationFrame.Navigate(typeof(TablePage));
            }
            else if (MatchdayListBoxItem.IsSelected)
            {
                NavigationFrame.Navigate(typeof(MatchdayPage));
            }
        }
    }
}
