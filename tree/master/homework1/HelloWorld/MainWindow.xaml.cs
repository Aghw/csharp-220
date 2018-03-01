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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Exercise1: Maximize window using C# code
            //WindowState = WindowState.Maximized; 

        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Username Entered is: " + uxName.Text + "\nPassword Entered is: " + uxPassword.Text);
          
            
        }

        //private void Username_Password_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    var uxName_txtBox = sender as TextBox;
        //}

        //private void uxName_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    uxSubmit.IsEnabled = true;
        //}

        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxSubmit.IsEnabled = true;
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxSubmit.IsEnabled = true;
        }
    }
}
