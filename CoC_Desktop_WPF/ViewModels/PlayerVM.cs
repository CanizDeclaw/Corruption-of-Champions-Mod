using CoC_Lib.Creatures;
using CoC_Lib.Creatures.Statistics;

namespace CoC_Desktop_WPF.ViewModels
{
    public class PlayerVM : CreatureVM
    {
        protected readonly Player player;

        public PlayerVM(Player player, CoC game)
            :base(player, game)
        {
            this.player = player;
        }
    }
}