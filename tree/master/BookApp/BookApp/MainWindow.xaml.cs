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
using System.ComponentModel;
using BookApp.Models;

namespace BookApp
{
    public class SortAdorner : Adorner
    {
        private static Geometry ascGeometry =
                Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

        private static Geometry descGeometry =
                Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

        public ListSortDirection Direction { get; private set; }

        public SortAdorner(UIElement element, ListSortDirection dir)
                : base(element)
        {
            this.Direction = dir;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (AdornedElement.RenderSize.Width < 20)
                return;

            TranslateTransform transform = new TranslateTransform
                    (
                            AdornedElement.RenderSize.Width - 15,
                            (AdornedElement.RenderSize.Height - 5) / 2
                    );
            drawingContext.PushTransform(transform);

            Geometry geometry = ascGeometry;
            if (this.Direction == ListSortDirection.Descending)
                geometry = descGeometry;
            drawingContext.DrawGeometry(Brushes.Black, null, geometry);

            drawingContext.Pop();
        }
    }



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        //private BookModel selectedContact;
        private BookModel selectedBook;


        public MainWindow()
        {
            InitializeComponent();

            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = App.BookRepository.GetAll();

            uxBookList.ItemsSource = books
                .Select(t => BookModel.ToModel(t))
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxBookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedBook = (BookModel)uxBookList.SelectedValue;
            if (selectedBook != null)
            {
                uxCalculated.Text = "Inventory Total Price of Selected Book: $" + (selectedBook.Price * selectedBook.Quantity).ToString("0.##");
            }
        }

      
        private void OnNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New command");
        }


        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new BookWindow();

            if (window.ShowDialog() == true)
            {
                var uiBookModel = window.Book;

                var repositoryBookModel = uiBookModel.ToRepositoryModel();

                App.BookRepository.Add(repositoryBookModel);

                // Or
                // App.BookRepository.Add(window.Book.ToRepositoryModel());
                LoadBooks();
            }

        }

        private void lvBookColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                uxBookList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            uxBookList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }



        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            var window = new BookWindow();

            // to prevent the grid from showing canceled update point the book to clone
            //window.Book = selectedBook;
            window.Book = selectedBook.Clone();

            if (window.ShowDialog() == true)
            {
                App.BookRepository.Update(window.Book.ToRepositoryModel());
                LoadBooks();
            }
            uxCalculated.Text = "";
        }

        private void uxBookList_MouseDblClick(object sender, RoutedEventArgs e)
        {
            uxFileChange_Click(sender, e);
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedBook != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedBook != null);
            uxContextFileDelete.IsEnabled = uxFileDelete.IsEnabled;
        }


        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.BookRepository.Remove(selectedBook.Id);
            selectedBook = null;
            LoadBooks();
        }
    }
}
