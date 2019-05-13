using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Whoring : HistoryPerk
    {
        public static string Key => "History Whoring";
        public override string GetKey => Key;
        public override string Name => "Whoring";
        public override string Description =>
            "You managed to find work as a whore.  Because of your time spent " +
            "trading seduction for profit, you're more effective at teasing " +
            "(+15% tease damage).";

        public override void OnAddPerk(Creature creature)
        {
            if (creature.HasVagina)
            {
                creature.Vaginas[0].IsVirgin = false;
                creature.Vaginas[0].Looseness = Creatures.BodyParts.Vagina.VaginalLooseness.Loose;
            }
            creature.Ass.Looseness = Creatures.BodyParts.Anus.AnalLooseness.Tight;
            creature.Gems.AdjustBaseValue(50);
            // TODO: Tease
        }
        public override void OnRemovePerk(Creature creature)
        {
            // TODO: Tease
        }

        public Whoring()
        {
        }
    }
}