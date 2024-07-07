// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from https://github.com/remyCases/Stoneshard-MoreSaveSlots.

using ModShardLauncher;
using ModShardLauncher.Mods;

namespace MoreSaveSlot;
public class MoreSaveSlot : Mod
{
    public override string Author => "zizani";
    public override string Name => "MoreSaveSlot";
    public override string Description => "More save slot available";
    public override string Version => "1.0.0";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        int saveslot = 20;

        Msl.LoadAssemblyAsString("gml_GlobalScript_scr_slotGetFreeDirName")
            .MatchFrom("pushi.e 10")
            .ReplaceBy($"pushi.e {saveslot}")
            .Save();
            
        Msl.LoadAssemblyAsString("gml_GlobalScript_scr_slotsGetOrderList")
            .MatchFrom("pushi.e 10")
            .ReplaceBy($"pushi.e {saveslot}")
            .Save();

        Msl.LoadAssemblyAsString("gml_Object_o_mainMenuNavContainer_Other_11")
            .MatchFrom("pushloc.v local._slotsOrderListSize\npushi.e 10")
            .ReplaceBy($"pushloc.v local._slotsOrderListSize\npushi.e {saveslot}")
            .Save();
    }
}
