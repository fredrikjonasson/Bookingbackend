using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Participant : IParticipant
    {
        public Guid Id { get; set; }
        public IContactInformation ContactInformation { get; set; }

        public IParticipant createNewParticipant(IContactInformation contactInformation)
        {
            throw new NotImplementedException();
        }
    }
}
