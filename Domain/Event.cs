using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event : IEvent
    {
        private IEnumerable<IInvitation> invitations;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public List<IInvitation> SentInvitations { get; set; }
        public List<IParticipant> Participants { get; set; }
        public Event(Guid id, string name, string description, DateTime startDate, IEnumerable<IInvitation> invitations, IEnumerable<IParticipant> participants)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            SentInvitations = (List<IInvitation>)invitations;
            Participants = (List<IParticipant>)participants;
        }


    }
}
