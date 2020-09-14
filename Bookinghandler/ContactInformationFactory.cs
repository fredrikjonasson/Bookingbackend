using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public class ContactInformationFactory : IContactinformationFactory
    {
        public IContactInformation CreateContactInformation(string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }
    }
}
