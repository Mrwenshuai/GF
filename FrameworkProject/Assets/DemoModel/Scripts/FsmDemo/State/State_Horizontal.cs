using GameFramework.Fsm;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    public class State_Horizontal : FsmState<EntityDemo>
    {
        protected internal override void OnInit(IFsm<EntityDemo> fsm)
        {
            base.OnInit(fsm);
            Log.Info("初始化水平状态");
        }

        protected internal override void OnEnter(IFsm<EntityDemo> fsm)
        {
            base.OnEnter(fsm);
            Log.Info("进入水平状态");
        }

        protected internal override void OnUpdate(IFsm<EntityDemo> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);

            if (Input.GetAxis("Horizontal") > 0)
            {
                fsm.Owner.transform.position += Vector3.right * .2f;
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                fsm.Owner.transform.position += Vector3.left * .2f;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                Log.Info("在 " + fsm.CurrentState + "  切换了状态   ");
                ChangeState<State_Vertical>(fsm);
            }
        }

        protected internal override void OnLeave(IFsm<EntityDemo> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
            Log.Info("离开了： " + fsm.CurrentState);
        }

        protected internal override void OnDestroy(IFsm<EntityDemo> fsm)
        {
            base.OnDestroy(fsm);
            Log.Info("销毁了状态： " + fsm.CurrentState);
        }
    }
}
