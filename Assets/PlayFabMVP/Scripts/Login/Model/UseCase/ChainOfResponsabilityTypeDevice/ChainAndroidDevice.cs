namespace Toranzo.Playfab
{
    public class ChainAndroidDevice : ChainTypeDevice
    {
        public ChainAndroidDevice(ITypeLoginGetter sOTypeEvent) : base(sOTypeEvent)
        {
        }

        public override bool IsThisDeviceCorrectType()
        {
            bool res = false;

#if UNITY_ANDROID
            res = true;
#endif
            return res;
        }
    }
}