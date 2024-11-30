using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Models;

namespace ProjectManagement.Forms
{

    public partial class UpdateProjectForm : Form
    {
        private ProjectItem _project;
        public event Action<ProjectItem> UpdateProject;
        public UpdateProjectForm(ProjectItem project)
        {
            InitializeComponent();

            _project = project;
            PopulateFormFields();
        }

        private void PopulateFormFields()
        {
            if (_project != null)
            {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                txtProjectName.Text = _project.ProjectName;
                rtxtDescription.Text = _project.ProjectDescription;
                cboStatus.Text = _project.Status;
                // Add more fields as needed
            }
        }

        private TextBox txtProjectName;
        private TextBox rtxtDescription;
        private ComboBox cboStatus;

        private void InitializeComponent()
        {
            txtProjectName = new TextBox();
            rtxtDescription = new TextBox();
            cboStatus = new ComboBox();
            SuspendLayout();
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(235, 62);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(100, 23);
            txtProjectName.TabIndex = 0;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(235, 108);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(100, 23);
            rtxtDescription.TabIndex = 1;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Ongoing", "Finished" });
            cboStatus.Location = new Point(235, 149);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 2;
            // 
            // UpdateProjectForm
            // 
            ClientSize = new Size(677, 307);
            Controls.Add(cboStatus);
            Controls.Add(rtxtDescription);
            Controls.Add(txtProjectName);
            Name = "UpdateProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}