using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghandler
{
    public class ParticipantFactory : IParticipantFactory
    {
        public IParticipant createParticipant(IContactInformation contactInformation)
        {
            throw new NotImplementedException();
        }
    }
}
