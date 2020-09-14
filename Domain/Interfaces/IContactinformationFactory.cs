using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IContactinformationFactory
    {
        IContactInformation CreateContactInformation(string firstName, string lastName, string email);

    }
}
