using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoC_Desktop_WPF.Models
{
    public class CoC
    {
        private Utilities.SaveLoadPackage saveLoadPackage;

        public CoC_Lib.Game Game;

        public CoC()
        {
            saveLoadPackage = new Utilities.SaveLoadPackage();
            Game = new CoC_Lib.Game(saveLoadPackage);
        }
    }
}
