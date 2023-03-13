namespace ManagementSystem
{
    partial class ReportsForm
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
            btnPostReport = new Button();
            dgvReports = new DataGridView();
            dgReportId = new DataGridViewTextBoxColumn();
            dgReportName = new DataGridViewTextBoxColumn();
            dgDateFinished = new DataGridViewTextBoxColumn();
            dgIncharge = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnDeleteReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // btnPostReport
            // 
            btnPostReport.Location = new Point(179, 429);
            btnPostReport.Name = "btnPostReport";
            btnPostReport.Size = new Size(133, 29);
            btnPostReport.TabIndex = 0;
            btnPostReport.Text = "Post Report";
            btnPostReport.UseVisualStyleBackColor = true;
            btnPostReport.Click += btnPostReport_Click;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.LavenderBlush;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { dgReportId, dgReportName, dgDateFinished, dgIncharge });
            dgvReports.Location = new Point(12, 43);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersWidth = 51;
            dgvReports.RowTemplate.Height = 29;
            dgvReports.Size = new Size(793, 360);
            dgvReports.TabIndex = 1;
            dgvReports.DoubleClick += dgvReports_DoubleClick;
            // 
            // dgReportId
            // 
            dgReportId.DataPropertyName = "ReportId";
            dgReportId.HeaderText = "Report ID";
            dgReportId.MinimumWidth = 6;
            dgReportId.Name = "dgReportId";
            dgReportId.ReadOnly = true;
            dgReportId.Visible = false;
            dgReportId.Width = 125;
            // 
            // dgReportName
            // 
            dgReportName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgReportName.DataPropertyName = "ReportName";
            dgReportName.HeaderText = "Report Name";
            dgReportName.MinimumWidth = 6;
            dgReportName.Name = "dgReportName";
            dgReportName.ReadOnly = true;
            // 
            // dgDateFinished
            // 
            dgDateFinished.DataPropertyName = "DateFinished";
            dgDateFinished.HeaderText = "Date Finished";
            dgDateFinished.MinimumWidth = 6;
            dgDateFinished.Name = "dgDateFinished";
            dgDateFinished.ReadOnly = true;
            dgDateFinished.Width = 200;
            // 
            // dgIncharge
            // 
            dgIncharge.DataPropertyName = "InCharge";
            dgIncharge.HeaderText = "InCharge";
            dgIncharge.MinimumWidth = 6;
            dgIncharge.Name = "dgIncharge";
            dgIncharge.ReadOnly = true;
            dgIncharge.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 2;
            label1.Text = "Reports";
            // 
            // btnDeleteReport
            // 
            btnDeleteReport.Location = new Point(470, 429);
            btnDeleteReport.Name = "btnDeleteReport";
            btnDeleteReport.Size = new Size(133, 29);
            btnDeleteReport.TabIndex = 0;
            btnDeleteReport.Text = "Delete Report";
            btnDeleteReport.UseVisualStyleBackColor = true;
            btnDeleteReport.Click += btnDeleteReport_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(817, 487);
            Controls.Add(label1);
            Controls.Add(dgvReports);
            Controls.Add(btnDeleteReport);
            Controls.Add(btnPostReport);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports Management";
            FormClosing += ReportsForm_FormClosing;
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPostReport;
        private DataGridView dgvReports;
        private Label label1;
        private Button btnDeleteReport;
        private DataGridViewTextBoxColumn dgReportId;
        private DataGridViewTextBoxColumn dgReportName;
        private DataGridViewTextBoxColumn dgDateFinished;
        private DataGridViewTextBoxColumn dgIncharge;
    }
}