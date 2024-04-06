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

namespace ISS_WPF_LOCAL
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        public void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProfilePage());
        }

        private void chessButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OpponentPage());
        }

        private void connect4Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OpponentPage());
        }

        private void dartsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OpponentPage());
        }

        private void obstructionButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OpponentPage());
        }
    }
}
