using CoC_Lib.Characters.BodyParts.Cocks;
using CoC_Lib.Commands;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class Man : Command
    {
        public override string ShortName => "Man";
        public override string LongName => "Man";
        public override string CanExecuteDescription => "You are a man. Your upbringing has provided you an advantage in strength and toughness.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            // TODO: Stat changes.
            Game.Player.Cocks[0] = new HumanCock();
            Game.Player.Strength.Value += 3;
            Game.Player.Toughness.Value += 2;
            Game.PushScene(new Build(Game));
            Game.NextScene();
        }

        public Man(Game game)
            : base(game)
        {

        }
    }
}