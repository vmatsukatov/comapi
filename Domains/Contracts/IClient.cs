using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Contracts
{
    public interface IClient
    {
        IEnumerable<IProject> GetAllProjects();
        IEnumerable<IIssue> EnumerateIssues(String projectKey, String issueType, String issueStatus);
    }
}
