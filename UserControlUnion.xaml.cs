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
    /// Логика взаимодействия для UserControlUnion.xaml
    /// </summary>
    public partial class UserControlUnion : UserControl
    {
        public static readonly DependencyProperty HeightMarginProperty =
         DependencyProperty.Register("HeightMargin", typeof(double), typeof(UserControlUnion), new PropertyMetadata(0d));
        public static readonly DependencyProperty PitchProperty =
        DependencyProperty.Register("Pitch", typeof(double), typeof(UserControlUnion), new PropertyMetadata(0.0));


        public void SubscribeToPitchValueChangedEvent(MainWindow mainWindow)
        {
            mainWindow.PitchValueChanged += MainWindow_PitchValueChanged;
        }

        private void MainWindow_PitchValueChanged(object sender, double pitchValue)
        {
            // Изменяем значение переменной в UserControl
            // ...
            Pitch = pitchValue;
        }

        public double Pitch
        {
            get { return (double)GetValue(PitchProperty); }
            set { SetValue(PitchProperty, value); }
        }


        public double HeightMargin
        {
            get { return (double)GetValue(HeightMarginProperty); }
            set { SetValue(HeightMarginProperty, value); }
        }

        

        public UserControlUnion()
        {
            InitializeComponent();

            //Pitch = 10;
            SubscribeToPitchValueChangedEvent((MainWindow)Window.GetWindow(this));

            double baseMargin = 540;
            HeightMargin = baseMargin- Pitch * 6;

        }


    }
}
