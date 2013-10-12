using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace vhConf3 {
	public class Options {
		private XmlDocument doc = new XmlDocument();

		public string vhostsPath = "";
		public string htdocsPath = "";
		public string hostsPath = "";
		public string apacheBinPath = "";
		public string extraHostsEntries = "";

		public void load(String filename) {
			doc.Load(filename);
			this.vhostsPath = doc.SelectSingleNode("/options/path[@name=\"vhosts\"]").InnerText;
			this.htdocsPath = doc.SelectSingleNode("/options/path[@name=\"htdocs\"]").InnerText;
			this.hostsPath = doc.SelectSingleNode("/options/path[@name=\"hosts\"]").InnerText;
			this.apacheBinPath = doc.SelectSingleNode("/options/path[@name=\"apache-bin\"]").InnerText;
			this.extraHostsEntries = doc.SelectSingleNode("/options/hosts").InnerText;
		}

		public void save(String filename) {
			doc = new XmlDocument();
			XmlNode root = doc.CreateElement("options");
			doc.AppendChild(root);

			addPath(root, "vhosts", vhostsPath);
			addPath(root, "htdocs", htdocsPath);
			addPath(root, "hosts", hostsPath);
			addPath(root, "apache-bin", apacheBinPath);

			XmlNode hostsNode = doc.CreateElement("hosts");
			hostsNode.AppendChild(doc.CreateTextNode(extraHostsEntries));
			root.AppendChild(hostsNode);

			doc.Save(filename);
		}

		private void addPath(XmlNode root, String name, String value) {
			XmlElement node = doc.CreateElement("path");
			node.SetAttribute("name", name);
			node.AppendChild(doc.CreateTextNode(value));
			root.AppendChild(node);
		}
	}
}
