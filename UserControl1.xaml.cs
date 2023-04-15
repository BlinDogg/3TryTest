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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static readonly DependencyProperty HeightMarginProperty =
            DependencyProperty.Register("HeightMargin", typeof(double), typeof(UserControl1), new PropertyMetadata(0.0, HeightMarginChangedCallback));

        public double HeightMargin
        {
            get { return (double)GetValue(HeightMarginProperty); }
            set { SetValue(HeightMarginProperty, value); }
        }

        private static void HeightMarginChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (UserControl1)d;
            var newHeightMargin = (double)e.NewValue;
            control.grid.Margin = new Thickness(0, -newHeightMargin, 0, 0);
        }

        public UserControl1()
        {
            InitializeComponent();

        }

        
        
    }
}
