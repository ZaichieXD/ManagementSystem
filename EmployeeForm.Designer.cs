namespace ManagementSystem
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            saveBtn = new Button();
            txtFirstName = new TextBox();
            dgvEmployees = new DataGridView();
            dgEmployeeId = new DataGridViewTextBoxColumn();
            dgFirstName = new DataGridViewTextBoxColumn();
            dgLastName = new DataGridViewTextBoxColumn();
            dgPosition = new DataGridViewTextBoxColumn();
            dgEmail = new DataGridViewTextBoxColumn();
            dgPassword = new DataGridViewTextBoxColumn();
            dgAddress = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            deleteBtn = new Button();
            cancelBtn = new Button();
            label7 = new Label();
            txtPosition = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 71);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(86, 325);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(104, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(256, 27);
            txtFirstName.TabIndex = 2;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.BackgroundColor = Color.LavenderBlush;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { dgEmployeeId, dgFirstName, dgLastName, dgPosition, dgEmail, dgPassword, dgAddress });
            dgvEmployees.Location = new Point(399, 12);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 29;
            dgvEmployees.Size = new Size(883, 486);
            dgvEmployees.TabIndex = 3;
            dgvEmployees.DoubleClick += dgvEmployees_DoubleClick;
            // 
            // dgEmployeeId
            // 
            dgEmployeeId.DataPropertyName = "EmployeeId";
            dgEmployeeId.HeaderText = "Id";
            dgEmployeeId.MinimumWidth = 6;
            dgEmployeeId.Name = "dgEmployeeId";
            dgEmployeeId.ReadOnly = true;
            dgEmployeeId.Width = 50;
            // 
            // dgFirstName
            // 
            dgFirstName.DataPropertyName = "FirstName";
            dgFirstName.HeaderText = "First Name";
            dgFirstName.MinimumWidth = 6;
            dgFirstName.Name = "dgFirstName";
            dgFirstName.ReadOnly = true;
            dgFirstName.Width = 125;
            // 
            // dgLastName
            // 
            dgLastName.DataPropertyName = "LastName";
            dgLastName.HeaderText = "Last Name";
            dgLastName.MinimumWidth = 6;
            dgLastName.Name = "dgLastName";
            dgLastName.ReadOnly = true;
            dgLastName.Width = 125;
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
            // dgEmail
            // 
            dgEmail.DataPropertyName = "Email";
            dgEmail.HeaderText = "Email";
            dgEmail.MinimumWidth = 6;
            dgEmail.Name = "dgEmail";
            dgEmail.ReadOnly = true;
            dgEmail.Width = 125;
            // 
            // dgPassword
            // 
            dgPassword.DataPropertyName = "Password";
            dgPassword.HeaderText = "Password";
            dgPassword.MinimumWidth = 6;
            dgPassword.Name = "dgPassword";
            dgPassword.ReadOnly = true;
            dgPassword.Width = 125;
            // 
            // dgAddress
            // 
            dgAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgAddress.DataPropertyName = "Address";
            dgAddress.HeaderText = "Address";
            dgAddress.MinimumWidth = 6;
            dgAddress.Name = "dgAddress";
            dgAddress.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(104, 101);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(256, 27);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 137);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 170);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 203);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 0;
            label5.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 27);
            txtPassword.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 236);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(104, 233);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 86);
            txtAddress.TabIndex = 2;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(186, 325);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(286, 325);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(129, 23);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 0;
            label7.Text = "Employee Registration";
            // 
            // txtPosition
            // 
            txtPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPosition.FormattingEnabled = true;
            txtPosition.Items.AddRange(new object[] { "Unity Game Programmer", "Unity Game Artist", "Unity Game UI Designer", "Unity Project Manager" });
            txtPosition.Location = new Point(104, 133);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(256, 28);
            txtPosition.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1294, 510);
            Controls.Add(txtPosition);
            Controls.Add(dgvEmployees);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management";
            FormClosing += EmployeeForm_FormClosing;
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveBtn;
        private TextBox txtFirstName;
        private DataGridView dgvEmployees;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtAddress;
        private Button deleteBtn;
        private Button cancelBtn;
        private DataGridViewTextBoxColumn dgEmployeeId;
        private DataGridViewTextBoxColumn dgFirstName;
        private DataGridViewTextBoxColumn dgLastName;
        private DataGridViewTextBoxColumn dgPosition;
        private DataGridViewTextBoxColumn dgEmail;
        private DataGridViewTextBoxColumn dgPassword;
        private DataGridViewTextBoxColumn dgAddress;
        private Label label7;
        private ComboBox txtPosition;
    }
}