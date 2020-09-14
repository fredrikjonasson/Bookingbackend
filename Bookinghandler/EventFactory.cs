using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bookinghandler
{
    public class EventFactory : IEventFactory
    {
        private readonly IEvent _event;
        private readonly IInvitationFactory _invitationFactory;

        public EventFactory(IEvent @event, IInvitationFactory invitationFactory)
        {
            _event = @event;
            _invitationFactory = invitationFactory;

        }
    }
}
