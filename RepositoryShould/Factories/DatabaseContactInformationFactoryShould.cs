using Repository.Entities;
using Repository.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RepositoryShould.Factories
{
    public class DatabaseContactInformationFactoryShould
    {
        DatabaseContactInformationFactory _dataBaseContactInformationFactory;

        private void SetupTest()
        {
            _dataBaseContactInformationFactory = new DatabaseContactInformationFactory();
        }

        public DatabaseContactInformationFactoryShould()
        {
            SetupTest();
        }

        [Fact]
        public void CreateDataBaseContactInformation()
        {
            Guid testGuid = Guid.NewGuid();
            DataBaseContactInformation contactInformation = _dataBaseContactInformationFactory.CreateDataBaseContactInformation(testGuid, "Fredrik", "Jonasson", "fredrik.jonasson@outlook.com");
            Assert.Equal("Fredrik", contactInformation.FirstName);
            Assert.Equal("Jonasson", contactInformation.LastName);
            Assert.Equal("fredrik.jonasson@outlook.com", contactInformation.Email);
            Assert.Equal(testGuid, contactInformation.Id);
        }

    }
}
