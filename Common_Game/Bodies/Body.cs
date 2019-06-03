using System;
using System.Collections.Generic;
using System.Text;
using Common_Game.Bodies.BodyParts;

namespace Common_Game.Bodies
{
    public enum Sex
    {
        Male,
        Female,
        Hermaphrodite,
        Sexless
    }

    public abstract class Body
    {
        // Game Info
        protected readonly Game game;
        // Bodies don't exist on their own outside a creature
        protected readonly Creature creature;

        #region Non-Sexual Characteristics
        #region Head & Neck
        public Antennae Antennae { get; }
        public Beard Beard { get; }
        public Ears Ears { get; }
        public Eyes Eyes { get; }
        public Face Face { get; }
        public Gills Gills { get; }
        public Hair Hair { get; }
        public Horns Horns { get; }
        public Neck Neck { get; }
        public Tongue Tongue { get; }

        public bool HasBeard => Beard != null /* && typeof(Beard) != typeof(new NoBeard) */;
        #endregion Head & Neck

        #region Upper Body
        public Shoulders Shoulders { get; }
        public Arms Arms { get; }
        public Claws Claws { get; }
        public Wings Wings { get; }
        public SpinalFeature SpinalFeature { get; }
        public Waist Waist { get; }
        #endregion Upper Body

        #region Lower Body
        public LowerBody LowerBody { get; }
        public Hips Hips { get; }
        public Butt Butt { get; }
        public List<Tail> Tails { get; }
        # endregion Lower Body

        #region General Body
        public Skin Skin { get; }
        public DorsalArea DorsalArea { get; }
        public VentralArea VentralArea { get; }

        public Statistics.HeightStat Height { get; protected set; }
        public Statistics.ToneStat Tone { get; protected set; } // TODO: Should be BoundedIntegerStatistic?
        public Statistics.ThicknessStat Thickness { get; protected set; }
        // TODO: Sort out which level each stat should be at.
        #endregion General Body
        #endregion Non-Sexual Characteristics

        #region Sexual Characteristics
        public List<BreastRow> Breasts { get; }
        public CockCollection Cocks { get; }
        public List<Testicle> Balls { get; }
        public List<Vagina> Vaginas { get; }
        public Anus Ass { get; }
        public Udder Udder { get; }

        public bool HasBreasts => Breasts.Count > 0;
        public bool HasCock => Cocks.Count > 0;
        public bool HasVagina => Vaginas.Count > 0;
        public Sex Sex
        {
            get
            {
                if (HasCock && HasVagina)
                {
                    return Sex.Hermaphrodite;
                }
                else if (HasCock)
                {
                    return Sex.Male;
                }
                else if (HasVagina)
                {
                    return Sex.Female;
                }
                else
                {
                    return Sex.Sexless;
                }
            }
        }
        #endregion Sexual Characteristics

        #region Body Modifications
        // TODO: Decide if Jewelry and/or Piercings should be moved to Creature
        public BodyMods.Jewelry Jewelry { get; }
        public BodyMods.Piercings Piercings { get; }
        #endregion Body Modifications

        public int SpeciesScore(Species.Type type)
        {
            int score = 0;
            // TODO: Fill in scoring by checking type against each body part.
            return score;
        }

        public Body(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
        }
        public Body(Game game, Creature creature, Body copyFrom)
        {
            this.game = game;
            this.creature = creature;
            // TODO: Copy from copyFrom to this.
        }
    }
}
