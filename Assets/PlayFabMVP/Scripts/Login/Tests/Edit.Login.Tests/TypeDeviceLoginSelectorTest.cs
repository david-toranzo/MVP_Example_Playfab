using NSubstitute;
using NUnit.Framework;
using Patterns.Factory;

namespace Toranzo.Playfab.Tests
{
    public class TypeDeviceLoginSelectorTest
    {
        [Test]
        public void GetTypeLogin_CallAllChains_SubstituteSameValue()
        {
            IChainTypeDevice chainAndroid = GetDefaultChainSubstitute();
            IChainTypeDevice chainIos = GetDefaultChainSubstitute();
            IChainTypeDevice[] chainTypes = GetArrayChainsTypeDevice(chainAndroid, chainIos);

            Factory<string, IBaseLogin> factoryLogin = GetFactoryTypeDevice();
            ActCallGetTypeLogin(chainTypes, factoryLogin);

            AssertReceivedOneCallIsThisDeviceCorrectType(chainAndroid);
            AssertReceivedOneCallIsThisDeviceCorrectType(chainIos);
        }

        private IChainTypeDevice GetDefaultChainSubstitute() => Substitute.For<IChainTypeDevice>();

        private IChainTypeDevice[] GetArrayChainsTypeDevice(IChainTypeDevice chainAndroid, IChainTypeDevice chainIos)
        {
            IChainTypeDevice[] chainTypes = new IChainTypeDevice[2];

            chainTypes[0] = chainAndroid;
            chainTypes[1] = chainIos;

            return chainTypes;
        }

        private void ActCallGetTypeLogin(IChainTypeDevice[] chainTypes, Factory<string, IBaseLogin> factoryLogin)
        {
            TypeDeviceLoginSelector typeDeviceLoginSelector = new TypeDeviceLoginSelector(chainTypes, factoryLogin);
            typeDeviceLoginSelector.GetTypeLogin();
        }

        private Factory<string, IBaseLogin> GetFactoryTypeDevice()
        {
            IBaseLogin[] baseLogins = new IBaseLogin[0];
            Factory<string, IBaseLogin> factoryLogin = new LoginFactoryTypeDevice(baseLogins);
            return factoryLogin;
        }

        private void AssertReceivedOneCallIsThisDeviceCorrectType(IChainTypeDevice chainAndroid)
        {
            chainAndroid.Received(1).IsThisDeviceCorrectType();
        }

        [Test]
        public void GetTypeLogin_CallFactoryGetType_SubstituteSameValue()
        {
            IChainTypeDevice chainAndroid = GetDefaultChainSubstitute();
            IChainTypeDevice chainIos = GetDefaultChainSubstitute();
            IChainTypeDevice[] chainTypes = GetArrayChainsTypeDevice(chainAndroid, chainIos);

            Factory<string, IBaseLogin> factoryLogin = Substitute.For<Factory<string, IBaseLogin>>();
            ActCallGetTypeLogin(chainTypes, factoryLogin);

            factoryLogin.Received(1).GetObjectType(Arg.Any<string>());
        }
    }
}