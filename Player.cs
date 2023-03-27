using Godot;
using System;

public partial class Player : Area2D
{
    [Export]
    public int Speed = 400;

    public Vector2 ScreenSize;

    public override void _Ready()
    {
        ScreenSize = GetViewportRect().Size;
    }
}
