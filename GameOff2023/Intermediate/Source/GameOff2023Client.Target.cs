using UnrealBuildTool;

public class GameOff2023ClientTarget : TargetRules
{
	public GameOff2023ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("GameOff2023");
	}
}
