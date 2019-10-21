using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    public class TestUI : UGuiForm
    {
        protected internal override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            TestUI ui = userData as TestUI;
            if (ui == null)
            {
                Log.Warning("没有界面数据信息。");
            }
            Log.Info("进入测试UI显示界面。");
        }
    }

}
