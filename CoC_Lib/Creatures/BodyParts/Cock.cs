using System;
using System.Collections.Generic;
using System.Linq;

namespace CoC_Lib.Creatures.BodyParts
{
    // TODO: Modifiers that affect all cocks (and vaginas, and breasts, and...)
    //       Property of parent collection, fed in by constructors?
    public class CockLengthStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Cock Length";
        public override string Description => "Cock Length";

        protected string CockCollectionOnAdjustingKey = "CockLengthStat CockCollection OnAdjusting";
        protected decimal CockCollectionOnAdjusting(decimal adjustment)
        {
            var adjusters = creature.Body.Cocks.OnAdjustingLength;
            var total = adjusters.Values.Sum(adj => adj(adjustment));
            return total;
        }

        public CockLengthStat(Game game, Creature creature, decimal length = 5.5m)
            :base(game, creature)
        {
            LowerBound = new Statistics.DecimalLowerBound(maximum: 0);
            UpperBound = new Statistics.DecimalUpperBound(this, value: 9999.9m, minimum: 9999.9m, maximum: 9999.9m);
            // TODO: Check this works as expected when changing ParentCollection and ParentCollection.OnAdjustingLength
            Value.OnAdjusting.Add(CockCollectionOnAdjustingKey, new Statistics.AdjustmentModifier(CockCollectionOnAdjusting));
            Value.Set(length);
        }
    }

    public class CockThicknessStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Cock Thickness";
        public override string Description => "Cock Thickness";

        protected string CockCollectionOnAdjustingKey = "CockThicknessStat CockCollection OnAdjusting";
        protected decimal CockCollectionOnAdjusting(decimal adjustment)
        {
            var adjusters = creature.Body.Cocks.OnAdjustingThickness;
            var total = adjusters.Values.Sum(adj => adj(adjustment));
            return total;
        }

        public CockThicknessStat(Game game, Creature creature, decimal thickness = 1)
            : base(game, creature)
        {
            LowerBound = new Statistics.DecimalLowerBound(maximum: 0);
            UpperBound = new Statistics.DecimalUpperBound(this, value: 999.9m, minimum: 999.9m, maximum: 999.9m);
            Value.OnAdjusting.Add(CockCollectionOnAdjustingKey, new Statistics.AdjustmentModifier(CockCollectionOnAdjusting));
            Value.Set(thickness);
        }
    }

    // TODO: This whole class feels wrong somehow.
    public abstract class Cock : AbstractBodyPart
    {
        /*
		 Group Types used for general description code (eventually)
		 * human  	        - obvious
		 * mammal 	        - obvious again
		 * supernatural 	- supernatural types
		 * tentacle         - only one tentacle!
		 * reptile	        - make a guess
		 * aquatic          - Anything in the water
		 * other	        - doesn't fit anywhere else
         * insect           - obvious
         * avian            - obvious
		 */
        // TODO: This seems like it won't work as expected.  Some overlap (human, mammal),
        // and some are orthogonal (human, supernatural).  Definitely needs more thought
        // and refactoring.
        public enum CockCategory
        {
            Mammal       =   1,
            Human        =   2,
            Supernatural =   4,
            Tentacle     =   8,
            Reptile      =  16,
            Aquatic      =  32,
            Other        =  64,
            Insect       = 128,
            Avian        = 256,
        }

        // General Cock info
        protected decimal DefaultLength = 5.5m;
        protected decimal DefaultThickness = 1;
        public CockLengthStat Length { get; protected set; }
        public CockThicknessStat Thickness { get; protected set; }
        public bool IsVirgin { get; set; }

        // Derivative Cock dimensions
        /// <summary>
        /// Area of the 2D top-down projection of the cock (length * width). Assumes rectangular profile.
        /// </summary>
        public virtual decimal Area => Length * Thickness;
        /// <summary>
        /// Area of the front-to-back 2D cross-section of the cock. Default assumes a circular profile.
        /// </summary>
        public virtual decimal CrossSection => (decimal)Math.PI * (Thickness / 2) * (Thickness / 2);
        /// <summary>
        /// Volume of the cock. Default assumes a circular cross-section.
        /// </summary>
        public virtual decimal Volume => CrossSection * Length;

        // Knot info
        public abstract bool SupportsKnot { get; }
        public virtual CockKnotCollection Knots
        {
            get;
            protected set;
        }
        public bool HasKnot => Knots.Count > 0;

        public Cock(Game game, Creature creature)
            :base(game, creature)
        {
            Length = new CockLengthStat(game, creature);
            Thickness = new CockThicknessStat(game, creature);
            Knots = new CockKnotCollection();
            IsVirgin = true;
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Length.Set(DefaultLength);
            Thickness.Set(DefaultThickness);
            Knots.Clear();
        }
    }
}