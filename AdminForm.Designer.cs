namespace WinFormsApp1
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvUsers;

        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // Label and TextBox for First Name
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);

            // Label and TextBox for Last Name
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.txtLastName.Location = new System.Drawing.Point(120, 60);

            // Label and TextBox for Username
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(20, 100);
            this.txtUsername.Location = new System.Drawing.Point(120, 100);

            // Label and TextBox for Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(20, 140);
            this.txtPassword.Location = new System.Drawing.Point(120, 140);

            // Label and ComboBox for Role
            this.lblRole.Text = "Role:";
            this.lblRole.Location = new System.Drawing.Point(20, 180);
            this.cmbRole.Location = new System.Drawing.Point(120, 180);
            this.cmbRole.Items.AddRange(new object[] { "Administrator", "Teacher", "Student" });

            // Button to Create User
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.Location = new System.Drawing.Point(20, 220);
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);

            // Button to Delete User
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.Location = new System.Drawing.Point(120, 220);
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);

            // DataGridView for Users
            this.dgvUsers.Location = new System.Drawing.Point(20, 260);
            this.dgvUsers.Size = new System.Drawing.Size(400, 150);

            // AdminForm Properties
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.dgvUsers);
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
