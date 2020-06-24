namespace E_Genealogy
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.genealogyIDBOX = new System.Windows.Forms.TextBox();
            this.passwordBOX = new System.Windows.Forms.TextBox();
            this.loginBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genealogyIDBOX
            // 
            this.genealogyIDBOX.ForeColor = System.Drawing.Color.LightGray;
            this.genealogyIDBOX.Location = new System.Drawing.Point(289, 97);
            this.genealogyIDBOX.Name = "genealogyIDBOX";
            this.genealogyIDBOX.Size = new System.Drawing.Size(210, 25);
            this.genealogyIDBOX.TabIndex = 1;
            this.genealogyIDBOX.Text = "族谱ID";
            this.genealogyIDBOX.Enter += new System.EventHandler(this.GenealogyIDBOX_Enter);
            this.genealogyIDBOX.Leave += new System.EventHandler(this.GenealogyIDBOX_Leave);
            // 
            // passwordBOX
            // 
            this.passwordBOX.ForeColor = System.Drawing.Color.LightGray;
            this.passwordBOX.Location = new System.Drawing.Point(289, 176);
            this.passwordBOX.Name = "passwordBOX";
            this.passwordBOX.PasswordChar = '*';
            this.passwordBOX.Size = new System.Drawing.Size(210, 25);
            this.passwordBOX.TabIndex = 2;
            this.passwordBOX.Text = "******";
            this.passwordBOX.Enter += new System.EventHandler(this.PasswordBOX_Enter);
            this.passwordBOX.Leave += new System.EventHandler(this.PasswordBOX_Leave);
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(354, 289);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(75, 23);
            this.loginBT.TabIndex = 0;
            this.loginBT.Text = "登录";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.passwordBOX);
            this.Controls.Add(this.genealogyIDBOX);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genealogyIDBOX;
        private System.Windows.Forms.TextBox passwordBOX;
        private System.Windows.Forms.Button loginBT;
    }
}