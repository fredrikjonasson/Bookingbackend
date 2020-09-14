using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IParticipant
    {
        public Guid Id { get; set; }
        public IContactInformation ContactInformation { get; set; }

        public IParticipant createNewParticipant(IContactInformation contactInformation);
    }
}
