using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Genealogy
{
    /// <summary>
    /// 此类用于定义“家族大事记”数据类型；可依照个人需求扩展成员方法。
    /// </summary>
    class Event
    {
        private int eventID;
        private string genealogyID;
        private string eventContent;
        private string eventTime;

        public int EventID { get => eventID; set => eventID = value; }
        public string GenealogyID { get => genealogyID; set => genealogyID = value; }
        public string EventContent { get => eventContent; set => eventContent = value; }
        public string EventTime { get => eventTime; set => eventTime = value; }

        /// <summary>
        /// 构造一个Event类数据。
        /// </summary>
        /// <param name="eventID">家族大事记编号</param>
        /// <param name="genealogyID">家族大事记所属族谱ID</param>
        /// <param name="eventContent">家族大事记内容</param>
        /// <param name="eventTime">家族大事记时间</param>
        public Event(int eventID = 1, string genealogyID = "default", string eventContent = "default", string eventTime = "default")
        {
            this.eventID = eventID;
            this.genealogyID = genealogyID;
            this.eventContent = eventContent;
            this.eventTime = eventTime;
        }
    }
}
