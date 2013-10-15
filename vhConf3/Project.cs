using System;
using System.Collections.Generic;
using System.Text;

namespace VhostsManager {
    public class Project {
        public string title;
        public string baseDir;
        public string publicDir;
        public List<string> domains = new List<string>();
		public List<Property> options = new List<Property>();

		public override string ToString() {
			return title;
		}
    }
}
