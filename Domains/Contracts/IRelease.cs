using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Contracts
{
    public interface IRelease
    {
        string ReleaseKey { get; set; }
        string ReleaseName { get; set; }
        string ProjectKey { get; set; }
    }
}
