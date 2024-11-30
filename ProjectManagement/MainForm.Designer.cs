namespace ProjectManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       /* /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>*/
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify.
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddProject = new Button();
            label1 = new Label();
            projectsPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnAddProject);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 54);
            panel1.TabIndex = 0;
            // 
            // btnAddProject
            // 
            btnAddProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProject.BackColor = Color.ForestGreen;
            btnAddProject.ForeColor = Color.Transparent;
            btnAddProject.Location = new Point(689, 12);
            btnAddProject.Margin = new Padding(2, 2, 2, 2);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(100, 33);
            btnAddProject.TabIndex = 1;
            btnAddProject.Text = "Add Project";
            btnAddProject.UseVisualStyleBackColor = false;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 21);
            label1.TabIndex = 0;
            label1.Text = "Project Management App";
            // 
            // projectsPanel
            // 
            projectsPanel.Dock = DockStyle.Fill;
            projectsPanel.Location = new Point(0, 54);
            projectsPanel.Margin = new Padding(2, 2, 2, 2);
            projectsPanel.Name = "projectsPanel";
            projectsPanel.Size = new Size(834, 267);
            projectsPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 321);
            Controls.Add(projectsPanel);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Project Management System";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAddProject;  // Changed from btnAddTask to btnAddProject
        private FlowLayoutPanel projectsPanel;  // Changed from tasksPanel to projectsPanel
    }
}
