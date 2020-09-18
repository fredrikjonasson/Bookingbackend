using Repository;
using Repository.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RepositoryShould.Factories
{
    public class DataBaseInvitationFactoryShould
    {
        DataBaseInvitationFactory _dataBaseInvitationFactory;

        public DataBaseInvitationFactoryShould()
        {
            SetUpTest();
        }

        private void SetUpTest()
        {
            _dataBaseInvitationFactory = new DataBaseInvitationFactory();
        }

        [Fact]
        public void CreateDatabaseInvitation()
        {
            Guid testGuid = Guid.NewGuid();
            DataBaseInvitation databaseInvitation = _dataBaseInvitationFactory.CreateDataBaseInvitation(testGuid, "test@testmail.com");


            Assert.Equal("test@testmail.com", databaseInvitation.Email);
            Assert.Equal(testGuid, databaseInvitation.Id);
        }
    }
}
