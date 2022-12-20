using NSubstitute;
using NUnit.Framework;
using Patterns.Factory;

namespace Toranzo.Playfab.Tests
{
    public class LoginFactoryTypeDeviceTest
    {
        [Test]
        public void GetObjectType_GetSameValues_Compare()
        {
            IBaseLogin[] baseLogins = new IBaseLogin[1];

            baseLogins[0] = Substitute.For<IBaseLogin>();
            Factory<string, IBaseLogin> factoryLogin = new LoginFactoryTypeDevice(baseLogins);

            var baseLoginFac = factoryLogin.GetObjectType(baseLogins[0].GetTypeLoginString());

            Assert.AreEqual(baseLogins[0], baseLoginFac, "The object are not the same, there was a problem with the factory");
        }
    }
}