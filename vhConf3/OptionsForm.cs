using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VhostsManager {
    public partial class FormOptions : Form {
		private Options options = null;

		public FormOptions(Options options) {
            InitializeComponent();
			this.options = options;
			
			tbVhosts.Text = options.vhostsPath;
			tbWwwRoot.Text = options.htdocsPath;
			tbHosts.Text = options.hostsPath;
			tbExecBin.Text = options.executeBinPath;
			tbExecParams.Text = options.executeBinParams;
			tbExtra.Text = options.extraHostsEntries;
        }

		private void btnSave_Click(object sender, EventArgs e) {
			options.vhostsPath = tbVhosts.Text;
			options.htdocsPath = tbWwwRoot.Text;
			options.hostsPath = tbHosts.Text;
			options.executeBinPath = tbExecBin.Text;
			options.executeBinParams = tbExecParams.Text;
			options.extraHostsEntries = tbExtra.Text;

			btnCancel_Click(sender, e);
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Hide();
		}

		private void button1_Click(object sender, EventArgs e) {
			FileOpenDialog dialog = new FileOpenDialog();
			dialog.setFilter("apache configuration files (*.conf)|*.conf");
			if (dialog.trySelectFile(tbVhosts.Text)) {
				tbVhosts.Text = dialog.getFilename();
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			DirectoryOpenDialog dialog = new DirectoryOpenDialog();
			if (dialog.trySelectDirectory(tbWwwRoot.Text)) {
				tbWwwRoot.Text = dialog.getDirectory();
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			FileOpenDialog dialog = new FileOpenDialog();
			if (dialog.trySelectFile(tbHosts.Text)) {
				tbHosts.Text = dialog.getFilename();
			}
		}

		private void button4_Click(object sender, EventArgs e) {
			FileOpenDialog dialog = new FileOpenDialog();
			if (dialog.trySelectFile(tbExecBin.Text)) {
				tbExecBin.Text = dialog.getFilename();
			}
		}
	}
}
