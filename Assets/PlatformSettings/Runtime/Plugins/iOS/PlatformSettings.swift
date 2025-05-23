@_cdecl("openPlatformSettings")
public func openPlatformSettings() {
  UIApplication.shared.open(URL(string: UIApplication.openSettingsURLString)!)
}