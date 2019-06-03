using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Fertile : EndowmentPerk
    {
        public static string Key => "Endowment: Fertile";
        public override string GetKey => Key;
        public override string Name => "Fertile";
        public override string ShortName => Name;
        public override string ShortDescription =>
            "Makes you 15% more likely to become pregnant.";
        public override string LongDescription =>
            "Your family is particularly fertile (+15% Fertility).<br/><br/>" +
            "A high fertility will cause you to become pregnant much more easily.  " +
            "Pregnancy may result in: Strange children, larger bust, larger hips, " +
            "a bigger ass, and other weirdness.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }

        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {

        }

        public override bool Qualified(Player player) => player.HasVagina;
    }
}