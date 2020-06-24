namespace E_Genealogy
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "综合查询（关系树状图）模块入口";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "个人信息查询模块入口";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "近亲查询模块入口";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "族谱管理模块入口";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(283, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "成员管理（添加成员）模块入口";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(424, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(283, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "修改成员模块入口";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

