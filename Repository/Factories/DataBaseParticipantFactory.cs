using Domain.Interfaces;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Factories
{
    public class DataBaseParticipantFactory
    {
        public DataBaseParticipant CreateDataBaseParticipant(Guid id, DataBaseContactInformation contactInformation)
        {
            DataBaseParticipant participant = new DataBaseParticipant(id, contactInformation);
            return participant;
        }
    }
}
