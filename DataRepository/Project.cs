using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraRestClient
{
    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public IEnumerable<string> avatarUrls { get; set; }
    }
}
