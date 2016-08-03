using System.Collections.Generic;
using Domains.Enums;

namespace Domains.Contracts
{
    public interface IApplicationContext
    {
        Dictionary<IssueStatusesEnum, string> MappedIssueStatuses { get; set; }
    }
}