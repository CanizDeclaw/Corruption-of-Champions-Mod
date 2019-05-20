using System.Collections.Generic;

namespace CoC_Lib.Creatures
{
    // TODO: Dynamic player sprite.
    //       Might take position of previous enemy sprite (which would then go on the right), given wider GUI.
    // TODO: Default skin color based on the Fitzpatrick scale?
    // TODO: Ovipositor tails, not just abdomens.
    public class Player : Character
    {
        public Player(Game game)
            :base(game, new Bodies.HumanBody())
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