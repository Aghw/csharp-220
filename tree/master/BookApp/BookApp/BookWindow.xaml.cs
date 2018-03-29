using BookApp.Models;
using System;
using System.Windows;

namespace BookApp
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public BookWindow()
        {
            InitializeComponent();

            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }


        public BookModel Book { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if (Book != null)
            //{
            //uxTitle.Text = Book.Title;
            //uxCategory.Text = Book.Category;

            //uxISBN_10.Text = Book.ISBN_10;
            //uxISBN_13.Text = Book.ISBN_13;

            //uxPrice.Text = Book.Price.ToString();
            //uxCost.Text = Book.Cost.ToString();

            //uxQty.Text = Book.Quantity.ToString();

            //uxFName.Text = Book.FName;
            //uxLName.Text = Book.LName;
            //uxBirthDate.Text = Book.Birthdate.ToString();

            //uxPhone.Text = Book.Phone;
            //uxEmail.Text = Book.Email;
            //uxNotes.Text = Book.Notes;
            //}
            //else
            if (Book == null)
            {
                Book = new BookModel();
                Book.AddedDate = DateTime.Now;
            }

            uxGrid.DataContext = Book;
        }


        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
