using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Entities
{
    public class DataBaseContactInformation
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DataBaseContactInformation()
        {

        }
        public DataBaseContactInformation(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
