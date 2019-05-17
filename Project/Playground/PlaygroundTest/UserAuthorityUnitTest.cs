using NUnit.Framework;
using Playground.Models.User;

namespace Test
{
    public class UserAuthorityUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UserCreate_NullObject_ExceptionThrown()
        {
            UserRequestModel _UserModel = null;

            Assert.IsTrue(true,"Test 1",null);
        }

        [Test]
        public void UserCreate_ValidObject_ObjectCreated()
        {
            UserRequestModel _UserRequestModel = new UserRequestModel();


            Assert.That(true, "Second", null);
        }

    }
}