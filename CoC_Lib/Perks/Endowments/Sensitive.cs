using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Sensitive : EndowmentPerk
    {
        public static string Key => "Endowment: Sensitive";
        public override string GetKey => Key;
        public override string Name => "Sensitive";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains sensitivity 25% faster.";
        public override string LongDescription =>
            "Your skin is unusually sensitive (+5 Sensitivity).<br/><br/>" +
            "Sensitivity affects how easily touches and certain magics will " +
            "raise your lust.  Very low sensitivity will make it difficult to orgasm.";

        public override void OnAddPerk(Creature creature)
        {
            creature.Sensitivity.AdjustBaseValue(5);
            creature.Sensitivity.OnBaseValueAdjusting.Add(this, (value) => (value > 0) ? (value * 0.25m) : 0);
        }
        public override void OnRemovePerk(Creature creature)
        {
            creature.Sensitivity.OnBaseValueAdjusting.Remove(this);
        }

        public override bool Qualified(Player player) => true;
    }
}