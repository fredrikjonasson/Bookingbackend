using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DataBaseEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public List<Invitation> SentInvitations { get; set; }
        public List<Participant> Participants { get; set; }
        public DataBaseEvent(Guid id, string name, string description, DateTime startDate, List<Invitation> invitations, List<Participant> participants)
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
