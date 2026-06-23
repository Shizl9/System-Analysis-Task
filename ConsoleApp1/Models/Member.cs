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
        public string memberName { get; set; } // input entered by the member during registration
        public string memberPhone { get; set; } //input entered by the member during registration
        public string memberEmail { get; set; } //input entered by the member during registration
        public string registrationDate { get; set; } //default value automatically set to the current date when the member registers
    }
}
