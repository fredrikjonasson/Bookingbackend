using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public List<IInvitation> SentInvitations { get; set; }
        public List<IParticipant> Participants { get; set; }
        public Event(Guid id, string name, string description, DateTime startDate, List<IInvitation> invitations, List<IParticipant> participants)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            SentInvitations = invitations;
            Participants = participants;
        }


    }
}
