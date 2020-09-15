using Factories;
using Domain;
using Domain.Interfaces;
using System;
using Xunit;
using System.Collections.Generic;

namespace FactoriesShould
{
    public class ContactInformationFactoryShould
    {
        IContactInformationFactory _contactInformationFactory;

        private void SetupTest()
        {
            _contactInformationFactory = new ContactInformationFactory();
        }

        public ContactInformationFactoryShould()
        {
            SetupTest();
        }

        [Fact]
        public void CreateContactInformation()
        {
            Guid testGuid = Guid.NewGuid();
            IContactInformation contactInformation = _contactInformationFactory.CreateContactInformation(testGuid,"Fredrik", "Jonasson", "fredrik.jonasson@outlook.com");
            Assert.Equal("Fredrik", contactInformation.FirstName);
            Assert.Equal("Jonasson", contactInformation.LastName);
            Assert.Equal("fredrik.jonasson@outlook.com", contactInformation.Email);
            Assert.Equal(testGuid, contactInformation.Id);
        }
    }
}
