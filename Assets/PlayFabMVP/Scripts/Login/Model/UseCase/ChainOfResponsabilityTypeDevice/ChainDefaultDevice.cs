namespace Toranzo.Playfab
{
    public class ChainDefaultDevice : ChainTypeDevice
    {
        public ChainDefaultDevice(ITypeLoginGetter TypeEvent) : base(TypeEvent)
        {
        }

        public override bool IsThisDeviceCorrectType()
        {
            return true;
        }
    }
}