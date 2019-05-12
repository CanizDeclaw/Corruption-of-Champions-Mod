using CoC_Lib.Commands;

namespace CoC_Lib.Scenes.CharacterCreation
{
    internal class CockSizeCommand : Command
    {
        // TODO: Units (Imperial/Metric)
        // TODO: Will this convert right?  Floating point fun.
        public override string ShortName => Size + "\"";
        public override string LongName => Size + "\"";
        public override string CanExecuteDescription => "Set your cock to this length.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            if (Game.Player.HasCock)
            {
                Game.Player.Cocks[0].Length = Size;
            }
            Game.NextScene();
        }

        protected double Size;

        public CockSizeCommand(Game game, double size)
            : base(game)
        {
            Size = size;
        }
    }
}