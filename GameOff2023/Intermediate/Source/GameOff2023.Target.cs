using UnrealBuildTool;

public class GameOff2023Target : TargetRules
{
	public GameOff2023Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameOff2023");
	}
}
