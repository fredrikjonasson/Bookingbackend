using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bookinghandler
{
    public class EventFactory
    {
        private readonly IEvent _event;
        private readonly IInvitation _invitation;

        public EventFactory(IEvent @event, IInvitation invitation)
        {
            _event = @event;
            _invitation = invitation;

        }

        public @IEvent CreateAnEvent(string name, string description, DateTime startDate, IEnumerable<string> sentInvitations)
        {
            InvitationFactory _invitationFactory = new InvitationFactory(_invitation);
            List<IInvitation> createdInvitations = _invitationFactory.createInvitations(sentInvitations);


            return _event.createNewEvent(name, description, startDate, createdInvitations); 
        }

    }
}
