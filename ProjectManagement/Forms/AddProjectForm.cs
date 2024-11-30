using ProjectManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Controllers;
using ProjectManagement.DAO;
using ProjectManagement.Services;
using ProjectManagement.Models;
namespace ProjectManagementSystem.Forms
{
    public partial class AddProjectForm : Form
    {
        private readonly ProjectController _projectController;
        public event Action ProjectAdded;

        public AddProjectForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var projectRepository = new ProjectRepository(context);
            var projectService = new ProjectService(projectRepository);
            _projectController = new ProjectController(projectService);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add any additional logic here if needed when the status is changed
        }

        private void InitializeComponent()
        {
            txtProjectName = new TextBox();
            rtxtDescription = new TextBox();
            lblProjectName = new Label();
            lblProjectDescription = new Label();
            label1 = new Label();
            cboStatus = new ComboBox();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(302, 65);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(100, 23);
            txtProjectName.TabIndex = 0;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(302, 108);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(100, 23);
            rtxtDescription.TabIndex = 1;
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(212, 71);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(79, 15);
            lblProjectName.TabIndex = 2;
            lblProjectName.Text = "Project Name";
            lblProjectName.Click += label1_Click;
            // 
            // lblProjectDescription
            // 
            lblProjectDescription.AutoSize = true;
            lblProjectDescription.Location = new Point(184, 111);
            lblProjectDescription.Name = "lblProjectDescription";
            lblProjectDescription.Size = new Size(107, 15);
            lblProjectDescription.TabIndex = 3;
            lblProjectDescription.Text = "Project Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 157);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Ongoing", "Finish" });
            cboStatus.Location = new Point(302, 154);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 5;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged_1;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(399, 198);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += button1_Click;
            // 
            // AddProjectForm
            // 
            ClientSize = new Size(687, 261);
            Controls.Add(SaveBtn);
            Controls.Add(cboStatus);
            Controls.Add(label1);
            Controls.Add(lblProjectDescription);
            Controls.Add(lblProjectName);
            Controls.Add(rtxtDescription);
            Controls.Add(txtProjectName);
            Name = "AddProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            string projectDescription = rtxtDescription.Text;
            string status = cboStatus.Text;

            // Check if the project name or description is emptyl
            if (string.IsNullOrWhiteSpace(projectName) || string.IsNullOrWhiteSpace(projectDescription))
            {
                MessageBox.Show("Project Name and Description cannot be empty.", "Error");
                return;
            }

            // Add the new project via the controller
            _projectController.AddProject(projectName, projectDescription, status);

            MessageBox.Show("Project Added Successfully", "Information");

            // Raise the event to notify the Main Form
            ProjectAdded?.Invoke();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtProjectName;
        private TextBox rtxtDescription;
        private Label lblProjectName;
        private Label lblProjectDescription;
        private Label label1;
        private Button SaveBtn;
        private ComboBox cboStatus;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
