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
            DependencyProperty.Register("Pitch", typeof(double), typeof(UserControlUnion), new PropertyMetadata(0d, OnPitchPropertyChanged));

        public static readonly DependencyProperty RollProperty =
            DependencyProperty.Register("Roll", typeof(double), typeof(UserControlUnion), new PropertyMetadata(0d, OnRollPropertyChanged));

        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register("Angle", typeof(double), typeof(UserControlUnion), new PropertyMetadata(0d));




        private static void OnRollPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControlUnion)d;
            control.Angle = (double)e.NewValue;
        }

        private static void OnPitchPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControlUnion)d;
            control.HeightMargin = 540 - ((double)e.NewValue * 6);
        }

        public double HeightMargin
        {
            get { return (double)GetValue(HeightMarginProperty); }
            set { SetValue(HeightMarginProperty, value); }
        }

        public double Pitch
        {
            get { return (double)GetValue(PitchProperty); }
            set { SetValue(PitchProperty, value); }
        }

        public double Roll
        {
            get { return (double)GetValue(RollProperty); }
            set { SetValue(RollProperty, value); }
        }

        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        public UserControlUnion()
        {
            InitializeComponent();

            //Pitch = 10;
            //Roll = 50;

            

        }


    }
}
