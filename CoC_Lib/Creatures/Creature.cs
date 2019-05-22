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
        public Statistics.RaceStat Race { get; }
        public string GenderString { get; set; }
        public Statistics.GenderStat Gender { get; set; }

        // Core Stats
        public Statistics.StrengthStat Strength { get; set; }
        public Statistics.ToughnessStat Toughness { get; set; }
        public Statistics.SpeedStat Speed { get; set; }
        public Statistics.IntelligenceStat Intelligence { get; set; }
        public Statistics.LibidoStat Libido { get; set; }
        public Statistics.SensitivityStat Sensitivity { get; set; }
        public Statistics.CorruptionStat Corruption { get; set; }

        // Combat Stats
        public Statistics.HpStat HP { get; set; }
        public Statistics.LustStat Lust { get; set; }
        public Statistics.FatigueStat Fatigue { get; set; }

        // Level Stats
        public Statistics.LevelStat Level { get; set; }
        public Statistics.XpStat XP { get; set; }

        // Hidden/Unused/Special Stats
        public Statistics.HungerStat Hunger { get; set; }
        public Statistics.ObedienceStat Obedience { get; set; }
        public Statistics.SelfEsteemStat SelfEsteem { get; set; }
        public Statistics.WillpowerStat Willpower { get; set; }

        // Items & Gems
        public Statistics.GemsStat Gems { get; }

        public Creature(Game game)
        {
            this.game = game;
            Body = new Bodies.HumanBody();

            // TODO: Clear test data out
            Name = "Goblin";
            RaceString = "Goblin";
            Race = new Statistics.RaceStat(game, this);
            GenderString = "Female";
            Gender = new Statistics.GenderStat(game, this);

            Strength = new Statistics.StrengthStat(game, this);
            Toughness = new Statistics.ToughnessStat(game, this);
            Speed = new Statistics.SpeedStat(game, this);
            Intelligence = new Statistics.IntelligenceStat(game, this);
            Libido = new Statistics.LibidoStat(game, this);
            Sensitivity = new Statistics.SensitivityStat(game, this);

            Corruption = new Statistics.CorruptionStat(game, this);
            Hunger = new Statistics.HungerStat(game, this);
            Obedience = new Statistics.ObedienceStat(game, this);
            SelfEsteem = new Statistics.SelfEsteemStat(game, this);
            Willpower = new Statistics.WillpowerStat(game, this);

            Lust = new Statistics.LustStat(game, this);
            Fatigue = new Statistics.FatigueStat(game, this);

            Level = new Statistics.LevelStat(game, this);
            XP = new Statistics.XpStat(game, this);

            Gems = new Statistics.GemsStat(game, this);

            // TODO: This (along with other stats) needs to consider other character stats + perks
            // HP needs to go last because it subscribes to events from other stats to keep its Maximum
            // updated.
            // TODO: Maybe just propagate stat changes and force re-read?
            HP = new Statistics.HpStat(game, this);
        }

        public Creature(Game game, Body body)
        {
            this.game = game;
            // Human body is default body.
            Body = new Bodies.HumanBody(body);
        }
    }
}