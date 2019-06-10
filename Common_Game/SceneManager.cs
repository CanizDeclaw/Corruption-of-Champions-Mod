using Common_Game.Scenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game
{
    public class SceneManager : NotifyPropertyChangedBase
    {
        protected readonly Game game;

        protected Scene _currentScene;
        public Scene CurrentScene
        {
            get
            {
                if (_currentScene == null)
                {
                    NextScene();
                }
                return _currentScene;
            }
            protected set
            {
                _currentScene = value;
                OnPropertyChanged();
            }
        }

        public List<HistoryItem> History { get; } = new List<HistoryItem>();

        protected internal HomeScene HomeScene { get; set; }
        protected Stack<Scene> SceneStack { get; } = new Stack<Scene>();

        public SceneManager(Game game)
        {
            this.game = game;
        }

        // TODO: These need to work with interstitials or something?
        public event Action OnChangeScene;
        public event Action OnGotoHomeScene;

        public void BrowseHistory(int startIndex = int.MaxValue)
        {
            var currentScene = _currentScene;
            var exitAction = new Action(() => CurrentScene = currentScene);
            CurrentScene = new HistoryBrowser(game, History, startIndex, exitAction);
        }
        public void PushScene(Scene scene)
        {
            SceneStack.Push(scene);
        }
        public void NextScene()
        {
            // Use _currentScene instead of CurrentScene to avoid cyclical behaviour.
            if (_currentScene != null && !(_currentScene is HistoryBrowser))
            {
                game.GameTime.Add(_currentScene.ElapsedTime);
                if (_currentScene.IncludeInHistory)
                {
                    History.AddRange(_currentScene.GetHistoryItems());
                }
            }
            OnChangeScene?.Invoke();
            if (SceneStack.Count == 0 || SceneStack.Peek() is HomeScene)
            {
                OnGotoHomeScene?.Invoke();
            }
            // Scenes may be added from the event invocation, so we need to test again.
            if (SceneStack.Count == 0)
            {
                SceneStack.Push(HomeScene ?? game.Settings.DefaultHomeScene);
            }
            var next = SceneStack.Pop();
            next.Run();
            CurrentScene = next;
        }

        internal void Reset()
        {
            _currentScene = null;
            History.Clear();
            HomeScene = null;
            SceneStack.Clear();
            OnChangeScene = null;
            OnGotoHomeScene = null;
        }
    }
}
