using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Services
{
    public class NewEventAssembler
    {

        private readonly IInvitationFactory _invitationFactory;
        private readonly IEventFactory _eventFactory;

        public NewEventAssembler( IInvitationFactory invitationFactory, IEventFactory eventFactory)
        {
            _invitationFactory = invitationFactory;
            _eventFactory = eventFactory;
        }

        public IEvent AssembleEvent(string eventName, string eventDescription, DateTime startDate, IEnumerable<string> sentInvitations) 
        {
            List<IParticipant> participants = new List<IParticipant>();
            IEnumerable<IInvitation> invitations = convertToInvitationList(sentInvitations);
            IEvent @event = _eventFactory.CreateEvent(Guid.NewGuid(), eventName, eventDescription, startDate, invitations, participants);
            throw new NotImplementedException();
        }

        private IEnumerable<IInvitation> convertToInvitationList(IEnumerable<string> sentInvitations)
        {
            return _invitationFactory.CreateInvitationEnumerable(sentInvitations);
        }
    }
}
