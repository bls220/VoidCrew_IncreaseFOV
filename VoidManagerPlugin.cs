using VoidManager.MPModChecks;

namespace IncreaseFOV;

public class VoidManagerPlugin : VoidManager.VoidPlugin
{
    public override MultiplayerType MPType => MultiplayerType.Client;

    public override string Author => ThisAssembly.PluginAuthors;

    public override string Description => ThisAssembly.PluginDescription;
}