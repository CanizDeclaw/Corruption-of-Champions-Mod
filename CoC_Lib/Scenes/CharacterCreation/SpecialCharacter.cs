﻿using CoC_Lib.Characters;
using CoC_Lib.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Scenes.CharacterCreation
{
    public class SpecialCharacter
    {
        public string Name { get; set; }
        public bool SkipCustomization { get; set; }
        public ISceneDocument Description { get; set; }
        public Func<Player> CreatePlayerCharacter { get; set; }
    }
}
