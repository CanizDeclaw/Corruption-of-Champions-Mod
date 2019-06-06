using System;
using System.Collections.Generic;
using System.Text;

namespace Common_Game.Registries
{
    public class RegistryItem<T>
    {
        private Func<T> NewItemFunction;
        public T NewItem()
        {
            return NewItemFunction();
        }

        public RegistryItem(Func<T> newItemGenerator)
        {
            NewItemFunction = newItemGenerator;
        }

    }
}
