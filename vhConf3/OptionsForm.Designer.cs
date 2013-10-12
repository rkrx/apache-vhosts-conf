namespace vhConf3 {
    partial class FormOptions {
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
			this.tbVhosts = new System.Windows.Forms.TextBox();
			this.tbWwwRoot = new System.Windows.Forms.TextBox();
			this.tbHosts = new System.Windows.Forms.TextBox();
			this.tbApacheBin = new System.Windows.Forms.TextBox();
			this.tbExtra = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbVhosts
			// 
			this.tbVhosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbVhosts.Location = new System.Drawing.Point(12, 25);
			this.tbVhosts.Name = "tbVhosts";
			this.tbVhosts.Size = new System.Drawing.Size(414, 20);
			this.tbVhosts.TabIndex = 1;
			// 
			// tbWwwRoot
			// 
			this.tbWwwRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWwwRoot.Location = new System.Drawing.Point(12, 74);
			this.tbWwwRoot.Name = "tbWwwRoot";
			this.tbWwwRoot.Size = new System.Drawing.Size(414, 20);
			this.tbWwwRoot.TabIndex = 3;
			// 
			// tbHosts
			// 
			this.tbHosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbHosts.Location = new System.Drawing.Point(12, 123);
			this.tbHosts.Name = "tbHosts";
			this.tbHosts.Size = new System.Drawing.Size(414, 20);
			this.tbHosts.TabIndex = 5;
			// 
			// tbApacheBin
			// 
			this.tbApacheBin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbApacheBin.Location = new System.Drawing.Point(12, 172);
			this.tbApacheBin.Name = "tbApacheBin";
			this.tbApacheBin.Size = new System.Drawing.Size(414, 20);
			this.tbApacheBin.TabIndex = 7;
			// 
			// tbExtra
			// 
			this.tbExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbExtra.Location = new System.Drawing.Point(12, 221);
			this.tbExtra.Multiline = true;
			this.tbExtra.Name = "tbExtra";
			this.tbExtra.Size = new System.Drawing.Size(451, 170);
			this.tbExtra.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "vhosts.conf-Datei";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "www-root";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "hosts-Datei";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "apache-exe";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.Image = global::vhConf3.Properties.Resources.folder;
			this.button1.Location = new System.Drawing.Point(432, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 22);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.AutoSize = true;
			this.button2.Image = global::vhConf3.Properties.Resources.folder;
			this.button2.Location = new System.Drawing.Point(432, 74);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 22);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.AutoSize = true;
			this.button3.Image = global::vhConf3.Properties.Resources.folder;
			this.button3.Location = new System.Drawing.Point(432, 123);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(31, 22);
			this.button3.TabIndex = 6;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.AutoSize = true;
			this.button4.Image = global::vhConf3.Properties.Resources.folder;
			this.button4.Location = new System.Drawing.Point(432, 172);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(31, 22);
			this.button4.TabIndex = 8;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Extra Hosts-Einträge";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.AutoSize = true;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Image = global::vhConf3.Properties.Resources.delete;
			this.btnCancel.Location = new System.Drawing.Point(378, 397);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(85, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.AutoSize = true;
			this.btnSave.Image = global::vhConf3.Properties.Resources.accept;
			this.btnSave.Location = new System.Drawing.Point(291, 397);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(81, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Speichern";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(473, 428);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbExtra);
			this.Controls.Add(this.tbApacheBin);
			this.Controls.Add(this.tbHosts);
			this.Controls.Add(this.tbWwwRoot);
			this.Controls.Add(this.tbVhosts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Optionen";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVhosts;
        private System.Windows.Forms.TextBox tbWwwRoot;
        private System.Windows.Forms.TextBox tbHosts;
        private System.Windows.Forms.TextBox tbApacheBin;
        private System.Windows.Forms.TextBox tbExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}