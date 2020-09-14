using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Invitation : IInvitation
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        IInvitation.InvitationStatus IInvitation.Status { get; set; }
        public Invitation(Guid id, string email)
        {
            Id = id;
            Email = email;
        }


    }
}
