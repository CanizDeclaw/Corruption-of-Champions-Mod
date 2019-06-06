using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Registries
{
    public class Registry<T> : IDictionary<string, RegistryItem<T>>
    {
        #region IDictionary Implementation
        private Dictionary<string, RegistryItem<T>> Items = new Dictionary<string, RegistryItem<T>>();

        public RegistryItem<T> this[string key] { get => ((IDictionary<string, RegistryItem<T>>)Items)[key]; set => ((IDictionary<string, RegistryItem<T>>)Items)[key] = value; }

        public ICollection<string> Keys => ((IDictionary<string, RegistryItem<T>>)Items).Keys;

        public ICollection<RegistryItem<T>> Values => ((IDictionary<string, RegistryItem<T>>)Items).Values;

        public int Count => ((IDictionary<string, RegistryItem<T>>)Items).Count;

        public bool IsReadOnly => ((IDictionary<string, RegistryItem<T>>)Items).IsReadOnly;

        public void Add(string key, RegistryItem<T> value)
        {
            ((IDictionary<string, RegistryItem<T>>)Items).Add(key, value);
        }

        public void Add(KeyValuePair<string, RegistryItem<T>> item)
        {
            ((IDictionary<string, RegistryItem<T>>)Items).Add(item);
        }

        public void Clear()
        {
            ((IDictionary<string, RegistryItem<T>>)Items).Clear();
        }

        public bool Contains(KeyValuePair<string, RegistryItem<T>> item)
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).Contains(item);
        }

        public bool ContainsKey(string key)
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<string, RegistryItem<T>>[] array, int arrayIndex)
        {
            ((IDictionary<string, RegistryItem<T>>)Items).CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, RegistryItem<T>>> GetEnumerator()
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).GetEnumerator();
        }

        public bool Remove(string key)
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).Remove(key);
        }

        public bool Remove(KeyValuePair<string, RegistryItem<T>> item)
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).Remove(item);
        }

        public bool TryGetValue(string key, out RegistryItem<T> value)
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IDictionary<string, RegistryItem<T>>)Items).GetEnumerator();
        }
        #endregion IDictionary Implementation
    }
}
