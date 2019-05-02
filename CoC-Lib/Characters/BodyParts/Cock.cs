using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class Cock : IBodyPart
    {
        public enum CockType
        {
            Human     =  0,
            Horse     =  1,
            Dog       =  2,
            Demon     =  3,
            Tentacle  =  4,
            Cat       =  5,
            Lizard    =  6,
            Anemone   =  7,
            Kangaroo  =  8,
            Dragon    =  9,
            Displacer = 10,
            Fox       = 11,
            Bee       = 12,
            Pig       = 13,
            Avian     = 14,
            Rhino     = 15,
            Echidna   = 16,
            Wolf      = 17,
            RedPanda  = 18,
            Ferret    = 19,
            Undefined = 20,
        }

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
        // This seems like it won't work as expected.  Some overlap (human, mammal),
        // and some are orthogonal (human, supernatural).  Definitely needs more thought
        // and refactoring.
        public enum CockTypeGroup
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

        public const double MaxLength = 9999.9;
        public const double MaxThickness = 999.9;
        public const double KnotMultiplierDefault = 1;

        public double Length;
        public double Thickness;
        public CockType Type;
        public double KnotMultiplier;
        public bool IsVirgin;

        public double Area => Length * Thickness;
        public bool SupportsKnot
        {
            get
            {
                switch (Type)
                {
                    case CockType.Displacer:
                    case CockType.Dog:
                    case CockType.Dragon:
                    case CockType.Fox:
                    case CockType.Human:
                    case CockType.Wolf:
                        return true;
                    case CockType.Horse:
                    case CockType.Demon:
                    case CockType.Tentacle:
                    case CockType.Cat:
                    case CockType.Lizard:
                    case CockType.Anemone:
                    case CockType.Kangaroo:
                    case CockType.Bee:
                    case CockType.Pig:
                    case CockType.Avian:
                    case CockType.Rhino:
                    case CockType.Echidna:
                    case CockType.RedPanda:
                    case CockType.Ferret:
                    case CockType.Undefined:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        public bool HasKnot => SupportsKnot && KnotMultiplier > KnotMultiplierDefault;

        public Cock()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Length = 5.5;
            Thickness = 1;
            Type = CockType.Human;
            KnotMultiplier = KnotMultiplierDefault;
            IsVirgin == true;
        }
    }
}