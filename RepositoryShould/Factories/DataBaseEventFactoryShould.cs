using Moq;
using Repository;
using Repository.Entities;
using Repository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace RepositoryShould
{
    public class DataBaseEventFactoryShould
    {
        public DataBaseEventFactoryShould()
        {
        }

        [Fact]
        public void CreateDataBaseEvent()
        {
            Guid InvitationTestGuid = Guid.NewGuid();
            DataBaseInvitation dataBaseInvitation = new DataBaseInvitation(InvitationTestGuid, "test@testmail.com");
            

            List<DataBaseInvitation> dataBaseInvitations = new List<DataBaseInvitation>
            {
                dataBaseInvitation
            };
            

            Guid participantTestGuid = Guid.NewGuid();
            DataBaseParticipant DataBaseParticipant = new DataBaseParticipant
            {
                Id = participantTestGuid,
                ContactInformation = new DataBaseContactInformation { Id = Guid.NewGuid(), Email = "test@testmail.com", FirstName = "TestFirstName", LastName = "TestLastname" }
            };
            List<DataBaseParticipant> dataBaseParticipants = new List<DataBaseParticipant>
            {
                DataBaseParticipant
            };

            DataBaseEventFactory _dataBaseEventFactory = new DataBaseEventFactory();

            Guid eventTestGuid = Guid.NewGuid();
            DataBaseEvent dataBaseEvent  =_dataBaseEventFactory.CreateDataBaseEvent(eventTestGuid, "A great name on a great party","A great description", DateTime.Now, dataBaseInvitations, dataBaseParticipants);

            Assert.Equal(eventTestGuid, dataBaseEvent.Id);
            Assert.Equal(participantTestGuid, dataBaseEvent.Participants.First().Id);
            Assert.Equal(InvitationTestGuid, dataBaseEvent.SentInvitations.First().Id);
        }
    }
}
