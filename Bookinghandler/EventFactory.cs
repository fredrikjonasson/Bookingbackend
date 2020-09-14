using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Factories
{
    public class EventFactory : IEventFactory
    {
        public IEvent CreateEvent(Guid id, string name, string description, DateTime startDate, IEnumerable<IInvitation> invitations, IEnumerable<IParticipant> participants)
        {
            IEvent @event = new Event(id, name, description, startDate, invitations, participants);
            return @event;
        }
    }
}
