// Copyright Audiokinetic 2015

using UnrealBuildTool;
using System.Collections.Generic;

public class WwiseDemoGameTarget : TargetRules
{
#if WITH_FORWARDED_TARGET_RULES_CTOR
    public WwiseDemoGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        ExtraModuleNames.AddRange( new string[] { "WwiseDemoGame" } );
    }
#else
    public WwiseDemoGameTarget(TargetInfo Target)
    {
        Type = TargetType.Game;
    }

    //
    // TargetRules interface.
    //

    public override void SetupBinaries(
        TargetInfo Target,
        ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
        ref List<string> OutExtraModuleNames
        )
    {
        OutExtraModuleNames.AddRange(new string[] { "WwiseDemoGame" });
    }
#endif
}
