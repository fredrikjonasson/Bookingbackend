using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    public class ContactInformationFactory : IContactInformationFactory
    {
        public IContactInformation CreateContactInformation(Guid id, string firstName, string lastName, string email)
        {
            IContactInformation contactInformation = new ContactInformation(id, firstName, lastName, email); 
            return contactInformation;
        }
    }
}
