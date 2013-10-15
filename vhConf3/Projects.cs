using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace VhostsManager {
    class Projects {
        private List<Project> projects = new List<Project>();

        public Project create() {
            return new Project();
        }

        public void add(Project project) {
            projects.Add(project);
        }

        public void remove(Project project) {
            projects.Remove(project);
        }

        public Project[] getAll() {
            return projects.ToArray();
        }

        public void load(string filename) {
			var loader = new ProjectReader();
			loader.readFromFile(projects, filename);
        }

        public void save(string filename) {
			var writer = new ProjectWriter();
			writer.writeToFile(projects, filename);
        }
    }
}
