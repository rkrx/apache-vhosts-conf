using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace vhConf3 {
    public partial class FormMain : Form {
		private Projects projects = new Projects();
		private Options options = new Options();
		private String projectsFilename = "data\\projects.xml";
		private String optionsFilename = "data\\config.xml";

        public FormMain() {
            InitializeComponent();

            init();
		}

		private void btOptions_Click(object sender, EventArgs e) {
			var form = new FormOptions(options);
			form.ShowDialog();
			options.save(optionsFilename);
		}

		private void btNewProject_Click(object sender, EventArgs e) {
			var project = new Project();
			project.title = "New Project";
			project.baseDir = options.htdocsPath;
			project.publicDir = options.htdocsPath;
			var form = new FormProject(project);
			if (form.ShowDialog() == DialogResult.OK) {
				projects.add(project);
				saveAndReload();
			}
		}

		private void lbProjects_DoubleClick(object sender, EventArgs e) {
			int selIndex = lbProjects.SelectedIndex;
			if (selIndex > -1) {
				var project = (Project) lbProjects.Items[selIndex];
				var form = new FormProject(project);
				form.ShowDialog();
				saveAndReload();
			}
		}

		private void saveAndReload() {
			projects.save(projectsFilename);
			reload();
		}

		private void reload() {
			lbProjects.BeginUpdate();
			lbProjects.Items.Clear();
			foreach (var project in projects.getAll()) {
				lbProjects.Items.Add(project);
			}
			lbProjects.EndUpdate();
		}

		private void btApply_Click(object sender, EventArgs e) {
			var publisher = new Publisher(projects, options);
			publisher.publish();
            MessageBox.Show("Configuration successfully written and restarted apache.");
		}

		private void entfernenToolStripMenuItem_Click(object sender, EventArgs e) {
			if (lbProjects.SelectedIndex > -1) {
				projects.remove((Project) lbProjects.SelectedItem);
			}
			saveAndReload();
		}

		private void menuProjects_Opened(object sender, EventArgs e) {
			entfernenToolStripMenuItem.Enabled = lbProjects.SelectedIndex > -1;
		}

        private void init() {
            initDataDirectory();
            options.load(optionsFilename);
            projects.load(projectsFilename);
            reload();
        }

        private void initDataDirectory() {
            if (!Directory.Exists(".\\data")) {
                MessageBox.Show("The directory .\\data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
	}
}
