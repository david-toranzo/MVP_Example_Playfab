using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class ChainTypeDeviceTest
    {
        [Test]
        public void IsThisDeviceCorrectType_IOSVerificatorIfFalse()
        {
            ChainIOSDevice chainIOSDevice = new ChainIOSDevice(null);

            Assert.IsFalse(chainIOSDevice.IsThisDeviceCorrectType(), "Chain IOS should be false in the editor.");
        }

        [Test]
        public void IsThisDeviceCorrectType_AndroidVerificatorIfFalse()
        {
            ChainAndroidDevice chainAndroidDevice = new ChainAndroidDevice(null);

            Assert.IsFalse(chainAndroidDevice.IsThisDeviceCorrectType(), "Chain Android should be false in the editor.");
        }

        [Test]
        public void IsThisDeviceCorrectType_DefaultVerificatorIfTrue()
        {
            ChainDefaultDevice chainDefaultDevice = new ChainDefaultDevice(null);

            Assert.IsTrue(chainDefaultDevice.IsThisDeviceCorrectType(), "Default Chain should be true in the editor.");
        }
    }
}