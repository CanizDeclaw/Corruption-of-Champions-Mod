using System;
using System.Collections.Generic;
using System.Text;
using BodyMods;
using CoC_Lib.Creatures.BodyParts;

namespace CoC_Lib.Creatures.Bodies
{
    /// <summary>
    /// Represents a body with no body parts.
    /// </summary>
    public class NoBody : Body
    {
        public NoBody(Game game, Creature creature)
            : base(game, creature)
        {
        }
        public NoBody(Game game, Creature creature, Body body)
            : base(game, creature, body)
        {
        }
    }
}
