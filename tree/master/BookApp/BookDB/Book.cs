//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string AuthorFName { get; set; }
        public string AuthorLName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Quantity { get; set; }
        public System.DateTime AddedDate { get; set; }
    }
}
