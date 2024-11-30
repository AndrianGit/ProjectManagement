using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.DAO;
using ProjectManagement.Models;
using ProjectManagement.Controllers;


namespace ProjectManagement.Services
{
    public class ProjectService
    {
        private readonly ProjectRepository _projectRepository;
        public ProjectService(ProjectRepository ProjectRepository)
        {
            _projectRepository = _projectRepository;
        }

        public ProjectRepository Get_projectRepository()
        {
            return _projectRepository;
        }

        public List<ProjectItem> GetAllProject()
        {
            return _projectRepository.GetAllProject();


        }


        public ProjectItem GetProjectById(int id)
        {
            return _projectRepository.GetProjectById(id);
        }
        public void AddProject(ProjectItem projectItem)
        {
            _projectRepository.AddProject(projectItem);
        }
        public void DeleteProject(int id)
        {
            _projectRepository.DeleteProject(id);
        }
        public void UpdateProject(ProjectItem projectItem)
        {
            _projectRepository.UpdateProject(projectItem);
        }

    }
}