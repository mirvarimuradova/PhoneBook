using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class Contact
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public Contact(string name, string surname, string number, string email)
        {
            Name = name;
            Surname = surname;
            Phone = number;
            Email = email;

        }

    }
}
