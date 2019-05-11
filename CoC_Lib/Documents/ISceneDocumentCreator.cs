using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Documents
{
    public interface ISceneDocumentCreator
    {
        ISceneDocument NewSceneDocument();
    }
}
