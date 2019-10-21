using GameFramework.Event;
using GameFramework.Fsm;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    /// <summary>
    /// 带有状态机的实体demo测试
    /// </summary>
    public class EntityDemo : TargetableObject
    {
        private IFsm<EntityDemo> m_EntityFsm;

        [SerializeField]
        private EntityDemoData m_EntityData;

        [SerializeField]
        protected Thruster m_Thruster;

        [SerializeField]
        protected List<Weapon> m_Weapons = new List<Weapon>();

        [SerializeField]
        protected List<Armor> m_Armors = new List<Armor>();


        public override ImpactData GetImpactData()
        {
            return new ImpactData(m_EntityData.Camp, m_EntityData.HP, 100, m_EntityData.Defense);
        }

        protected internal override void OnInit(object userData)
        {
            base.OnInit(userData);
            //初始化该实体拥有的状态机
            FsmState<EntityDemo>[] states = new FsmState<EntityDemo>[]
            {
                new State_Horizontal(),
                new State_Vertical(),
            };
            Log.Error("按 C 切换状态");
            m_EntityFsm = GameEntry.Fsm.CreateFsm<EntityDemo>(this, states);
            m_EntityFsm.Start<State_Horizontal>();

        }

        protected internal override void OnShow(object userData)
        {
            base.OnShow(userData);
            Log.Info("Show Entity");
            m_EntityData = userData as EntityDemoData;
            if (m_EntityData == null)
            {
                Log.Error("不能获取到测试实体的数据信息。");
                return;
            }
            //初始化拥有的武器，护甲，等信息
            var weapons = m_EntityData.GetAllWeaponDatas();
            for (int i = 0; i < weapons.Count; i++)
            {
                GameEntry.Entity.ShowWeapon(weapons[i]);
            }
            var armors = m_EntityData.GetAllArmorDatas();
            for (int i = 0; i < armors.Count; i++)
            {
                GameEntry.Entity.ShowArmor(armors[i]);
            }
            GameEntry.Entity.ShowThruster(m_EntityData.GetThrusterData());
        }

        protected internal override void OnAttached(EntityLogic childEntity, Transform parentTransform, object userData)
        {
            base.OnAttached(childEntity, parentTransform, userData);
            if (childEntity is Thruster)
            {
                m_Thruster = (Thruster)childEntity;
                return;
            }

            if (childEntity is Weapon)
            {
                m_Weapons.Add((Weapon)childEntity);
                return;
            }

            if (childEntity is Armor)
            {
                m_Armors.Add((Armor)childEntity);
                return;
            }
        }

        protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);

            if (Input.GetMouseButton(0))
            {
                //Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //m_TargetPosition = new Vector3(point.x, 0f, point.z);

                for (int i = 0; i < m_Weapons.Count; i++)
                {
                    m_Weapons[i].TryAttack();
                }
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                Log.Info("按下了回收键");

            }
        }

        protected override void OnDead(Entity attacker)
        {
            base.OnDead(attacker);
            //TODO 死亡后要做的处理，目前只做回收处理
        }

    }

}
