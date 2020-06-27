using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Genealogy
{
    public partial class GenealogyTreeView : Form
    {
        private string genealogyID;
        public GenealogyTreeView(string genealogyID)
        {
            this.genealogyID = genealogyID;
            InitializeComponent();
        }

        struct member
        {
            public string memberID;
            public string memberName;
            public string spouseID;
            public string fatherID;
            public int GenerationFlag;
            public int RankFlag;
        };

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            int Curent = 0;
            int i = 0;
            string spouseName = "无";
            member[] Member = new member[100];
            int RankMemberFlag = 1;
            int[] RankMember = new int[10];
            for (int j = 0; j < 10; j++)
            {
                RankMember[j] = 1;
            }
            string FatherMemberID;          //当前成员的父亲ID
            string FatherMemberName;        //当前成员的父亲姓名
            int FatherGenerationFlag;       //当前成员的父亲所处辈分
            string CurentMemberName;        //当前成员姓名
            string CurentMemberID;          //当前成员ID
            int CurentFlag = 1;                 //当前标志
            int CurentGeneration = 2;
            int midCountFlag = 0;   //画中间结点时用到的偏移量
            int subCountFlag = 0;   //画顶层结点时用到的偏移量
            int x = 0;              //结点矩形图左上角X坐标
            int y = 0;              //结点矩形图左上角Y坐标
            int picX = this.Width;   //绘图区域水平长度
            int picY = pictureBox1.Height;  //绘图区域竖直长度
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            Rectangle rect;         //结点矩形图
            Point loc;              //结点矩形图左上角坐标
            Point startP;           //连接线起始坐标
            Point endP;             //连接线终止坐标
            Point tempP = new Point();   //坐标缓存量
            SizeF sizeF;            //结点内容尺寸大小
            Size s;
            Font font = new Font("宋体", 18);     //结点内容的字体
            Pen blackPen = new Pen(Color.Black, 2);   //连线需要的画笔
            Graphics g = e.Graphics;
            g.Clear(Color.White);         //每次重绘先把绘图区域清空

            int MemberCount = 0;
            int BroCount = 0;
            int ChildCount = 0;
            ArrayList midTree = new ArrayList();
            int midTreeCount;
            string parentTree;     //树状图顶端
            string memberFather;   //用于存储父亲ID
            string memberID;       //用于存储个人ID
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = @"SELECT * FROM Member WHERE Genealogy_ID = '"+ this.genealogyID +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())                                   //将数据库中的数据保存在结构体中
            {
                Member[Curent].memberName = dr["Member_name"].ToString();
                Member[Curent].memberID = dr["Member_ID"].ToString();
                Member[Curent].spouseID = dr["Member_spouseID"].ToString();
                Member[Curent].fatherID = dr["Member_father"].ToString();
                Member[Curent].GenerationFlag = 0;
                Member[Curent].RankFlag = 0;
                Curent++;
            }
            MemberCount = Curent;

            Member[0].GenerationFlag = 1;
            Member[0].RankFlag = 1;


            string parentMember_memberID = Member[0].memberID;
            string parentMember_spouseID = Member[0].spouseID;

            for (Curent = 0; Curent < MemberCount - 1; Curent++)              //寻找第一代的配偶
            {
                if (Member[Curent].spouseID == Member[0].memberID)
                {
                    spouseName = Member[Curent].memberName;
                }
            }
            int picXMid = picX / 2;                                 //得到屏幕水平中央的位置
            sizeF = g.MeasureString(Member[0].memberName, font);    //得到字体的长度和宽度
            sizeF.Width += 10;                                      //为了使矩形框与字体不显得紧凑
            s = sizeF.ToSize();
            x = picXMid - s.Width * 2;
            y = 30;
            loc = new Point(x, y);
            rect = new Rectangle(loc, s);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString(Member[0].memberName, font, Brushes.Black, rect, sf);

            x = x + s.Width;
            loc = new Point(x, y);
            rect = new Rectangle(loc, s);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString(spouseName, font, Brushes.Black, rect, sf);

            startP = new Point(rect.X, y + s.Height);
            
            Curent = 0;
            FatherMemberID = Member[0].memberID;
            FatherGenerationFlag = Member[0].GenerationFlag;

            while (CurentFlag <= (MemberCount-2))
            {

                /*FatherMemberID = Member[CurentFlag-1].memberID;
                FatherGenerationFlag = Member[CurentFlag-1].GenerationFlag;*/

                for (i = 1; i < MemberCount; i++)
                {
                    if (Member[i].fatherID == FatherMemberID && Member[i].GenerationFlag == 0)
                    {
                        Member[i].GenerationFlag = FatherGenerationFlag + 1;
                        Member[i].RankFlag = RankMember[Member[i].GenerationFlag];
                        RankMember[Member[i].GenerationFlag]++;

                        CurentMemberName = Member[i].memberName;
                        CurentMemberID = Member[i].memberID;
                        sizeF = g.MeasureString(CurentMemberName, font);
                        sizeF.Width += 10;
                        s = sizeF.ToSize();
                        x = 50 + (Member[i].RankFlag - 1) * 155;                        //得到当前矩形的左上横坐标
                        y = 100 + (Member[i].GenerationFlag - 2) * 100;                 //得到当前矩形的左上纵坐标
                        endP = new Point(x + s.Width / 2, y);                           //得到直线末端的坐标
                        loc = new Point(x, y);
                        rect = new Rectangle(loc, s);
                        g.DrawRectangle(Pens.Black, rect);
                        g.DrawString(CurentMemberName, font, Brushes.Black, rect, sf);
                        g.DrawLine(blackPen, startP, endP);
                        /*FatherMemberID = Member[i].memberID;
                        FatherGenerationFlag = Member[i].GenerationFlag;*/
                        CurentFlag++;

                        if (Member[i].spouseID != null)                                 //查看该成员是否有配偶
                        {
                            for (int j = 0; j < MemberCount; j++)
                            {
                                if (Member[j].memberID == Member[i].spouseID)
                                {
                                    Member[j].GenerationFlag = FatherGenerationFlag + 1;
                                    CurentMemberName = Member[j].memberName;
                                    sizeF = g.MeasureString(CurentMemberName, font);
                                    sizeF.Width += 10;
                                    s = sizeF.ToSize();
                                    x = x+s.Width;                        
                                    y = 100 + (Member[j].GenerationFlag - 2) * 100;    
                                    loc = new Point(x, y);
                                    rect = new Rectangle(loc, s);
                                    g.DrawRectangle(Pens.Black, rect);
                                    g.DrawString(CurentMemberName, font, Brushes.Black, rect, sf);
                                    CurentFlag++;
                                }
                            }
                        }
                    }

                }
                
                    for (int j = 0; j < MemberCount; j++)
                    {
                        if (Member[j].RankFlag == RankMemberFlag && Member[j].GenerationFlag == CurentGeneration)
                        {
                            FatherMemberID = Member[j].memberID;
                            FatherGenerationFlag = Member[j].GenerationFlag;
                            RankMemberFlag++;
                            startP = new Point(50 + (Member[j].RankFlag - 1) * 155 + s.Width / 2, 100 + (Member[j].GenerationFlag - 2) * 100 + s.Height);
                            break;
                        }
                    }
                if (RankMemberFlag > RankMember[CurentGeneration])
                {
                    RankMemberFlag = 1;
                    CurentGeneration++;
                }
            }


        }
    }
}
