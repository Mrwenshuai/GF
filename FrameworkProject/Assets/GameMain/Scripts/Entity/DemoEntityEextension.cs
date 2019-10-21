using GameFramework.DataTable;
using System;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    public static class DemoEntityEextension
    {
        /// <summary>
        /// 创建FSMdemo中实体的拓展方法
        /// </summary>
        /// <param name="entityComponent"></param>
        /// <param name=""></param>
        public static void ShowFsmDemoEntity(this EntityComponent entityComponent, EntityDemoData data)
        {
            entityComponent.ShowEntity(typeof(EntityDemo), "FsmEntityGroup", Constant.AssetPriority.MyAircraftAsset, data);
        }
        /// <summary>
        /// 创建实体demo中要用到的扩展方法
        /// </summary>
        /// <param name="entityComponent"></param>
        /// <param name="data"></param>
        public static void ShowCreateEntityDemo(this EntityComponent entityComponent, EntityData_Demo data)
        {
            entityComponent.ShowEntity(typeof(Entity_Demo), "FsmEntityGroup", Constant.AssetPriority.MyAircraftAsset, data);
        }

        private static void ShowEntity(this EntityComponent entityComponent, Type logicType, string entityGroup, int priority, EntityData data)
        {
            if (data == null)
            {
                Log.Warning("ID:[{0}]无对应的数据，检查表中是否配置. ");
                return;
            }

            IDataTable<DREntity> dtEntity = GameEntry.DataTable.GetDataTable<DREntity>();
            DREntity drEntity = dtEntity.GetDataRow(data.TypeId);
            if (drEntity == null)
            {
                Log.Warning("Can not load entity id '{0}' from data table.", data.TypeId.ToString());
                return;
            }

            entityComponent.ShowEntity(data.Id, logicType, AssetUtility.GetEntityAsset(drEntity.AssetName), entityGroup, priority, data);
        }
    }

}
