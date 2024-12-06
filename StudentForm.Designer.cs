namespace WinFormsApp1
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.DataGridView dgvGrades;

        private void InitializeComponent()
        {
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();

            // Label and TextBox for Student ID
            this.lblStudentId.Text = "Student ID:";
            this.lblStudentId.Location = new System.Drawing.Point(20, 20);
            this.txtStudentId.Location = new System.Drawing.Point(120, 20);

            // Button to View Grades
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.Location = new System.Drawing.Point(20, 60);
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);

            // DataGridView for Grades
            this.dgvGrades.Location = new System.Drawing.Point(20, 100);
            this.dgvGrades.Size = new System.Drawing.Size(400, 200);

            // StudentForm Properties
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.dgvGrades);
            this.Text = "StudentForm";

            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
