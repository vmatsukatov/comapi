using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IIssue
    {
        string id { get; set; }
        string key { get; set; }
        string summary { get; set; }
        IStatus status { get; set; }
        IUser assignee { get; set; }
    }
}
