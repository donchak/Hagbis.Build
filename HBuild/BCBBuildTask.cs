using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Hagbis.Build {
    public class BCBBuildTask : Task {
        BCBProjectProcessingItem[] processing;
        string addDefines;
        string projectPath;
        [XmlAttribute("projectPath")]
        public string ProjectPath {
            get { return projectPath; }
            set { projectPath = value; }
        }
        [XmlAttribute("addDefines")]
        public string AddDefines {
            get { return addDefines; }
            set { addDefines = value; }
        }
        [XmlElement("ProcessingItem")]
        public BCBProjectProcessingItem[] ProcessingItems {
            get { return processing; }
            set { processing = value; }
        }
    }
    public class BCBProjectProcessingItem {
        string toAdd;
        string toRemove;
        string key;
        [XmlAttribute("key")]
        public string Key {
            get { return key; }
            set { key = value; }
        }
        [XmlAttribute("toRemove")]
        public string ToRemove {
            get { return toRemove; }
            set { toRemove = value; }
        }
        [XmlAttribute("toAdd")]
        public string ToAdd {
            get { return toAdd; }
            set { toAdd = value; }
        }
    }
}
