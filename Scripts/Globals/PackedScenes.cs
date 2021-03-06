using Godot;
using System;

public class PackedScenes : Node2D
{
	public static PackedScenes packedScenesClass;

	[Export]
	public PackedScene TitleScreen;

	[Export]
	public PackedScene Woodville;

	[Export]
	public PackedScene WoodvilleHouse1;

	[Export]
	public PackedScene WoodvilleHouse2;

	[Export]
	public PackedScene WoodvilleQuarry;

	[Export]
	public PackedScene deathClouds;

	public override void _Ready()
	{
		packedScenesClass = this;
	}
}
