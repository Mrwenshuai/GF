using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
namespace ProjectName
{
    public class TestUIProcedure : ProcedureBase
    {
        public override bool UseNativeDialog { get { return true;  }}

        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Log.Info("进入UI测试流程");

            GameEntry.UI.OpenUIForm("Assets/DemoModel/Prefab/TestUI.prefab", "DefaultGroup");
        }
    }

}
