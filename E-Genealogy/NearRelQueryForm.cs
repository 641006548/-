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
    public partial class NearRelQueryForm : Form
    {
        public NearRelQueryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            string name = textB1.Text;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();//连接数据库
            string sql = @"SELECT * FROM Member WHERE Member_name='" + textB1.Text + "'AND Genealogy_ID='" + textB2.Text + "'";//通过成员姓名和族谱ID来进行条件比较
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员不存在！");
                return;
            }
            //查找成功就在相应文本框中输入信息
            textB3.Text = dr["Member_ID"].ToString();
            textB4.Text = dr["Member_sex"].ToString();
            string fatherID = dr["Member_father"].ToString();
            string ID = dr["Member_ID"].ToString();
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name,Member_spouseID FROM Member WHERE Member_ID=" + fatherID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的父亲无法查询！");
                goto InvalidParents;
            }
            string motherID = dr["Member_spouseID"].ToString();
            textB5.Text = "父亲：" + dr["Member_name"].ToString();
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_ID=" + motherID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())//查找提示
            {
                MessageBox.Show("该成员的母亲无法查询！");
                return;
            }
            textB5.Text += "  母亲：" + dr["Member_name"].ToString();
        InvalidParents: conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_sex ='男' AND Member_father=" + fatherID + " AND Member_ID<>" + ID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员同辈男性近亲不存在！");
            }
            else
            {
                textB6.Text = "兄弟：";//连续输出数据
                do
                {
                    textB6.Text += dr["Member_name"].ToString() + "；";
                } while (dr.Read());
            }
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_sex ='女' AND Member_father=" + fatherID + " AND Member_ID<>" + ID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员同辈女性近亲不存在！");

            }
            else
            {
                textB6.Text += "  姐妹：";
                do
                {
                    textB6.Text += dr["Member_name"].ToString() + "；";
                } while (dr.Read());
            }
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_sex ='男' AND Member_father=" + ID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的儿子不存在！");
            }
            else
            {
                textB7.Text = "儿子：";
                do
                {
                    textB7.Text += dr["Member_name"].ToString() + "；";
                } while (dr.Read());
            }
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_sex ='女' AND Member_father=" + ID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的女儿不存在！");
            }
            else
            {
                textB7.Text += "  女儿：";
                do
                {
                    textB7.Text += dr["Member_name"].ToString() + "；";
                } while (dr.Read());
            }
            conn.Close();
        }
    }
}
