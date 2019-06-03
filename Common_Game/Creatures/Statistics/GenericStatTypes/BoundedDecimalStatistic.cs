using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common_Game.Creatures.Statistics
{
    // TODO: Reimplement Value, Minimum, and Maximum to be self-contained,
    //       with the latter two including their temporary limiters.
    //       Should also have multipart modifier (pre-setter, post-setter, etc).
    /// <summary>
    /// LowerBound <= Minimum <= Value <= Maximum <= UpperBound
    /// </summary>
    /// <remarks>
    /// </remarks>
    public abstract class BoundedDecimalStat : DecimalStat
    {
        public override DecimalValue Value { get; protected set; }
        /// <summary>
        /// The absolute lower limit of the stat.
        /// </summary>
        public virtual DecimalLowerBound LowerBound { get; protected set; }
        /// <summary>
        /// The effective lower limit of the stat.
        /// </summary>
        public virtual DecimalMinimum Minimum { get; protected set; }
        /// <summary>
        /// The effective upper limit of the stat.
        /// </summary>
        public virtual DecimalMaximum Maximum { get; protected set; }
        /// <summary>
        /// The absolute upper limit of the stat.
        /// </summary>
        public virtual DecimalUpperBound UpperBound { get; protected set; }

        public BoundedDecimalStat(Game game, Creature creature)
            :base(game, creature)
        {
            LowerBound = new DecimalLowerBound();
            UpperBound = new DecimalUpperBound(this);
            Minimum = new DecimalMinimum(this);
            Maximum = new DecimalMaximum(this);
            Value = new BoundedDecimalValue(this, 0);
        }
    }       
}           
