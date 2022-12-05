namespace Toranzo.Playfab
{
    public class ChainIOSDevice : ChainTypeDevice
    {
        public ChainIOSDevice(ITypeLoginGetter typeEvent) : base(typeEvent)
        {
        }

        public override bool IsThisDeviceCorrectType()
        {
            bool res = false;

#if UNITY_IOS
            res = true;
#endif
            return res;
        }
    }
}