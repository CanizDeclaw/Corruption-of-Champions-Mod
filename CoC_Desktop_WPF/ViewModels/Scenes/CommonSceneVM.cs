using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CoC_Lib.Scenes;

namespace CoC_Desktop_WPF.ViewModels.Scenes
{
    public class CommonSceneVM : SceneVM
    {
        private readonly CommonScene commonScene;

        // Always-present commands for a CommonScene
        // Not always visible or selectable, though.
        public CommandVM MainMenu { get; }
        public CommandVM Data { get; }
        public CommandVM Stats { get; }
        public CommandVM RankUp { get; }
        public CommandVM Perks { get; }
        public CommandVM Appearance { get; }
        public CommandVM Achievements { get; }

        // Scene Description
        public FlowDocument SceneText => GetSceneText();
        protected FlowDocument GetSceneText()
        {
            return (FlowDocument)commonScene.SceneDescription.Description;
        }

        public CommonSceneVM(CommonScene cs, CoC game)
            :base(cs, game)
        {
            commonScene = cs;
            MainMenu = new CommandVM(cs, cs.MainMenu);
            Data = new CommandVM(cs, cs.Data);
            Stats = new CommandVM(cs, cs.Stats);
            RankUp = new CommandVM(cs, cs.RankUp);
            Perks = new CommandVM(cs, cs.Perks);
            Appearance = new CommandVM(cs, cs.Appearance);
            Achievements = new CommandVM(cs, cs.Achievements);
        }
    }
}
