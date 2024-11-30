using ProjectManagementSystem.Forms;
using ProjectManagement.Controllers;
using ProjectManagement.DAO;
using ProjectManagement.Models;
using ProjectManagement.Services;
using ProjectManagement.Data;
using ProjectManagement.Forms;

namespace ProjectManagementSystem
{
    public partial class MainForm : Form
    {
        public readonly ProjectController _projectController;

        public MainForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var projectRepository = new ProjectRepository(context);
            var projectService = new ProjectService(projectRepository);
            _projectController = new ProjectController(projectService);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            var addProjectForm = new AddProjectForm();
            addProjectForm.ProjectAdded += LoadProjects;
            addProjectForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            var projects = _projectController.GetAllProject();
            projectsPanel.Controls.Clear();
            foreach (var project in projects)
            {
                AddProjectCard(project);
            }
        }

        private void AddProjectCard(ProjectItem projectItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.CadetBlue,
                Margin = new Padding(30),
                Padding = new Padding(10)
            };

            // Delete Icon (Text-Based)
            var deleteIcon = new Label
            {
                Text = "✖", // Unicode character for 'X' symbol
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteProject(projectItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "✏", // Unicode character for pencil
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateProject(projectItem);
            cardPanel.Controls.Add(editIcon);

            var projectNameLabel = new Label
            {
                Text = $"{projectItem.ProjectName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(projectNameLabel);

            var projectDescriptionLabel = new Label
            {
                Text = $"{projectItem.ProjectDescription}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(projectDescriptionLabel);

            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };
            // Calculate the position for bottom right corner
            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowProjectDetails(projectItem);
            cardPanel.Controls.Add(viewDetails);

            projectsPanel.Controls.Add(cardPanel);
        }

        private void ShowProjectDetails(ProjectItem projectItem)
        {
            MessageBox.Show(projectItem.ProjectName);
        }

        private void UpdateProject(ProjectItem projectItem)
        {
            // Logic to update the project
            var updateProject = new UpdateProjectForm(projectItem);
            updateProject.UpdateProject += LoadProjects;  // Refresh after updating

            {
                LoadProjects();
            }
            updateProject.ShowDialog();
        }

        private void LoadProjects(ProjectItem item)
        {
            throw new NotImplementedException();
        }

        private void DeleteProject(ProjectItem projectItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete the project: {projectItem.ProjectName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _projectController.DeleteProject(projectItem.Id);
                LoadProjects(); // Refresh the projects list
            }
        }
    }

    
    }
