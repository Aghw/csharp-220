//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using BookDB;

namespace BookRepository
{
    class DatabaseManager
    {
        private static readonly BooksEntities entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new BooksEntities();
            entities.Database.Connection.Open();
        }

        // Provide an accessor to the database
        public static BooksEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
