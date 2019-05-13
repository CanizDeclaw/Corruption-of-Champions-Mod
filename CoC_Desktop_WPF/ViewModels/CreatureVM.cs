using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoC_Lib.Creatures;
using CoC_Lib.Creatures.Statistics;

namespace CoC_Desktop_WPF.ViewModels
{
    public class CreatureVM
    {
        protected readonly Creature creature;
        public CoC Game { get; }

        public string Name => creature.Name;
        public Body Body => creature.Body;
        public GenderStat Gender => creature.Gender;
        public RaceStat Race => creature.Race;

        // Core Stats
        public StrengthStat Strength => creature.Strength;
        public ToughnessStat Toughness => creature.Toughness;
        public SpeedStat Speed => creature.Speed;
        public IntelligenceStat Intelligence => creature.Intelligence;
        public LibidoStat Libido => creature.Libido;
        public SensitivityStat Sensitivity => creature.Sensitivity;
        public CorruptionStat Corruption => creature.Corruption;

        // Combat Stats
        public HpStat HP => creature.HP;
        public LustStat Lust => creature.Lust;
        public FatigueStat Fatigue => creature.Fatigue;

        // Level Stats
        public LevelStat Level => creature.Level;
        public XpStat XP => creature.XP;

        // Items & Gems
        public GemsStat Gems => creature.Gems;

        public CreatureVM(Creature creature, CoC game)
        {
            Game = game;
            this.creature = creature;
        }
    }
}
