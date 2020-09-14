using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IEventFactory
    {
        public IEvent CreateEvent(string name, string description, DateTime startDate, IEnumerable<IInvitation> invitations);
    }
}