using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
            public int Y11 { get; set; }
            public int Y12 { get; set; }
            public string Text { get; set; }
        }

       

        public ObservableCollection<LineViewModel> Lines { get; set; }
        //public ObservableCollection<DegreeNumberViewModel> DegreeNumbers { get; set; }

        public UserControlLinearScale()
        {
            InitializeComponent();
            //DegreeNumbers = new ObservableCollection<DegreeNumberViewModel>();
            Lines = new ObservableCollection<LineViewModel>();
            for (int i = 170; i >= 0; i-=10)
            {
                int degreeCounter = i - 80;
                if (degreeCounter < 0)
                {
                    degreeCounter = -degreeCounter;
                    string degree = degreeCounter.ToString();
                    Lines.Add(new LineViewModel { Y11 = 58, Y12 = 58, Text = degree });
                }
                    
                else if (degreeCounter == 0) Lines.Add(new LineViewModel { Y11 = 58, Y12 = 58, Text = "" });
                else
                {
                    string degree = degreeCounter.ToString();
                    Lines.Add(new LineViewModel { Y11 = 58, Y12 = 58, Text = degree });
                }
                

                
                
                    
            }
            
            DataContext = this;
        }
    }
}