namespace vhConf3
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbProjects = new System.Windows.Forms.ListBox();
            this.menuProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btApply = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            this.btNewProject = new System.Windows.Forms.Button();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjects
            // 
            this.lbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProjects.ContextMenuStrip = this.menuProjects;
            this.lbProjects.FormattingEnabled = true;
            this.lbProjects.Location = new System.Drawing.Point(12, 12);
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.Size = new System.Drawing.Size(310, 446);
            this.lbProjects.Sorted = true;
            this.lbProjects.TabIndex = 0;
            this.lbProjects.DoubleClick += new System.EventHandler(this.lbProjects_DoubleClick);
            // 
            // menuProjects
            // 
            this.menuProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entfernenToolStripMenuItem});
            this.menuProjects.Name = "menuProjects";
            this.menuProjects.Size = new System.Drawing.Size(126, 26);
            this.menuProjects.Opened += new System.EventHandler(this.menuProjects_Opened);
            // 
            // btApply
            // 
            this.btApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btApply.AutoSize = true;
            this.btApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btApply.Image = global::ApacheVhostsManager.Properties.Resources.page_go;
            this.btApply.Location = new System.Drawing.Point(261, 472);
            this.btApply.Name = "btApply";
            this.btApply.Padding = new System.Windows.Forms.Padding(1);
            this.btApply.Size = new System.Drawing.Size(61, 25);
            this.btApply.TabIndex = 3;
            this.btApply.Text = "Apply";
            this.btApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btOptions
            // 
            this.btOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOptions.AutoSize = true;
            this.btOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOptions.Image = global::ApacheVhostsManager.Properties.Resources.cog;
            this.btOptions.Location = new System.Drawing.Point(184, 472);
            this.btOptions.Name = "btOptions";
            this.btOptions.Padding = new System.Windows.Forms.Padding(1);
            this.btOptions.Size = new System.Drawing.Size(71, 25);
            this.btOptions.TabIndex = 2;
            this.btOptions.Text = "Options";
            this.btOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOptions.UseVisualStyleBackColor = true;
            this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
            // 
            // btNewProject
            // 
            this.btNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNewProject.AutoSize = true;
            this.btNewProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btNewProject.Image = global::ApacheVhostsManager.Properties.Resources.add;
            this.btNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewProject.Location = new System.Drawing.Point(12, 472);
            this.btNewProject.Name = "btNewProject";
            this.btNewProject.Padding = new System.Windows.Forms.Padding(1);
            this.btNewProject.Size = new System.Drawing.Size(93, 25);
            this.btNewProject.TabIndex = 1;
            this.btNewProject.Text = "New Project";
            this.btNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNewProject.UseVisualStyleBackColor = true;
            this.btNewProject.Click += new System.EventHandler(this.btNewProject_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Image = global::ApacheVhostsManager.Properties.Resources.delete;
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 509);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btOptions);
            this.Controls.Add(this.btNewProject);
            this.Controls.Add(this.lbProjects);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 220);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApacheVhostsManager";
            this.menuProjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProjects;
        private System.Windows.Forms.Button btNewProject;
        private System.Windows.Forms.Button btOptions;
        private System.Windows.Forms.Button btApply;
		private System.Windows.Forms.ContextMenuStrip menuProjects;
		private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
    }
}

