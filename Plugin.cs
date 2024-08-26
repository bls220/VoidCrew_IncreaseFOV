using BepInEx;

using HarmonyLib;

namespace IncreaseFOV;

[BepInPlugin(ThisAssembly.PluginGUID, ThisAssembly.PluginTitle, ThisAssembly.AssemblyFileVersion)]
[BepInProcess("Void Crew.exe")]
[BepInDependency("VoidManager")]
public class Plugin : BaseUnityPlugin
{
    private static readonly Harmony _harmony = new(ThisAssembly.PluginGUID);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members")]
    private void Awake()
    {
        Logger.LogDebug($"Plugin {ThisAssembly.PluginGUID} is loading!");
        _harmony.PatchAll();
        Logger.LogInfo($"Plugin {ThisAssembly.PluginGUID} is loaded!");
    }
}