using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public interface IContactinformationFactory
    {
        IContactInformation createContactInformation(string firstName, string lastName, string email);

    }
}
