using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IProject
    {
        string ProjectKey { get; set; }
        string ProjectName { get; set; }
    }
}
