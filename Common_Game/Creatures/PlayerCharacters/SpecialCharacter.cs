using CoC_Lib.Creatures;
using CoC_Lib.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Creatures.PlayerCharacters
{
    public class SpecialPlayerCharacter
    {
        public string Name { get; set; }
        public bool SkipCustomization { get; set; }
        public ISceneDocument Description { get; set; }
        public Func<Player> CreatePlayerCharacter { get; set; }
    }
}
