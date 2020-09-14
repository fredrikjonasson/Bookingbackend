using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IContactInformationFactory
    {
        IContactInformation CreateContactInformation(Guid id, string firstName, string lastName, string email);

    }
}
