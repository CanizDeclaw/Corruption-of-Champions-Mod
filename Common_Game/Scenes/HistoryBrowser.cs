using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Scenes
{
    public class HistoryNavPrevious : Commands.Command
    {
        protected HistoryBrowser HB;
        public override string ShortName => "Previous";
        public override string LongName => "Previous Scene";
        public override string CanExecuteDescription => "View the previous scene in the history";
        public override string CanNotExecuteDescription => "You've reached the beginning of the history";

        public override bool CanExecute => HB.CurrentIndex >= 0;

        public override void Execute()
        {
            HB.PreviousScene();
        }

        public HistoryNavPrevious(Game game, HistoryBrowser hb)
            : base(game)
        {
            HB = hb;
        }
    }

    public class HistoryNavNext : Commands.Command
    {
        protected HistoryBrowser HB;
        public override string ShortName => "Next";
        public override string LongName => "Next Scene";
        public override string CanExecuteDescription => "View the next scene in the history";
        public override string CanNotExecuteDescription => "You've reached the end of the history";

        public override bool CanExecute => HB.CurrentIndex < HB.History.Count - 1;

        public override void Execute()
        {
            HB.NextScene();
        }

        public HistoryNavNext(Game game, HistoryBrowser hb)
            : base(game)
        {
            HB = hb;
        }
    }

    public class HistoryExit : Commands.Command
    {
        public override string ShortName => "Leave";
        public override string LongName => "Leave history browser";
        public override string CanExecuteDescription => "Leave the history browser and return to the game";
        public override string CanNotExecuteDescription => "";

        public override bool CanExecute => true;

        protected Action _execute;
        public override void Execute()
        {
            _execute();
        }

        public HistoryExit(Game game, Action exitAction)
            : base(game)
        {
            _execute = exitAction;
        }
    }

    public class HistoryBrowser : Scene
    {
        public override bool IncludeInHistory => false;
        public List<HistoryItem> History { get; }
        public HistoryItem CurrentItem => History[CurrentIndex];
        public int CurrentIndex { get; protected set; }

        public override TimeSpan ElapsedTime
        {
            get => new TimeSpan(0);
            protected set => _;
        }

        // Need to make a history manager to deal with all of this?
        // Make sure scenes can link forward without having to have all scenes instantiated.
        public HistoryBrowser(Game game, List<HistoryItem> history, int startIndex, Action exitAction)
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
            CurrentIndex = startIndex;

            Commands[0] = new HistoryNavPrevious(game, this);
            Commands[1] = new HistoryNavNext(game, this);
            Commands[14] = new HistoryExit(game, exitAction);
        }

        public override List<HistoryItem> GetHistoryItems() => null;

        public void PreviousScene()
        {
            if (CurrentIndex <= 0)
            {
                return;
            }
            CurrentIndex--;
            UpdateScene();
        }

        public void NextScene()
        {
            if (CurrentIndex >= History.Count - 1)
            {
                return;
            }
            CurrentIndex++;
            UpdateScene();
        }

        public override void Run()
        {
            UpdateScene();
        }

        protected void UpdateScene()
        {
            SceneDescription = CurrentItem.SceneDescription;
        }

        protected override void SetDescription()
        {}
    }
}
