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
			this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btNewProject = new System.Windows.Forms.Button();
			this.btOptions = new System.Windows.Forms.Button();
			this.btApply = new System.Windows.Forms.Button();
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
			// entfernenToolStripMenuItem
			// 
			this.entfernenToolStripMenuItem.Image = global::vhConf3.Properties.Resources.delete;
			this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
			this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.entfernenToolStripMenuItem.Text = "Entfernen";
			this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
			// 
			// btNewProject
			// 
			this.btNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btNewProject.Location = new System.Drawing.Point(12, 474);
			this.btNewProject.Name = "btNewProject";
			this.btNewProject.Size = new System.Drawing.Size(90, 23);
			this.btNewProject.TabIndex = 1;
			this.btNewProject.Text = "Neues Projekt";
			this.btNewProject.UseVisualStyleBackColor = true;
			this.btNewProject.Click += new System.EventHandler(this.btNewProject_Click);
			// 
			// btOptions
			// 
			this.btOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btOptions.Location = new System.Drawing.Point(166, 474);
			this.btOptions.Name = "btOptions";
			this.btOptions.Size = new System.Drawing.Size(75, 23);
			this.btOptions.TabIndex = 2;
			this.btOptions.Text = "Optionen";
			this.btOptions.UseVisualStyleBackColor = true;
			this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
			// 
			// btApply
			// 
			this.btApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btApply.Location = new System.Drawing.Point(247, 474);
			this.btApply.Name = "btApply";
			this.btApply.Size = new System.Drawing.Size(75, 23);
			this.btApply.TabIndex = 3;
			this.btApply.Text = "Anwenden";
			this.btApply.UseVisualStyleBackColor = true;
			this.btApply.Click += new System.EventHandler(this.btApply_Click);
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
			this.Text = "vhConf3";
			this.menuProjects.ResumeLayout(false);
			this.ResumeLayout(false);

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

