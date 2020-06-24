using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Genealogy
{
    /// <summary>
    /// 此类用于定义“家训”数据类型；可依照个人需求扩展成员方法。
    /// </summary>
    class FamilyInstruction
    {
        private int familyInstructionID;
        private string familyInstructionContent;

        public int FamilyInstructionID { get => familyInstructionID; set => familyInstructionID = value; }
        public string FamilyInstructionContent { get => familyInstructionContent; set => familyInstructionContent = value; }

        /// <summary>
        /// 构造一个FamilyInstruction类数据
        /// </summary>
        /// <param name="familyInstructionID">家训编号</param>
        /// <param name="familyInstructionContent">家训内容</param>
        public FamilyInstruction(int familyInstructionID = 1, string familyInstructionContent = "default")
        {
            this.familyInstructionID = familyInstructionID;
            this.familyInstructionContent = familyInstructionContent;
        }
    }
}
