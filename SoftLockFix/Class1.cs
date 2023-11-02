using PluginAPI.Core.Attributes;
using ServerOutput;

namespace SoftLockFix;

internal class EntryPoint
{
    [PluginEntryPoint("SoftLockFix", "1.0.0.0", "Restarts the server each round.", "Jesus-QC")]
    private void Init()
    {
        ServerLogs.AddLog(ServerLogs.Modules.Administrative, "[SoftLockFix] Restarting server next round.", ServerLogs.ServerLogType.RemoteAdminActivity_GameChanging);
        ServerStatic.StopNextRound = ServerStatic.NextRoundAction.Restart;
        ServerConsole.AddOutputEntry(default(ExitActionRestartEntry));
    }
}