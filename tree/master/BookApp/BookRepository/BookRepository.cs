//using System;
using BookDB;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BookRepository
{
    //class BookRepository
    //{
    //}
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public System.DateTime Birthdate { get; set; }
        public string Notes { get; set; }
        public int Quantity { get; set; }
        public System.DateTime AddedDate { get; set; }
    }

    public class BookRepository
    {
        public BookModel Add(BookModel bookModel)
        {
            var bookDb = ToDbModel(bookModel);

            DatabaseManager.Instance.Books.Add(bookDb);
            DatabaseManager.Instance.SaveChanges();

            bookModel = new BookModel
            {
                Id = bookDb.BookID,
                Title = bookDb.Title,
                Category = bookDb.Category,
                FName = bookDb.AuthorFName,
                LName = bookDb.AuthorLName,
                Price = bookDb.Price,
                Cost = bookDb.Cost,
                ISBN_10 = bookDb.ISBN_10,
                ISBN_13 = bookDb.ISBN_13,
                Email = bookDb.ContactEmail,
                Phone = bookDb.ContactPhone,
                Birthdate = bookDb.BirthDate.Value,
                Notes = bookDb.Notes,
                Quantity = bookDb.Quantity.Value,
                AddedDate = bookDb.AddedDate
            };
            return bookModel;
        }

        public List<BookModel> GetAll()
        {
            // Use .Select() to map the database contacts to ContactModel
            var items = DatabaseManager.Instance.Books
              .Select(t => new BookModel
              {
                  Id = t.BookID,
                  Title = t.Title,
                  Category = t.Category,
                  FName = t.AuthorFName,
                  LName = t.AuthorLName,
                  Price = t.Price,
                  Cost = t.Cost,
                  ISBN_10 = t.ISBN_10,
                  ISBN_13 = t.ISBN_13,
                  Email = t.ContactEmail,
                  Phone = t.ContactPhone,
                  Birthdate = t.BirthDate.Value,
                  Notes = t.Notes,
                  Quantity = t.Quantity.Value,
                  AddedDate = t.AddedDate,

              }).ToList();

            return items;
        }

        public bool Update(BookModel bookModel)
        {
            var original = DatabaseManager.Instance.Books.Find(bookModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(bookModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int bookId)
        {
            var items = DatabaseManager.Instance.Books
                                .Where(t => t.BookID == bookId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Books.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Book ToDbModel(BookModel bookModel)
        {
            var bookDb = new Book
            {
                BookID = bookModel.Id,
                Title = bookModel.Title,
                Category = bookModel.Category,
                AuthorFName = bookModel.FName,
                AuthorLName = bookModel.LName,
                Price = bookModel.Price,
                Cost = bookModel.Cost,
                ISBN_10 = bookModel.ISBN_10,
                ISBN_13 = bookModel.ISBN_13,
                ContactEmail = bookModel.Email,
                ContactPhone = bookModel.Phone,
                BirthDate = bookModel.Birthdate,
                Notes = bookModel.Notes,
                Quantity = bookModel.Quantity,
                AddedDate = bookModel.AddedDate
            };

            return bookDb;
        }
    }
}
