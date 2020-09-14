using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public class ContactInformationFactory : IContactinformationFactory
    {
        public IContactInformation createContactInformation(string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }
    }
}
