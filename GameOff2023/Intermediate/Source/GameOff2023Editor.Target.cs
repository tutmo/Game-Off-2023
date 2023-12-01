using UnrealBuildTool;

public class GameOff2023EditorTarget : TargetRules
{
	public GameOff2023EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("GameOff2023");
	}
}
