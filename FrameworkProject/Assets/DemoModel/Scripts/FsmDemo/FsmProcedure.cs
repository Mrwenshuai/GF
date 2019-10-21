using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityGameFramework.Runtime;
using UnityEngine;

namespace ProjectName
{
    /// <summary>
    /// fsm demo测试
    /// </summary>
    public class FsmProcedure : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get { return true; }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Info("进入FSM测试流程");

            // 获取框架实体组件
            //EntityComponent entityComponent
            //    = UnityGameFramework.Runtime.GameEntry.GetComponent<EntityComponent>();

            //// 创建实体
            //entityComponent.ShowEntity<EntityDemo>(1, "Assets/DemoModel/Prefab/FsmDemo.prefab", "EntityGroup");

            GameEntry.Entity.ShowFsmDemoEntity(new EntityDemoData(GameEntry.Entity.GenerateSerialId(), 10003, CampType.Player)
            {
                Name = "Entity-001",
                Position = Vector3.zero,
            });
        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }
    }

}
