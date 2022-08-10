# Unity Mobile Version Code

Natively gets the [version code](https://developer.android.com/reference/android/content/pm/PackageInfo#versionCode) on Android or the [bundle version](https://developer.apple.com/documentation/bundleresources/information_property_list/cfbundleversion) on iOS. In Unity it equates to the values set to Bundle Version Code (Android) or Build (iOS) in Player Settings.

This package assumes that for both platforms this is an integer value. The iOS bundle version can technically be a string, but common practice is to use an incrementing integer synced for both platforms.

## Example

```
using MobileVersionCode;
using UnityEngine;

public class TestVersionCode : MonoBehaviour
{
    void Start()
    {
        Debug.Log($"Version Code: {VersionCode.GetVersionCode()}");
    }
}

```

## Install

TODO
