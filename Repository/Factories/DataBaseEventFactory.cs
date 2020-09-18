using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DataBaseEventFactory
    {
        public DataBaseEvent CreateDataBaseEvent(Guid id, string name, string description, DateTime startDate, List<DataBaseInvitation> invitations, List<DataBaseParticipant> participants)
        {
            DataBaseEvent @event = new DataBaseEvent(id, name, description, startDate, invitations, participants);
            return @event;
        }
    }
}
