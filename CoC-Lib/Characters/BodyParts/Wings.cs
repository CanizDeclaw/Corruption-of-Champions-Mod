namespace CoC_Lib.Characters.BodyParts
{
    public class Wings : IBodyPart
    {
        public enum WingType
        {
            None           =   0,
            BeeLikeSmall   =   1,
            BeeLikeLarge   =   2,
            Harpy          =   4,
            Imp            =   5,
            BatLikeTiny    =   6,
            BatLikeLarge   =   7,
            SharkFin       =   8, // Deprecated, moved to the rearBody slot.
            FeatheredLarge =   9,
            DraconicSmall  =  10,
            DraconicLarge  =  11,
            GiantDragonfly =  12,
            ImpLarge       =  13,
            FaerieSmall    =  14, // currently for monsters only
            FaerieLarge    =  15, // currently for monsters only
        }

        public WingType Type;
        public string MainColor; // TODO: A better way to do colors
        public string SecondaryColor; // TODO: A better way to do color pairs

        public Wings()
        {
            SetToDefault();
        }

        public void SetToDefault()
        {
            Type = WingType.None;
            MainColor = "no";
            SecondaryColor = "no";
        }
    }
}