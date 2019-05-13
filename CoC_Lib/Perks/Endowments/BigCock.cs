using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigCock : EndowmentPerk
    {
        public static string Key => "Endowment BigCock";
        public override string GetKey => Key;
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => player.HasCock;
    }
}