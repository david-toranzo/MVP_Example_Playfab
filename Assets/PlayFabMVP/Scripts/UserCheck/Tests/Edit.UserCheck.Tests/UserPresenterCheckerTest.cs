using NSubstitute;
using NUnit.Framework;

namespace Toranzo.Playfab.Tests
{
    public class UserPresenterCheckerTest
    {
        [Test]
        public void Event_InvokeEvent_CallMethodSetNewErrorMessageCheckUser()
        {
            IUserViewChecker userViewChecker = Substitute.For<IUserViewChecker>();
            IUserDataChecker userDataChecker = new UserDataCheckerTestClass();
            var loginSuccessPresenter = new UserPresenterChecker(userDataChecker, userViewChecker);

            userDataChecker.OnCheckUserError.Invoke("");

            userViewChecker.Received(1).SetNewErrorMessageCheckUser(Arg.Any<string>());
        }
    }
}