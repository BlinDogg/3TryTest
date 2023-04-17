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

        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register("Angle", typeof(double), typeof(UserControlAir), new PropertyMetadata(0.0, AngleChangedCallback));

        public static readonly DependencyProperty alarmBoolProperty =
    DependencyProperty.Register("alarmBool", typeof(bool), typeof(UserControlAir), new PropertyMetadata(false, alarmBoolChangedCallback));

        public bool alarmBool
        {
            get { return (bool)GetValue(alarmBoolProperty); }
            set { SetValue(alarmBoolProperty, value); }
        }

        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        private static void AngleChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControlAir)d;
            var newAngle = (double)e.NewValue;
            control.rotate.Angle = newAngle;

        }

        private static void alarmBoolChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControlAir)d;
            var newValue = (bool)e.NewValue;

            if (newValue)
            {
                control.timer = new DispatcherTimer();
                control.timer.Interval = TimeSpan.FromSeconds(0.4);
                control.timer.Tick += control.OnTimedEvent;
                control.timer.Start();
            }
            else
            {
                control.timer.Stop();
                control.pinkImage.Visibility = Visibility.Hidden;
                control.blackImage.Visibility = Visibility.Visible;
            }

        }



        public UserControlAir()
        {
            InitializeComponent();            
                
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
