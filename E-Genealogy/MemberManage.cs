using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace E_Genealogy
{
    public partial class MemberManage : Form
    {
        public MemberManage()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            string id = txtB2.Text;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();//连接数据库
            string sql = @"SELECT * FROM Member WHERE Member_ID='" + txtB2.Text + "'AND Genealogy_ID='"+txtB1.Text+"'";//通过成员ID和族谱ID来进行条件比较
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员不存在！");
                return;
            }
            //查找成功就在相应文本框中输入信息
            txtB3.Text = dr["Member_ID"].ToString();
            txtB4.Text = dr["Member_name"].ToString();
            txtB5.Text = dr["Member_sex"].ToString();
            txtB6.Text = dr["Member_birth"].ToString();
            txtB7.Text = dr["Member_died"].ToString();
            txtB8.Text = dr["Member_origin"].ToString();
            txtB9.Text = dr["Member_address"].ToString();
            txtB10.Text = dr["Member_live"].ToString();
            txtB11.Text = dr["Member_father"].ToString();
            txtB12.Text = dr["Member_spouseID"].ToString();
            txtB13.Text = dr["Genealogy_ID"].ToString();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "insert into Member(Member_ID,Member_name,Member_sex,Member_live,Member_spouseID,Member_father,Member_address,Member_origin,Member_birth,Member_died,Genealogy_ID) values('" + txtB3.Text + "', '" + txtB4.Text + "', '" + txtB5.Text + "', '" + txtB10.Text + "', '" + txtB12.Text + "', '" + txtB11.Text + "', '" + txtB9.Text + "', '" + txtB8.Text + "', '" + txtB6.Text + "', '" + txtB7.Text + "', '" + txtB13.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("信息已存入数据库！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("出问题了！\n出错原因：" + msg.Message);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = @"UPDATE Member SET [Member_name]='" + txtB4.Text + "',[Member_sex]='" + txtB5.Text + "',[Member_birth]='" + txtB6.Text + "',[Member_died]='" + txtB7.Text + "',[Member_origin]='" + txtB8.Text + "',[Member_address]='" + txtB9.Text + "',[Member_live]='" + txtB10.Text + "',[Member_father]='" + txtB11.Text + "',[Member_spouseID]='" + txtB12.Text + "'";
            sql += " WHERE [Member_ID]='" + txtB2.Text + "'";                                                
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("成员信息修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新出错！" + ex.Message);
            }
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag = false;//作为标志信息
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            string id = txtB2.Text;//通过成员ID这个主键来进行条件比较
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = @"DELETE FROM Member WHERE Member_ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(id + "号学生删除成功！");
                flag = true;//删除成功，标志变为true
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除出错！" + ex.Message);
            }
            conn.Close();
            //删除成功后将文本框内容变为“***”，覆盖掉原来信息
            if(flag)
            {
                txtB3.Text = "***";
                txtB4.Text = "***";
                txtB5.Text = "***";
                txtB6.Text = "***";
                txtB7.Text = "***";
                txtB8.Text = "***";
                txtB9.Text = "***";
                txtB10.Text = "***";
                txtB11.Text = "***";
                txtB12.Text = "***";
                txtB13.Text = "***";
            }

        }
    }
}
