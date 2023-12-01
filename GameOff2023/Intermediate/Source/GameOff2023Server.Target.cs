using UnrealBuildTool;

public class GameOff2023ServerTarget : TargetRules
{
	public GameOff2023ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("GameOff2023");
	}
}
