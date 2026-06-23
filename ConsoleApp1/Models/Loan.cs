using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Loan
    {
        public int loanId { get; set; }//system generate //generated automatically when a new loan is created
        public int memberId { get; set; } // From List //chosen from the list of registered members
        public int bookId { get; set; }   // From List ///chosen from the list of available books
        public string borrowDate { get; set; } //default value ====>//automatically set to the current date
        public string returnDate { get; set; } //default ===>//entered when the member returns the book
        public string dueDate { get; set; } // calculated from  book (calculated as borrowDate + 14 days) 
        public double fineAmount { get; set; }// calculated form due date 
    }
}
