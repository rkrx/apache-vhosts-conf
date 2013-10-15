using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VhostsManager {
	class ProjectWriter {
		internal void writeToFile(List<Project> projects, string filename) {
			var doc = new XmlDocument();
			buildDoc(projects, doc);
			doc.Save(filename);
		}

		private void buildDoc(List<Project> projects, XmlDocument doc) {
			XmlElement xProjects = doc.CreateElement("projects");
			foreach (Project project in projects) {
				buildProjects(doc, xProjects, project);
			}
			doc.AppendChild(xProjects);
		}

		private void buildProjects(XmlDocument doc, XmlElement parent, Project project) {
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
