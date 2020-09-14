using Domain.Interfaces;
using System.Collections.Generic;

namespace Bookinghandler
{
    public interface IInvitationFactory
    {
        List<IInvitation> createInvitations(IEnumerable<string> sentInvitations);
    }
}