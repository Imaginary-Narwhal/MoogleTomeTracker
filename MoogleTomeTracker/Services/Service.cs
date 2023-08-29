using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace MoogleTomeTracker.Services;
public class Service
{
    public static void Initialize(DalamudPluginInterface _pluginInterface)
    {
        _pluginInterface.Create<Service>();
    }

    [PluginService][RequiredVersion("1.0")] public static ChatGui ChatGui { get; private set; } = null;
    [PluginService][RequiredVersion("1.0")] public static CommandManager CommandManager { get; private set; } = null;
    [PluginService][RequiredVersion("1.0")] public static DataManager DataManager { get; private set; } = null;
    [PluginService][RequiredVersion("1.0")] public static Framework Framework { get; private set; } = null;
    [PluginService][RequiredVersion("1.0")] public static DalamudPluginInterface Interface { get; private set; } = null;
    [PluginService][RequiredVersion("1.0")] public static ClientState ClientState { get; private set; } = null;
}
