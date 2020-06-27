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
    public partial class PerInfQueryForm : Form
    {
        public PerInfQueryForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();//连接数据库
            string sql = @"SELECT * FROM Member WHERE Member_name='" + textBox1.Text + "'AND Genealogy_ID='" + textBox2.Text + "'";//通过成员姓名和族谱ID来进行条件比较
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员不存在！");
                return;
            }
            //查找成功就在相应文本框中输入信息
            textBox3.Text = dr["Member_ID"].ToString();
            textBox4.Text = dr["Member_sex"].ToString();
            textBox8.Text = dr["Member_birth"].ToString();
            textBox9.Text = dr["Member_died"].ToString();
            textBox10.Text = dr["Member_address"].ToString();
            textBox11.Text = dr["Member_live"].ToString();
            string fatherID= dr["Member_father"].ToString();
            string spouseID = dr["Member_spouseID"].ToString();
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_ID=" + spouseID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的配偶无法查询！");
                return;
            }
            textBox7.Text = dr["Member_name"].ToString();
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name,Member_spouseID FROM Member WHERE Member_ID=" + fatherID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的父亲无法查询！");
                return;
            }
            string motherID= dr["Member_spouseID"].ToString();
            textBox5.Text = dr["Member_name"].ToString();
            conn.Close();
            conn.Open();
            sql = @"SELECT Member_name FROM Member WHERE Member_ID=" + motherID;
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该成员的母亲无法查询！");
                return;
            }
            textBox6.Text = dr["Member_name"].ToString();
            conn.Close();
        }
    }
}
