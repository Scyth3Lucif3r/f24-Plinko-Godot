using Godot;
using System;

public partial class DestroyArea : Area2D
{
	private void OnBodyEntered(Node2D body)
	{
		body.QueueFree();
		//GD.Print($"Destroy Object: {body.Name}");
	}
}
