using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace dz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string path = "";


        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text file(*.txt)|*.txt";
            
            if (openFile.ShowDialog() == true)
            {
                
                    StreamReader stream = File.OpenText(openFile.FileName);
                Notepad.Text = stream.ReadToEnd();
                path = openFile.FileName;
                stream.Close();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter= "Text file(*.txt)|*.txt";
            
           if(saveFile.ShowDialog()==true) {
                StreamWriter stream = new StreamWriter(saveFile.FileName);
                stream.Write(Notepad.Text);
                path = "";
                stream.Close();
            }
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            if (path != "")
            {

                MessageBoxResult result = MessageBox.Show("Changes will not be saved ", "Massage", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    return;
                }

            }
            Notepad.Clear();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            if(Notepad.TextWrapping == TextWrapping.Wrap)
            {
                window1.Ch(true, Notepad.FontSize/10);
            }
            else window1.Ch(false, Notepad.FontSize/10);

            if ( window1.ShowDialog()==true)
                {
                if (window1.WrapChecked)
                {
                    Notepad.TextWrapping = TextWrapping.Wrap;
                }
                else Notepad.TextWrapping = TextWrapping.NoWrap;
                if(window1.FontChecked == 1)
                {
                    Notepad.FontSize = 10;
                }
                else if(window1.FontChecked == 2)
                {
                    Notepad.FontSize = 20;
                }
                else if (window1.FontChecked == 3)
                {
                    Notepad.FontSize = 30;
                }
                else if (window1.FontChecked == 4)
                {
                    Notepad.FontSize = 40;
                }
                else if (window1.FontChecked == 5)
                {
                    Notepad.FontSize = 50;
                }
            }
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            Notepad.SelectAll();
           
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            Notepad.Paste();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            Notepad.Cut();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            Notepad.Copy();
        }
    }
}
