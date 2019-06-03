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
    public abstract class BoundedIntegerStat : IntegerStat
    {
        public override IntValue Value { get; protected set; }
        /// <summary>
        /// The absolute lower limit of the stat.
        /// </summary>
        public virtual IntLowerBound LowerBound { get; protected set; }
        /// <summary>
        /// The effective lower limit of the stat.
        /// </summary>
        public virtual IntMinimum Minimum { get; protected set; }
        /// <summary>
        /// The effective upper limit of the stat.
        /// </summary>
        public virtual IntMaximum Maximum { get; protected set; }
        /// <summary>
        /// The absolute upper limit of the stat.
        /// </summary>
        public virtual IntUpperBound UpperBound { get; protected set; }

        public BoundedIntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            LowerBound = new IntLowerBound();
            UpperBound = new IntUpperBound(this);
            Minimum = new IntMinimum(this);
            Maximum = new IntMaximum(this);
            Value = new BoundedIntValue(this, 0);
        }
    }       
}           
