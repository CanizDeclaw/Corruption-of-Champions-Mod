using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.History
{
    internal class Scholar : HistoryPerk
    {
        public static string Key => "History: Scholar";
        public override string GetKey => Key;
        public override string Name => "History: Scholar";
        public override string ShortName => "Scholar";
        public override string ShortDescription =>
            "Time spent focusing your mind makes spellcasting 20% less fatiguing.";
        public override string LongDescription =>
            "You spent much of your time in school, and even begged the richest" +
            " man in town, Mr. " + (Game.Settings.SillyMode ? "Savin" : "Sellet") +
            ", to let you read some of his books.  You are much better at " +
            "focusing, and spellcasting uses 20% less fatigue.";

        public override void OnAddPerk(Creature creature, bool firstTime = true)
        {
            if (firstTime)
            {
                OnFirstTimeAdd(creature);
            }
            // TODO: SpellCost
        }

        public override void OnFirstTimeAdd(Creature creature)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRemovePerk(Creature creature)
        {
            // TODO: SpellCost
        }

        protected Game Game;

        public Scholar(Game game)
        {
            Game = game;
        }
    }
}