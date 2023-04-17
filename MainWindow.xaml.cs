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

namespace _3TryTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private UserControlUnion myUserControlUnion;

        private void OnPitchSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double pitchValue = e.NewValue;
            myUserControlUnion.Pitch = pitchValue;
        }
        private void OnRollSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double rollValue = e.NewValue;
            myUserControlUnion.Roll = rollValue;
        }

        public MainWindow()
        {
            InitializeComponent();
            myUserControlUnion = new UserControlUnion();
            MainGrid.Children.Add(myUserControlUnion);

        }
    }
}
