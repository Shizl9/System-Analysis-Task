using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Book
    {
        public int bookId { get; set; } //System Generated :generated automatically by the system when a new book is added.
        public string title { get; set; } // input //entered by the librarian when adding a book
        public string auther { get; set; } // input //entered by the librarian when adding a book
        public string genre { get; set; }//input //entered by the librarian when adding a book
        public int totalCopies { get; set; } //input //entered by the librarian when adding a book
        public int borrowCount { get; set; } //calculated from the total number of loan records for this book
    }
}
