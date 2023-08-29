using Dalamud.Interface.Windowing;
using ImGuiNET;
using ImGuiScene;
using System;
using System.Numerics;
using Dalamud.Interface.Raii;

namespace MoogleTomeTracker.Windows;
public class MoogleTomeTrackerWindow : Window, IDisposable
{
    private Plugin Plugin;

    public MoogleTomeTrackerWindow(Plugin plugin) : base(
            "Moogle Tomestone Tracker", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse)
    {
        this.SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(500, 700),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };

        this.Plugin = plugin;
    }

    public void Dispose()
    {
    }

    public override void Draw()
    {
        ImGui.Text("This is a thing.");
    }
}
