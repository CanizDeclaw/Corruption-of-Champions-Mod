using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Slutting : HistoryPerk
    {
        public static string Key => "History Slutting";
        public override string GetKey => Key;
        public override string Name => "Slutting";
        public override string Description =>
            "You managed to spend most of your time having sex.  Quite simply, " +
            "when it came to sex, you were the village bicycle - everyone got a " +
            "ride.  Because of this, your body is a bit more resistant to " +
            "penetrative stretching, and has a higher upper limit on what exactly " +
            "can be inserted.";

        public override void OnAddPerk(Creature creature)
        {
            if (creature.HasVagina)
            {
                creature.Vaginas[0].IsVirgin = false;
                creature.Vaginas[0].Looseness = Creatures.BodyParts.Vagina.VaginalLooseness.Loose;
            }
            creature.Ass.Looseness = Creatures.BodyParts.Anus.AnalLooseness.Tight;
            // TODO: Anal Capacity
            // TODO: Vaginal Capacity
        }
        public override void OnRemovePerk(Creature creature)
        {
            // TODO: Anal Capacity
            // TODO: Vaginal Capacity
        }

        public Slutting()
        {
        }
    }
}