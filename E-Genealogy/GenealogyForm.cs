using System;
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
    public partial class GenealogyForm : Form
    {
        private string genealogyID;
        public int i = 0;
        public GenealogyForm()
        {
            InitializeComponent();
        }
        public string GetGeneaID { get => genealogyID; set => genealogyID = value; }

        public int CloseMainForm()
        {
            return i;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String geneID = GetGeneaID;//得到Genealogy_ID

            //提醒是否确认删除
            DialogResult dr = MessageBox.Show("真的要删除吗？",
               "提醒",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation);

            //确认后删除进行删除
            if (dr.Equals(DialogResult.Yes))
            {
                //连接数据库
                string connString = @"Data Source = .; 
                Initial Catalog = E-Genealogy; 
                User ID = sa; 
                Password = 123456";

                //sql删除语句
                string sql1 = @"DELETE  FROM  Member WHERE Genealogy_ID = '" + geneID + "';";
                string sql2 = @"DELETE  FROM  FamilyInstruction WHERE Genealogy_ID = '" + geneID + "';";
                string sql3 = @"DELETE  FROM  Event WHERE Genealogy_ID = '" + geneID + "';";
                string sql4 = @"DELETE  FROM  Genealogy WHERE Genealogy_ID = '" + geneID + "';";

                //执行sql语句并捕捉异常
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                try
                {
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd4 = new SqlCommand(sql4, conn);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("族谱已删除成功,请重新注册登录！");
                    conn.Close();
                    i = 1;
                    this.Close();
                    Application.Exit();
                }
                catch (Exception msg)
                {
                    MessageBox.Show("删除失败！\n出错原因：" + msg.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//点击修改族谱跳转到修改族谱界面
        {
            ModifyGenealogyForm modifyGenealogyForm = new ModifyGenealogyForm(this.genealogyID);
            modifyGenealogyForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewGenealogy view = new ViewGenealogy(this.genealogyID);
            view.Show();
        }
    }
}
