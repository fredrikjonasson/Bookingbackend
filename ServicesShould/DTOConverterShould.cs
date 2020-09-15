using Domain;
using Factories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServicesShould
{
    public class DTOConverterShould
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

        [Fact]
        public void Test1()
        {

        }
    }
}
