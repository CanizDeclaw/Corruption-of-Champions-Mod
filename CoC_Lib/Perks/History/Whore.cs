using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Whore : HistoryPerk
    {
        public static string Key => "History: Whore";
        public override string GetKey => Key;
        public override string Name => "History: Whore";
        public override string ShortName => "Whore";
        public override string ShortDescription =>
            "Seductive experience causes your tease attacks to be 15% more effective.";
        public override string LongDescription =>
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

        public Whore()
        {
        }
    }
}