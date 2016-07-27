using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface ITask
    {
        string TaskKey { get; set; }
        string TaskURL { get; set; }
        string TaskSummary { get; set; }
        string ProjectKey { get; set; }
        string ReleaseKey { get; set; }
    }
}
