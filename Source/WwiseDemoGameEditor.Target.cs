// Copyright Audiokinetic 2015

using UnrealBuildTool;
using System.Collections.Generic;

public class WwiseDemoGameEditorTarget : TargetRules
{
#if WITH_FORWARDED_TARGET_RULES_CTOR

    public WwiseDemoGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        ExtraModuleNames.AddRange( new string[] { "WwiseDemoGame" } );
	}
#else
    public WwiseDemoGameEditorTarget(TargetInfo Target)
    {
        Type = TargetType.Editor;
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
