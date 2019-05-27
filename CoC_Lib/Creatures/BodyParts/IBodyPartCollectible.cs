using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.BodyParts
{
    public interface ICollectibleBodyPart<T> where T: ICollectibleBodyPart<T>
    {
        void SetCollector(BodyPartCollection<T> collector);
    }
}
