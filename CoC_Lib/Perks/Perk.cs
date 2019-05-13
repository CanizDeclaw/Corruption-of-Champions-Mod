using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks
{
    public abstract class Perk
    {
        /// <summary>
        /// This should be backed by a `public static string Key { get; }` property.
        /// </summary>
        public abstract string GetKey { get; }
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Category { get; }

        public abstract void OnAddPerk(Creatures.Creature creature);
        public abstract void OnRemovePerk(Creatures.Creature creature);
    }
}
