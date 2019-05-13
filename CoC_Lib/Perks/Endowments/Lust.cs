using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class Lust : EndowmentPerk
    {
        public static string Key => "Endowment Lust";
        public override string GetKey => Key;
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => true;
    }
}