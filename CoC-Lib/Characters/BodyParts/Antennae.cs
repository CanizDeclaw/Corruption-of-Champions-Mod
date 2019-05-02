using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Characters.BodyParts
{
    public class Antennae : IBodyPart
    {
        public enum AntennaeType
        {
            None        = 0,
            Bee         = 2,
            Cockatrice  = 3,
        }

        public AntennaeType Type;

        #region Constructors
        public Antennae()
        {
            SetToDefault();
        }

        public Antennae(AntennaeType antennaeType)
        {
            Type = antennaeType;
        }
        #endregion Constructors

        public void SetToDefault()
        {
            Type = AntennaeType.None;
        }
    }
}
