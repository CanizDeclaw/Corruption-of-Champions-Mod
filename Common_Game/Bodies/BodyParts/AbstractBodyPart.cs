using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Bodies.BodyParts
{
    public abstract class AbstractBodyPart
    {
        protected readonly Game game;
        protected readonly Creature creature;
        public abstract Species.Type Species { get; }
        public bool IsIncorporeal { get; private set; } = false;

        public AbstractBodyPart(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
        }

        // TODO: Resetting body parts will probably have to change, since
        //       they're now class-based instead of enum-based.  Mutating
        //       and resetting may become a body-level operation.
        public virtual void SetToDefault()
        {
            // Nothing to do here yet.
        }
    }
}
