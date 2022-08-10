#if UNITY_ANDROID && !UNITY_EDITOR
using MobileVersionCode.Native.Android;
#endif

#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace MobileVersionCode
{
    public static class VersionCode
    {
#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern int getBundleVersion();
#endif
        
        public static int GetVersionCode()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            return AndroidVersionCode.GetVersionCode();
#elif UNITY_IOS && !UNITY_EDITOR
            return getBundleVersion();
#else
            return -1;
#endif
        }
    }
}