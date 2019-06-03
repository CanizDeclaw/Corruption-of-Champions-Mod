using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Perks
{
    public abstract class Perk
    {
        /// <summary>
        /// This should be backed by a `public static string Key { get; }` property.
        /// </summary>
        public abstract string GetKey { get; }
        public abstract string Name { get; }
        public abstract string ShortName { get; }
        public abstract string ShortDescription { get; }
        public abstract string LongDescription { get; }
        public abstract string Category { get; }

        public abstract bool KeepOnAscension { get; }

        public abstract void OnFirstTimeAdd(Creatures.Creature creature);
        public abstract void OnAddPerk(Creatures.Creature creature, bool firstTime = true);
        public abstract void OnRemovePerk(Creatures.Creature creature);
    }
}
