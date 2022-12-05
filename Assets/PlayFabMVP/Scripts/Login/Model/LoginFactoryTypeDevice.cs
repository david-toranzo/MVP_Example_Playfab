using Patterns.Factory;

namespace Toranzo.Playfab
{
    public class LoginFactoryTypeDevice : Factory<string, IBaseLogin>
    {
        public LoginFactoryTypeDevice(IBaseLogin[] baseLogins)
        {
            for (int i = 0; i < baseLogins.Length; i++)
            {
                AddObjectToFactory(baseLogins[i].GetTypeLoginString(), baseLogins[i]);
            }
        }
    }
}