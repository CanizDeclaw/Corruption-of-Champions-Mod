using System.Collections.Generic;

namespace CoC_Lib.Characters
{
    public class Player : Character
    {
        public Player()
            :base(new Bodies.HumanBody())
        {
            Name = "Player";
            RaceString = "Human";
            GenderString = "Herm";
        }

        public Dictionary<string, Perks.Perk> Perks { get; } = new Dictionary<string, Perks.Perk>();

        public int StatPoints { get; internal set; }
        public bool CanLevelUp { get; internal set; }
        public bool CanPerkUp { get; internal set; }
        public bool CanRankUp { get; internal set; }
        public bool CanStatUp { get; internal set; }
    }
}