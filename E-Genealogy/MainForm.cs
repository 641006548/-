using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Genealogy
{
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm;
        public MainForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.loginForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
         MemberManage mm = new MemberManage();
         mm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenealogyForm genealogyForm = new GenealogyForm();
            genealogyForm.Show();
        }
    }
}
