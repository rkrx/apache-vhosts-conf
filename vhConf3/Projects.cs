using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace vhConf3 {
    class Projects {
        private List<Project> projects = new List<Project>();
		private XmlDocument doc = new XmlDocument();

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
			Project project = null;
			this.projects.Clear();

			doc.Load(filename);

			foreach (XmlNode node in doc.SelectNodes("/projects/project")) {
				project = create();
				project.title = node.SelectNodes("./@title")[0].InnerText.Trim();
				project.baseDir = node.SelectNodes("./@project-path")[0].InnerText.Trim();
				project.publicDir = node.SelectNodes("./@public-path")[0].InnerText.Trim();

				foreach (XmlNode domainNode in node.SelectNodes("./domain/@name")) {
					project.domains.Add(domainNode.InnerText.Trim());
				}

				foreach (XmlNode optionNode in node.SelectNodes("./option")) {
					var property = new Property {
						name = optionNode.Attributes.GetNamedItem("name").InnerText.Trim(),
						value = optionNode.InnerText.Trim()
					};
					project.options.Add(property);
				}

				this.projects.Add(project);
			}
        }

        public void save(string filename) {
			doc = new XmlDocument();
			buildDoc();
			doc.Save(filename);
        }

		private void buildDoc() { 
			XmlElement xProjects = doc.CreateElement("projects");
			foreach(Project project in projects) {
				buildProjects(xProjects, project);
			}
			doc.AppendChild(xProjects);
		}

		private void buildProjects(XmlElement parent, Project project) {
			XmlElement xProject = doc.CreateElement("project");
			xProject.SetAttribute("title", project.title);
			xProject.SetAttribute("project-path", project.baseDir);
			xProject.SetAttribute("public-path", project.publicDir);
			parent.AppendChild(xProject);

			foreach (String domain in project.domains) {
				XmlElement xDomain = doc.CreateElement("domain");
				xDomain.SetAttribute("name", domain);
				xProject.AppendChild(xDomain);
			}

			foreach (Property property in project.options) {
				XmlElement xOption = doc.CreateElement("option");
				xOption.SetAttribute("name", property.name);
				xOption.AppendChild(doc.CreateTextNode(property.value));
				xProject.AppendChild(xOption);
			}
		}
    }
}
