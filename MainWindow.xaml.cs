using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace _3TryTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public static double maxPitch { get; set; } = 30;
        public static double maxRoll { get; set; } = 40;


        public double currentRoll { get; set; } = 0;
        public double currentPitch{ get; set; } = 0;


        public string maxPitchStr { get; set; } = Convert.ToString(maxPitch);
        public string maxRollStr { get; set; } = Convert.ToString(maxRoll);

        private UserControlUnion myUserControlUnion;

        private void OnPitchSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double pitchValue = e.NewValue;
            myUserControlUnion.Pitch = pitchValue;
            currentPitch = pitchValue;
            checkAlarm();
        }
        private void OnRollSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double rollValue = e.NewValue;
            myUserControlUnion.Roll = rollValue;
            currentRoll = rollValue;
            checkAlarm();
        }

        private void checkAlarm()
        {
            if (currentRoll >= maxRoll || currentPitch >= maxPitch ||
                currentRoll <= -maxRoll || currentPitch <= -maxPitch) 
                myUserControlUnion.alarmBool = true;
            else myUserControlUnion.alarmBool = false;
        }

        public MainWindow()
        {
            InitializeComponent();
            myUserControlUnion = new UserControlUnion();
            MainGrid.Children.Add(myUserControlUnion);

            DataContext = this;
        }
    }
}
