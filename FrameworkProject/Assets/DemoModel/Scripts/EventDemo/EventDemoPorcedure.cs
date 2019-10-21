using GameFramework.Event;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ProjectName
{
    /// <summary>
    /// 测试此demo的时候，需要将框架的Procedure中的入口调整为该流程 
    /// </summary>
    public class EventDemoPorcedure : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get { return true; }
        }

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Info("进入Event测试流程");
            GameEntry.Event.Subscribe(EventSubcribe_Demo.EventId, TestHandle);

        }

        protected internal override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);


            if (Input.GetKeyDown(KeyCode.F))
            {
                Log.Info("Press Key : F");
                GameEntry.Event.Fire(this, EventSubcribe_Demo.Create("TestEventName", this));
            }

        }


        protected internal override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameEntry.Event.Unsubscribe(EventSubcribe_Demo.EventId, TestHandle);
        }


        private void TestHandle(object sender, GameEventArgs e)
        {
            EventSubcribe_Demo data = (EventSubcribe_Demo)e;
            // 判断userData是否为自己
            if (data.UserData != this)
            {
                Log.Error(" 信息不一致。 ");
                return;
            }
            Log.Info("获取到的信息： 事件名：[" + data.EventName + "] UserData: [" + data.UserData + "] EventId : [" + data.Id+"]");
        }

    }

}

