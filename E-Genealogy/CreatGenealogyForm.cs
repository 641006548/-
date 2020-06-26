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
    public partial class CreatGenealogyForm : Form
    {
        public CreatGenealogyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库
            string connString = @"Data Source = .; 
            Initial Catalog = E-Genealogy; 
            User ID = sa; 
            Password = 123456";

            //sql插入语句
            string sql = @"INSERT INTO  Genealogy VALUES('" + GenealogyID.Text + "','" + GenealogyName.Text + "'" +
                ",'" + GenealogyLastname.Text + "','" + Introduction.Text + "')";

            //执行sql语句并捕捉异常
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("族谱已创建成功！");
                conn.Close();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show("创建失败！\n出错原因：" + msg.Message);
            }

            conn.Close();
        }
    }
}
