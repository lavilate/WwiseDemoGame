// Copyright Audiokinetic 2015

using UnrealBuildTool;

public class WwiseDemoGame : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public WwiseDemoGame(ReadOnlyTargetRules Target) : base(Target)
#else
    public WwiseDemoGame(TargetInfo Target)
#endif
    {
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
