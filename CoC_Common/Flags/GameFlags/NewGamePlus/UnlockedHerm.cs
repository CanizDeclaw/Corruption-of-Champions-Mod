using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Flags.GameFlags.NewGamePlus
{
    public class UnlockedHerm : GameFlag
    {
        public static string Key => @"NewGamePlus UnlockedHerm";
        public override string UnlockText => "Congratulations! You have unlocked hermaphrodite option on character creation, accessible from New Game Plus!";
        public override string Description => "Unlocked hermaphrodite gender option in character creation.";

        public override string ConditionDescription => "Obtained by having shown up to your camp as a herm at some point.";
    }
}
