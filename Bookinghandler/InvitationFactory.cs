using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    public class InvitationFactory : IInvitationFactory
    {
        public InvitationFactory()
        {
        }

        public IInvitation CreateInvitation(Guid id, string email)
        {
            IInvitation invitation = new Invitation(id, email);
            return invitation;

        }
        public IEnumerable<IInvitation> CreateInvitationEnumerable(IEnumerable<string> sentInvitations)
        {
            List<IInvitation> invitations = new List<IInvitation>();
            foreach (string email in sentInvitations)
            {
               invitations.Add(CreateInvitation(Guid.NewGuid(), email));
            }
            return invitations;
        }
    }
}
