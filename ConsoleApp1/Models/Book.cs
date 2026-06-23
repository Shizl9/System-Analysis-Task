using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Book
    {
        public int bookId { get; set; } //system generated
        public string title { get; set; } // input
        public string auther { get; set; } // input 
        public string genre { get; set; }//input
        public int totalCopies { get; set; } //input
        public int borrowCount { get; set; } //calculated form loan 
    }
}
