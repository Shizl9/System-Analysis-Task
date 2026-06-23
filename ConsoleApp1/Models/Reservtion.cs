using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Reservtion
    {
        public int reservationId { get; set; }// system generated 
        public int memberId { get; set; } // From List chosen from the list of members
        public int bookId { get; set; }   // From List chosen from the list of books
        public string resrvationDate { get; set; } //default automatically set to the current date
        public string status { get; set; }// default value==> automatically set to "Pending" when the reservation is created
    }

}
