package com.ntt_us.konan2050xr;

import android.content.Intent;
import android.net.Uri;
import com.unity3d.player.UnityPlayer;

public class PlatformSettings {
    public static void openSettings() {
        var context = UnityPlayer.currentActivity;
        Intent intent = new Intent(android.provider.Settings.ACTION_APPLICATION_DETAILS_SETTINGS);
        intent.setData(Uri.parse("package:" + context.getPackageName()));
        context.startActivity(intent);
    }
}
