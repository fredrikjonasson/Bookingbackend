using Domain;
using Domain.Interfaces;
using Factories;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ServicesShould
{
    public class DataBaseEventConverterShould
    {
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

        private IContactInformation SetUpContactInformation()
        {

            IContactInformation contactInformation = new ContactInformation
            {
                Id = Guid.NewGuid(),
                FirstName = "Fredrik",
                LastName = "Jonasson",
                Email = "fredrik.jonasson@outlook.com"

            };
            return contactInformation;
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
                    ContactInformation = SetUpContactInformation()
                },
                new Participant
                {
                    Id = guid2,
                    ContactInformation = SetUpContactInformation()
                },
                new Participant
                {
                    Id = guid1,
                    ContactInformation = SetUpContactInformation()
                },
                new Participant
                {
                    Id = guid2,
                    ContactInformation = SetUpContactInformation()
                }
            };
            return participants;
        }
        private EventDTO SetUpEventDTO()
        {
            EventDTO eventDTO = new EventDTO
            {
                Name = "Födelsedagsfest",
                Description = "En rolig fest för att fira en födelsedag",
                StartDate = DateTime.Now,
                SentInvitations = new List<string>
                {
                "fredrik.jonasson@outlook.com",
                "fredrikjonasson@outlook.com",
                "testmail@1.com",
                "testmail@2.se",
                "testmail@3.net"
                }
            };
            return eventDTO;
        }

        private IEvent SetUpEvent()
        {
            IEventFactory _eventFactory = new EventFactory();
            List<IInvitation> invitations = SetUpInvitations();
            List<IParticipant> participants = SetUpParticipants();

            Guid testGuid = Guid.NewGuid();
            IEvent @event = _eventFactory.CreateEvent(testGuid, "Födelsedagsfest", "En rolig fest för att fira en födelsedag", DateTime.Now, invitations, participants);
            return @event;
        }

        public DataBaseEventConverterShould()
        {

        }

        [Fact]
        public void EntityInvitationsToDataBaseInvitations()
        {

        }

        [Fact]
        public void EntityEventToDataBaseEvent()
        {
            IEvent @event = SetUpEvent();
            DataBaseConverter dataBaseEventConverter = new DataBaseConverter();
            DataBaseEvent databaseEvent = dataBaseEventConverter.EntityEventToDataBaseEvent(@event);
            Assert.Equal(@event.Id, databaseEvent.Id);
            Assert.Equal(@event.Name, databaseEvent.Name);
            Assert.Equal(@event.Description, databaseEvent.Description);
            Assert.Equal(@event.StartDate, databaseEvent.StartDate);
        }

    }
}
