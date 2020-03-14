using UnrealBuildTool;

public class Group5_PBTarget : TargetRules
{
	public Group5_PBTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Group5_PB");
	}
}
