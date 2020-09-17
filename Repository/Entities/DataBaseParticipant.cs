using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Entities
{
    public class DataBaseParticipant
    {
        public Guid Id { get; set; }
        public DataBaseContactInformation ContactInformation { get; set; }
        public DataBaseParticipant(Guid id, DataBaseContactInformation contactInformation)
        {
            Id = id;
            ContactInformation = contactInformation;
        }

        public DataBaseParticipant()
        {

        }
    }
}
