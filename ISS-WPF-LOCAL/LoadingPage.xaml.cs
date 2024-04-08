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
using System.Windows.Threading;

namespace ISS_WPF_LOCAL
{
    /// <summary>
    /// Interaction logic for LoadingPage.xaml
    /// </summary>
    public partial class LoadingPage : Page
    {

        private string _gamePage;
        private DispatcherTimer timer;
        private TimeSpan elapsedTime;
        private TimeSpan desiredTime = TimeSpan.FromSeconds(10); // Change to desired time

        public LoadingPage(string gamePage)
        {
            InitializeComponent();

            this._gamePage= gamePage;
            // Initialize and start the timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update elapsed time
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));

            // Check if desired time has passed
            if (elapsedTime >= desiredTime)
            {
                // Stop the timer
                timer.Stop();

                // Navigate to another page
                NavigationService?.Navigate(new Uri($"{this._gamePage}.xaml", UriKind.Relative));
            }
        }
    }
}
