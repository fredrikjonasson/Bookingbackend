using Factories;
using Domain;
using Domain.Interfaces;
using System;
using Xunit;
using System.Collections.Generic;
using Moq;

namespace FactoriesShould
{
    public class InvitationFactoryShould
    {
        IInvitationFactory _invitationFactory;

        private void SetupTest()
        {
            _invitationFactory = new InvitationFactory();
 
        }

        public InvitationFactoryShould()
        {
            SetupTest();
        }

        [Fact]
        public void CreateInvitationShould()
        {
            Guid testGuid = Guid.NewGuid();
            IInvitation invitation = _invitationFactory.CreateInvitation(testGuid, "fredrik.jonasson@outlook.com");
            Assert.Equal(testGuid, invitation.Id);
            Assert.Equal("fredrik.jonasson@outlook.com", invitation.Email);
        }
        [Fact]
        public void CreateInvitationEnumerableShouldSetOwnGuid()
        {
            List<string> sentInvitations = new List<string>
            {
                "fredrik.jonasson@outlook.com",
                "fredrikjonasson@outlook.com",
                "testmail@1.com",
                "testmail@2.se",
                "testmail@3.net"
            };
            List<IInvitation> convertedInvitations = _invitationFactory.CreateInvitationEnumerable(sentInvitations);
            Assert.NotEqual(Guid.Parse("00000000-0000-0000-0000-000000000000"), convertedInvitations[2].Id);
        }
    }
}
