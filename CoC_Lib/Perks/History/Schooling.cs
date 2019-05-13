using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Schooling : HistoryPerk
    {
        public static string Key => "History Schooling";
        public override string GetKey => Key;
        public override string Name => "Schooling";
        public override string Description =>
            "You spent much of your time in school, and even begged the richest" +
            " man in town, Mr. " + (Game.Settings.SillyMode ? "Savin" : "Sellet") +
            ", to let you read some of his books.  You are much better at " +
            "focusing, and spellcasting uses 20% less fatigue.";

        public override void OnAddPerk(Creature creature)
        {
            // TODO: SpellCost
        }
        public override void OnRemovePerk(Creature creature)
        {
            // TODO: SpellCost
        }

        protected Game Game;

        public Schooling(Game game)
        {
            Game = game;
        }
    }
}