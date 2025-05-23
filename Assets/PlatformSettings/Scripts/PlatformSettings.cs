using UnityEngine;

#if UNITY_EDITOR
public class PlatformSettings
{
  public static void openSettings() { }
}
#elif UNITY_IOS
using System.Runtime.InteropServices;

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
