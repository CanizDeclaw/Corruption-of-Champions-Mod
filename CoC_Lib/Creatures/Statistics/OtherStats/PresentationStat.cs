using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public class PresentationStat : BoundedIntegerStat
    {
        public override string Name => "Presentation";
        public override string Description => "How masculine/feminine a creature is.  Higher values are more feminine.";

        public int Femininity => Value;
        public int Masculinity => UpperBound - Value;

        public void IncreaseFemininity(int value) => Adjust(value);
        public void DecreaseFemininity(int value) => Adjust(-value);
        public void IncreaseMasculinity(int value) => Adjust(-value);
        public void DecreaseMasculinity(int value) => Adjust(value);

        public PresentationStat(Game game, Creature creature)
            :base(game, creature)
        {
            LowerBound = new IntLowerBound(maximum: 0);
            UpperBound = new IntUpperBound(this, value: 100, minimum: 100, maximum: 100);
            Value.Set(50);
        }
    }
}
