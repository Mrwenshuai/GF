using GameFramework;
using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    public class EventSubcribe_Demo : GameEventArgs
    {
        /// <summary>
        /// 订阅事件测试ID
        /// </summary>
        public static readonly int EventId = typeof(EventSubcribe_Demo).GetHashCode();

        public EventSubcribe_Demo()
        {
            EventName = null;
            UserData = null;
        }

        /// <summary>
        /// 事件名称
        /// </summary>
        public string EventName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取用户自定义数据
        /// </summary>
        public object UserData
        {
            get;
            private set;
        }

        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        public static EventSubcribe_Demo Create(string eventname, object data)
        {
            EventSubcribe_Demo args = ReferencePool.Acquire<EventSubcribe_Demo>();
            args.EventName = eventname;
            args.UserData = data;
            return args;
        }

        public override void Clear()
        {
            EventName = null;
            UserData = null;
        }
    }
}
