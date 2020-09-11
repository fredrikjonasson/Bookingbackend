using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IInvitation
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public InvitationStatus Status { get; set; }

        public enum InvitationStatus
        {
            Sent,
            Attending,
            NotAttending
        }

        public IInvitation createNewInvitation(string email);
    }
}
