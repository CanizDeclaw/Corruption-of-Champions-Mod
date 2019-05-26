using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Slut : HistoryPerk
    {
        public static string Key => "History: Slut";
        public override string GetKey => Key;
        public override string Name => "History: Slut";
        public override string ShortName => "Slut";
        public override string ShortDescription =>
            "Sexual experience has made you more able to handle large insertions " +
            "and more resistant to stretching.";
        public override string LongDescription =>
            "You managed to spend most of your time having sex.  Quite simply, " +
            "when it came to sex, you were the village bicycle - everyone got a " +
            "ride.  Because of this, your body is a bit more resistant to " +
            "penetrative stretching, and has a higher upper limit on what exactly " +
            "can be inserted.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
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

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {
            // TODO: Anal Capacity
            // TODO: Vaginal Capacity
        }

        public Slut()
        {
        }
    }
}