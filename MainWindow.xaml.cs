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
        public class CacheData
        {
            public double currentRoll { get; set; } = 0;
            public double maxRoll { get; set; } = 40;
            public double currentPitch{ get; set; } = 0;
            public double maxPitch { get; set; } = 30;
        }

        private UserControlUnion myUserControlUnion;
        private CacheData cache = new CacheData();

        private void OnPitchSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double pitchValue = e.NewValue;
            myUserControlUnion.Pitch = pitchValue;
            cache.currentPitch = pitchValue;
            checkAlarm();
        }
        private void OnRollSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double rollValue = e.NewValue;
            myUserControlUnion.Roll = rollValue;
            cache.currentRoll = rollValue;
            checkAlarm();
        }

        private void checkAlarm()
        {
            if (cache.currentRoll >= cache.maxRoll || cache.currentPitch >= cache.maxPitch ||
                cache.currentRoll <= -cache.maxRoll || cache.currentPitch <= -cache.maxPitch) 
                myUserControlUnion.alarmBool = true;
            else myUserControlUnion.alarmBool = false;
        }

        public MainWindow()
        {
            InitializeComponent();
            myUserControlUnion = new UserControlUnion();
            MainGrid.Children.Add(myUserControlUnion);
            

        }
    }
}
