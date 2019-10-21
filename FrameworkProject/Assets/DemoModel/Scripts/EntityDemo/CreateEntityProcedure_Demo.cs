using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ProjectName
{
    /// <summary>
    /// 实体大致使用方法流程
    /// 测试前先将ProcedurePreload流程中的changestate修改为该流程
    /// </summary>
    public class CreateEntityProcedure_Demo : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get { return true; }
        }

        public bool InitSuccess = false;

        protected internal override void OnInit(ProcedureOwner procedureOwner)
        {
            base.OnInit(procedureOwner);

            //初始化资源，但同时需要加载所需要的表
            //GameEntry.Resource.InitResources(InitResourcesCallback);
        }

        private void InitResourcesCallback()
        {
            InitSuccess = true;
            Log.Info("初始化资源成功。");
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Info("--------------进入实体创建流程---------------\n" +
                "，创建实体前需要在Entity组件上设置实体所属的EntityGroup，并设置最大创建数量和回收数量。\n" +
                "按Space键创建实体，按R键回收\n若要测试加载实体，则要在preload中设置切换到该流程，或者直接设置该流程为入口并在该流程中初始化资源");
        }

        private int m_Distance = 1;

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Log.Info("Create Entity: ");
                //不带数据的实体创建
                //GameEntry.Entity.ShowEntity<Entity_Demo>(100010, "Assets/DemoModel/Prefab/CreateEntityDemo.prefab", "Test");

                //带有数据的实体创建
                GameEntry.Entity.ShowCreateEntityDemo(new EntityData_Demo(GameEntry.Entity.GenerateSerialId(), 10004, 100010, "TestStringValue")
                {
                    Name = "Wen Shuai",
                    Position = Vector3.left * m_Distance,
                });
                m_Distance += 1;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                m_Distance -= 1;

                var groups = GameEntry.Entity.GetEntityGroup("FsmEntityGroup");
                foreach (var item in groups.GetAllEntities())
                {
                    Log.Info("Name:  " + item.EntityAssetName + " Id: " + item.Id);
                }
                var array = groups.GetAllEntities();
                var e = array[array.Length - 1];
                //需要注意的是，回收的时候，回收的类型为runtime层的实体，不是gamecore层的实体
                GameEntry.Entity.HideEntity(((UnityGameFramework.Runtime.Entity)e));
            }
        }
    }
}
