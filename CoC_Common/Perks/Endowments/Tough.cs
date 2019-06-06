using CoC_Common.Creatures;

namespace CoC_Common.Perks.Endowments
{
    internal class Tough : EndowmentPerk
    {
        public static string Key => "Endowment: Tough";
        public override string GetKey => Key;
        public override string Name => "Tough";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Gains toughness 25% faster.";
        public override string LongDescription =>
            "You are unusually tough (+5 Toughness).<br/><br/>" +
            "Toughness gives you more HP and increases the chances an attack " +
            "against you will fail to wound you.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            creature.Toughness.Value.OnAdjusting.Add(Key, (value) => (value > 0) ? (value * 0.25m) : 0);
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            creature.Toughness.Increase(5);
            creature.Body.Tone.Increase(5);
            creature.Body.Thickness.Increase(5);
            creature.HP.RestoreHP();
        }

        public override void OnRemovePerk(Creature creature)
        {
            creature.Toughness.Value.OnAdjusting.Remove(Key);
        }

        public override bool Qualified(Player player) => true;
    }
}