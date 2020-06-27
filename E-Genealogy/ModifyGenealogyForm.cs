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
    public partial class ModifyGenealogyForm : Form
    {
        private string genealogyID;
        public ModifyGenealogyForm(string genealogyID)
        {
            this.genealogyID = genealogyID;
            InitializeComponent();
            DisplayInformation();
         }

        private void DisplayInformation()//在界面显示族谱信息  
        {
            //得到Genealogy_ID
            String geneID = genealogyID;

            //连接数据库
            string connString = @"Data Source = .; 
                Initial Catalog = E-Genealogy; 
                User ID = sa; 
                Password = 123456";

            //sql查询语句
            string sql1 = @"SELECT Genealogy_name,Genealogy_Lastname,Genealogy_introduction
                FROM Genealogy WHERE Genealogy_ID = '" + geneID + "'";

            //执行sql语句并捕捉异常
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();
                string name = reader1["Genealogy_name"].ToString();
                string lastName = reader1["Genealogy_Lastname"].ToString();
                string introduction = reader1["Genealogy_introduction"].ToString();
                GenealogyName.Text = name.ToString();
                textBox1.Text = "******".ToString();
                GenealogyLastname.Text = lastName.ToString();
                Introduction.Text = introduction.ToString();
                conn.Close();
            }
            catch (Exception) //当try中有错误则执行catch中的代码,否则不执行
            {
                Console.WriteLine("异常!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String geneID = this.genealogyID; 

            //连接的数据库的信息
            string connString = @"Data Source = .; 
                Initial Catalog = E-Genealogy; 
                User ID = sa; 
                Password = 123456";

            //sql更新语句
            string sql = @"UPDATE Genealogy SET  Genealogy_name = '"+GenealogyName.Text+"'," +
                "Genealogy_Lastname = '"+GenealogyLastname.Text+ "',Genealogy_introduction = '" 
                +Introduction.Text + "'WHERE  Genealogy_ID= '"+ geneID+"' ";

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("族谱已修改成功！");
                conn.Close();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show("修改失败！\n出错原因：" + msg.Message);
            }
            conn.Close();
        }
    }
}
