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

    }
}
