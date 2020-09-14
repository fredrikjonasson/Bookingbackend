using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain
{
    public interface IInvitationFactory
    {
        public IInvitation CreateInvitation(string email);
    }
}