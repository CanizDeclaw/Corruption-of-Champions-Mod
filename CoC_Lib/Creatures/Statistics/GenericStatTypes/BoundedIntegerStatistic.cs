using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
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
        public override IntValue Value { get; }
        /// <summary>
        /// The absolute lower limit of the stat.
        /// </summary>
        public virtual object LowerBound { get; }
        /// <summary>
        /// The effective lower limit of the stat.
        /// </summary>
        public virtual int Minimum { get; }
        /// <summary>
        /// The effective upper limit of the stat.
        /// </summary>
        public virtual int Maximum { get; }
        /// <summary>
        /// The absolute upper limit of the stat.
        /// </summary>
        public virtual object UpperBound { get; }

        public BoundedIntegerStat(Game game, Creature creature)
            :base(game, creature)
        {
            Value = new BoundedIntValue(this, 0);
            LowerBound = new object();
            //Minimum = new object();
            UpperBound = new object();
            //Maximum = new object();
        }
    }       
}           
