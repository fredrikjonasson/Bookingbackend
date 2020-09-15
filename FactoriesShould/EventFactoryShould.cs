using Factories;
using Domain;
using Domain.Interfaces;
using System;
using Xunit;
using System.Collections.Generic;
using Moq;

namespace FactoriesShould
{
    public class EventFactoryShould
    {
        IEventFactory _eventFactory;

        private void SetupTest()
        {
            _eventFactory = new EventFactory();

        }

        public EventFactoryShould()
        {
            SetupTest();
        }

        private List<IInvitation> SetUpInvitations() 
        {
            List<string> sentInvitations = new List<string>
            {
                "fredrik.jonasson@outlook.com",
                "fredrikjonasson@outlook.com",
                "testmail@1.com",
                "testmail@2.se",
                "testmail@3.net"
            };
            IInvitationFactory _invitationFactory = new InvitationFactory();
            
            return _invitationFactory.CreateInvitationEnumerable(sentInvitations);
        }

        private IContactInformation SetUpContactInformationMock()
        {
            Mock<IContactInformation> contactInformationMock = new Mock<IContactInformation>();
            contactInformationMock.Setup(prop => prop.FirstName).Returns("Fredrik");
            contactInformationMock.Setup(prop => prop.LastName).Returns("Jonasson");
            return contactInformationMock.Object;
        }

        private List<IParticipant> SetUpParticipants()
        {
            Guid guid1 = Guid.NewGuid();
            Guid guid2 = Guid.NewGuid();
            List<IParticipant> participants = new List<IParticipant>
            {
                new Participant
                {
                    Id = guid1,
                    ContactInformation = SetUpContactInformationMock()
                },
                new Participant
                {
                    Id = guid2,
                    ContactInformation = SetUpContactInformationMock()
                },
                new Participant
                {
                    Id = guid1,
                    ContactInformation = SetUpContactInformationMock()
                },
                new Participant
                {
                    Id = guid2,
                    ContactInformation = SetUpContactInformationMock()
                }
            };
            return participants;
        }
        [Fact]
        public void CreateEventShould()
        {
        
            List<IInvitation> invitations = SetUpInvitations();
            List<IParticipant> participants = SetUpParticipants();

            Guid testGuid = Guid.NewGuid();
            IEvent @event = _eventFactory.CreateEvent(testGuid, "Fredriks födelsedagskalas", "Ett vanligt födelsedagskalas", DateTime.Now, invitations, participants);

            Assert.NotEqual(@event.Participants[0].Id, @event.Participants[1].Id);
            Assert.Equal(@event.Participants[0].Id, @event.Participants[2].Id);
            Assert.Equal(testGuid, @event.Id);
            Assert.Equal("Fredriks födelsedagskalas", @event.Name);
            Assert.Equal("fredrik.jonasson@outlook.com", @event.SentInvitations[0].Email);
        }
    }
}
