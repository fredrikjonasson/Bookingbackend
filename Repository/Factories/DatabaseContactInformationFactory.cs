using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Factories
{
    public class DatabaseContactInformationFactory
    {
        public DatabaseContactInformationFactory()
        {

        }

        public DataBaseContactInformation CreateDataBaseContactInformation(Guid id, string firstName, string lastName, string email)
        {
            DataBaseContactInformation contactInformation = new DataBaseContactInformation(id, firstName, lastName, email);
            return contactInformation;
        }
    }
}
