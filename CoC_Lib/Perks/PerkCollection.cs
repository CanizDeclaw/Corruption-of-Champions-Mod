using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Perks
{
    public class PerkCollection : IDictionary<string, Perk>
    {
        protected readonly Creatures.Player owner;
        protected Dictionary<string, Perk> Perks = new Dictionary<string, Perk>();

        #region Default IDictionary Implementation
        public ICollection<string> Keys => ((IDictionary<string, Perk>)Perks).Keys;
        public ICollection<Perk> Values => ((IDictionary<string, Perk>)Perks).Values;

        public int Count => ((IDictionary<string, Perk>)Perks).Count;

        public bool IsReadOnly => ((IDictionary<string, Perk>)Perks).IsReadOnly;

        public bool Contains(KeyValuePair<string, Perk> item)
        {
            return ((IDictionary<string, Perk>)Perks).Contains(item);
        }
        public bool ContainsKey(string key)
        {
            return ((IDictionary<string, Perk>)Perks).ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, Perk>[] array, int arrayIndex)
        {
            ((IDictionary<string, Perk>)Perks).CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, Perk>> GetEnumerator()
        {
            return ((IDictionary<string, Perk>)Perks).GetEnumerator();
        }

        public bool TryGetValue(string key, out Perk value)
        {
            return ((IDictionary<string, Perk>)Perks).TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IDictionary<string, Perk>)Perks).GetEnumerator();
        }
        #endregion Default IDictionary Implementation

        #region Customized IDictionary Implementation
        public Perk this[string key]
        {
            get => ((IDictionary<string, Perk>)Perks)[key];
            set => Replace(key, value);
        }

        public void Add(Perk perk)
        {
            Add(perk.GetKey, perk);
        }
        public void Add(KeyValuePair<string, Perk> item)
        {
            Add(item.Key, item.Value);
        }
        public void Add(string key, Perk perk)
        {
            Add(key, perk, restoringSave: false);
        }
        public void Add(string key, Perk perk, bool restoringSave = false)
        {
            if (restoringSave == false)
            {
                perk.OnFirstTimeAdd(owner);
            }
            perk.OnAddPerk(owner);
            ((IDictionary<string, Perk>)Perks).Add(key, perk);
        }

        public void Clear()
        {
            var keys = ((IDictionary<string, Perk>)Perks).Keys;
            foreach (var key in keys)
            {
                Remove(key);
            }
        }

        public bool Remove(string key)
        {
            return Remove(new KeyValuePair<string, Perk>(key, this[key]));
        }
        public bool Remove(KeyValuePair<string, Perk> item)
        {
            item.Value.OnRemovePerk(owner);
            return ((IDictionary<string, Perk>)Perks).Remove(item);
        }
        #endregion Customized IDictionary Implementation

        private void Replace(string key, Perk replacement)
        {
            Remove(key);
            Add(key, replacement);
        }

        /// <summary>
        /// This should return XML listing each perk present in this collection
        /// by its key.
        /// </summary>
        /// <returns>XML listing each perk in this collection by key.</returns>
        public object Save()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Given the XML output from Save() this clears the collection and restores
        /// all the perks in the list.
        /// </summary>
        public void Restore()
        {
            throw new NotImplementedException();
        }

        public PerkCollection(Creatures.Player owner)
        {
            this.owner = owner;
        }
    }
}
