namespace TestTreeView
{
    partial class MainForm
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FillTreeView = new System.Windows.Forms.Button();
            this.treeView_Main = new System.Windows.Forms.TreeView();
            this.button_ExpandAll = new System.Windows.Forms.Button();
            this.button_CollapseAll = new System.Windows.Forms.Button();
            this.button_CheckedAll = new System.Windows.Forms.Button();
            this.button_UncheckedAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Location = new System.Drawing.Point(382, 269);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(90, 30);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_FillTreeView
            // 
            this.button_FillTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_FillTreeView.Location = new System.Drawing.Point(12, 233);
            this.button_FillTreeView.Name = "button_FillTreeView";
            this.button_FillTreeView.Size = new System.Drawing.Size(90, 30);
            this.button_FillTreeView.TabIndex = 1;
            this.button_FillTreeView.Text = "Fill TreeView";
            this.button_FillTreeView.UseVisualStyleBackColor = true;
            this.button_FillTreeView.Click += new System.EventHandler(this.button_FillTreeView_Click);
            // 
            // treeView_Main
            // 
            this.treeView_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_Main.CheckBoxes = true;
            this.treeView_Main.Location = new System.Drawing.Point(12, 12);
            this.treeView_Main.Name = "treeView_Main";
            this.treeView_Main.Size = new System.Drawing.Size(460, 215);
            this.treeView_Main.TabIndex = 2;
            this.treeView_Main.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Main_AfterCheck);
            // 
            // button_ExpandAll
            // 
            this.button_ExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ExpandAll.Location = new System.Drawing.Point(12, 269);
            this.button_ExpandAll.Name = "button_ExpandAll";
            this.button_ExpandAll.Size = new System.Drawing.Size(90, 30);
            this.button_ExpandAll.TabIndex = 3;
            this.button_ExpandAll.Text = "Expand All";
            this.button_ExpandAll.UseVisualStyleBackColor = true;
            this.button_ExpandAll.Click += new System.EventHandler(this.button_ExpandAll_Click);
            // 
            // button_CollapseAll
            // 
            this.button_CollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CollapseAll.Location = new System.Drawing.Point(108, 269);
            this.button_CollapseAll.Name = "button_CollapseAll";
            this.button_CollapseAll.Size = new System.Drawing.Size(90, 30);
            this.button_CollapseAll.TabIndex = 4;
            this.button_CollapseAll.Text = "Collapse All";
            this.button_CollapseAll.UseVisualStyleBackColor = true;
            this.button_CollapseAll.Click += new System.EventHandler(this.button_CollapseAll_Click);
            // 
            // button_CheckedAll
            // 
            this.button_CheckedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CheckedAll.Location = new System.Drawing.Point(108, 233);
            this.button_CheckedAll.Name = "button_CheckedAll";
            this.button_CheckedAll.Size = new System.Drawing.Size(90, 30);
            this.button_CheckedAll.TabIndex = 5;
            this.button_CheckedAll.Text = "Checked All";
            this.button_CheckedAll.UseVisualStyleBackColor = true;
            this.button_CheckedAll.Click += new System.EventHandler(this.button_CheckedAll_Click);
            // 
            // button_UncheckedAll
            // 
            this.button_UncheckedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_UncheckedAll.Location = new System.Drawing.Point(204, 233);
            this.button_UncheckedAll.Name = "button_UncheckedAll";
            this.button_UncheckedAll.Size = new System.Drawing.Size(90, 30);
            this.button_UncheckedAll.TabIndex = 6;
            this.button_UncheckedAll.Text = "Unchecked All";
            this.button_UncheckedAll.UseVisualStyleBackColor = true;
            this.button_UncheckedAll.Click += new System.EventHandler(this.button_UncheckedAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button_UncheckedAll);
            this.Controls.Add(this.button_CheckedAll);
            this.Controls.Add(this.button_CollapseAll);
            this.Controls.Add(this.button_ExpandAll);
            this.Controls.Add(this.treeView_Main);
            this.Controls.Add(this.button_FillTreeView);
            this.Controls.Add(this.button_Exit);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test TreeView";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FillTreeView;
        private System.Windows.Forms.TreeView treeView_Main;
        private System.Windows.Forms.Button button_ExpandAll;
        private System.Windows.Forms.Button button_CollapseAll;
        private System.Windows.Forms.Button button_CheckedAll;
        private System.Windows.Forms.Button button_UncheckedAll;
    }
}

