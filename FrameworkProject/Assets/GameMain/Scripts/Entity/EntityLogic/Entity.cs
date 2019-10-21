
using GameFramework;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    /// <summary>
    /// 用于游戏内实体继承的父类
    /// 例如子弹，特效，武器等都继承于该类
    /// </summary>
    public abstract class Entity : EntityLogic
    {
        [SerializeField]
        private EntityData m_EntityData = null;

        public int Id
        {
            get
            {
                return Entity.Id;
            }
        }

        public Animation CachedAnimation
        {
            get;
            private set;
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnInit(object userData)
#else
        protected internal override void OnInit(object userData)
#endif
        {
            base.OnInit(userData);
            CachedAnimation = GetComponent<Animation>();
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnShow(object userData)
#else
        protected internal override void OnShow(object userData)
#endif
        {
            base.OnShow(userData);

            m_EntityData = userData as EntityData;
            if (m_EntityData == null)
            {
                Log.Warning(" Entity data is not set.");
                return;
            }
            //修改生成实体名称
            Name = Utility.Text.Format("[Entity {0}]", Id.ToString());
            CachedTransform.localPosition = m_EntityData.Position;
            CachedTransform.localRotation = m_EntityData.Rotation;
            CachedTransform.localScale = Vector3.one;
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnHide(bool isShutdown, object userData)
#else
        protected internal override void OnHide(bool isShutdown, object userData)
#endif
        {
            base.OnHide(isShutdown, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
#else
        protected internal override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
#endif
        {
            base.OnAttached(childEntity, parentTransform, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnDetached(EntityLogic childEntity, object userData)
#else
        protected internal override void OnDetached(EntityLogic childEntity, object userData)
#endif
        {
            base.OnDetached(childEntity, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
#else
        protected internal override void OnAttachTo(EntityLogic parentEntity, Transform parentTransform, object userData)
#endif
        {
            base.OnAttachTo(parentEntity, parentTransform, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnDetachFrom(EntityLogic parentEntity, object userData)
#else
        protected internal override void OnDetachFrom(EntityLogic parentEntity, object userData)
#endif
        {
            base.OnDetachFrom(parentEntity, userData);
        }

#if UNITY_2017_3_OR_NEWER
        protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
#else
        protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
#endif
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }
    }
}
