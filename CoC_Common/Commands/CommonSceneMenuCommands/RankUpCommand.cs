using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Commands.CommonSceneMenuCommands
{
    public class RankUpCommand : Command
    {
        public override string ShortName { get; }
        public override string LongName { get; }
        public override string CanExecuteDescription { get; }
        public override string CanNotExecuteDescription => "You don't have the XP to level up and you don't have any stat or perk points to spend.";

        public override bool CanExecute => Game.Player.CanRankUp;
        public override void Execute() => throw new NotImplementedException();

        public RankUpCommand(Game game)
            : base(game)
        {
            if (game.Player.CanLevelUp)
            {
                ShortName = "Level Up";
                LongName = "Level Up";
                CanExecuteDescription = "";
            }
            else if (game.Player.CanStatUp)
            {
                ShortName = "Stat Up";
                LongName = "Stat Up";
                CanExecuteDescription = "";
            }
            else if(game.Player.CanPerkUp)
            {
                ShortName = "Perk Up";
                LongName = "Perk Up";
                CanExecuteDescription = "";
            }
            else
            {
                ShortName = "Level Up";
                LongName = "Level Up";
                CanExecuteDescription = "";
            }
        }
    }
}
