using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigClit : EndowmentPerk
    {
        public static string Key => "Endowment BigClit";
        public override string GetKey => Key;
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => player.HasVagina;
    }
}