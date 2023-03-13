namespace ManagementSystem
{
    partial class ProjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            taskFinished = new CheckBox();
            txtPosition = new ComboBox();
            dgvProjects = new DataGridView();
            dgProjectId = new DataGridViewTextBoxColumn();
            dgProjectName = new DataGridViewTextBoxColumn();
            dgInCharge = new DataGridViewTextBoxColumn();
            dgPosition = new DataGridViewTextBoxColumn();
            gdStartDate = new DataGridViewTextBoxColumn();
            dgEndDate = new DataGridViewTextBoxColumn();
            dgCompleted = new DataGridViewTextBoxColumn();
            txtStartDate = new DateTimePicker();
            label1 = new Label();
            txtProjName = new TextBox();
            proj = new Label();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEndDate = new DateTimePicker();
            txtEmployees = new ComboBox();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // taskFinished
            // 
            taskFinished.AutoSize = true;
            taskFinished.Location = new Point(154, 337);
            taskFinished.Name = "taskFinished";
            taskFinished.Size = new Size(85, 24);
            taskFinished.TabIndex = 1;
            taskFinished.Text = "Finished";
            taskFinished.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            txtPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPosition.FormattingEnabled = true;
            txtPosition.Items.AddRange(new object[] { "Unity Game Programmer", "Unity Game Artist", "Unity Game UI Designer", "Unity Project Manager" });
            txtPosition.Location = new Point(154, 194);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(250, 28);
            txtPosition.TabIndex = 2;
            txtPosition.SelectedValueChanged += txtPosition_SelectedValueChanged;
            // 
            // dgvProjects
            // 
            dgvProjects.BackgroundColor = Color.LavenderBlush;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Columns.AddRange(new DataGridViewColumn[] { dgProjectId, dgProjectName, dgInCharge, dgPosition, gdStartDate, dgEndDate, dgCompleted });
            dgvProjects.Location = new Point(456, 12);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.RowTemplate.Height = 29;
            dgvProjects.Size = new Size(861, 439);
            dgvProjects.TabIndex = 3;
            dgvProjects.DoubleClick += dgvProjects_DoubleClick;
            // 
            // dgProjectId
            // 
            dgProjectId.DataPropertyName = "ProjectId";
            dgProjectId.HeaderText = "Project ID";
            dgProjectId.MinimumWidth = 6;
            dgProjectId.Name = "dgProjectId";
            dgProjectId.ReadOnly = true;
            dgProjectId.Visible = false;
            dgProjectId.Width = 125;
            // 
            // dgProjectName
            // 
            dgProjectName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgProjectName.DataPropertyName = "ProjectName";
            dgProjectName.HeaderText = "Project Name";
            dgProjectName.MinimumWidth = 6;
            dgProjectName.Name = "dgProjectName";
            dgProjectName.ReadOnly = true;
            // 
            // dgInCharge
            // 
            dgInCharge.DataPropertyName = "InCharge";
            dgInCharge.HeaderText = "Employee In charge";
            dgInCharge.MinimumWidth = 6;
            dgInCharge.Name = "dgInCharge";
            dgInCharge.ReadOnly = true;
            dgInCharge.Width = 135;
            // 
            // dgPosition
            // 
            dgPosition.DataPropertyName = "Position";
            dgPosition.HeaderText = "Position";
            dgPosition.MinimumWidth = 6;
            dgPosition.Name = "dgPosition";
            dgPosition.ReadOnly = true;
            dgPosition.Width = 125;
            // 
            // gdStartDate
            // 
            gdStartDate.DataPropertyName = "StartDate";
            gdStartDate.HeaderText = "Start Date";
            gdStartDate.MinimumWidth = 6;
            gdStartDate.Name = "gdStartDate";
            gdStartDate.ReadOnly = true;
            gdStartDate.Width = 125;
            // 
            // dgEndDate
            // 
            dgEndDate.DataPropertyName = "EstimatedEndDate";
            dgEndDate.HeaderText = "End Date";
            dgEndDate.MinimumWidth = 6;
            dgEndDate.Name = "dgEndDate";
            dgEndDate.ReadOnly = true;
            dgEndDate.Width = 125;
            // 
            // dgCompleted
            // 
            dgCompleted.DataPropertyName = "Finished";
            dgCompleted.HeaderText = "Completed";
            dgCompleted.MinimumWidth = 6;
            dgCompleted.Name = "dgCompleted";
            dgCompleted.ReadOnly = true;
            dgCompleted.Width = 125;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(154, 262);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(250, 27);
            txtStartDate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 12);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 5;
            label1.Text = "Project Registration";
            // 
            // txtProjName
            // 
            txtProjName.Location = new Point(154, 71);
            txtProjName.Name = "txtProjName";
            txtProjName.Size = new Size(250, 27);
            txtProjName.TabIndex = 6;
            // 
            // proj
            // 
            proj.AutoSize = true;
            proj.Location = new Point(46, 71);
            proj.Name = "proj";
            proj.Size = new Size(102, 20);
            proj.TabIndex = 5;
            proj.Text = "Project Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 104);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(154, 104);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 84);
            txtDescription.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 231);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "Employee:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 264);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Start Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 300);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 5;
            label7.Text = "End Date";
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(154, 295);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(250, 27);
            txtEndDate.TabIndex = 4;
            // 
            // txtEmployees
            // 
            txtEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEmployees.FormattingEnabled = true;
            txtEmployees.Location = new Point(154, 228);
            txtEmployees.Name = "txtEmployees";
            txtEmployees.Size = new Size(250, 28);
            txtEmployees.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(332, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1329, 463);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtProjName);
            Controls.Add(proj);
            Controls.Add(label1);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(dgvProjects);
            Controls.Add(txtEmployees);
            Controls.Add(txtPosition);
            Controls.Add(taskFinished);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Name = "ProjectsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projects Management";
            FormClosing += ProjectsForm_FormClosing;
            Load += ProjectsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox taskFinished;
        private ComboBox txtPosition;
        private DataGridView dgvProjects;
        private DateTimePicker txtStartDate;
        private Label label1;
        private TextBox txtProjName;
        private Label proj;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker txtEndDate;
        private ComboBox txtEmployees;
        private Button btnDelete;
        private Button btnCancel;
        private DataGridViewTextBoxColumn dgProjectId;
        private DataGridViewTextBoxColumn dgProjectName;
        private DataGridViewTextBoxColumn dgInCharge;
        private DataGridViewTextBoxColumn dgPosition;
        private DataGridViewTextBoxColumn gdStartDate;
        private DataGridViewTextBoxColumn dgEndDate;
        private DataGridViewTextBoxColumn dgCompleted;
    }
}