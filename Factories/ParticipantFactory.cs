using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    public class ParticipantFactory : IParticipantFactory
    {
        public IParticipant CreateParticipant(Guid id, IContactInformation contactInformation)
        {
            IParticipant participant = new Participant(id, contactInformation);
            return participant;
        }
    }
}
