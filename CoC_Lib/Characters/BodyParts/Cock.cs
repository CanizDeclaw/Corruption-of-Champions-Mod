using System;

namespace CoC_Lib.Characters.BodyParts
{
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

        protected const double MaxLength = 9999.9;
        protected const double MaxThickness = 999.9;
        protected const double KnotMultiplierDefault = 1;

        public double Length;
        public double Thickness;
        public double KnotMultiplier;
        public bool IsVirgin;
        public abstract bool SupportsKnot { get; }

        public double Area => Length * Thickness;
        public bool HasKnot => SupportsKnot && KnotMultiplier > KnotMultiplierDefault;

        public Cock()
        {
            SetToDefault();
        }

        public override void SetToDefault()
        {
            base.SetToDefault();
            Length = 5.5;
            Thickness = 1;
            KnotMultiplier = KnotMultiplierDefault;
            IsVirgin = true;
        }
    }
}