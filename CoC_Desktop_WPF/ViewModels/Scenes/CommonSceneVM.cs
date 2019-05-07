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

        // Scene Description
        public FlowDocument SceneText => GetSceneText();
        protected FlowDocument GetSceneText()
        {
            var run = new Run(commonScene.SceneText);
            var document = new FlowDocument(new Paragraph(run));
            return document;
        }

        public CommonSceneVM(CommonScene cs, CoC game)
            :base(cs, game)
        {
            commonScene = cs;
            MainMenu = new CommandVM(cs.MainMenu);
            Data = new CommandVM(cs.Data);
            Stats = new CommandVM(cs.Stats);
            RankUp = new CommandVM(cs.RankUp);
            Perks = new CommandVM(cs.Perks);
            Appearance = new CommandVM(cs.Appearance);
        }
    }
}
