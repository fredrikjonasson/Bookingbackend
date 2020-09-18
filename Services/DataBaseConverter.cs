using Domain.Interfaces;
using Repository;
using Repository.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class DataBaseConverter
    {
        public List<DataBaseInvitation> EntityInvitationsToDataBaseInvitations (List<IInvitation> invitations)
        {
            DataBaseInvitationFactory dataBaseInvitationFactory = new DataBaseInvitationFactory();
            throw new NotImplementedException();
        }
        public DataBaseEvent EntityEventToDataBaseEvent (IEvent @event) 
        {
            DataBaseEventFactory dataBaseEventFactory = new DataBaseEventFactory();
            //dataBaseEventFactory.CreateDataBaseEvent(@event.Id, @event.Name, @event.Description, @event.StartDate)

            throw new NotImplementedException();
        }
    }
}
