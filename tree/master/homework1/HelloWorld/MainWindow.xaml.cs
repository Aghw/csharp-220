//
// Homework1
// 
// HelloWorld
// Description: The submit button should be disabled unless there is text in both the name
//              textbox and the password textbox. Submit button should be enabled when text is
//              filled in both the name textbox and the password textbox.
// Due date: 02/06/2018
// Author: Asmerom S. Ghebrihiwet

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


        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableDisableSubmitButton();
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableDisableSubmitButton();
        }

        private void EnableDisableSubmitButton()
        {
            string password = uxPassword.Text;
            string name = uxName.Text;
            uxSubmit.IsEnabled = !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(name);
        }
    }
}
