using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DataBaseInvitation
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        InvitationStatus Status { get; set; }
        
        public DataBaseInvitation(Guid id, string email)
        {
            Id = id;
            Email = email;
        }

        public enum InvitationStatus
        {
            Sent,
            Attending,
            NotAttending
        }

    }
}
