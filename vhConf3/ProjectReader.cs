using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VhostsManager {
	class ProjectReader {
		public void readFromFile(List<Project> projects, string filename) {
			var doc = new XmlDocument();
			Project project = null;
			projects.Clear();

			doc.Load(filename);

			foreach (XmlNode node in doc.SelectNodes("/projects/project")) {
				project = new Project();
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

				projects.Add(project);
			}
		}
	}
}
