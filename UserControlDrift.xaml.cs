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
    /// Логика взаимодействия для UserControlDrift.xaml
    /// </summary>
    public partial class UserControlDrift : UserControl
    {
        public static readonly DependencyProperty DriftMarginProperty =
            DependencyProperty.Register("DriftMargin", typeof(double), typeof(UserControlDrift), new PropertyMetadata(0.0, DriftMarginChangedCallback));

        public double DriftMargin
        {
            get { return (double)GetValue(DriftMarginProperty); }
            set { SetValue(DriftMarginProperty, value); }
        }



        private static void DriftMarginChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControlDrift)d;
            var newDriftMargin1 = 85 + (double)e.NewValue;
            var newDriftMargin2 = 85 - (double)e.NewValue;
            control.mooveout.Margin = new Thickness(newDriftMargin1, 0, newDriftMargin2, 0);

        }
        public UserControlDrift()
        {
            InitializeComponent();
        }
    }
}
