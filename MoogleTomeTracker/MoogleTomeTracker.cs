using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;
using MoogleTomeTracker.Attributes;
using MoogleTomeTracker.CommandHandler;
using MoogleTomeTracker.Services;
using MoogleTomeTracker.Windows;
using System.IO;
using System.Reflection;

#nullable disable

namespace MoogleTomeTracker;
public sealed class Plugin : IDalamudPlugin
{
    public string Name => "Moogle Tomestone Tracker";

    internal Configuration Config { get; init; }
    public WindowSystem WindowSystem = new("MoogleTomeTracker");

    private PluginCommandManager<Plugin> CommandManager { get; init; }

    private MoogleTomeTrackerWindow MainWindow { get; init; }

    public Plugin(DalamudPluginInterface _pluginInterface)
    {
        Service.Initialize(_pluginInterface);
        CommandManager = new(this, Service.CommandManager);

        Config = Service.Interface.GetPluginConfig() as Configuration ?? new Configuration();
        Config.Initialize(Service.Interface);

        MainWindow = new MoogleTomeTrackerWindow(this);
        WindowSystem.AddWindow(MainWindow);

        Service.Interface.UiBuilder.Draw += DrawUI;
    }

    public void Dispose()
    {
        CommandManager.Dispose();
        WindowSystem.RemoveAllWindows();
        Service.Interface.UiBuilder.Draw -= DrawUI;
    }

    private void DrawUI()
    {
        WindowSystem.Draw();
    }

    [Command("/pmtt")]
    [HelpMessage("Open Moogle Tomestone Tracker Window")]
    public void MTTCommand()
    {
        MainWindow.IsOpen = true;
    }
}
