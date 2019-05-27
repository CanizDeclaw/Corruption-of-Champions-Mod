using System;

namespace CoC_Lib.Creatures.BodyParts
{
    // TODO: Modifiers that affect all cocks (and vaginas, and breasts, and...)
    //       Property of parent collection, fed in by constructors?
    public class CockLengthStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Cock Length";
        public override string Description => "Cock Length";
        protected Cock Parent { get; }

        public CockLengthStat(Game game, Creature creature, Cock parent)
            :base(game, creature)
        {
            Parent = parent;
            LowerBound = new Statistics.DecimalLowerBound();
            UpperBound = new Statistics.DecimalUpperBound(this);
        }
    }

    public class CockThicknessStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Cock Thickness";
        public override string Description => "Cock Thickness";
        protected Cock Parent { get; }

        public CockThicknessStat(Game game, Creature creature, Cock parent)
            : base(game, creature)
        {
            Parent = parent;
            LowerBound = new Statistics.DecimalLowerBound();
            UpperBound = new Statistics.DecimalUpperBound(this);
        }
    }

    public class KnotMultiplierStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Knot Multiplier";
        public override string Description => "How thick the knot is relative to the cock thickness";
        protected Cock Parent { get; }

        public KnotMultiplierStat(Game game, Creature creature, Cock parent)
            : base(game, creature)
        {
            Parent = parent;
            LowerBound = new Statistics.DecimalLowerBound();
            UpperBound = new Statistics.DecimalUpperBound(this);
        }
    }

    // TODO: This whole class feels wrong somehow.
    public abstract class Cock : AbstractBodyPart, ICollectibleBodyPart<Cock>
    {
        protected CockCollection ParentCollection { get; set; }
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

        protected const decimal MaxLength = 9999.9m;
        protected const decimal MaxThickness = 999.9m;
        protected const decimal KnotMultiplierDefault = 1;

        public CockLengthStat Length;
        public CockThicknessStat Thickness;
        public KnotMultiplierStat KnotMultiplier;
        public bool IsVirgin;
        public abstract bool SupportsKnot { get; }

        public decimal Area => Length * Thickness;
        public bool HasKnot => SupportsKnot && KnotMultiplier > KnotMultiplierDefault;

        public Cock(Game game, Creature creature)
            :base(game, creature)
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Length.Set(5.5m);
            Thickness.Set(1);
            KnotMultiplier.Set(KnotMultiplierDefault);
            IsVirgin = true;
        }

        public void SetCollector(BodyPartCollection<Cock> collector)
        {
            if (collector is CockCollection cc)
            {
                ParentCollection = cc;
            }
        }
    }
}