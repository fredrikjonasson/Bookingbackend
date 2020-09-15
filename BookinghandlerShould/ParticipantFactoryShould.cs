using Factories;
using Domain;
using Domain.Interfaces;
using System;
using Xunit;
using System.Collections.Generic;
using Moq;

namespace FactoriesShould
{
    public class ParticipantFactoryShould
    {
        IParticipantFactory _participantFactory;


        private void SetupTest()
        {
            _participantFactory = new ParticipantFactory();
        }

        public ParticipantFactoryShould()
        {
            SetupTest();
        }

        [Fact]
        public void CreateParticipantShould()
        {
            Mock<IContactInformation> contactInformationMock = new Mock<IContactInformation>();
            
            Guid testGuid = Guid.NewGuid();

            contactInformationMock.Setup(prop => prop.FirstName).Returns("Fredrik");
            contactInformationMock.Setup(prop => prop.LastName).Returns("Jonasson");
            IParticipant participant = _participantFactory.CreateParticipant(testGuid, contactInformationMock.Object);

            Assert.Equal(contactInformationMock.Object, participant.ContactInformation);
            Assert.Equal("Fredrik", contactInformationMock.Object.FirstName);
            Assert.Equal(testGuid, participant.Id);
        }
    }
}
