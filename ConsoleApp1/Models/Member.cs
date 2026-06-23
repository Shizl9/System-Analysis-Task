using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Member
    {
        public int memberId { get; set; } //system generated
        public string memberName { get; set; } // input
        public string memberPhone { get; set; } //input
        public string memberEmail { get; set; } //input
        public string registrationDate { get; set; } //defult value
    }
}
