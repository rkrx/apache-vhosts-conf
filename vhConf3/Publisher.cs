using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace vhConf3 {
	class Publisher {
		private Options options;
		private Projects projects;

		public Publisher(Projects projects, Options options) {
			this.options = options;
			this.projects = projects;
		}

		public void publish() {
			writeHosts();
			
			transform();
			repairConf();
			restartApache();
		}

		private void writeHosts() {
			var content = new List<String>();

			foreach (var project in projects.getAll()) {
				foreach(var domain in project.domains) {
					content.Add("127.0.0.1\t" + domain);
				}
			}

			content.Add(options.extraHostsEntries);

			var hostsContent = string.Join("\r\n", content.ToArray());

			System.IO.File.WriteAllText(options.hostsPath, hostsContent);
		}

		private void transform() {
			var xpath = new XPathDocument(new XmlTextReader("data\\projects.xml"));
			var xtrans = new XslCompiledTransform();
			xtrans.Load(new XmlTextReader("data\\transform.xsl"));
			var xwriter = new XmlTextWriter(options.vhostsPath, null);
			xtrans.Transform(xpath, null, xwriter);
			xwriter.Close();
		}

		private void repairConf() {
			var reader = new System.IO.StreamReader(options.vhostsPath);
			var lines = new List<String>();
			var line = "";

			while((line = reader.ReadLine()) != null) {
				line = line.Replace("&lt;", "<");
				line = line.Replace("&gt;", ">");
				lines.Add(line);
			}
			reader.Close();

			var writer = new System.IO.StreamWriter(options.vhostsPath);
			foreach(var writeLine in lines) {
				writer.WriteLine(writeLine);
			}
			writer.Close();
		}

		private void restartApache() {
			var apacheBin = new Process();
			apacheBin.StartInfo.FileName = options.apacheBinPath;
			apacheBin.StartInfo.Arguments = "-k restart";
			apacheBin.StartInfo.UseShellExecute = false;
			apacheBin.StartInfo.RedirectStandardOutput = true;
			apacheBin.StartInfo.CreateNoWindow = true;
			apacheBin.Start();

			var output = "";
			while (!apacheBin.StandardOutput.EndOfStream) {
				output += apacheBin.StandardOutput.ReadLine();
				MessageBox.Show(output);
			}
			apacheBin.WaitForExit();

			output = output.Trim();
			if (output != "") {
				MessageBox.Show(output);
			}
		}
	}
}
