using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _3TryTest
{
    /// <summary>
    /// Логика взаимодействия для UserControlAir.xaml
    /// </summary>
    public partial class UserControlAir : UserControl
    {
        private DispatcherTimer timer;
        private bool isPinkVisible = false;
        public UserControlAir()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.4); //интервал
            timer.Tick += OnTimedEvent;
            timer.Start();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            if (isPinkVisible)
            {
                pinkImage.Visibility = Visibility.Hidden;
                blackImage.Visibility = Visibility.Visible;
                isPinkVisible = false;
            }
            else
            {
                pinkImage.Visibility = Visibility.Visible;
                blackImage.Visibility = Visibility.Hidden;
                isPinkVisible = true;
            }
        }
    }
}
