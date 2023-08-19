using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.Shared.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string firstName, string lastName)
        {
            ContactId = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
