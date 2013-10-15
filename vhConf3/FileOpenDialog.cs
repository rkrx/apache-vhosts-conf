using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VhostsManager {
	class FileOpenDialog {
		private OpenFileDialog dialog = new OpenFileDialog();

		public FileOpenDialog() { 
			dialog.Multiselect = false;
		}

		public Boolean trySelectFile(string initialPath) {
			dialog.FileName = initialPath;
			setInitialDir(initialPath);
			return dialog.ShowDialog() == DialogResult.OK;
		}

		public String getFilename() {
			return dialog.FileName;
		}

		public FileOpenDialog setFilter(string filter) {
			this.dialog.Filter = filter;
			return this;
		}

		private void setInitialDir(string initialPath) {
			try {
				dialog.InitialDirectory = 
					Directory.GetParent(initialPath).FullName;
			} catch (System.ArgumentException ex) {
			}
		}
	}
}
