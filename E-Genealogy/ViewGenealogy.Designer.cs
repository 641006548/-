namespace E_Genealogy
{
    partial class ViewGenealogy
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
            this.GenealogyID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Introduction = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenealogyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenealogyLastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenealogyID
            // 
            this.GenealogyID.Location = new System.Drawing.Point(546, 94);
            this.GenealogyID.Name = "GenealogyID";
            this.GenealogyID.Size = new System.Drawing.Size(157, 25);
            this.GenealogyID.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(249, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "族谱ID";
            // 
            // Introduction
            // 
            this.Introduction.Location = new System.Drawing.Point(536, 463);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(425, 165);
            this.Introduction.TabIndex = 48;
            this.Introduction.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(249, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "族谱简介";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(249, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "族谱姓氏";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(420, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 45;
            this.label3.Text = "查看族谱";
            // 
            // GenealogyName
            // 
            this.GenealogyName.Location = new System.Drawing.Point(546, 201);
            this.GenealogyName.Name = "GenealogyName";
            this.GenealogyName.Size = new System.Drawing.Size(157, 25);
            this.GenealogyName.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(249, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "族谱名";
            // 
            // GenealogyLastname
            // 
            this.GenealogyLastname.Location = new System.Drawing.Point(546, 312);
            this.GenealogyLastname.Name = "GenealogyLastname";
            this.GenealogyLastname.Size = new System.Drawing.Size(157, 25);
            this.GenealogyLastname.TabIndex = 41;
            // 
            // ViewGenealogy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 710);
            this.Controls.Add(this.GenealogyID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenealogyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenealogyLastname);
            this.Name = "ViewGenealogy";
            this.Text = "ViewGenealogy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenealogyID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Introduction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GenealogyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenealogyLastname;
    }
}