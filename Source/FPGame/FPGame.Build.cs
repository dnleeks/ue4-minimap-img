// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPGame : ModuleRules
{
	public FPGame(TargetInfo Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
