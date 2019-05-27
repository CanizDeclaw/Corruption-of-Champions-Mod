using CoC_Lib.Creatures.Statistics;

namespace CoC_Lib.Creatures
{
    public abstract class Creature
    {
        // Game Info
        protected readonly Game game;

        // Body Info
        public Body Body { get; protected set; }

        // TODO: Many of these stats are the same code with different
        //       config.  Reduce them to a common parameterized constructor
        //       or leave as is for UI differentiation?
        // TODO: Non-`Statistic` info => `Statistic` derivative?
        public string Name { get; set; }

        public string RaceString { get; set; }
        public RaceStat Race { get; }
        public string GenderString { get; set; }
        public GenderStat Gender { get; set; }

        public PresentationStat Presentation { get; protected set; }

        // Core Stats
        public StrengthStat Strength { get; set; }
        public ToughnessStat Toughness { get; set; }
        public SpeedStat Speed { get; set; }
        public IntelligenceStat Intelligence { get; set; }
        public LibidoStat Libido { get; set; }
        public SensitivityStat Sensitivity { get; set; }
        public CorruptionStat Corruption { get; set; }

        // Combat Stats
        public HpStat HP { get; set; }
        public LustStat Lust { get; set; }
        public FatigueStat Fatigue { get; set; }

        // Level Stats
        public LevelStat Level { get; set; }
        public XpStat XP { get; set; }

        // Hidden/Unused/Special Stats
        public HungerStat Hunger { get; set; }
        public ObedienceStat Obedience { get; set; }
        public SelfEsteemStat SelfEsteem { get; set; }
        public WillpowerStat Willpower { get; set; }

        // Items & Gems
        public GemsStat Gems { get; }

        public Creature(Game game)
        {
            this.game = game;
            Body = new Bodies.HumanBody();

            // TODO: Clear test data out
            Name = "Goblin";
            RaceString = "Goblin";
            Race = new RaceStat(game, this);
            GenderString = "Female";
            Gender = new GenderStat(game, this);

            Presentation = new PresentationStat(game, this);

            Strength = new StrengthStat(game, this);
            Toughness = new ToughnessStat(game, this);
            Speed = new SpeedStat(game, this);
            Intelligence = new IntelligenceStat(game, this);
            Libido = new LibidoStat(game, this);
            Sensitivity = new SensitivityStat(game, this);

            Corruption = new CorruptionStat(game, this);
            Hunger = new HungerStat(game, this);
            Obedience = new ObedienceStat(game, this);
            SelfEsteem = new SelfEsteemStat(game, this);
            Willpower = new WillpowerStat(game, this);

            Lust = new LustStat(game, this);
            Fatigue = new FatigueStat(game, this);

            Level = new LevelStat(game, this);
            XP = new XpStat(game, this);

            Gems = new GemsStat(game, this);

            // TODO: This (along with other stats) needs to consider other character stats + perks
            // HP needs to go last because it subscribes to events from other stats to keep its Maximum
            // updated.
            // TODO: Maybe just propagate stat changes and force re-read?
            HP = new HpStat(game, this);
        }

        public Creature(Game game, Body body)
        {
            this.game = game;
            // Human body is default body.
            Body = new Bodies.HumanBody(body);
        }
    }
}