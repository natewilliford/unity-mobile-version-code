using UnityEngine;

namespace MobileVersionCode.Native.Android
{
    internal static class AndroidVersionCode
    {
#if UNITY_ANDROID && !UNITY_EDITOR    
        public static int GetVersionCode() {
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject packageManager = activity.Call<AndroidJavaObject>("getPackageManager");
            var pInfo = packageManager.Call<AndroidJavaObject>("getPackageInfo", Application.identifier, 0);
            return pInfo.Get<int>("versionCode");
        }
#endif
    }
}