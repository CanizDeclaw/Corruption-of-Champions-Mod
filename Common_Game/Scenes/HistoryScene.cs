using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    public class HistoryScene : Scene
    {
        public override bool IncludeInHistory => false;
        protected List<HistoryItem> History { get; }
        protected int CurrentItem { get; set; }

        public override TimeSpan ElapsedTime
        {
            get => new TimeSpan(0);
            protected set => _;
        }

        // Need to make a history manager to deal with all of this?
        // Make sure scenes can link forward without having to have all scene instantiated.
        public HistoryScene(Game game, List<HistoryItem> history, int startIndex)
            :base(game)
        {
            History = history;
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex >= history.Count)
            {
                startIndex = history.Count - 1;
            }
            CurrentItem = startIndex;

            // Command[0] = HistoryNavPrevious
            // Command[1] = HistoryNavNext
            // Command[last] = HistoryExit
        }

        public override void Run()
        {
            throw new NotImplementedException();
        }

        protected override void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
