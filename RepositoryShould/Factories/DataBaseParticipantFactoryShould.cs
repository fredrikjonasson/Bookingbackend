using Moq;
using Repository.Entities;
using Repository.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RepositoryShould.Factories
{
    public class DataBaseParticipantFactoryShould
    {
        DataBaseParticipantFactory _dataBaseParticipantFactory;
        DatabaseContactInformationFactory _dataBaseContactInformationFactory;

        private void SetupTest()
        {
            _dataBaseParticipantFactory = new DataBaseParticipantFactory();
            _dataBaseContactInformationFactory = new DatabaseContactInformationFactory();
            
        }

        public DataBaseContactInformation SetUpDataBaseContactInformation() 
        {
            DataBaseContactInformation dataBaseContactInformation = _dataBaseContactInformationFactory.CreateDataBaseContactInformation(Guid.NewGuid(), "Fredrik", "Jonasson", "fredrik@test.com");
            return dataBaseContactInformation;
        }

        public DataBaseParticipantFactoryShould()
        {
            SetupTest();
        }

        [Fact]
        public void CreateParticipantShould()
        {
            DataBaseContactInformation DataBaseContactInformation = SetUpDataBaseContactInformation();
            Guid testGuid = Guid.NewGuid();


            DataBaseParticipant participant = _dataBaseParticipantFactory.CreateDataBaseParticipant(testGuid, DataBaseContactInformation);

            Assert.Equal(testGuid, participant.Id);
            Assert.Equal("Fredrik", participant.ContactInformation.FirstName);
        }
    }
}
