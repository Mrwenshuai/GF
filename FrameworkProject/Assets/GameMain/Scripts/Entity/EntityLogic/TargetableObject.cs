using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    /// <summary>
    /// 可作为被继承目标的实体类。
    /// 该类已经对实体对象进行了一些常见属性处理
    /// </summary>
    public abstract class TargetableObject : Entity
    {
        [SerializeField]
        private TargetableObjectData m_TargetableObjectData = null;

        public bool IsDead
        {
            get
            {
                return m_TargetableObjectData.HP <= 0;
            }
        }

        public abstract ImpactData GetImpactData();

        public void ApplyDamage(Entity attacker, int damageHP)
        {
            float fromHPRatio = m_TargetableObjectData.HPRatio;
            m_TargetableObjectData.HP -= damageHP;
            float toHPRatio = m_TargetableObjectData.HPRatio;
            if (fromHPRatio > toHPRatio)
            {
                //GameEntry.HPBar.ShowHPBar(this, fromHPRatio, toHPRatio);
            }

            if (m_TargetableObjectData.HP <= 0)
            {
                OnDead(attacker);
            }
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnInit(object userData)
#else
        protected internal override void OnInit(object userData)
#endif
        {
            base.OnInit(userData);
            gameObject.SetLayerRecursively(Constant.Layer.TargetableObjectLayerId);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnShow(object userData)
#else
        protected internal override void OnShow(object userData)
#endif
        {
            base.OnShow(userData);

            m_TargetableObjectData = userData as TargetableObjectData;
            if (m_TargetableObjectData == null)
            {
                Log.Error("Targetable object data is invalid.");
                return;
            }
        }

        protected virtual void OnDead(Entity attacker)
        {
            GameEntry.Entity.HideEntity(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            Entity entity = other.gameObject.GetComponent<Entity>();
            if (entity == null)
            {
                return;
            }

            if (entity is TargetableObject && entity.Id >= Id)
            {
                // 碰撞事件由 Id 小的一方处理，避免重复处理
                return;
            }

            AIUtility.PerformCollision(this, entity);
        }
    }
}
