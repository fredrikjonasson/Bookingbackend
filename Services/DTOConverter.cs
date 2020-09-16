using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class DTOConverter
    {
        IEventFactory _eventFactory;
        IInvitationFactory _invitationFactory;

        public DTOConverter(IEventFactory eventFactory, IInvitationFactory invitationFactory)
        {
            _eventFactory = eventFactory;
            _invitationFactory = invitationFactory;
        }
        public IEvent DTOToEvent(EventDTO eventDTO)
        { List<IParticipant> participants = new List<IParticipant>();
            List<IInvitation> invitations = _invitationFactory.CreateInvitationEnumerable(eventDTO.SentInvitations);
            IEvent @event = _eventFactory.CreateEvent(Guid.NewGuid(), eventDTO.Name, eventDTO.Description, eventDTO.StartDate, invitations, participants);
            return @event;
        }
    }


}
