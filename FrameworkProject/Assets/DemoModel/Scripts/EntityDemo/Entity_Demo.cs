using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{

    /// <summary>
    /// 用作测试的实体对象类，此处也可直接继承于 ProjectName.Entity
    /// 此实体不附加任何其他实体
    /// </summary>
    public class Entity_Demo : Entity
    {
        [SerializeField]
        private EntityData_Demo m_EntityData;

        protected internal override void OnShow(object userData)
        {
            base.OnShow(userData);

#if true //带有数据的测试
            m_EntityData = userData as EntityData_Demo;
            if (m_EntityData != null)
            {
                Log.Info("Info Name: [" + m_EntityData.Name + "] Id: [" + m_EntityData.Id + "] String : [" + m_EntityData.TestStr + "]");
            }
#endif

        }


        protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);

        }

    }

}
