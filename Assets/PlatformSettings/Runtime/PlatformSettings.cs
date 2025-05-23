using UnityEngine;
using System.Runtime.InteropServices;

#if UNITY_EDITOR
public class PlatformSettings
{
  public static void openSettings() { }
}
#elif UNITY_IOS

public class PlatformSettings {
  [DllImport("__Internal", EntryPoint = "openPlatformSettings")]
  public static extern void openSettings();
}
#elif UNITY_ANDROID
public class PlatformSettings {
  public static void openSettings() {
    using (var javaClass = new AndroidJavaClass("net.suichu.tools.PlatformSettings"))
    {
        javaClass.CallStatic("openSettings");
    }
  }
}
#endif