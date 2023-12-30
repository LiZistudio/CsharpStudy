namespace Class005_Identifiers
{
    partial class Form1
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
            this.MyTextBox = new System.Windows.Forms.TextBox();
            this.MyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyTextBox
            // 
            this.MyTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyTextBox.Location = new System.Drawing.Point(125, 108);
            this.MyTextBox.Name = "MyTextBox";
            this.MyTextBox.Size = new System.Drawing.Size(275, 31);
            this.MyTextBox.TabIndex = 0;
            this.MyTextBox.Text = "hello";
            // 
            // MyButton
            // 
            this.MyButton.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyButton.Location = new System.Drawing.Point(147, 224);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(227, 60);
            this.MyButton.TabIndex = 1;
            this.MyButton.Text = "Click Me";
            this.MyButton.UseVisualStyleBackColor = true;
            this.MyButton.Click += new System.EventHandler(this.MyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.MyButton);
            this.Controls.Add(this.MyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MyTextBox;
        private System.Windows.Forms.Button MyButton;
    }
}

