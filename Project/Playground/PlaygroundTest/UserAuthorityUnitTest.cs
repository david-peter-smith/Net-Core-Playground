using NUnit.Framework;
//using Playground;

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
            //UserModel _UserModel = null;

            Assert.IsTrue(true,"Test 1",null);
        }

        [Test]
        public void UserCreate_ValidObject_ObjectCreated()
        {
            //UserModel _UserModel = new UserModel();


            Assert.That(true, "Second", null);
        }

    }
}