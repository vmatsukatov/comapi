using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Domains.ViewModels;
using Domains;
using Domains.Contracts;

namespace JiraAPICommander
{
    public class JiraTasksService
    {
        IClient jiraClient = null;
        IApplicationContext appContext = null;

        public JiraTasksService(IClient client, IApplicationContext appContext)
        {
            this.jiraClient = client;
            this.appContext = appContext;
        }

        public IEnumerable<ProjectActivityViewModel> GetInProgressTasksViewModels()
        {
            var projects = jiraClient.GetAllProjects();
            
            foreach(var project in projects)
            {
                var inProgressIssues = GetInProgressIssuesByProjectKey(project.key);

                if(inProgressIssues.Count() == 0)
                {
                    continue;
                }

                var model = new ProjectActivityViewModel();
                model.project = project;
                model.InProgressIssues = inProgressIssues;

                yield return model;                
            }

            
        }

        private IEnumerable<IIssue> GetInProgressIssuesByProjectKey(string projectKey)
        {
            IEnumerable<IIssue> issues = jiraClient.EnumerateIssues(projectKey, null, appContext.MappedIssueStatuses[Domains.Enums.IssueStatusesEnum.InProgress]);
            return issues;
        }


        


    }
}
