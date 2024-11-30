using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Data;
using ProjectManagement.Models;

namespace ProjectManagement.DAO
{
    public class ProjectRepository 
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<ProjectItem> GetAllProject()
        {
            return _context.ProjectItemTable.ToList();
        }

        public void AddProject(ProjectItem projectItem)
        {
            _context.ProjectItemTable.Add(projectItem);
            _context.SaveChanges();
        }
        public void UpdateProject(ProjectItem projectItem)
        {
            _context.ProjectItemTable.Update(projectItem);
            _context.SaveChanges();
        }
        public void DeleteProject(int id)
        {
            var project = _context.ProjectItemTable.Find(id);
            if (project!= null)
            {
                _context.ProjectItemTable.Remove(project);
                _context.SaveChanges();
            }
        }

        internal ProjectItem GetProjectById(int id) => throw new NotImplementedException();
    }
}