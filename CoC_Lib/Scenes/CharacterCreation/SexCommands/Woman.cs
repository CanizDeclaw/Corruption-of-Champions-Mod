using CoC_Lib.Creatures.BodyParts.Vaginas;
using CoC_Lib.Commands;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class Woman : Command
    {
        public override string ShortName => "Woman";
        public override string LongName => "Woman";
        public override string CanExecuteDescription => "You are a woman. Your upbringing has provided you an advantage in speed and intellect.";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            // TODO: Stat changes.
            Game.Player.Vaginas[0] = new HumanVagina();
            Game.Player.Speed.Value += 3;
            Game.Player.Intelligence.Value += 2;
            Game.PushScene(new Build(Game));
            Game.NextScene();
        }

        public Woman(Game game)
            : base(game)
        {

        }
    }
}