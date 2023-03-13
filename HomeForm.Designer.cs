namespace ManagementSystem
{
    partial class HomeForm
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
            label1 = new Label();
            btnProjects = new Button();
            dgvNews = new DataGridView();
            dgNewsId = new DataGridViewTextBoxColumn();
            dgNews = new DataGridViewTextBoxColumn();
            btnEmployees = new Button();
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNews).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(664, 128);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "Company Management";
            // 
            // btnProjects
            // 
            btnProjects.Location = new Point(647, 169);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(246, 51);
            btnProjects.TabIndex = 1;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // dgvNews
            // 
            dgvNews.BackgroundColor = Color.LavenderBlush;
            dgvNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNews.Columns.AddRange(new DataGridViewColumn[] { dgNewsId, dgNews });
            dgvNews.Location = new Point(21, 12);
            dgvNews.Name = "dgvNews";
            dgvNews.ReadOnly = true;
            dgvNews.RowHeadersWidth = 51;
            dgvNews.RowTemplate.Height = 29;
            dgvNews.Size = new Size(593, 467);
            dgvNews.TabIndex = 2;
            // 
            // dgNewsId
            // 
            dgNewsId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgNewsId.DataPropertyName = "NewsId";
            dgNewsId.HeaderText = "News Id";
            dgNewsId.MinimumWidth = 6;
            dgNewsId.Name = "dgNewsId";
            dgNewsId.ReadOnly = true;
            dgNewsId.Visible = false;
            // 
            // dgNews
            // 
            dgNews.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgNews.DataPropertyName = "NewsReport";
            dgNews.HeaderText = "News";
            dgNews.MinimumWidth = 6;
            dgNews.Name = "dgNews";
            dgNews.ReadOnly = true;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(647, 226);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(246, 52);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(647, 284);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(246, 51);
            btnReport.TabIndex = 1;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(905, 491);
            Controls.Add(dgvNews);
            Controls.Add(btnReport);
            Controls.Add(btnEmployees);
            Controls.Add(btnProjects);
            Controls.Add(label1);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            Load += HomeForm_Load;
            Shown += HomeForm_Shown;
            DoubleClick += HomeForm_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dgvNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProjects;
        private DataGridView dgvNews;
        private Button btnEmployees;
        private Button btnReport;
        private DataGridViewTextBoxColumn dgNewsId;
        private DataGridViewTextBoxColumn dgNews;
    }
}