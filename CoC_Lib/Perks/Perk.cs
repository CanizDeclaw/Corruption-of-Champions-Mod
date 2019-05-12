using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks
{
    public abstract class Perk
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Category { get; }
    }
}
