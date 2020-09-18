using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Factories
{
    public class DataBaseInvitationFactory
    {
        public DataBaseInvitationFactory()
        {

        }

        public DataBaseInvitation CreateDataBaseInvitation(Guid id, string email) 
        {
            DataBaseInvitation dataBaseInvitation = new DataBaseInvitation(id, email);
            return dataBaseInvitation;
        }
    }
}
