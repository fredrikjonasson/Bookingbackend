using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Bookinghandler
{
    public interface IEventFactory
    {
        IEvent CreateAnEvent(string name, string description, DateTime startDate, IEnumerable<string> sentInvitations);
    }
}