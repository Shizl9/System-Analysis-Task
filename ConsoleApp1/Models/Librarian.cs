using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Librarian
    {
        public int librarianID { get; set; }//system generated
        public string fullName { get; set; }//entered by the librarian 
        public string librarianEmail { get; set; }//entered by the librarian 
        public string librarianPhone { get; set; }//entered by the librarian
        public string username { get; set; } // entered by the librarian
        public string password { get; set; }//entered by the librarian 
    }
}
