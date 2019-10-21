using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectName
{
    [Serializable]
    public class EntityData_Demo : EntityData
    {
        [SerializeField]
        private int m_TestInt1 = 0;
        [SerializeField]
        private string m_TestStr1 = null;

        public EntityData_Demo(int entityId, int typeId,int other1,string other2) : base(entityId, typeId)
        {
            m_TestInt1 = other1;
            m_TestStr1 = other2;
        }

        public int TestInt
        {
            get { return m_TestInt1; }
        }

        public string TestStr
        {
            get { return m_TestStr1; }
        }

        public string Name = string.Empty;
    }

}
