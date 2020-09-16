using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IEventFactory
    {
        public IEvent CreateEvent(Guid id, string name, string description, DateTime startDate, List<IInvitation> invitations, List<IParticipant> participants);
    }
}