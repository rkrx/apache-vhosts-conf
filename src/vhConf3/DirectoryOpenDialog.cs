using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace vhConf3 {
	class DirectoryOpenDialog {
		private FolderBrowserDialog dialog = new FolderBrowserDialog();

		public DirectoryOpenDialog() {
		}

		public Boolean trySelectDirectory(String initialDir) {
			dialog.SelectedPath = initialDir;
			return dialog.ShowDialog() == DialogResult.OK;
		}

		public String getDirectory() {
			return dialog.SelectedPath;
		}
	}
}
