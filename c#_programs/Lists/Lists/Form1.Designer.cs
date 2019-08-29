namespace Lists
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
            this.buttonMove = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.checkedListBoxPossibleValues = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonMove.ForeColor = System.Drawing.Color.Black;
            this.buttonMove.Location = new System.Drawing.Point(320, 181);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(150, 70);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 15;
            this.listBoxSelected.Location = new System.Drawing.Point(487, 12);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(301, 409);
            this.listBoxSelected.TabIndex = 1;
            // 
            // checkedListBoxPossibleValues
            // 
            this.checkedListBoxPossibleValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxPossibleValues.CheckOnClick = true;
            this.checkedListBoxPossibleValues.FormattingEnabled = true;
            this.checkedListBoxPossibleValues.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"});
            this.checkedListBoxPossibleValues.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPossibleValues.Name = "checkedListBoxPossibleValues";
            this.checkedListBoxPossibleValues.Size = new System.Drawing.Size(288, 404);
            this.checkedListBoxPossibleValues.TabIndex = 2;
            this.checkedListBoxPossibleValues.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPossibleValues_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxPossibleValues);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.buttonMove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.CheckedListBox checkedListBoxPossibleValues;
    }
}

