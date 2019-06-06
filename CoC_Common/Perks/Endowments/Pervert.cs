using CoC_Common.Creatures;

namespace CoC_Common.Perks.Endowments
{
    internal class Pervert : EndowmentPerk
    {
        public static string Key => "Endowment: Pervert";
        public override string GetKey => Key;
        public override string Name => "Pervert";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains corruption 25% faster. Reduces corruption requirement for " +
            "high-corruption variant of scenes.";
        public override string LongDescription =>
            "You are unusually perverted (+5 Corruption).<br/><br/>" +
            "Corruption affects certain scenes and having a higher corruption " +
            "makes you more prone to Bad Ends.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            // Not in original.  Assuming it was excluded by error.
            // TODO: Check if intentional.
            creature.Corruption.Value.OnAdjusting.Add(Key, (value) => (value > 0) ? (value * 0.25m) : 0);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            creature.Corruption.Increase(5);
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Corruption.Value.OnAdjusting.Remove(Key);
        }

        public override bool Qualified(Player player) => true;
    }
}