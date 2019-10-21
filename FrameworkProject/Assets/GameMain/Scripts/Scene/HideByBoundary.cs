using UnityEngine;
using UnityGameFramework.Runtime;

namespace ProjectName
{
    /// <summary>
    /// 碰到边界隐藏对象
    /// </summary>
    public class HideByBoundary : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            GameObject go = other.gameObject;
            Entity entity = go.GetComponent<Entity>();
            if (entity == null)
            {
                Log.Warning("Unknown GameObject '{0}', you must use entity only.", go.name);
                Destroy(go);
                return;
            }

            GameEntry.Entity.HideEntity(entity);
        }
    }

}
