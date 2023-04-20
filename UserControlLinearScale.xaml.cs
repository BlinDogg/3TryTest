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
            public int X1 { get; set; }
            public int X2 { get; set; }
        }
        public class DegreeNumberViewModel
        {
            public string Text { get; set; }
        }

        public ObservableCollection<LineViewModel> Lines { get; set; }
        public ObservableCollection<DegreeNumberViewModel> DegreeNumbers { get; set; }

        public UserControlLinearScale()
        {
            InitializeComponent();
            DegreeNumbers = new ObservableCollection<DegreeNumberViewModel>();
            Lines = new ObservableCollection<LineViewModel>();
            for (int i = 0; i <= 36; i++)
            {
                if (i % 2 == 1) Lines.Add(new LineViewModel { Y1 = 28, Y2 = 28, X1 = 250, X2 = 290 });
                else
                {
                    Lines.Add(new LineViewModel { Y1 = 28, Y2 = 28, X1 = 210, X2 = 250 });
                    DegreeNumbers.Add(new DegreeNumberViewModel {Text = "10"});
                    Lines.Add(new LineViewModel { Y1 = -2, Y2 = -2, X1 = 290, X2 = 330 });
                }
                    
            }

            DataContext = this;
        }
    }
}