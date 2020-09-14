using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public interface IParticipantFactory
    {
        IParticipant createParticipant(IContactInformation contactInformation);
    }
}
