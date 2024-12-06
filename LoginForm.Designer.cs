namespace WinFormsApp1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();

            // Label and TextBox for Username
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.txtUsername.Location = new System.Drawing.Point(120, 20);

            // Label and TextBox for Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(20, 60);
            this.txtPassword.Location = new System.Drawing.Point(120, 60);

            // Button to Log In
            this.btnLogin.Text = "Log In";
            this.btnLogin.Location = new System.Drawing.Point(20, 100);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // LoginForm Properties
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Text = "LoginForm";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
