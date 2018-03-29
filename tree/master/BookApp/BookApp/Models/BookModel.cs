using System;

namespace BookApp.Models
{
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



        // to prevent updating the grid of book data with memory data
        internal BookModel Clone()
        {
            return (BookModel)MemberwiseClone();
        }
        public BookRepository.BookModel ToRepositoryModel()
        {
            var repositoryModel = new BookRepository.BookModel
            {
                Id = Id,
                Title = Title,
                Category = Category,
                FName = FName,
                LName = LName,
                Price = Price,
                Cost = Cost,
                ISBN_10 = ISBN_10,
                ISBN_13 = ISBN_13,
                Email = Email,
                Phone = Phone,
                Birthdate = Birthdate,
                Notes = Notes,
                Quantity = Quantity,
                AddedDate = AddedDate,
            };

            return repositoryModel;
        }

        public static BookModel ToModel(BookRepository.BookModel respositoryModel)
        {
            var bookModel = new BookModel
            {
                Id = respositoryModel.Id,
                Title = respositoryModel.Title,
                Category = respositoryModel.Category,
                FName = respositoryModel.FName,
                LName = respositoryModel.LName,
                Price = respositoryModel.Price,
                Cost = respositoryModel.Cost,
                ISBN_10 = respositoryModel.ISBN_10,
                ISBN_13 = respositoryModel.ISBN_13,
                Email = respositoryModel.Email,
                Phone = respositoryModel.Phone,
                Birthdate = respositoryModel.Birthdate,
                Notes = respositoryModel.Notes,
                Quantity = respositoryModel.Quantity,
                AddedDate = respositoryModel.AddedDate,
            };

            return bookModel;
        }
    }
}
