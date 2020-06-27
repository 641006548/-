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
    public partial class LoginForm : Form
    {
        private Boolean genealogyIDBOXHasText = false;//判断输入框是否有文本
        private Boolean passwordBOXHasText = false;//判断输入框是否有文本
        public LoginForm()
        {
            InitializeComponent();
        }

        private void GenealogyIDBOX_Enter(object sender, EventArgs e)
        {
            if (genealogyIDBOXHasText == false)
                genealogyIDBOX.Text = "";

            genealogyIDBOX.ForeColor = Color.Black;
        }

        private void GenealogyIDBOX_Leave(object sender, EventArgs e)
        {
            if (genealogyIDBOX.Text == "")
            {
                genealogyIDBOX.Text = "族谱ID";
                genealogyIDBOX.ForeColor = Color.LightGray;
                genealogyIDBOXHasText = false;
            }
            else
                genealogyIDBOXHasText = true;
        }

        private void PasswordBOX_Enter(object sender, EventArgs e)
        {
            if (passwordBOXHasText == false)
                passwordBOX.Text = "";

            passwordBOX.ForeColor = Color.Black;
        }

        private void PasswordBOX_Leave(object sender, EventArgs e)
        {
            if (passwordBOX.Text == "")
            {
                passwordBOX.Text = "******";
                passwordBOX.ForeColor = Color.LightGray;
                passwordBOXHasText = false;
            }
            else
                passwordBOXHasText = true;
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {

            string connStr = @"Server=.; Initial Catalog=E-Genealogy; Integrated Security=True";
            string id = genealogyIDBOX.Text;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();//连接数据库
            string sql = @"SELECT * FROM Genealogy WHERE Genealogy_ID='" + genealogyIDBOX.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) 
            {
                MessageBox.Show("族谱ID错误！请重试！","登录出错",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!(passwordBOX.Text == "admin" || passwordBOX.Text == "123456" || passwordBOX.Text == "123"))
            {
                MessageBox.Show("密码错误！请重试！", "登录出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //密码验证通过
            this.Hide();
            MainForm mainForm = new MainForm(this,genealogyIDBOX.Text);
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatGenealogyForm creatGenealogyForm = new CreatGenealogyForm();
            creatGenealogyForm.Show();
        }
    }
}
