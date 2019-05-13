using CoC_Lib.Creatures;

namespace CoC_Lib.Perks.Endowments
{
    internal class WetVagina : EndowmentPerk
    {
        public static string Key => "Endowment WetVagina";
        public override string GetKey => Key;
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => player.HasVagina;
    }
}