using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Genealogy
{
    /// <summary>
    /// 此类用于定义“族谱”数据类型；可依照个人需求扩展成员方法。
    /// </summary>
    class Genealogy
    {
        private string genealogyID;
        private string genealogyName;
        private string genealogyLastName;
        private string genealogyIntroduction;

        public string GenealogyID { get => genealogyID; set => genealogyID = value; }
        public string GenealogyName { get => genealogyName; set => genealogyName = value; }
        public string GenealogyLastName { get => genealogyLastName; set => genealogyLastName = value; }
        public string GenealogyIntroduction { get => genealogyIntroduction; set => genealogyIntroduction = value; }

        /// <summary>
        /// 构造一个Genealogy类数据。
        /// </summary>
        /// <param name="genealogyID">族谱ID</param>
        /// <param name="genealogyName">族谱名</param>
        /// <param name="genealogyLastName">族谱姓氏</param>
        /// <param name="genealogyIntroduction">族谱简介</param>
        public Genealogy(string genealogyID, string genealogyName = "default",
            string genealogyLastName = "default", string genealogyIntroduction = "default")
        {
            this.genealogyID = genealogyID;
            this.genealogyName = genealogyName;
            this.genealogyLastName = genealogyLastName;
            this.genealogyIntroduction = genealogyIntroduction;
        }

        
    }
}
