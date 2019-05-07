using CoC_Lib.Characters;
using CoC_Lib.Characters.Statistics;

namespace CoC_Desktop_WPF.ViewModels
{
    public class PlayerVM
    {
        protected readonly Player player;
        public CoC Game { get; }

        public string Name => player.Name;
        public Body Body => player.Body;

        // Core Stats
        public StrengthStat Strength => player.Strength;
        public ToughnessStat Toughness => player.Toughness;
        public SpeedStat Speed => player.Speed;
        public IntelligenceStat Intelligence => player.Intelligence;
        public LibidoStat Libido => player.Libido;
        public SensitivityStat Sensitivity => player.Sensitivity;
        public CorruptionStat Corruption => player.Corruption;

        // Combat Stats
        public HpStat HP => player.HP;
        public LustStat Lust => player.Lust;
        public FatigueStat Fatigue => player.Fatigue;

        // Level Stats
        public LevelStat Level => player.Level;
        public XpStat XP => player.XP;

        // Items & Gems
        public int Gems => player.Gems;

        public PlayerVM(Player player, CoC game)
        {
            Game = game;
            this.player = player;
        }
    }
}