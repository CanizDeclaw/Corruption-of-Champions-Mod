using System.Collections.Generic;

namespace CoC_Lib.Creatures
{
    public class Player : Character
    {
        public Player()
            :base(new Bodies.HumanBody())
        {
            Perks = new Perks.PerkCollection(this);
            Name = "Player";
            RaceString = "Human";
            GenderString = "Herm";
        }

        public Perks.PerkCollection Perks { get; }
        public int StatPoints { get; internal set; }
        public bool CanLevelUp { get; internal set; }
        public bool CanPerkUp { get; internal set; }
        public bool CanRankUp { get; internal set; }
        public bool CanStatUp { get; internal set; }
    }
}