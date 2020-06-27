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
        private string genealogyID;
        private readonly LoginForm loginForm;
        public MainForm(LoginForm loginForm, string genealogyID)
        {
            this.loginForm = loginForm;
            this.genealogyID = genealogyID;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.loginForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenealogyTreeView genealogyTreeView = new GenealogyTreeView(this.genealogyID)
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            mainPanel.Controls.Add(genealogyTreeView);
            genealogyTreeView.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            PerInfQueryForm perInfQuery = new PerInfQueryForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            mainPanel.Controls.Add(perInfQuery);
            perInfQuery.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NearRelQueryForm nearRelQuery = new NearRelQueryForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            mainPanel.Controls.Add(nearRelQuery);
            nearRelQuery.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GenealogyForm genealogyForm = new GenealogyForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            genealogyForm.GetGeneaID = this.genealogyID;
            mainPanel.Controls.Add(genealogyForm);
            genealogyForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            MemberManage mm = new MemberManage
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            mainPanel.Controls.Add(mm);
            mm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mainPanel.Width = this.Width - treeViewPanel.Width;
            this.mainPanel.Height = this.Height;
            mainPanel.Location = new Point(treeViewPanel.Location.X + treeViewPanel.Width, 0);
        }

        private void mainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (mainPanel.Controls.Count > 1)
            {
                mainPanel.Controls.RemoveAt(0);
            }
            this.Text = "电子族谱 (" + mainPanel.Controls[0].Text + ")";
        }
    }
}
