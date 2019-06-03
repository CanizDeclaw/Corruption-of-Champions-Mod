using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Bodies.BodyParts
{
    public class KnotMultiplierStat : Statistics.BoundedDecimalStat
    {
        public override string Name => "Knot Multiplier";
        public override string Description => "How thick the knot is relative to the cock thickness";
        protected CockKnot Parent { get; }

        protected string CockCollectionOnAdjustingKey = "KnotMultiplierStat CockCollection OnAdjusting";
        protected decimal CockCollectionOnAdjusting(decimal adjustment)
        {
            var adjusters = creature.Body.Cocks.OnAdjustingKnotMultiplier;
            var total = adjusters.Values.Sum(adj => adj(adjustment));
            return total;
        }

        public KnotMultiplierStat(Game game, Creature creature, decimal multiplier = 1)
            : base(game, creature)
        {
            LowerBound = new Statistics.DecimalLowerBound(maximum: 0);
            UpperBound = new Statistics.DecimalUpperBound(this, value: 999.9m, minimum: 999.9m, maximum: 999.9m);
            Value.OnAdjusting.Add(CockCollectionOnAdjustingKey, new Statistics.AdjustmentModifier(CockCollectionOnAdjusting));
            Value.Set(multiplier);
        }
    }

    public abstract class CockKnot : AbstractBodyPart
    {
        protected Cock Parent { get; }
        public KnotMultiplierStat KnotMultiplier { get; protected set; }
        protected const decimal KnotMultiplierDefault = 1;

        // Derivative Knot dimensions
        public virtual decimal KnotThickness => Parent.Thickness * KnotMultiplier;
        public virtual decimal KnotCrossSection => (decimal)Math.PI * (KnotThickness / 2) * (KnotThickness / 2);

        public CockKnot(Game game, Creature creature)
            :base(game, creature)
        {
        }
    }
}
