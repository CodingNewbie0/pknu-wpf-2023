using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wp08_personalInfoApp.Models
{
    internal class Person
    {
        // 외부에서 접근불가
        private string email;
        private DateTime date;

        public string FirstName { get; set; } // Auto Property
        public string LastName { get; set; }
        public string Email { get => email; set => email = value; }
        public DateTime Date { get => date; set => date = value; }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }
    }
}
