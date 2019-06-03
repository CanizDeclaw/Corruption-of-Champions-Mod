using CoC_Lib.Commands;
using CoC_Lib.Perks.History;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    class HistoryCommand : Command
    {
        public override string ShortName => Career.Name;
        public override string LongName => Career.Name;
        public override string CanExecuteDescription => Career.LongDescription;
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;
        public override void Execute()
        {
            Game.Player.Perks.Add(Career.Name, Career);
            Game.PushScene(new GameModeSettings(Game));
            Game.NextScene();
        }

        private readonly HistoryPerk Career;

        public HistoryCommand(Game game, HistoryPerk history)
            : base(game)
        {
            Career = history;
        }
    }
}
