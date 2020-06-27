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
    public partial class ViewGenealogy : Form
    {
        private string genealogyID;
        public ViewGenealogy(string genealogyID)
        {
            this.genealogyID = genealogyID;
            InitializeComponent();
            DisplayInformation();
        }

        private void DisplayInformation()//在界面显示族谱信息  
        {
            //得到genealogy_ID
            String geneID = genealogyID;

            //连接数据库
            string connString = @"Data Source = .; 
                Initial Catalog = E-Genealogy; 
                User ID = sa; 
                Password = 123456";

            //sql查询语句
            string sql1 = @"SELECT Genealogy_name,Genealogy_Lastname,Genealogy_introduction,Genealogy_ID
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
                string id = reader1["Genealogy_ID"].ToString();
                GenealogyName.Text = name.ToString();
                GenealogyID.Text = id.ToString();
                GenealogyLastname.Text = lastName.ToString();
                Introduction.Text = introduction.ToString();
                conn.Close();
            }
            catch (Exception) //当try中有错误则执行catch中的代码,否则不执行
            {
                Console.WriteLine("异常!");
            }
            GenealogyName.ReadOnly = true;
            GenealogyID.ReadOnly = true;
            GenealogyLastname.ReadOnly = true;
            Introduction.ReadOnly = true;
        }
    }
}
