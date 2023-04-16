using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class UserControlLinearScale : UserControl
    {
        public class LineViewModel
        {
            public int Y1 { get; set; }
            public int Y2 { get; set; }
        }
        public ObservableCollection<LineViewModel> Lines { get; set; }

        public UserControlLinearScale()
        {
            InitializeComponent();

            Lines = new ObservableCollection<LineViewModel>();
            for (int i = 0; i <= 1020;)
            {
                Lines.Add(new LineViewModel { Y1 = i, Y2 = i });
                i = i + 51;
            }

            DataContext = this;
        }
    }
}