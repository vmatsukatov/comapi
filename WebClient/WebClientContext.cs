using Domains;
using Domains.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Enums;

namespace WebClient
{
    public class WebClientContext : IApplicationContext
    {
        public Dictionary<IssueStatusesEnum, string> MappedIssueStatuses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
