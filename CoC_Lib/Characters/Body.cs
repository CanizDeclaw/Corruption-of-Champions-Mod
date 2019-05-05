using System;
using System.Collections.Generic;
using System.Text;
using CoC_Lib.Characters.BodyParts;

namespace CoC_Lib.Characters
{
    public abstract class Body
    {
        #region Non-Sexual Characteristics
        #region Head & Neck
        public abstract Antennae Antennae { get; }
        public abstract Beard Beard { get; }
        public abstract Ears Ears { get; }
        public abstract Eyes Eyes { get; }
        public abstract Face Face { get; }
        public abstract Gills Gills { get; }
        public abstract Hair Hair { get; }
        public abstract Horns Horns { get; }
        public abstract Neck Neck { get; }
        public abstract Tongue Tongue { get; }
        #endregion Head & Neck

        #region Upper Body
        public abstract Shoulders Shoulders { get; }
        public abstract Arms Arms { get; }
        public abstract Claws Claws { get; }
        public abstract Wings Wings { get; }
        public abstract SpinalFeature SpinalFeature { get; }
        public abstract Waist Waist { get; }
        #endregion Upper Body

        #region Lower Body
        public abstract LowerBody LowerBody { get; }
        public abstract Hips Hips { get; }
        public abstract Butt Butt { get; }
        public abstract List<Tail> Tails { get; }
        # endregion Lower Body

        #region General Body
        public abstract Skin Skin { get; }
        public abstract DorsalArea DorsalArea { get; }
        public abstract VentralArea VentralArea { get; }
        #endregion General Body
        #endregion Non-Sexual Characteristics

        #region Sexual Characteristics
        public abstract List<BreastRow> Breasts { get; }
        public abstract List<Cock> Cocks { get; }
        public abstract List<Testicle> Balls { get; }
        public abstract List<Vagina> Vaginas { get; }
        public abstract Anus Ass { get; }
        public abstract Udder Udder { get; }
        #endregion Sexual Characteristics

        #region Body Modifications
        // TODO: Decide if Jewelry and/or Piercings should be moved to Creature
        public abstract BodyMods.Jewelry Jewelry { get; }
        public abstract BodyMods.Piercings Piercings { get; }
        #endregion Body Modifications

        public int SpeciesScore(Species.Type type)
        {
            int score = 0;
            // TODO: Fill in scoring by checking type against each body part.
            return score;
        }
    }
}
