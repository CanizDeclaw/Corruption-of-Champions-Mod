namespace CoC_Lib.Creatures
{
    public abstract class Creature : Body
    {
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

        public Creature()
            :base(new Bodies.HumanBody())
        {
            // TODO: Clear test data out
            Name = "Goblin";
            RaceString = "Goblin";
            Race = new Statistics.RaceStat(this);
            GenderString = "Female";
            Gender = new Statistics.GenderStat(this);

            Strength = new Statistics.StrengthStat(this);
            Toughness = new Statistics.ToughnessStat(this);
            Speed = new Statistics.SpeedStat(this);
            Intelligence = new Statistics.IntelligenceStat(this);
            Libido = new Statistics.LibidoStat(this);
            Sensitivity = new Statistics.SensitivityStat(this);

            Corruption = new Statistics.CorruptionStat(this);
            Hunger = new Statistics.HungerStat(this);
            Obedience = new Statistics.ObedienceStat(this);
            SelfEsteem = new Statistics.SelfEsteemStat(this);
            Willpower = new Statistics.WillpowerStat(this);

            Lust = new Statistics.LustStat(this);
            Fatigue = new Statistics.FatigueStat(this);

            Level = new Statistics.LevelStat(this);
            XP = new Statistics.XpStat(this);

            Gems = new Statistics.GemsStat(this);

            // TODO: This (along with other stats) needs to consider other character stats + perks
            HP = new Statistics.HpStat(this);
        }

        public Creature(Body body)
            :base(body)
        {

        }
    }
}