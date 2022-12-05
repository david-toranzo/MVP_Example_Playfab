using Patterns.Factory;

namespace Toranzo.Playfab
{
    public interface IBaseLogin 
    {
        void StartMakeLogin();

        string GetTypeLoginString();
    }
}