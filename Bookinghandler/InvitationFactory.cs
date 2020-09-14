using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public class InvitationFactory : IInvitationFactory
    {
        private readonly IInvitation _invitation;

        public InvitationFactory(IInvitation invitation)
        {
            _invitation = invitation;

        }

        public List<IInvitation> createInvitations(IEnumerable<string> sentInvitations)
        {
            List<IInvitation> createdInvitations = new List<IInvitation>();
            foreach (string sentInvitation in sentInvitations)
            {
                createdInvitations.Add(_invitation.createNewInvitation(sentInvitation));

            }
            return createdInvitations;
        }
    }
}
