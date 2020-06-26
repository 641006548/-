namespace E_Genealogy
{
    partial class CreatGenealogyForm
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
            this.Introduction = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenealogyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenealogyLastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GenealogyPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenealogyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Introduction
            // 
            this.Introduction.Location = new System.Drawing.Point(414, 460);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(425, 165);
            this.Introduction.TabIndex = 37;
            this.Introduction.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(239, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "族谱简介";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(715, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "族谱姓氏";
            // 
            // GenealogyName
            // 
            this.GenealogyName.Location = new System.Drawing.Point(397, 293);
            this.GenealogyName.Name = "GenealogyName";
            this.GenealogyName.Size = new System.Drawing.Size(157, 25);
            this.GenealogyName.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(239, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "族谱名";
            // 
            // GenealogyLastname
            // 
            this.GenealogyLastname.Location = new System.Drawing.Point(921, 293);
            this.GenealogyLastname.Name = "GenealogyLastname";
            this.GenealogyLastname.Size = new System.Drawing.Size(157, 25);
            this.GenealogyLastname.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(992, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "创建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenealogyPassword
            // 
            this.GenealogyPassword.Location = new System.Drawing.Point(921, 129);
            this.GenealogyPassword.Name = "GenealogyPassword";
            this.GenealogyPassword.Size = new System.Drawing.Size(157, 25);
            this.GenealogyPassword.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(715, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "族谱密码";
            // 
            // GenealogyID
            // 
            this.GenealogyID.Location = new System.Drawing.Point(397, 128);
            this.GenealogyID.Name = "GenealogyID";
            this.GenealogyID.Size = new System.Drawing.Size(157, 25);
            this.GenealogyID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(239, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "族谱ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(552, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "创建族谱";
            // 
            // CreatGenealogyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 752);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenealogyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenealogyLastname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenealogyPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenealogyID);
            this.Controls.Add(this.label1);
            this.Name = "CreatGenealogyForm";
            this.Text = "CreatGenealogyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Introduction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GenealogyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GenealogyLastname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GenealogyPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenealogyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}