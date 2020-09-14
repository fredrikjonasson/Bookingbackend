using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IInvitationFactory
    {
        public IInvitation CreateInvitation(Guid id, string email);
        public IEnumerable<IInvitation> CreateInvitationEnumerable(IEnumerable<string> sentInvitations);

    }
}