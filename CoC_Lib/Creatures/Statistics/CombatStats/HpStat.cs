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
        public override string Description => "";

        protected override int BaseMaximum
        {
            get
            {
                var value = creature.Toughness.Value * 2 + 50;
                if (game.Settings.GrimDarkMode)
                {
                    value += creature.Level.Value * 5;
                }
                else
                {
                    value += creature.Level.Value * 15;
                }
                return value;
            }
        }
        /// <summary>
        /// Used to restore the HP value to max available.  Use `AdjustBaseValue`
        /// if you need to move it up or down by a certain amount.
        /// </summary>
        public void RestoreHP()
        {
            AdjustBaseValue(UpperLimitOfMax);
        }

        public HpStat(Game game, Creature creature)
            : base(game, creature)
        {
            SetBaseValue(100);
            SetBaseMaximum(100);
        }
    }
}