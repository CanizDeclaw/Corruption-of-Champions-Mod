using System;
using static CoC_Lib.Creatures.Statistics.IntUpperBound;

namespace CoC_Lib.Creatures.Statistics
{
    public class HpStat : BoundedIntegerStat
    {
        // TODO: According to Creature.as/maxHP(), max hp is dependent on
        //       the following variables (among other things):
        //          * Toughness
        //          * Level
        //       It also has a lower limit for max of 50, and an upper limit
        //       for max of 9999.
        //
        //       Other stats should be checked for similar info.
        public override string Name => "HP";
        public override string Description => "How much health you have.  Higher is better.";

        /// <summary>
        /// Used to restore the HP value to max available.  Use `AdjustBaseValue`
        /// if you need to move it up or down by a certain amount.
        /// </summary>
        public void RestoreHP()
        {
            Value.Set(Maximum);
        }

        protected string ToughnessModifierKey = "HpStat ToughnessModifier";
        protected decimal ToughnessModifier()
        {
            return creature.Toughness * 2m;
        }
        protected string LevelModifierKey = "HpStat LevelModifier";
        protected decimal LevelModifier()
        {
            if (game.Settings.GrimDarkMode == true)
            {
                return creature.Level * 5m;
            }
            else
            {
                return creature.Level * 15m;
            }
        }

        public HpStat(Game game, Creature creature)
            : base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 50, minimum: 50, maximum: 9999);
            UpperBound.DynamicModifiers.Add(ToughnessModifierKey, (_) => ToughnessModifier());
            UpperBound.DynamicModifiers.Add(LevelModifierKey, (_) => LevelModifier());
            RestoreHP();
        }
    }
}