using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace VhostsManager {
	public class Options {
		private XmlDocument doc = new XmlDocument();

		public string vhostsPath = "";
		public string htdocsPath = "";
		public string hostsPath = "";
		public string executeBinPath = "";
		public string executeBinParams = "";
		public string extraHostsEntries = "";

		public void load(String filename) {
			if (File.Exists(filename)) {
				doc.Load(filename);
			}

			this.vhostsPath = getValue("/options/path[@name=\"vhosts\"]", "");
			this.htdocsPath = getValue("/options/path[@name=\"htdocs\"]", "");
			this.hostsPath = getValue("/options/path[@name=\"hosts\"]", "%SystemRoot%\\System32\\drivers\\etc\\hosts");
			this.executeBinPath = getValue("/options/path[@name=\"execute\"]", getValue("/options/path[@name=\"apache-bin\"]", "%ApacheBin%\\httpd.exe"));
			this.executeBinParams = getValue("/options/path[@name=\"execute-params\"]", "-k restart");
			this.extraHostsEntries = getValue("/options/hosts", getValue("/options/extra-hosts", ""));
		}

		public void save(String filename) {
			doc = new XmlDocument();
			XmlNode root = doc.CreateElement("options");
			doc.AppendChild(root);

			addPath(root, "vhosts", vhostsPath);
			addPath(root, "htdocs", htdocsPath);
			addPath(root, "hosts", hostsPath);
			addPath(root, "execute", executeBinPath);
			addPath(root, "execute-params", executeBinParams);

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

		private string getValue(string path, string def) {
			var nodes = doc.SelectNodes(path);
			if(nodes.Count < 1) {
				return def;
			}
			return nodes[0].InnerText;
		}
	}
}
