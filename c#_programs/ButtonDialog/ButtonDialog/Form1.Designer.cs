namespace ButtonDialog
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonDK = new System.Windows.Forms.Button();
            this.buttonUK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(458, 584);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK!\r\n";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonDK
            // 
            this.buttonDK.Image = global::ButtonDialog.Properties.Resources._60021251_p1;
            this.buttonDK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDK.Location = new System.Drawing.Point(590, 12);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(347, 601);
            this.buttonDK.TabIndex = 1;
            this.buttonDK.Text = "Danish\r\n";
            this.buttonDK.UseVisualStyleBackColor = true;
            this.buttonDK.Click += new System.EventHandler(this.buttonDK_Click);
            // 
            // buttonUK
            // 
            this.buttonUK.Image = global::ButtonDialog.Properties.Resources._60021251_p2;
            this.buttonUK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUK.Location = new System.Drawing.Point(68, 12);
            this.buttonUK.Name = "buttonUK";
            this.buttonUK.Size = new System.Drawing.Size(363, 601);
            this.buttonUK.TabIndex = 0;
            this.buttonUK.Text = "English\r\n";
            this.buttonUK.UseVisualStyleBackColor = true;
            this.buttonUK.Click += new System.EventHandler(this.buttonUK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 668);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDK);
            this.Controls.Add(this.buttonUK);
            this.Name = "Form1";
            this.Text = "Do you speak Danish or English";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUK;
        private System.Windows.Forms.Button buttonDK;
        private System.Windows.Forms.Button buttonOK;
    }
}

