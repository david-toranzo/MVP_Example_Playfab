namespace Toranzo.Playfab
{
    public interface IChainTypeDevice
    {
        string GetTypeLoginString();
        bool IsThisDeviceCorrectType();
    }
}