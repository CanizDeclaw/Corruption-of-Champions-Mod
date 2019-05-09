namespace CoC_Lib.Characters
{
    public class Creature
    {
        public string Name { get; set; }
        public Body Body { get; set; }

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
        {
            Name = "";

            Strength = new Statistics.StrengthStat();
            Toughness = new Statistics.ToughnessStat();
            Speed = new Statistics.SpeedStat();
            Intelligence = new Statistics.IntelligenceStat();
            Libido = new Statistics.LibidoStat();
            Sensitivity = new Statistics.SensitivityStat();
            Corruption = new Statistics.CorruptionStat();

            HP = new Statistics.HpStat();
            Lust = new Statistics.LustStat();
            Fatigue = new Statistics.FatigueStat();

            Level = new Statistics.LevelStat();
            XP = new Statistics.XpStat();

            Gems = new Statistics.GemsStat();
        }
    }
}