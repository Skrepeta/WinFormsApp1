namespace WinFormsApp1
{
    partial class TeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtLectureId;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblLectureId;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.DataGridView dgvGrades;

        private void InitializeComponent()
        {
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblLectureId = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtLectureId = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();

            // Label and TextBox for Student ID
            this.lblStudentId.Text = "Student ID:";
            this.lblStudentId.Location = new System.Drawing.Point(20, 20);
            this.txtStudentId.Location = new System.Drawing.Point(120, 20);

            // Label and TextBox for Lecture ID
            this.lblLectureId.Text = "Lecture ID:";
            this.lblLectureId.Location = new System.Drawing.Point(20, 60);
            this.txtLectureId.Location = new System.Drawing.Point(120, 60);

            // Label and TextBox for Grade
            this.lblGrade.Text = "Grade:";
            this.lblGrade.Location = new System.Drawing.Point(20, 100);
            this.txtGrade.Location = new System.Drawing.Point(120, 100);

            // Button to Save Grade
            this.btnSaveGrade.Text = "Save Grade";
            this.btnSaveGrade.Location = new System.Drawing.Point(20, 140);
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);

            // DataGridView for Grades
            this.dgvGrades.Location = new System.Drawing.Point(20, 180);
            this.dgvGrades.Size = new System.Drawing.Size(400, 200);

            // TeacherForm Properties
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblLectureId);
            this.Controls.Add(this.txtLectureId);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnSaveGrade);
            this.Controls.Add(this.dgvGrades);
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

