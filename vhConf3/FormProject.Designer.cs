namespace vhConf3 {
	partial class FormProject {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbProjectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPublicPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.lbDomains = new System.Windows.Forms.ListBox();
            this.popupDomains = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPublicPath = new System.Windows.Forms.Button();
            this.btnProjectPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.gvOptions = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popupDomains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projectname";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectName.Location = new System.Drawing.Point(12, 25);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(321, 20);
            this.tbProjectName.TabIndex = 1;
            // 
            // tbProjectPath
            // 
            this.tbProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectPath.Location = new System.Drawing.Point(12, 74);
            this.tbProjectPath.Name = "tbProjectPath";
            this.tbProjectPath.Size = new System.Drawing.Size(291, 20);
            this.tbProjectPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project path";
            // 
            // tbPublicPath
            // 
            this.tbPublicPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPublicPath.Location = new System.Drawing.Point(12, 123);
            this.tbPublicPath.Name = "tbPublicPath";
            this.tbPublicPath.Size = new System.Drawing.Size(291, 20);
            this.tbPublicPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Domains";
            // 
            // tbDomain
            // 
            this.tbDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomain.Location = new System.Drawing.Point(83, 327);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(220, 20);
            this.tbDomain.TabIndex = 7;
            this.tbDomain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDomain_KeyPress);
            // 
            // lbDomains
            // 
            this.lbDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDomains.ContextMenuStrip = this.popupDomains;
            this.lbDomains.FormattingEnabled = true;
            this.lbDomains.Location = new System.Drawing.Point(12, 172);
            this.lbDomains.Name = "lbDomains";
            this.lbDomains.Size = new System.Drawing.Size(321, 147);
            this.lbDomains.TabIndex = 6;
            // 
            // popupDomains
            // 
            this.popupDomains.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRemove});
            this.popupDomains.Name = "popupDomains";
            this.popupDomains.Size = new System.Drawing.Size(126, 26);
            this.popupDomains.Opened += new System.EventHandler(this.popupDomains_Opened);
            // 
            // menuItemRemove
            // 
            this.menuItemRemove.Image = global::ApacheVhostsManager.Properties.Resources.delete;
            this.menuItemRemove.Name = "menuItemRemove";
            this.menuItemRemove.Size = new System.Drawing.Size(125, 22);
            this.menuItemRemove.Text = "Entfernen";
            this.menuItemRemove.Click += new System.EventHandler(this.menuItemRemove_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Properties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "New Domain";
            // 
            // btnPublicPath
            // 
            this.btnPublicPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublicPath.AutoSize = true;
            this.btnPublicPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPublicPath.Image = global::ApacheVhostsManager.Properties.Resources.folder;
            this.btnPublicPath.Location = new System.Drawing.Point(309, 123);
            this.btnPublicPath.Name = "btnPublicPath";
            this.btnPublicPath.Padding = new System.Windows.Forms.Padding(1);
            this.btnPublicPath.Size = new System.Drawing.Size(24, 24);
            this.btnPublicPath.TabIndex = 5;
            this.btnPublicPath.UseVisualStyleBackColor = true;
            this.btnPublicPath.Click += new System.EventHandler(this.btnPublicPath_Click);
            // 
            // btnProjectPath
            // 
            this.btnProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectPath.AutoSize = true;
            this.btnProjectPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProjectPath.Image = global::ApacheVhostsManager.Properties.Resources.folder;
            this.btnProjectPath.Location = new System.Drawing.Point(309, 74);
            this.btnProjectPath.Name = "btnProjectPath";
            this.btnProjectPath.Padding = new System.Windows.Forms.Padding(1);
            this.btnProjectPath.Size = new System.Drawing.Size(24, 24);
            this.btnProjectPath.TabIndex = 3;
            this.btnProjectPath.UseVisualStyleBackColor = true;
            this.btnProjectPath.Click += new System.EventHandler(this.btnProjectPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::ApacheVhostsManager.Properties.Resources.accept;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(438, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(1);
            this.btnSave.Size = new System.Drawing.Size(60, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ApacheVhostsManager.Properties.Resources.delete;
            this.btnCancel.Location = new System.Drawing.Point(504, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(1);
            this.btnCancel.Size = new System.Drawing.Size(68, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDomain.AutoSize = true;
            this.btnAddDomain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddDomain.Image = global::ApacheVhostsManager.Properties.Resources.add;
            this.btnAddDomain.Location = new System.Drawing.Point(309, 326);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddDomain.Size = new System.Drawing.Size(24, 24);
            this.btnAddDomain.TabIndex = 8;
            this.btnAddDomain.UseVisualStyleBackColor = true;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // gvOptions
            // 
            this.gvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.valueColumn});
            this.gvOptions.Location = new System.Drawing.Point(352, 25);
            this.gvOptions.Name = "gvOptions";
            this.gvOptions.RowHeadersVisible = false;
            this.gvOptions.Size = new System.Drawing.Size(220, 294);
            this.gvOptions.TabIndex = 16;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.gvOptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPublicPath);
            this.Controls.Add(this.btnProjectPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbDomains);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.btnAddDomain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPublicPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProjectPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.FormProject_Load);
            this.popupDomains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbProjectName;
		private System.Windows.Forms.TextBox tbProjectPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPublicPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddDomain;
		private System.Windows.Forms.TextBox tbDomain;
		private System.Windows.Forms.ListBox lbDomains;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnProjectPath;
		private System.Windows.Forms.Button btnPublicPath;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ContextMenuStrip popupDomains;
		private System.Windows.Forms.ToolStripMenuItem menuItemRemove;
        private System.Windows.Forms.DataGridView gvOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
	}
}