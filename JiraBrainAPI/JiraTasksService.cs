using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.JiraRestClient;
using System.Collections.Specialized;

namespace JiraAPICommander
{
    public class JiraTasksService
    {
        IJiraClient jiraClient = null;

        public JiraTasksService(IJiraClient client)
        {
            jiraClient = client;
        }

        public HybridDictionary GetUsersInInProgressTasks()
        {
            //jiraClient.
            //jiraClient.GetIssues()
        }
    }
}
