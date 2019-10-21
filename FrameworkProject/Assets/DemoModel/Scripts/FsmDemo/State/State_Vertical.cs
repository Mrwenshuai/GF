using GameFramework.Fsm;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    public class State_Vertical : FsmState<EntityDemo>
    {
        protected internal override void OnEnter(IFsm<EntityDemo> fsm)
        {
            base.OnEnter(fsm);
            Log.Info("进入到垂直状态");
        }

        protected internal override void OnInit(IFsm<EntityDemo> fsm)
        {
            base.OnInit(fsm);
            Log.Info("初始化垂直状态");
        }

        protected internal override void OnUpdate(IFsm<EntityDemo> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);


            if (Input.GetAxis("Vertical") > 0)
            {
                fsm.Owner.transform.position += Vector3.forward * .2f;
            }

            if (Input.GetAxis("Vertical") < 0)
            {
                fsm.Owner.transform.position += Vector3.back * .2f;
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                Log.Info("在 " + fsm.CurrentState + " 切换了状态 ");
                ChangeState<State_Horizontal>(fsm);
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
