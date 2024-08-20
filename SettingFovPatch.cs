using HarmonyLib;

namespace IncreaseFOV;

[HarmonyPatch(typeof(SettingFov))]
static class SettingFovPatch
{
    [HarmonyPostfix, HarmonyPatch(MethodType.Constructor, typeof(string))]
    private static void Constructor_Postfix(ref ISetting[] ____setting)
    {
        ____setting =
        [
            new IntSetting(90, 70, 120)
        ];
    }
}