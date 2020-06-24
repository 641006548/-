using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Genealogy
{
    /// <summary>
    /// 此类用于定义“家族成员”数据类型；可依照个人需求扩展成员方法。
    /// </summary>
    class Member
    {
        private string memberID;
        private string genealogyID;
        private string memberName;
        private string memberSex;
        private string memberLive;
        private string spouseID;
        private string memberFather;
        private string memberAddress;
        private string memberOrigin;
        private string memberBirth;
        private string memberDied;

        public string MemberID { get => memberID; set => memberID = value; }
        public string GenealogyID { get => genealogyID; set => genealogyID = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public string MemberSex { get => memberSex; set => memberSex = value; }
        public string MemberLive { get => memberLive; set => memberLive = value; }
        public string SpouseID { get => spouseID; set => spouseID = value; }
        public string MemberFather { get => memberFather; set => memberFather = value; }
        public string MemberAddress { get => memberAddress; set => memberAddress = value; }
        public string MemberOrigin { get => memberOrigin; set => memberOrigin = value; }
        public string MemberBirth { get => memberBirth; set => memberBirth = value; }
        public string MemberDied { get => memberDied; set => memberDied = value; }


        /// <summary>
        /// 构造一个Member类数据。
        /// </summary>
        /// <param name="memberID">成员ID</param>
        /// <param name="genealogyID">成员所属族谱ID</param>
        /// <param name="memberName">成员姓名</param>
        /// <param name="memberSex">性别</param>
        /// <param name="memberLive">居住地</param>
        /// <param name="spouseID">配偶ID</param>
        /// <param name="memberFather">父亲ID</param>
        /// <param name="memberAddress">家庭住址（户口簿）</param>
        /// <param name="memberOrigin">出生地</param>
        /// <param name="memberBirth">生日日期</param>
        /// <param name="memberDied">死亡日期</param>
        public Member(string memberID, string genealogyID = "default", string memberName = "张三", string memberSex = "男", string memberLive = "default",
            string spouseID = "0000", string memberFather = "default", string memberAddress = "default",
            string memberOrigin = "default", string memberBirth = "default", string memberDied = "default")
        {
            this.memberID = memberID;
            this.genealogyID = genealogyID;
            this.memberName = memberName;
            this.memberSex = memberSex;
            this.memberLive = memberLive;
            this.spouseID = spouseID;
            this.memberFather = memberFather;
            this.memberAddress = memberAddress;
            this.memberOrigin = memberOrigin;
            this.memberBirth = memberBirth;
            this.memberDied = memberDied;
        }
    }
}
