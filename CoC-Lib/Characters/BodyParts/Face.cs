using System;

namespace CoC_Lib.Characters.BodyParts
{
    public class Face : IBodyPart
    {
        public enum FaceType
        {
            Human        =   0,
            Horse        =   1,
            Dog          =   2,
            CowMinotaur  =   3,
            SharkTeeth   =   4,
            SnakeFangs   =   5,
            Catgirl      =   6,
            Lizard       =   7,
            Bunny        =   8,
            Kangaroo     =   9,
            SpiderFangs  =  10,
            Fox          =  11,
            Dragon       =  12,
            RaccoonMask  =  13,
            Raccoon      =  14,
            Buckteeth    =  15,
            Mouse        =  16,
            FerretMask   =  17,
            Ferret       =  18,
            Pig          =  19,
            Boar         =  20,
            Rhino        =  21,
            Echidna      =  22,
            Deer         =  23,
            Wolf         =  24,
            Cockatrice   =  25,
            Beak         =  26, // This is a placeholder for the next beaked face type, so feel free to refactor (rename)
            RedPanda     =  27,
            Cat          =  28,
        }

        public FaceType Type;

        public bool HasMuzzle
        {
            get
            {
                switch (Type)
                {
                    case FaceType.Horse:
                    case FaceType.Dog:
                    case FaceType.Cat:
                    case FaceType.Lizard:
                    case FaceType.Kangaroo:
                    case FaceType.Fox:
                    case FaceType.Dragon:
                    case FaceType.Rhino:
                    case FaceType.Echidna:
                    case FaceType.Deer:
                    case FaceType.Wolf:
                    case FaceType.RedPanda:
                        return true;
                    case FaceType.Human:
                    case FaceType.CowMinotaur:
                    case FaceType.SharkTeeth:
                    case FaceType.SnakeFangs:
                    case FaceType.Catgirl:
                    case FaceType.Bunny:
                    case FaceType.SpiderFangs:
                    case FaceType.RaccoonMask:
                    case FaceType.Raccoon:
                    case FaceType.Buckteeth:
                    case FaceType.Mouse:
                    case FaceType.FerretMask:
                    case FaceType.Ferret:
                    case FaceType.Pig:
                    case FaceType.Boar:
                    case FaceType.Cockatrice:
                    case FaceType.Beak:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        public bool IsHumanish
        {
            get
            {
                switch (Type)
                {
                    case FaceType.Human:
                    case FaceType.SharkTeeth:
                    case FaceType.SnakeFangs:
                    case FaceType.SpiderFangs:
                        return true;
                    case FaceType.Horse:
                    case FaceType.Dog:
                    case FaceType.CowMinotaur:
                    case FaceType.Catgirl:
                    case FaceType.Lizard:
                    case FaceType.Bunny:
                    case FaceType.Kangaroo:
                    case FaceType.Fox:
                    case FaceType.Dragon:
                    case FaceType.RaccoonMask:
                    case FaceType.Raccoon:
                    case FaceType.Buckteeth:
                    case FaceType.Mouse:
                    case FaceType.FerretMask:
                    case FaceType.Ferret:
                    case FaceType.Pig:
                    case FaceType.Boar:
                    case FaceType.Rhino:
                    case FaceType.Echidna:
                    case FaceType.Deer:
                    case FaceType.Wolf:
                    case FaceType.Cockatrice:
                    case FaceType.Beak:
                    case FaceType.RedPanda:
                    case FaceType.Cat:
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }


        public Face()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = FaceType.Human;
        }
    }
}