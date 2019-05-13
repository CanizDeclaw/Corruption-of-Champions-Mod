using System;
using System.Collections.Generic;
using System.Text;
using BodyMods;
using CoC_Lib.Creatures.BodyParts;

namespace CoC_Lib.Creatures.Bodies
{
    /// <summary>
    /// A Human body.  Also represents the default body of the game.
    /// </summary>
    public class HumanBody : Body
    {
        #region Non-Sexual Characteristics
        #region Head & Neck
        public override Antennae Antennae { get; }
        public override Beard Beard { get; }
        public override Ears Ears { get; }
        public override Eyes Eyes { get; }
        public override Face Face { get; }
        public override Gills Gills { get; }
        public override Hair Hair { get; }
        public override Horns Horns { get; }
        public override Neck Neck { get; }
        public override Tongue Tongue { get; }
        #endregion Head & Neck

        #region Upper Body
        public override Shoulders Shoulders { get; }
        public override Arms Arms { get; }
        public override Claws Claws { get; }
        public override Wings Wings { get; }
        public override SpinalFeature SpinalFeature { get; }
        public override Waist Waist { get; }
        #endregion Upper Body

        #region Lower Body
        public override LowerBody LowerBody { get; }
        public override Hips Hips { get; }
        public override Butt Butt { get; }
        public override List<Tail> Tails { get; }
        # endregion Lower Body

        #region General Body
        public override Skin Skin { get; }
        public override DorsalArea DorsalArea { get; }
        public override VentralArea VentralArea { get; }
        #endregion General Body
        #endregion Non-Sexual Characteristics

        #region Sexual Characteristics
        public override List<BreastRow> Breasts { get; }
        public override List<Cock> Cocks { get; }
        public override List<Testicle> Balls { get; }
        public override List<Vagina> Vaginas { get; }
        public override Anus Ass { get; }
        public override Udder Udder { get; }
        #endregion Sexual Characteristics

        #region Body Modifications
        // TODO: Decide if Jewelry and/or Piercings should be moved to Creature
        public override Jewelry Jewelry { get; }
        public override Piercings Piercings { get; }
        #endregion Body Modifications
    }
}
