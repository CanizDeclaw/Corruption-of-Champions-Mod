using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Bodies.BodyParts
{
    public abstract class BodyPartCollection<T> : IList<T> where T: AbstractBodyPart
    {
        protected List<T> Collection { get; }

        #region IList<T> Implementation
        public T this[int index]
        {
            get => ((IList<T>)Collection)[index];
            set
            {
                ((IList<T>)Collection)[index] = value;
            }
        }

        public int Count => ((IList<T>)Collection).Count;
        public bool IsReadOnly => ((IList<T>)Collection).IsReadOnly;

        public void Add(T item)
        {
            ((IList<T>)Collection).Add(item);
        }

        public void Clear()
        {
            ((IList<T>)Collection).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)Collection).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)Collection).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IList<T>)Collection).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)Collection).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ((IList<T>)Collection).Insert(index, item);
        }

        public bool Remove(T item)
        {
            return ((IList<T>)Collection).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<T>)Collection).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<T>)Collection).GetEnumerator();
        }
        #endregion IList<T> Implementation
    }
}
