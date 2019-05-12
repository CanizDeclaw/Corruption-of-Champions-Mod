using CoC_Lib.Characters;

namespace CoC_Lib.Perks.Endowments
{
    internal class BigBreasts : EndowmentPerk
    {
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => player.HasBreasts;
    }
}