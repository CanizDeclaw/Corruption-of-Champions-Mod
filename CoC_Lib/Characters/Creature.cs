namespace CoC_Lib.Characters
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

            Strength = new Statistics.StrengthStat();
            Toughness = new Statistics.ToughnessStat();
            Speed = new Statistics.SpeedStat();
            Intelligence = new Statistics.IntelligenceStat();
            Libido = new Statistics.LibidoStat();
            Sensitivity = new Statistics.SensitivityStat();

            Corruption = new Statistics.CorruptionStat();
            Hunger = new Statistics.HungerStat();
            Obedience = new Statistics.ObedienceStat();
            SelfEsteem = new Statistics.SelfEsteemStat();
            Willpower = new Statistics.WillpowerStat();

            Lust = new Statistics.LustStat();
            Fatigue = new Statistics.FatigueStat();

            Level = new Statistics.LevelStat();
            XP = new Statistics.XpStat();

            Gems = new Statistics.GemsStat();

            // TODO: This (along with other stats) needs to consider other character stats + perks
            HP = new Statistics.HpStat();
        }

        public Creature(Body body)
            :base(body)
        {

        }
    }
}