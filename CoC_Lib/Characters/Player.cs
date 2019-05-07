namespace CoC_Lib.Characters
{
    public class Player : Character
    {
        public Player()
        {
            Name = "Player";
        }

        public bool CanLevelUp { get; internal set; }
        public int StatPoints { get; internal set; }
        public bool CanPerkUp { get; internal set; }
        public bool CanRankUp { get; internal set; }
        public bool CanStatUp { get; internal set; }
    }
}