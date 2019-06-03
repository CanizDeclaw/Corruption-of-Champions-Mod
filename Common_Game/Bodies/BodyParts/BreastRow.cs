using Common_Game.Creatures.Statistics;

namespace Common_Game.Bodies.BodyParts
{
    public abstract class BreastRow : AbstractBodyPart
    {
        // TODO: For this and others, anything not a stat should be eval'd for if it needs to be uint.

        public int Breasts;
        public int NipplesPerBreast;
        public BreastSize Size { get; protected set; }
        public BreastCup CupSize => Size.CupSize;
        public decimal LactationMultiplier;
        //Fullness used for lactation....if 75 or greater warning bells start going off!
        //If it reaches 100 it reduces lactation multiplier.
        public int MilkFullness;
        public int Fullness;
        public bool Fuckable;
        public bool NippleCocks;

        public BreastRow(Game game, Creature creature)
            :base(game, creature)
        {
            Size = new BreastSize(game, creature);
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Breasts = 2;
            NipplesPerBreast = 1;
            // TODO: Fix breast size assignment
            Size.Set(BreastCup.Flat);
            LactationMultiplier = 0;
            MilkFullness = 0;
            Fullness = 0;
            Fuckable = false;
            NippleCocks = false;
        }
    }
}