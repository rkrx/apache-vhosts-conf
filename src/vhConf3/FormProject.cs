using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vhConf3 {
	public partial class FormProject : Form {
		private Project project;

		public FormProject(Project project) {
			InitializeComponent();
			this.project = project;
		}

		private void FormProject_Load(object sender, EventArgs e) {
			tbProjectName.Text = project.title;
			tbProjectPath.Text = project.baseDir;
			tbPublicPath.Text = project.publicDir;

			lbDomains.Items.Clear();
			foreach (String domain in project.domains) {
				lbDomains.Items.Add(domain);
			}

			gvOptions.Rows.Clear();
			foreach (Property property in project.options) {
				gvOptions.Rows.Add();
				int rowCount = gvOptions.Rows.Count - 1;
				gvOptions.Rows[rowCount-1].Cells[0].Value = property.name;
				gvOptions.Rows[rowCount-1].Cells[1].Value = property.value;
			}
		}

		private void btnProjectPath_Click(object sender, EventArgs e) {
			DirectoryOpenDialog dialog = new DirectoryOpenDialog();
			if (dialog.trySelectDirectory(tbProjectPath.Text)) {
				tbProjectPath.Text = dialog.getDirectory();
			}
		}

		private void btnPublicPath_Click(object sender, EventArgs e) {
			DirectoryOpenDialog dialog = new DirectoryOpenDialog();
			if (dialog.trySelectDirectory(tbPublicPath.Text)) {
				tbPublicPath.Text = dialog.getDirectory();
			}
		}

		private void btnAddDomain_Click(object sender, EventArgs e) {
			if (tbDomain.Text != "") {
				lbDomains.Items.Add(tbDomain.Text);
				tbDomain.Text = "";
				tbDomain.Focus();
			}
		}

		private void tbDomain_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == 13) {
				btnAddDomain_Click(sender, null);
				e.Handled = true;
			}
		}

		private void popupDomains_Opened(object sender, EventArgs e) {
			menuItemRemove.Enabled = lbDomains.SelectedIndex > -1;
		}

		private void menuItemRemove_Click(object sender, EventArgs e) {
			if (lbDomains.SelectedIndex > -1) {
				lbDomains.Items.Remove(lbDomains.SelectedItem);
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			project.title = tbProjectName.Text;
			project.baseDir = tbProjectPath.Text;
			project.publicDir = tbPublicPath.Text;

			project.domains.Clear();
			foreach(String domain in lbDomains.Items) {
				project.domains.Add(domain);
			}

			project.options.Clear();
			foreach (DataGridViewRow row in gvOptions.Rows) {
				if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Trim() != "") {
					String value = "";
					if (row.Cells[1].Value != null) {
						value = row.Cells[1].Value.ToString().Trim();
					}
					project.options.Add(new Property {
						name = row.Cells[0].Value.ToString().Trim(),
						value = value
					});
				}
			}

			btnCancel_Click(sender, e);
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Hide();
		}
	}
}
