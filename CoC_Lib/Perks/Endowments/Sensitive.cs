using CoC_Lib.Characters;

namespace CoC_Lib.Perks.Endowments
{
    internal class Sensitive : EndowmentPerk
    {
        public override string Name => throw new System.NotImplementedException();
        public override string Description => throw new System.NotImplementedException();

        public override bool Qualified(Player player) => true;
    }
}