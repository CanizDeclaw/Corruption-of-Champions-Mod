using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters
{
    public class Body
    {
        #region Non-Sexual Characteristics
        #region Head & Neck
        public BodyParts.Antennae Antennae;
        public BodyParts.Beard Beard;
        public BodyParts.Ears Ears;
        public BodyParts.Eyes Eyes;
        public BodyParts.Face Face;
        public BodyParts.Gills Gills;
        public BodyParts.Hair Hair;
        public BodyParts.Horns Horns;
        public BodyParts.Neck Neck;
        public BodyParts.Tongue Tongue;
        #endregion Head & Neck

        #region Upper Body
        public BodyParts.Wings Wings;
        #endregion Upper Body

        #region Lower Body
        public BodyParts.LowerBody LowerBody;
        public BodyParts.Arms Arms;
        public BodyParts.Claws Claws;
        public BodyParts.Hips Hips;
        public BodyParts.Butt Butt;
        public List<BodyParts.Tail> Tails;
        #endregion Lower Body

        #region General Body
        public BodyParts.Skin Skin;
        public BodyParts.DorsalArea DorsalArea;
        public BodyParts.VentralArea VentralArea;
        #endregion General Body
        #endregion Non-Sexual Characteristics

        #region Sexual Characteristics
        public List<BodyParts.BreastRow> Breasts;
        public List<BodyParts.Cock> Cocks;
        public List<BodyParts.Testicle> Balls;
        public List<BodyParts.Vagina> Vaginas;
        public BodyParts.Anus Ass;
        public BodyParts.Udder Udder;
        #endregion Sexual Characteristics

        #region Body Modifications
        // TODO: Decide if Jewelry and/or Piercings should be moved to Creature
        public BodyMods.Jewelry Jewelry;
        public BodyMods.Piercings Piercings;
        #endregion Body Modifications
    }
}
