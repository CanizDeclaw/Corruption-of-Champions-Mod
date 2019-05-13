using CoC_Lib.Commands;
using CoC_Lib.Perks.Endowments;

namespace CoC_Lib.Scenes.CharacterCreation
{
    internal class EndowmentCommand : Command
    {
        public override string ShortName => Endowment.Name;
        public override string LongName => Endowment.Name;
        public override string CanExecuteDescription => Endowment.LongDescription;
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.Player.Perks.Add(Endowment.Name, Endowment);
            Game.PushScene(new History(Game));
            Game.NextScene();
        }

        private readonly EndowmentPerk Endowment;

        public EndowmentCommand(Game game, EndowmentPerk endowment)
            : base(game)
        {
            Endowment = endowment;
        }
    }
}