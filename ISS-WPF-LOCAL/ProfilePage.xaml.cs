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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MenuPage());
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HistoryPage());
        }

        private void chessStatsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void connect4StatsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obstructionStatsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dartsStatsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
