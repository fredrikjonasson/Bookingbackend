using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IParticipantFactory
    {
        IParticipant CreateParticipant(IContactInformation contactInformation);
    }
}
