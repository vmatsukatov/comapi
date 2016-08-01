using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Domains.ViewModels;
using Domains;

namespace JiraAPICommander
{
    public class JiraTasksService
    {
        IClient jiraClient = null;

        public JiraTasksService(IClient client)
        {
            jiraClient = client;
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

        private IEnumerable<IIssue> GetInProgressIssuesByProjectKey(string key)
        {
            throw new NotImplementedException();
        }


    }
}
