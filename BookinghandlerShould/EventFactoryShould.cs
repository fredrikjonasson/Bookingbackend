using Factories;
using Domain;
using Domain.Interfaces;
using System;
using Xunit;
using System.Collections.Generic;

namespace FactoriesShould
{
    public class FactoriesShould
    {
        
        public IEvent setupTest()
        {
            IContactInformationFactory contactinformationFactory = new ContactInformationFactory();
            IParticipantFactory participantFactory = new ParticipantFactory();
            IInvitationFactory invitationFactory = new InvitationFactory();
            IEventFactory eventFactory = new EventFactory();

            IContactInformation contactInformation = contactinformationFactory.CreateContactInformation(Guid.NewGuid(),"Fredrik", "Jonasson", "fredrik.jonasson@outlook.com");
            IParticipant participant = participantFactory.CreateParticipant(Guid.NewGuid(), contactInformation);
            IInvitation invitation= invitationFactory.CreateInvitation(Guid.NewGuid(), "fredrik.jonasson@outlook.com");
            List < IInvitation > invitations = new List<IInvitation>();
            invitations.Add(invitation);
            List<IParticipant> participants = new List<IParticipant>();
            participants.Add(participant);
            IEvent @event = eventFactory.CreateEvent(Guid.NewGuid(), "Fredriks födelsedagsfest", "Ett kul partaj", DateTime.Now, invitations, participants);
            return @event;
        }

        public FactoriesShould()
        {

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
