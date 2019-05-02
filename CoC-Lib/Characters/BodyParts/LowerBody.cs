namespace CoC_Lib.Characters.BodyParts
{
    public class LowerBody : IBodyPart
    {
        public enum LowerBodyType
        {
            Human               =   0,
            Hoofed              =   1,
            Dog                 =   2,
            Naga                =   3,
          //Centaur             =   4, //DEPRECATED - USE HOOFED + LEGCOUNT 4
            DemonicHighHeels    =   5,
            DemonicClaws        =   6,
            Bee                 =   7,
            Goo                 =   8,
            Cat                 =   9,
            Lizard              =  10,
            Pony                =  11,
            Bunny               =  12,
            Harpy               =  13,
            Kangaroo            =  14,
            ChitinousSpiderLegs =  15,
            Drider              =  16,
            Fox                 =  17,
            Dragon              =  18,
            Raccoon             =  19,
            Ferret              =  20,
            ClovenHoofed        =  21,
          //Rhino               =  22,
            Echidna             =  23,
          //Deertaur            =  24, //DEPRECATED - USE CLOVEN HOOFED + LEGCOUNT 4
            Salamander          =  25,
            Wolf                =  26,
            Imp                 =  27,
            Cockatrice          =  28,
            RedPanda            =  29,
        }

        public LowerBodyType Type;
        public int LegCount;
        public bool Incorporeal;

        public void SetToDefault()
        {
            Type = LowerBodyType.Human;
            LegCount = 2;
            Incorporeal = false;
        }
    }
}