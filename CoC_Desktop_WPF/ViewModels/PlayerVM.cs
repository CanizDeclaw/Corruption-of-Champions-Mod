using CoC_Lib.Characters;
using CoC_Lib.Characters.Statistics;

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