using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Models;
using ProjectManagement.Services;
namespace ProjectManagement.Controllers
{

    public class ProjectController
    {
        private readonly ProjectService _projectService;
        private readonly string projectNameName;
        private readonly string projectNameaskDescription;
        private ProjectItem projectItem;

        public ProjectController(ProjectService projectService)
        {
            _projectService = projectService;
        }

        public List<ProjectItem> GetAllProject()
        {
            return _projectService.GetAllProject();
        }

        public ProjectItem GetProjectById(int id)
        {
            return _projectService.GetProjectById(id);
        }

        public void AddProject(string projectName, string projectNameDescription, string status)
        {
            var projectItem = new ProjectItem
            {
                ProjectName = projectNameName,
                ProjectDescription = projectNameaskDescription,
                Status = status
            };
            _projectService.AddProject(projectItem);
        }

        public void UpdateProject(int id, string projectName, string projectDescription, string status)
        {
            var projectItem = _projectService.GetProjectById(id);
            if (projectItem != null)
            {
                projectItem.ProjectName = projectName;
                projectItem.ProjectDescription = projectDescription;
                projectItem.Status = status;
                _projectService.UpdateProject(projectItem);
            }
        }

        public void Deleteproject(int id)
        {
            _projectService.DeleteProject(id);
        }

        internal void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }
    }
}