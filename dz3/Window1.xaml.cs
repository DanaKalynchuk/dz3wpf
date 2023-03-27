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
using System.Windows.Shapes;
using static dz3.MainWindow;

namespace dz3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public bool WrapChecked = false;
        public int FontChecked = 0;
        public Window1()
        {
            InitializeComponent();
        }
        public void Ch(bool _WrapChecked, double _NotepadFontSize)
        {
            WrapChecked = _WrapChecked;
            if (_WrapChecked)
            {
                WrapTextCheckbox.IsChecked = true;
            }
            else WrapTextCheckbox.IsChecked = false;
            if (_NotepadFontSize == 1)
            {
                VerySmall.IsChecked = true;
            }
            else if (_NotepadFontSize == 2)
            {
                Small.IsChecked = true;
            }
            else if (_NotepadFontSize == 3)
            {
                Normal.IsChecked = true;
            }
            else if (_NotepadFontSize == 4)
            {
                Big.IsChecked = true;
            }
            else if (_NotepadFontSize == 5)
            {
                VeryBig.IsChecked = true;
            }

        }

        private void WrapTextCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            WrapChecked = true;
          
           
        }

        private void WrapTextCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            WrapChecked = false;
            
            
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void VerySmall_Checked(object sender, RoutedEventArgs e)
        {
            FontChecked = 1;
        }

        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            FontChecked = 2;
        }

        private void Normal_Checked(object sender, RoutedEventArgs e)
        {
            FontChecked = 3;
        }

        private void Big_Checked(object sender, RoutedEventArgs e)
        {
            FontChecked = 4;
        }

        private void VeryBig_Checked(object sender, RoutedEventArgs e)
        {
            FontChecked = 5;
        }
    }
}
