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
    /// Interaction logic for OpponentPage.xaml
    /// </summary>
    public partial class OpponentPage : Page
    {
        private string _gamePage;
        public OpponentPage(string gamePage)
        {
            InitializeComponent();
            _gamePage = gamePage;
        }

        private void humanButton_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new LoadingPage(_gamePage));
        }

        private void robotButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri($"{_gamePage}.xaml", UriKind.Relative));
        }
    }
}
