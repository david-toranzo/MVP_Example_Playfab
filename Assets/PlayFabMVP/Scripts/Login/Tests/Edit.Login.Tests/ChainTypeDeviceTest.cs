using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class ChainTypeDeviceTest
    {
        [Test]
        public void IsThisDeviceCorrectType_IOSVerificatorIfFalse()
        {
            ChainIOSDevice chainIOSDevice = new ChainIOSDevice(null);

            Assert.IsFalse(chainIOSDevice.IsThisDeviceCorrectType());
        }

        [Test]
        public void IsThisDeviceCorrectType_AndroidVerificatorIfFalse()
        {
            ChainAndroidDevice chainAndroidDevice = new ChainAndroidDevice(null);

            Assert.IsFalse(chainAndroidDevice.IsThisDeviceCorrectType());
        }

        [Test]
        public void IsThisDeviceCorrectType_DefaultVerificatorIfTrue()
        {
            ChainDefaultDevice chainDefaultDevice = new ChainDefaultDevice(null);

            Assert.IsTrue(chainDefaultDevice.IsThisDeviceCorrectType());
        }
    }
}